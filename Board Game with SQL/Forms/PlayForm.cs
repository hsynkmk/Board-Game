using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Board_Game
{
    public partial class PlayForm : Form
    {
        public PlayForm()
        {
            InitializeComponent();
        }
    }
}

/*
 private List<List<Button>> buttons = new List<List<Button>>();
        private List<List<int>> ShapeAndColors = new List<List<int>>();

        System.Media.SoundPlayer winSound = new System.Media.SoundPlayer(Properties.Resources.WinSound);
        System.Media.SoundPlayer pointSound = new System.Media.SoundPlayer(Properties.Resources.PointSound);
        System.Media.SoundPlayer moveSound = new System.Media.SoundPlayer(Properties.Resources.MoveSound);


        private int Column, Row;
        private int SBcol, SBrow;
        private Image SBi;
        private int PointSum;



        public PlayForm()
        {
            InitializeComponent();
            Play();
            this.Text = "Best Score: " + GlobalFunctions.Xelem.Element("bestScore").Value;
        }


        private void PlayForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            new GameForm().Show();
        }

        private void Play()
        {
            if (GlobalFunctions.Xelem.Element("difficulty").Value == "1000")
            {
                this.ClientSize = new System.Drawing.Size(750, 750);
                Column = Row = 15;
                BoardMaker(15, 15);
                PointThreeShape(15, 15);
            }

            else if (GlobalFunctions.Xelem.Element("difficulty").Value == "0100")
            {
                this.ClientSize = new System.Drawing.Size(450, 450);
                Column = Row = 9;
                BoardMaker(9, 9);
                PointThreeShape(9, 9);
            }

            else if (GlobalFunctions.Xelem.Element("difficulty").Value == "0010")
            {
                this.ClientSize = new System.Drawing.Size(300, 300);
                Column = Row = 6;
                BoardMaker(6, 6);
                PointThreeShape(6, 6);
            }

            else if (GlobalFunctions.Xelem.Element("difficulty").Value == "0001")
            {
                Column = int.Parse(GlobalFunctions.Xelem.Element("customDifficultyWidth").Value);
                Row = int.Parse(GlobalFunctions.Xelem.Element("customDifficultyHeight").Value);
                this.ClientSize = new System.Drawing.Size(Column * 50, Row * 50);
                BoardMaker(Row, Column);
                PointThreeShape(Row, Column);
            }
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        }




        private void BoardMaker(int row, int col)
        {
            int locx = 0;
            int locy = 0;
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
                    buttons[i][j].Name = i + " " + j;
                    this.buttons[i][j].MouseClick += new System.Windows.Forms.MouseEventHandler(this.Buttons_MouseClick);///////////////////
                    buttons[i][j].Location = new Point(locx, locy);
                    buttons[i][j].Size = new Size(50, 50);
                    buttons[i][j].BackColor = Color.Azure;

                    locx += 50;
                }
                locx = 0;
                locy += 50;
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
                int rand_shape = rd.Next(0, GlobalFunctions.ShapeAndColorPref().Count() - 1);

                if (ShapeAndColors[rand_r][rand_c] == -1)
                {
                    ShapeAndColors[rand_r][rand_c] = GlobalFunctions.SClist[rand_shape];

                    buttons[rand_r][rand_c].Enabled = true;
                    buttons[rand_r][rand_c].BackgroundImage = Properties.Resources.shapes[GlobalFunctions.SClist[rand_shape]];
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
                            if (GlobalFunctions.Xelem.Element("difficulty").Value == "1000")
                                PointSum += 1;
                            else if (GlobalFunctions.Xelem.Element("difficulty").Value == "0100")
                                PointSum += 3;
                            else if (GlobalFunctions.Xelem.Element("difficulty").Value == "0010")
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
                            if (GlobalFunctions.Xelem.Element("difficulty").Value == "1000")
                                PointSum += 1;
                            else if (GlobalFunctions.Xelem.Element("difficulty").Value == "0100")
                                PointSum += 3;
                            else if (GlobalFunctions.Xelem.Element("difficulty").Value == "0010")
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

                        //ShortestAndAvailable(true, i, j);
                        DisableEmptyButtons(Row, Column);
                        moveSound.Play();

                        //if (IsGetPoint(ShapeAndColors))
                        //{

                        //}

                        if (!IsGetPoint(ShapeAndColors))
                            PointThreeShape(Row, Column);

                        if (IsGameOver())
                        {
                            if (PointSum > int.Parse(GlobalFunctions.Xelem.Element("bestScore").Value))
                            {
                                GlobalFunctions.xmlsave("bestScore", PointSum.ToString());
                                GlobalFunctions.Xelem.Element("bestScore").Value = PointSum.ToString();
                            }


                            winSound.Play();
                            MessageBox.Show("Game Over\n" + "Point: " + PointSum.ToString() + "\n" + "Best Score: " + GlobalFunctions.Xelem.Element("bestScore").Value);
                            this.Close();
                            Form a = GameForm.ActiveForm;
                            a.Show();

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
 */