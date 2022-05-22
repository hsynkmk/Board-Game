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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            usernameTextbox.Text = Properties.Settings.Default.username;                                    //Save last succesfull entrance
        }

        private void loginButton_Click(object sender, EventArgs e)                                          //Login
        {

            if(GlobalFunctions.xmlConnection(usernameTextbox.Text, passwordTextbox.Text))
            {
                new GameForm().Show();
                this.Hide();
                Properties.Settings.Default.username = usernameTextbox.Text;                                //Last succesfull entrance
                Properties.Settings.Default.Save();
            }

            else {
                incorrectLoginLabel.Visible = true;
                usernameTextbox.Clear();
                passwordTextbox.Clear();
                usernameTextbox.Focus();
            }
        }

        private void showPasswordCheckBox_CheckedChanged(object sender, EventArgs e)                        //Show password
        {
            if (showPasswordCheckBox.Checked)
                passwordTextbox.PasswordChar = '\0';
            else
                passwordTextbox.PasswordChar = '*';
        }

        private void registerLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)          //Register link
        {
            RegisterForm register = new RegisterForm();
            register.Owner = this;
            register.Show();
            this.Hide();
        }

        private void usernameTextbox_TextChanged(object sender, EventArgs e)                                //Username only alphabetic caracter
        {
            usernameTextbox.Text = string.Concat(usernameTextbox.Text.Where(char.IsLetter));
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutUsLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Enabled = false;
            AboutBox about = new AboutBox();
            about.Owner = this;
            about.Show();
        }
    }
}