using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Board_Game_5
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            UsernameTextbox.Text = Properties.Settings.Default.username;                                    //fill username textbox with last succesful entrance
        }
        private void LoginLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)             //login
        {
            new AdminForm().Show();

            //if ()
            //{
            //    this.Hide();
            //    GameForm logedin = new GameForm();
            //    logedin.Owner = this;
            //    logedin.Show();

            //    Properties.Settings.Default.username = UsernameTextbox.Text;                                //save last succesfull entrance
            //    Properties.Settings.Default.Save();
            //}

            //else
            //{
            //    IncorrectLoginLabel.Visible = true;
            //    UsernameTextbox.Clear();
            //    PasswordTextbox.Clear();
            //    UsernameTextbox.Focus();
            //}
        }

        private void ShowPasswordCheckBox_CheckedChanged(object sender, EventArgs e)                        //show password
        {
            if (ShowPasswordCheckBox.Checked)
                PasswordTextbox.PasswordChar = '\0';
            else
                PasswordTextbox.PasswordChar = '*';
        }

        private void RegisterLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)          //register link
        {
            this.Hide();
            RegisterForm register = new RegisterForm();
            register.Owner = this;
            register.Show();
        }

        private void UsernameTextbox_TextChanged(object sender, EventArgs e)
        {
            UsernameTextbox.Text = string.Concat(UsernameTextbox.Text.Where(char.IsLetter));                //username only letter
        }

        private void ExitLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)              //exit game
        {
            Application.Exit();
        }

        private void aboutUsLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)           //about link
        {
            this.Enabled = false;
            AboutBox about = new AboutBox();
            about.Owner = this;
            about.Show();
        }
    }
}
