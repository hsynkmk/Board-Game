using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Threading;

namespace Board_Game
{


    public partial class PlayForm : Form
    {

        private List<List<Button>> buttons = new List<List<Button>>();
        private List<List<int>> ShapeAndColors = new List<List<int>>();
        ////////private List<List<int>> ShortestPath = new List<List<int>>();


        private int width, height;
        private int SBx, SBy;
        private Image SBi;
        private int PointSum;



        public PlayForm()
        {
            InitializeComponent();
            Play();

        }

        private void Play()
        {
            if (UserClass.Xelem.Element("difficulty").Value == "1000")
            {
                this.ClientSize = new System.Drawing.Size(750, 750);
                width = height = 15;
                BoardMaker(15, 15);
                PointThreeShape(15, 15);
            }

            else if (UserClass.Xelem.Element("difficulty").Value == "0100")
            {
                this.ClientSize = new System.Drawing.Size(450, 450);
                width = height = 9;
                BoardMaker(9, 9);
                PointThreeShape(9, 9);
            }

            else if (UserClass.Xelem.Element("difficulty").Value == "0010")
            {
                this.ClientSize = new System.Drawing.Size(300, 300);
                width = height = 6;
                BoardMaker(6, 6);
                PointThreeShape(6, 6);
            }

            else
            {
                width = int.Parse(UserClass.Xelem.Element("customDifficultyWidth").Value) * 50;
                height = int.Parse(UserClass.Xelem.Element("customDifficultyHeight").Value) * 50;
                this.ClientSize = new System.Drawing.Size(width, height);
                BoardMaker(width, height);
                PointThreeShape(width, height);
            }
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            //for(int i = 0; i < height; i++)
            //{
            //    for(int j = 0; j < width; j++)
            //    {


            //    }
            //}


        }




        private void BoardMaker(int width, int height)
        {
            int locx = 0;
            int locy = 0;
            for (int i = 0; i < height; i++)
            {
                buttons.Add(new List<Button>());
                ShapeAndColors.Add(new List<int>());

                for (int j = 0; j < width; j++)
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



        private void PointThreeShape(int width, int height)
        {
            DisableEmptyButtons(width, height);

            Random rd = new Random();

            for (int i = 0; i < 3; i++)
            {

                int rand_x = rd.Next(0, width);
                int rand_y = rd.Next(0, height);
                int rand_shape = rd.Next(0, 9);

                if (ShapeAndColors[rand_x][rand_y] == -1)
                {
                    ShapeAndColors[rand_x][rand_y] = rand_shape;

                    buttons[rand_x][rand_y].Enabled = true;
                    buttons[rand_x][rand_y].BackgroundImage = Properties.Resources.shapes[rand_shape];
                    buttons[rand_x][rand_y].BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
                }
                else
                    i--;

            }

        }

        private void DisableEmptyButtons(int width, int height)
        {
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (ShapeAndColors[i][j] == -1)
                        buttons[i][j].Enabled = false;
                }
            }
        }

        private void EnableEmptyButtons(int width, int height)
        {
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (ShapeAndColors[i][j] == -1)
                        buttons[i][j].Enabled = true;
                }
            }
        }


        bool IsGetPoint(List<List<int>> ShapeAndColors)
        {
            int track;

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j <= width - 5; j++)
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
                            return true;
                        }

                    }
                }
            }

            for (int j = 0; j < width; j++)
            {
                for (int i = 0; i <= height - 5; i++)
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
                            return true;
                        }
                    }
                }
            }
            return false;
        }


        bool IsGameOver()
        {

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                    if (ShapeAndColors[i][j] == -1)
                        return false;
            }
            return true;
        }

        private void Buttons_MouseClick(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (sender == buttons[i][j] && ShapeAndColors[i][j] != -1)
                    {

                        buttons[i][j].BackColor = Color.Aqua;
                        SBx = j;
                        SBy = i;
                        SBi = buttons[i][j].BackgroundImage;
                        //EnableEmptyButtons(width, height);
                        DisableEmptyButtons(width, height);
                        ShortestAndAvailable(ShapeAndColors, false, SBy, SBx);

                    }
                    else if (sender == buttons[i][j] && ShapeAndColors[i][j] == -1)
                    {
                        buttons[SBy][SBx].BackColor = Color.Azure;
                        buttons[SBy][SBx].BackgroundImage = null;
                        buttons[i][j].BackgroundImage = SBi;
                        buttons[i][j].BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;

                        buttons[SBy][SBx].Enabled = false;
                        ShapeAndColors[SBy][SBx] = -1;
                        buttons[i][j].Enabled = true;
                        ShapeAndColors[i][j] = Properties.Resources.shapes.IndexOf((Bitmap)SBi);

                        ShortestAndAvailable(ShapeAndColors, true, i, j);
                        DisableEmptyButtons(width, height);

                        if (IsGetPoint(ShapeAndColors))
                        {
                            if (UserClass.Xelem.Element("difficulty").Value == "1000")
                                PointSum += 1;
                            else if (UserClass.Xelem.Element("difficulty").Value == "0100")
                                PointSum += 3;
                            else if (UserClass.Xelem.Element("difficulty").Value == "0010")
                                PointSum += 5;
                            else
                                PointSum += 2;
                            MessageBox.Show("Point: " + PointSum.ToString());
                        }

                        else
                            PointThreeShape(width, height);
                        if (IsGameOver())
                            MessageBox.Show("game over");
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


        void ShortestAndAvailable(List<List<int>> grid, bool move, int row, int column)
        {
            QItem source = new QItem(0, 0, 0);

            // To keep track of visited QItems. Marking
            // blocked cells as visited.
            bool[][] visited = RectangularArrays.RectangularBoolArray(height, width);

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (grid[i][j] != -1)
                    {
                        visited[i][j] = true;
                    }
                    else
                    {
                        visited[i][j] = false;
                    }

                     if(move==true)
                        visited[row][column] = false;

                    // Finding source

                    source.row = SBy;
                    source.col = SBx;
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
                    MessageBox.Show("Step: " + p.dist.ToString());
                    return;
                    //return p.dist;
                }

                // moving up
                if (p.row - 1 >= 0 && visited[p.row - 1][p.col] == false)
                {
                    q.Enqueue(new QItem(p.row - 1, p.col, p.dist + 1));
                    visited[p.row - 1][p.col] = true;
                    buttons[p.row - 1][p.col].Enabled = true;
                }

                // moving down
                if (p.row + 1 < height && visited[p.row + 1][p.col] == false)
                {
                    q.Enqueue(new QItem(p.row + 1, p.col, p.dist + 1));
                    visited[p.row + 1][p.col] = true;
                    buttons[p.row + 1][p.col].Enabled = true;
                }

                // moving left
                if (p.col - 1 >= 0 && visited[p.row][p.col - 1] == false)
                {
                    q.Enqueue(new QItem(p.row, p.col - 1, p.dist + 1));
                    visited[p.row][p.col - 1] = true;
                    buttons[p.row][p.col - 1].Enabled = true;
                }

                // moving right
                if (p.col + 1 < width && visited[p.row][p.col + 1] == false)
                {
                    q.Enqueue(new QItem(p.row, p.col + 1, p.dist + 1));
                    visited[p.row][p.col + 1] = true;
                    buttons[p.row][p.col + 1].Enabled = true;
                }
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