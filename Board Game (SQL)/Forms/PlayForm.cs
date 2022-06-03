using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Board_Game__SQL_
{
    public partial class PlayForm : Form
    {
        private List<List<Button>> buttons = new List<List<Button>>();      //2 dimensional button list
        private List<List<int>> ShapeAndColors = new List<List<int>>();     //2 dimensional shape info list

        private int Column, Row;    //Total rows and total columns
        private int SBcol, SBrow;   //Source row and column
        private Image SBi;          //Source button's shape
        private int PointSum;       //Total point

        System.Media.SoundPlayer winSound = new System.Media.SoundPlayer(Properties.Resources.WinSound);                //Sounds
        System.Media.SoundPlayer pointSound = new System.Media.SoundPlayer(Properties.Resources.EntranceSound);
        System.Media.SoundPlayer lastStepSound = new System.Media.SoundPlayer(Properties.Resources.LastStepSound);
        System.Media.SoundPlayer stepSound = new System.Media.SoundPlayer(Properties.Resources.StepSound);
        System.Media.SoundPlayer bonusSound = new System.Media.SoundPlayer(Properties.Resources.BonusSound);

        public PlayForm()
        {
            InitializeComponent();
            Play();
        }

        private void Play()                                                 //Initilizes game board with user settings
        {
            if (UserClass.Difficulty.Equals("1000"))
            {
                this.ClientSize = new System.Drawing.Size(750, 770);
                Column = Row = 15;
                BoardMaker(15, 15);
                PointThreeShape(15, 15);
            }

            else if (UserClass.Difficulty.Equals("0100"))
            {
                this.ClientSize = new System.Drawing.Size(450, 470);
                Column = Row = 9;
                BoardMaker(9, 9);
                PointThreeShape(9, 9);
            }

            else if (UserClass.Difficulty.Equals("0010"))
            {
                this.ClientSize = new System.Drawing.Size(300, 320);
                Column = Row = 6;
                BoardMaker(6, 6);
                PointThreeShape(6, 6);
            }

            else if (UserClass.Difficulty.Equals("0001"))
            {
                Column = int.Parse(UserClass.CustomDifficultyWidth);
                Row = int.Parse(UserClass.CustomDifficultyHeight);
                this.ClientSize = new System.Drawing.Size(Column * 50, Row * 50 + 20);
                BoardMaker(Row, Column);
                PointThreeShape(Row, Column);
            }
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            exitButton.Location = new System.Drawing.Point(Column * 50-45, 0);
            BestScoreLabel.Text = "Best Score: " + UserClass.BestScore.ToString();
        }

        private void BoardMaker(int row, int col)                           //Makes board game
        {
            int colLoc = 0;
            int rowLoc = 20;

            for (int i = 0; i < row; i++)
            {
                buttons.Add(new List<Button>());
                ShapeAndColors.Add(new List<int>());

                for (int j = 0; j < col; j++)
                {
                    Button newButton = new Button();
                    buttons[i].Add(newButton);
                    ShapeAndColors[i].Add(9);

                    this.Controls.Add(buttons[i][j]);
                    this.buttons[i][j].MouseClick += new System.Windows.Forms.MouseEventHandler(this.Buttons_MouseClick);
                    buttons[i][j].Location = new Point(colLoc, rowLoc);
                    buttons[i][j].Size = new Size(50, 50);
                    buttons[i][j].BackColor = Color.Azure;

                    colLoc += 50;
                }
                colLoc = 0;
                rowLoc += 50;
            }
            DisableEmptyButtons(row, col);
        }

        private void PointThreeShape(int row, int col)                      //Points 3 random shape
        {
            Random rd = new Random();

            for (int i = 0; i < 3; i++)
            {
                int rand_c = rd.Next(0, col);
                int rand_r = rd.Next(0, row);
                int rand_shape = rd.Next(0, GlobalMethods.ShapeAndColorPref().Count() - 1);

                if (ShapeAndColors[rand_r][rand_c] == 9)
                {
                    ShapeAndColors[rand_r][rand_c] = GlobalMethods.SClist[rand_shape];

                    buttons[rand_r][rand_c].Enabled = true;
                    buttons[rand_r][rand_c].BackgroundImage = Properties.Resources.shapes[GlobalMethods.SClist[rand_shape]];
                    buttons[rand_r][rand_c].BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
                }
                else if (IsGameOver())
                    return;

                else
                    i--;
                IsGetPoint(ShapeAndColors);
            }
        }
        private void DisableEmptyButtons(int row, int col)                  //Disables empty buttons
        {
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (ShapeAndColors[i][j] == 9)
                        buttons[i][j].Enabled = false;
                }
            }
        }


        bool IsGetPoint(List<List<int>> ShapeAndColors)                     //Calculates if the user get a point
        {
            int track;

            for (int i = 0; i < Row; i++)
            {
                for (int j = 0; j <= Column - 5; j++)
                {
                    track = ShapeAndColors[i][j];
                    for (int t = j + 1; t <= j + 4; t++)
                    {
                        if (ShapeAndColors[i][t] != track || track == 9)
                            break;
                        if (t == j + 4)
                        {
                            for (t = j; t <= j + 4; t++)
                            {
                                ShapeAndColors[i][t] = 9;
                                buttons[i][t].BackgroundImage = null;
                                buttons[i][t].Enabled = false;
                            }
                            pointSound.Play();
                            if (UserClass.Difficulty.Equals("1000"))
                                PointSum += 1;
                            else if (UserClass.Difficulty.Equals("0100"))
                                PointSum += 3;
                            else if (UserClass.Difficulty.Equals("0010"))
                                PointSum += 5;
                            else
                                PointSum += 2;
                            return true;
                        }

                    }
                }
            }

            for (int j = 0; j < Column; j++)
            {
                for (int i = 0; i <= Row - 5; i++)
                {
                    track = ShapeAndColors[i][j];
                    for (int t = i + 1; t <= i + 4; t++)
                    {
                        if (ShapeAndColors[t][j] != track || track == 9)
                            break;
                        if (t == i + 4)
                        {
                            for (t = i; t <= i + 4; t++)
                            {
                                ShapeAndColors[t][j] = 9;
                                buttons[t][j].BackgroundImage = null;
                                buttons[t][j].Enabled = false;
                            }
                            pointSound.Play();
                            if (UserClass.Difficulty.Equals("1000"))
                                PointSum += 1;
                            else if (UserClass.Difficulty.Equals("0100"))
                                PointSum += 3;
                            else if (UserClass.Difficulty.Equals("0010"))
                                PointSum += 5;
                            else
                                PointSum += 2;
                            return true;
                        }
                    }
                }
            }
            return false;
        }
        bool IsGameOver()                                                   //Checks if the game is over
        {
            for (int i = 0; i < Row; i++)
            {
                for (int j = 0; j < Column; j++)
                    if (ShapeAndColors[i][j] == 9)
                        return false;
            }
            return true;
        }


        private void Buttons_MouseClick(object sender, MouseEventArgs e)    //Handles the mouse events (selection of a button)
        {
            int[,] WeightPath = new int[Row, Column];

            for (int i = 0; i < Row; i++)
            {
                for (int j = 0; j < Column; j++)
                {
                    if (sender == buttons[i][j] && ShapeAndColors[i][j] != 9)
                    {

                        buttons[i][j].BackColor = Color.Aqua;
                        SBrow = i;
                        SBcol = j;
                        SBi = buttons[i][j].BackgroundImage;
                        WeightPath = ShortestAndAvailable(SBrow, SBcol);

                    }
                    else if (sender == buttons[i][j] && ShapeAndColors[i][j] == 9)
                    {
                       // move(WeightPath, i, j);

                        buttons[SBrow][SBcol].BackColor = Color.Azure;
                        buttons[SBrow][SBcol].BackgroundImage = null;
                        buttons[i][j].BackgroundImage = SBi;
                        buttons[i][j].BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;

                        buttons[SBrow][SBcol].Enabled = false;
                        ShapeAndColors[SBrow][SBcol] = 9;
                        buttons[i][j].Enabled = true;
                        ShapeAndColors[i][j] = Properties.Resources.shapes.IndexOf((Bitmap)SBi);

                        DisableEmptyButtons(Row, Column);
                        lastStepSound.Play();

                        if (!IsGetPoint(ShapeAndColors))
                            PointThreeShape(Row, Column);

                        if (IsGameOver())
                        {
                            if (PointSum > UserClass.BestScore)
                            {
                                UserClass.BestScore = PointSum;
                                SQLClass.SetBestScore(PointSum.ToString());
                            }
                            

                            winSound.Play();
                            MessageBox.Show("Game Over\n" + "Point: " + PointSum.ToString() + "\n" + "Best Score: " + UserClass.BestScore);
                            this.Owner.Show();
                            this.Close();
                        }
                    }
                    else
                        buttons[i][j].BackColor = Color.Azure;
                }
            }
        }

        //Movement
        /*
        public static bool operator <(Cell a, Cell b)
        {
            if (a.dist == b.dist)
            {
                if (a.row != b.col)
                {
                    return (a.row < b.col);
                }
                else
                {
                    return (a.col < b.col);
                }
            }
            return (a.dist < b.dist);
        }

	// Utility method to check whether a point is
	// inside the grid or not
	public static bool isInsideGrid(int i, int j)
	{
		return (i >= 0 && i < DefineConstants.ROW && j >= 0 && j < DefineConstants.COL);
	}

	// Method returns minimum cost to reach bottom
	// right from top left
	public static int shortest(int[][] grid, int row, int col)
	{
		int[][] dis = RectangularArrays.RectangularIntArray(row, col);

		// initializing distance array by INT_MAX
		for (int i = 0; i < row; i++)
		{
			for (int j = 0; j < col; j++)
			{
				dis[i][j] = int.MaxValue;
			}
		}

		// direction arrays for simplification of getting
		// neighbour
		int[] dx = {-1, 0, 1, 0};
		int[] dy = {0, 1, 0, -1};

		SortedSet<cell> st = new SortedSet<cell>();

		// insert (0, 0) cell with 0 distance
		st.Add(new cell(0, 0, 0));

		// initialize distance of (0, 0) with its grid value
		dis[0][0] = grid[0][0];

		// loop for standard dijkstra's algorithm
		while (st.Count > 0)
		{
			// get the cell with minimum distance and delete
			// it from the set
			cell k = *st.GetEnumerator();
			st.erase(st.GetEnumerator());

			// looping through all neighbours
			for (int i = 0; i < 4; i++)
			{
				int x = k.x + dx[i];
				int y = k.y + dy[i];

				// if not inside boundary, ignore them
				if (!isInsideGrid(x, y))
				{
					continue;
				}

				// If distance from current cell is smaller, then
				// update distance of neighbour cell
				if (dis[x][y] > dis[k.x][k.y] + grid[x][y])
				{
					// If cell is already there in set, then
					// remove its previous entry
					if (dis[x][y] != int.MaxValue)
					{
						st.erase(st.find(new cell(x, y, dis[x][y])));
					}

					// update the distance and insert new updated
					// cell in set
					dis[x][y] = dis[k.x][k.y] + grid[x][y];
					st.Add(new cell(x, y, dis[x][y]));
				}
			}
		}

		
		return dis[row - 1][col - 1];
	}
        */





        int[,] ShortestAndAvailable(int row, int column)                            //Checks if desired button is reachable
        {
            int[,] WeightPath = new int[Row, Column];                               //for shortest path (on progress)



            Cell source = new Cell(0, 0, 0);
            source.row = SBrow;
            source.col = SBcol;

            // To keep track of visited QItems. Marking
            // blocked cells as visited.
            bool[][] visited = RectangularArrays.RectangularBoolArray(Row, Column);

            for (int i = 0; i < Row; i++)
            {
                for (int j = 0; j < Column; j++)
                {
                    if (ShapeAndColors[i][j] != 9)
                    {
                        visited[i][j] = true;
                        WeightPath[i, j] = int.MaxValue;
                    }
                    else
                    {
                        visited[i][j] = false;
                    }
                }
            }


            // applying BFS on matrix cells starting from source
            Queue<Cell> q = new Queue<Cell>();
            q.Enqueue(source);

            //if (move == true)
            //    visited[source.row][source.col] = true;

            while (q.Count > 0)
            {
                Cell p = q.Peek();
                q.Dequeue();



                // Destination found;
                //if (p.row == row && p.col == column && move == true)/////////////////////////////
                //{
                //    //MessageBox.Show("Step: " + p.dist.ToString());
                //    return;
                //    //return p.dist;
                //}

                // moving up
                if (p.row - 1 >= 0 && visited[p.row - 1][p.col] == false)
                {
                    q.Enqueue(new Cell(p.row - 1, p.col, p.dist + 1));
                    visited[p.row - 1][p.col] = true;
                    buttons[p.row - 1][p.col].Enabled = true;
                    WeightPath[p.row - 1, p.col] = p.dist + 1;
                }

                // moving down
                if (p.row + 1 < Row && visited[p.row + 1][p.col] == false)
                {
                    q.Enqueue(new Cell(p.row + 1, p.col, p.dist + 1));
                    visited[p.row + 1][p.col] = true;
                    buttons[p.row + 1][p.col].Enabled = true;
                    WeightPath[p.row + 1, p.col] = p.dist + 1;
                }

                // moving left
                if (p.col - 1 >= 0 && visited[p.row][p.col - 1] == false)
                {
                    q.Enqueue(new Cell(p.row, p.col - 1, p.dist + 1));
                    visited[p.row][p.col - 1] = true;
                    buttons[p.row][p.col - 1].Enabled = true;
                    WeightPath[p.row, p.col - 1] = p.dist + 1;
                }

                // moving right
                if (p.col + 1 < Column && visited[p.row][p.col + 1] == false)
                {
                    q.Enqueue(new Cell(p.row, p.col + 1, p.dist + 1));
                    visited[p.row][p.col + 1] = true;
                    buttons[p.row][p.col + 1].Enabled = true;
                    WeightPath[p.row, p.col + 1] = p.dist + 1;
                }
            }
            return WeightPath;
        }

        internal static class RectangularArrays                                     //Creates 2 dimensional array
        {
            public static bool[][] RectangularBoolArray(int size1, int size2)
            {
                bool[][] newArray = new bool[size1][];
                for (int array1 = 0; array1 < size1; array1++)
                {
                    newArray[array1] = new bool[size2];
                }

                return newArray;
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)                   //Exit game
        {
            this.Owner.Show();
            this.Close();
        }
    }
}