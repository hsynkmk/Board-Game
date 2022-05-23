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
    public partial class HelpForm : Form
    {
        public HelpForm()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Owner.Enabled = true;
            this.Close();
        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            AboutBox about = new AboutBox();
            about.Owner = this;
            about.Show();
            //new AboutBox().Show();
        }
    }
}
