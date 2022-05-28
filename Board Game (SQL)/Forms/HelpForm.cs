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
    public partial class HelpForm : Form
    {
        public HelpForm()
        {
            InitializeComponent();
        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            this.Owner.Enabled = true;
            this.Close();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            AboutBox about = new AboutBox{ Owner = this };
            about.Show();
        }
    }
}
