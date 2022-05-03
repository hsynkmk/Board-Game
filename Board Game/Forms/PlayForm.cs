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

        private void BoardMaker(int width, int height)
        {
            int locx = 0;
            int locy = 0;
            for (int i = 0; i < height; i++)
            {
                buttons.Add(new List<Button>());

                for (int j = 0; j < width; j++)
                {
                    Button newButton = new Button();
                    buttons[i].Add(newButton);

                    this.Controls.Add(newButton);
                    newButton.Location = new Point(locx, locy);
                    newButton.Size = new Size(50, 50);
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
                int rand_shape = rd.Next(0, Properties.Resources.shapes.Count);

                buttons[rand_x][rand_y].BackgroundImage = Properties.Resources.shapes[rand_shape];
                buttons[rand_x][rand_y].BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            }
        }


        public PlayForm()
        {
            InitializeComponent();

            if (UserClass.Xelem.Element("difficulty").Value == "1000")
            {
                this.ClientSize = new System.Drawing.Size(750, 750);
                BoardMaker(15, 15);
                PointThreeShape(15, 15);
            }

            else if (UserClass.Xelem.Element("difficulty").Value == "0100")
            {
                this.ClientSize = new System.Drawing.Size(450, 450);
                BoardMaker(9, 9);
            }

            else if (UserClass.Xelem.Element("difficulty").Value == "0010")
            {
                this.ClientSize = new System.Drawing.Size(300, 300);
                BoardMaker(6, 6);
            }

            else
            {
                int width = int.Parse(UserClass.Xelem.Element("customDifficultyWidth").Value);
                int height = int.Parse(UserClass.Xelem.Element("customDifficultyHeight").Value);
                this.ClientSize = new System.Drawing.Size(width * 50, height * 50);
                BoardMaker(width, height);
            }
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        }

        private void PlayForm_Load(object sender, EventArgs e)
        {

        }
    }
}
