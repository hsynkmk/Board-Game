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
        private List<List<Button>> buttons = new List<List<Button>>();
        private List<List<int>> ShapeAndColors = new List<List<int>>();

        private int Column, Row;
        private int SBcol, SBrow;
        private Image SBi;
        private int PointSum;

        System.Media.SoundPlayer winSound = new System.Media.SoundPlayer(Properties.Resources.WinSound);
        System.Media.SoundPlayer pointSound = new System.Media.SoundPlayer(Properties.Resources.EntranceSound);
        System.Media.SoundPlayer lastStepSound = new System.Media.SoundPlayer(Properties.Resources.LastStepSound);
        System.Media.SoundPlayer stepSound = new System.Media.SoundPlayer(Properties.Resources.StepSound);
        System.Media.SoundPlayer bonusSound = new System.Media.SoundPlayer(Properties.Resources.BonusSound);

        public PlayForm()
        {
            InitializeComponent();
            Play();
        }

        private void Play()
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
        }

        private void BoardMaker(int row, int col)
        {
            int colLoc = 0;
            int rowLoc = 20;

            Button BackButton = new Button();
            this.Controls.Add(BackButton);
            BackButton.Text = "Back";
            BackButton.Location=new System.Drawing.Point(Column * 44, 0);
            BackButton.Size = new System.Drawing.Size(50, 20);
            BackButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BackButton_MouseClick);
            
            //Label BestScoreLBL = new Label();
            //BestScoreLBL.Font= new System.Drawing.Font ;
            //this.Controls.Add(BestScoreLBL);
            //BestScoreLBL.Text = $"Best Score: {UserClass.BestScore}";
            //BestScoreLBL.Location = new System.Drawing.Point(Column * 0, 0);
            //BestScoreLBL.Size = new System.Drawing.Size(50, 20);

            for (int i = 0; i < row; i++)
            {
                buttons.Add(new List<Button>());
                ShapeAndColors.Add(new List<int>());

                for (int j = 0; j < col; j++)
                {
                    Button newButton = new Button();
                    buttons[i].Add(newButton);
                    ShapeAndColors[i].Add(-1);

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
        }

        private void PointThreeShape(int row, int col)
        {
            DisableEmptyButtons(row, col);

            Random rd = new Random();

            for (int i = 0; i < 3; i++)
            {

                int rand_c = rd.Next(0, col);
                int rand_r = rd.Next(0, row);
                int rand_shape = rd.Next(0,GlobalMethods.ShapeAndColorPref().Count() - 1);

                if (ShapeAndColors[rand_r][rand_c] == -1)
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
        private void DisableEmptyButtons(int row, int col)
        {
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (ShapeAndColors[i][j] == -1)
                        buttons[i][j].Enabled = false;
                }
            }
        }


        bool IsGetPoint(List<List<int>> ShapeAndColors)
        {
            int track;

            for (int i = 0; i < Row; i++)
            {
                for (int j = 0; j <= Column - 5; j++)
                {
                    track = ShapeAndColors[i][j];
                    for (int t = j + 1; t <= j + 4; t++)
                    {
                        if (ShapeAndColors[i][t] != track || track == -1)
                            break;
                        if (t == j + 4)
                        {
                            for (t = j; t <= j + 4; t++)
                            {
                                ShapeAndColors[i][t] = -1;
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
                        if (ShapeAndColors[t][j] != track || track == -1)
                            break;
                        if (t == i + 4)
                        {
                            for (t = i; t <= i + 4; t++)
                            {
                                ShapeAndColors[t][j] = -1;
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
        bool IsGameOver()
        {

            for (int i = 0; i < Row; i++)
            {
                for (int j = 0; j < Column; j++)
                    if (ShapeAndColors[i][j] == -1)
                        return false;
            }
            return true;
        }


        private void BackButton_MouseClick(object sender, MouseEventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }
        private void Buttons_MouseClick(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < Row; i++)
            {
                for (int j = 0; j < Column; j++)
                {
                    if (sender == buttons[i][j] && ShapeAndColors[i][j] != -1)
                    {

                        buttons[i][j].BackColor = Color.Aqua;
                        SBcol = j;
                        SBrow = i;
                        SBi = buttons[i][j].BackgroundImage;
                        DisableEmptyButtons(Row, Column);
                        ShortestAndAvailable(false, SBrow, SBcol);

                    }
                    else if (sender == buttons[i][j] && ShapeAndColors[i][j] == -1)
                    {
                        buttons[SBrow][SBcol].BackColor = Color.Azure;
                        buttons[SBrow][SBcol].BackgroundImage = null;
                        buttons[i][j].BackgroundImage = SBi;
                        buttons[i][j].BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;

                        buttons[SBrow][SBcol].Enabled = false;
                        ShapeAndColors[SBrow][SBcol] = -1;
                        buttons[i][j].Enabled = true;
                        ShapeAndColors[i][j] = Properties.Resources.shapes.IndexOf((Bitmap)SBi);

                        DisableEmptyButtons(Row, Column);
                        stepSound.Play();

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
        // QItem for current location and distance
        // from source location
        public class QItem
        {
            public int row;
            public int col;
            public int dist;
            public QItem(int x, int y, int w)
            {
                this.row = x;
                this.col = y;
                this.dist = w;
            }
        }



        void ShortestAndAvailable(bool move, int row, int column)
        {
            int[,] WeightPath = new int[Row, Column];             //for shortest path

            //for (int i = 0; i < Row; i++)
            //    for (int j = 0; j < Column; j++)
            //        WeightPath[i, j] = int.MaxValue;



            QItem source = new QItem(0, 0, 0);

            // To keep track of visited QItems. Marking
            // blocked cells as visited.
            bool[][] visited = RectangularArrays.RectangularBoolArray(Row, Column);

            for (int i = 0; i < Row; i++)
            {
                for (int j = 0; j < Column; j++)
                {
                    if (ShapeAndColors[i][j] != -1)
                    {
                        visited[i][j] = true;
                        WeightPath[i, j] = int.MaxValue;
                    }
                    else
                    {
                        visited[i][j] = false;
                    }

                    if (move == true)
                        visited[row][column] = false;

                    // Finding source

                    source.row = SBrow;
                    source.col = SBcol;
                }
            }

            // applying BFS on matrix cells starting from source
            Queue<QItem> q = new Queue<QItem>();
            q.Enqueue(source);

            if (move == true)
                visited[source.row][source.col] = true;

            while (q.Count > 0)
            {
                QItem p = q.Peek();
                q.Dequeue();



                // Destination found;
                if (p.row == row && p.col == column && move == true)
                {
                    //MessageBox.Show("Step: " + p.dist.ToString());
                    return;
                    //return p.dist;
                }

                // moving up
                if (p.row - 1 >= 0 && visited[p.row - 1][p.col] == false)
                {
                    q.Enqueue(new QItem(p.row - 1, p.col, p.dist + 1));
                    visited[p.row - 1][p.col] = true;
                    buttons[p.row - 1][p.col].Enabled = true;
                    WeightPath[p.row - 1, p.col] = p.dist + 1;
                }

                // moving down
                if (p.row + 1 < Row && visited[p.row + 1][p.col] == false)
                {
                    q.Enqueue(new QItem(p.row + 1, p.col, p.dist + 1));
                    visited[p.row + 1][p.col] = true;
                    buttons[p.row + 1][p.col].Enabled = true;
                    WeightPath[p.row + 1, p.col] = p.dist + 1;
                }

                // moving left
                if (p.col - 1 >= 0 && visited[p.row][p.col - 1] == false)
                {
                    q.Enqueue(new QItem(p.row, p.col - 1, p.dist + 1));
                    visited[p.row][p.col - 1] = true;
                    buttons[p.row][p.col - 1].Enabled = true;
                    WeightPath[p.row, p.col - 1] = p.dist + 1;
                }

                // moving right
                if (p.col + 1 < Column && visited[p.row][p.col + 1] == false)
                {
                    q.Enqueue(new QItem(p.row, p.col + 1, p.dist + 1));
                    visited[p.row][p.col + 1] = true;
                    buttons[p.row][p.col + 1].Enabled = true;
                    WeightPath[p.row, p.col + 1] = p.dist + 1;
                }
            }
        }

        internal static class RectangularArrays
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
    }
}