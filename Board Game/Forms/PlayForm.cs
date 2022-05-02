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
            if (UserClass.Xelem.Element("difficulty").Value == "1000")
            {
                this.ClientSize = new System.Drawing.Size(750, 750);
                this.tableLayoutPanel1.Size = new System.Drawing.Size(750, 750);

                this.tableLayoutPanel1.ColumnCount = 15;
                for(int i = 1; i < 15; i++)
                    this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 49F));
                this.tableLayoutPanel1.RowCount = 15;
                for (int i = 1; i < 15; i++)
                    this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            }

            else if (UserClass.Xelem.Element("difficulty").Value == "0100")
            {
                this.ClientSize = new System.Drawing.Size(450, 450);
                this.tableLayoutPanel1.Size = new System.Drawing.Size(450, 450);

                this.tableLayoutPanel1.ColumnCount = 9;
                for (int i = 1; i < 9; i++)
                    this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 49F));
                this.tableLayoutPanel1.RowCount = 9;
                for (int i = 1; i < 9; i++)
                    this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            }

            else if (UserClass.Xelem.Element("difficulty").Value == "0010")
            {
                this.ClientSize = new System.Drawing.Size(300, 300);
                this.tableLayoutPanel1.Size = new System.Drawing.Size(300, 300);

                this.tableLayoutPanel1.ColumnCount = 6;
                for (int i = 1; i < 6; i++)
                    this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 48F));
                this.tableLayoutPanel1.RowCount = 6;
                for (int i = 1; i < 6; i++)
                    this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            }

            else
            {
                int width = int.Parse(UserClass.Xelem.Element("customDifficultyWidth").Value);
                int height = int.Parse(UserClass.Xelem.Element("customDifficultyHeight").Value);
                this.ClientSize = new System.Drawing.Size(width * 50, height * 50);
                this.tableLayoutPanel1.Size = new System.Drawing.Size(width * 50, height * 50);

                this.tableLayoutPanel1.ColumnCount = width;
                for (int i = 1; i < width; i++)
                    this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 48F));
                this.tableLayoutPanel1.RowCount = height;
                for (int i = 1; i < height; i++)
                    this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            }

            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

        }

        private void tableLayoutPanel1_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            if ((e.Column + e.Row) % 2 == 1)
                e.Graphics.FillRectangle(Brushes.Black, e.CellBounds);
            else
                e.Graphics.FillRectangle(Brushes.White, e.CellBounds);
        }
    }
}
