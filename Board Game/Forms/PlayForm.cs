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

        private List<List<Button>> buttons = new List<List<Button>>();
        private List<List<int>> ShapeAndColors = new List<List<int>>();
        

        private int width, height;
        private int SBx, SBy;
        private Image SBi;


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

        private void Buttons_MouseClick(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (sender == buttons[i][j] && ShapeAndColors[i][j] != -1)
                    {
                        EnableEmptyButtons(width, height);
                        buttons[i][j].BackColor = Color.Aqua;
                        SBx = j;
                        SBy = i;
                        SBi = buttons[i][j].BackgroundImage;
                    }
                    else if(sender == buttons[i][j] && ShapeAndColors[i][j] == -1)
                    {
                        buttons[SBy][SBx].BackgroundImage = null;
                        buttons[i][j].BackgroundImage = SBi;
                        buttons[i][j].BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
                        DisableEmptyButtons(width, height);
                        buttons[SBy][SBx].Enabled = false;
                        ShapeAndColors[SBy][SBx] = -1;
                        buttons[i][j].Enabled = true;
                        ShapeAndColors[i][j] = Properties.Resources.shapes.IndexOf((Bitmap)SBi);
                    }
                    else
                        buttons[i][j].BackColor = Color.Azure;
                }
            }
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
                    ShapeAndColors[i].Add( -1 );
                    
                    this.Controls.Add(buttons[i][j]);
                    buttons[i][j].Name = i + " " + j;
                    this.buttons[i][j].MouseClick += new System.Windows.Forms.MouseEventHandler(this.Buttons_MouseClick);///////////////////
                    buttons[i][j].Location = new Point(locx, locy);
                    buttons[i][j].Size = new Size(50, 50);
                    buttons[i][j].BackColor= Color.Azure;

                    locx += 50;
                }
                locx = 0;
                locy += 50;
            }
        }
        

        private void PointThreeShape(int width, int height)
        {
                Random rd = new Random();

            for (int i = 0; i < 3; i++)
            {
                int rand_x = rd.Next(0, width);
                int rand_y = rd.Next(0, height);
                int rand_shape = rd.Next(0, 9);

                ShapeAndColors[rand_x][rand_y] = rand_shape;

                buttons[rand_x][rand_y].BackgroundImage = Properties.Resources.shapes[rand_shape];
                buttons[rand_x][rand_y].BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            }
            DisableEmptyButtons(width, height);
        }

        private void DisableEmptyButtons(int width, int height)
        {
            for(int i = 0; i < height; i++)
            {
                for(int j = 0; j < width; j++)
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
    }
}