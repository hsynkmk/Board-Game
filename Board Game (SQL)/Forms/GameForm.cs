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
    public partial class GameForm : Form
    {
        public GameForm()
        {
            InitializeComponent();
            if (UserClass.IsAdmin == true)
                manageButton.Visible = true;
        }

        private void manageButton_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            AdminForm adminfrm = new AdminForm { Owner = this };
            adminfrm.Show();
        }

        private void HelpLinkLabel_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            HelpForm help = new HelpForm { Owner = this };
            help.Show();
        }

        private void playButton_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            PlayForm play = new PlayForm { Owner = this };
            play.Show();
        }

        private void profileButton_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            ProfileForm profile = new ProfileForm { Owner = this };
            profile.Show();
        }

        private void settingsButton_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            SettingsForm settings = new SettingsForm { Owner = this };
            settings.Show();
        }

        private void logoutButton_Click_1(object sender, EventArgs e)
        {
            UserClass.Clear();
            this.Owner.Show();
            this.Close();
        }

        private void ExitLinkLabel_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SQLClass.closeConn();
            Application.Exit();
        }

        private void MultiplayerButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MultiplayerForm mlt = new MultiplayerForm { Owner = this };
            mlt.Show();
        }
    }
}
