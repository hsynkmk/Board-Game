using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace Board_Game__SQL_
{
    public partial class MultiplayerForm : Form
    {

        private TcpClient client;
        private TcpListener Listener;
        public StreamReader STR;
        public StreamWriter STW;
        string received;
        string send;


        private List<List<Button>> buttons = new List<List<Button>>();
        private List<List<int>> ShapeAndColors = new List<List<int>>();

        private int Column = 9, Row = 9;
        private int SBcol, SBrow;
        private Image SBi;
        private int PointSum;


        System.Media.SoundPlayer winSound = new System.Media.SoundPlayer(Properties.Resources.WinSound);
        System.Media.SoundPlayer pointSound = new System.Media.SoundPlayer(Properties.Resources.EntranceSound);
        System.Media.SoundPlayer lastStepSound = new System.Media.SoundPlayer(Properties.Resources.LastStepSound);
        System.Media.SoundPlayer stepSound = new System.Media.SoundPlayer(Properties.Resources.StepSound);
        System.Media.SoundPlayer bonusSound = new System.Media.SoundPlayer(Properties.Resources.BonusSound);


        public MultiplayerForm(TcpListener Listener, TcpClient client)
        {
            InitializeComponent();
            this.client = client;
            this.Listener = Listener;

            STR = new StreamReader(this.client.GetStream());
            STW = new StreamWriter(this.client.GetStream());
            STW.AutoFlush = true;


            backgroundWorker1.RunWorkerAsync();                     //start reciving data in backround
            backgroundWorker1.WorkerSupportsCancellation = true;
            backgroundWorker2.WorkerSupportsCancellation = true;    //ability to cancel this thread




            YourTurnButton.Location = new System.Drawing.Point(182, 0);
            this.ClientSize = new System.Drawing.Size(450, 470);
            ExitButton.Location = new System.Drawing.Point(405, 0);
            Column = Row = 9;
            BoardMaker(9, 9);
            PointThreeShape(9, 9);
            backgroundWorker2.RunWorkerAsync();
        }

        public MultiplayerForm(TcpClient client)
        {
            InitializeComponent();
            this.client = client;

            STR = new StreamReader(this.client.GetStream());
            STW = new StreamWriter(this.client.GetStream());
            STW.AutoFlush = true;

            backgroundWorker1.RunWorkerAsync();                     //start reciving data in backround
            backgroundWorker1.WorkerSupportsCancellation = true;
            backgroundWorker2.WorkerSupportsCancellation = true;    //ability to cancel this thread


            YourTurnButton.Location = new System.Drawing.Point(182, 0);
            ExitButton.Location = new System.Drawing.Point(405, 0);
            this.ClientSize = new System.Drawing.Size(450, 470);
            Column = Row = 9;
            BoardMaker(9, 9);
        }


        private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)         //recieves
        {
            Thread.Sleep(1000);
            while (client.Connected)
            {


                try
                {

                    int a = 0;


                    received = STR.ReadLine();


                    if (!(received == null))
                    {
                        OpponentPointLabel.Invoke(new MethodInvoker(delegate () { OpponentPointLabel.Text = received.Substring(81); }));


                        for (int i = 0; i < 9; i++)
                        {
                            for (int j = 0; j < 9; j++)
                            {
                                ShapeAndColors[i][j] = (int)(received[a] - '0');
                                a++;
                            }

                            BoardEquilizer(ShapeAndColors);
                            YourTurnButton.BackColor = Color.Green;
                            EnableAllButtons(9, 9);
                        }
                    }

                    if (IsGameOver())
                    {
                        for (int i = 0; i < 9; i++)
                        {
                            for (int j = 0; j < 9; j++)
                                send += (ShapeAndColors[i][j].ToString());
                        }
                        send += PointSum.ToString();
                        STW.WriteLine(send);

                        winSound.Play();
                        GameOver();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void BackgroundWorker2_DoWork(object sender, DoWorkEventArgs e)         //sends
        {
            send = "";
            if (client.Connected)
            {
                if (IsGameOver())
                {
                    winSound.Play();
                    GameOver();
                }

                for (int i = 0; i < 9; i++)
                {
                    for (int j = 0; j < 9; j++)
                        send += (ShapeAndColors[i][j].ToString());
                }
                send += PointSum.ToString();
                STW.WriteLine(send);


                YourTurnButton.BackColor = Color.Red;
                DisableAllButtons(9, 9);
                YourPointLabel.Invoke(new MethodInvoker(delegate () { YourPointLabel.Text = PointSum.ToString(); }));
            }
            else
            {
                MessageBox.Show("Send Failed");
            }
            backgroundWorker2.CancelAsync();
        }


        private void GameOver()
        {
            if (OpponentPointLabel.Text != "" && YourPointLabel.Text != "")
            {
                if (int.Parse(OpponentPointLabel.Text) < int.Parse(YourPointLabel.Text))
                {
                    MessageBox.Show("YOU WON\n");
                    //client.Close();
                    backgroundWorker1.CancelAsync();

                    this.Invoke(new MethodInvoker(delegate () { this.Hide(); }));
                    this.Invoke(new MethodInvoker(delegate () { this.Owner.Owner.Show(); }));
                    return;
                }

                else if (int.Parse(OpponentPointLabel.Text) > int.Parse(YourPointLabel.Text))
                {
                    MessageBox.Show("YOU LOST\n");
                    //client.Close();
                    backgroundWorker1.CancelAsync();

                    this.Invoke(new MethodInvoker(delegate () { this.Hide(); }));
                    this.Invoke(new MethodInvoker(delegate () { this.Owner.Owner.Show(); }));

                    return;
                }

                else if (int.Parse(OpponentPointLabel.Text) == int.Parse(YourPointLabel.Text))
                {
                    MessageBox.Show("SCORELESS, You are even");
                    //client.Close();
                    backgroundWorker1.CancelAsync();

                    this.Invoke(new MethodInvoker(delegate () { this.Hide(); }));
                    this.Invoke(new MethodInvoker(delegate () { this.Owner.Owner.Show(); }));
                    return;
                }
            }
        }

        private void DisableAllButtons(int row, int col)
        {
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    buttons[i][j].Invoke(new MethodInvoker(delegate () { buttons[i][j].Enabled = false; }));
                }
            }
        }

        private void EnableAllButtons(int row, int col)
        {
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (ShapeAndColors[i][j] == 9)
                        buttons[i][j].Invoke(new MethodInvoker(delegate () { buttons[i][j].Enabled = false; }));
                    else
                        buttons[i][j].Invoke(new MethodInvoker(delegate () { buttons[i][j].Enabled = true; }));
                }
            }
        }




        private void BoardEquilizer(List<List<int>> ShapeAndColors)
        {
            //this.ShapeAndColors = ShapeAndColors;
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (ShapeAndColors[i][j] != 9)
                    {
                        buttons[i][j].BackgroundImage = Properties.Resources.shapes[ShapeAndColors[i][j]];
                        buttons[i][j].Invoke(new MethodInvoker(delegate () { buttons[i][j].Enabled = true; }));
                        buttons[i][j].BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
                    }

                    else
                    {
                        buttons[i][j].BackgroundImage = null;
                        buttons[i][j].Invoke(new MethodInvoker(delegate () { buttons[i][j].Enabled = false; }));
                        buttons[i][j].BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
                    }
                }
            }
        }




        private void BoardMaker(int row, int col)
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

        private void Buttons_MouseClick(object sender, MouseEventArgs e)
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

                        }
                        backgroundWorker2.RunWorkerAsync();
                    }
                    else
                        buttons[i][j].BackColor = Color.Azure;
                }
            }
        }
        private void PointThreeShape(int row, int col)
        {
            Random rd = new Random();

            for (int i = 0; i < 3; i++)
            {
                int rand_c = rd.Next(0, col);
                int rand_r = rd.Next(0, row);
                int rand_shape = rd.Next(0, GlobalMethods.ShapeAndColorPref().Count());

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
        private void DisableEmptyButtons(int row, int col)
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
                            PointSum += 3;

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
                            PointSum += 3;

                            return true;
                        }
                    }
                }
            }
            return false;
        }
        private bool IsGameOver()
        {
            for (int i = 0; i < Row; i++)
            {
                for (int j = 0; j < Column; j++)
                    if (ShapeAndColors[i][j] == 9)
                        return false;
            }
            return true;
        }




        int[,] ShortestAndAvailable(int row, int column)
        {
            int[,] WeightPath = new int[Row, Column];             //for shortest path



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
        private void BackButton_Click(object sender, EventArgs e)
        {
            client.Close();
            SQLClass.connection.Close();
            Application.Exit();
        }
    }
}