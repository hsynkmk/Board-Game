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
            if (UserClass.IsAdmin == true)                                                          //Is admin
                manageButton.Visible = true;
        }

        private void ManageButton_Click_1(object sender, EventArgs e)                               //Admin form
        {
            this.Hide();
            AdminForm adminfrm = new AdminForm { Owner = this };
            adminfrm.Show();
        }

        private void PlayButton_Click_1(object sender, EventArgs e)                                 //Play form
        {
            this.Hide();
            PlayForm play = new PlayForm { Owner = this };
            play.Show();
        }

        private void MultiplayerButton_Click(object sender, EventArgs e)                            //Socket connection for multiplayer
        {
            this.Hide();
            ConnectionForm connf = new ConnectionForm { Owner = this };
            connf.Show();
        }

        private void ProfileButton_Click_1(object sender, EventArgs e)                              //Profile form
        {
            this.Hide();
            ProfileForm profile = new ProfileForm { Owner = this };
            profile.Show();
        }

        private void SettingsButton_Click_1(object sender, EventArgs e)                             //Settings form
        {
            this.Hide();
            SettingsForm settings = new SettingsForm { Owner = this };
            settings.Show();
        }

        private void LogoutButton_Click_1(object sender, EventArgs e)                               //Logout
        {
            UserClass.Clear();
            this.Owner.Show();
            this.Close();
        }

        private void HelpLinkLabel_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)    //Help form
        {
            this.Enabled = false;
            HelpForm help = new HelpForm { Owner = this };
            help.Show();
        }

        private void ExitLinkLabel_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)    //Exit game
        {
            SQLClass.closeConn();
            Application.Exit();
        }
    }
}
