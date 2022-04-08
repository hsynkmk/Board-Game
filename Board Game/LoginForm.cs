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
            usernameTextbox.Text = Properties.Settings.Default.username;
            usernameTextbox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {

            if(UserClass.xmlConnection(usernameTextbox.Text, passwordTextbox.Text))
            {
                new GameForm().Show();
                this.Hide();
                Properties.Settings.Default.username = usernameTextbox.Text;
                Properties.Settings.Default.Save();
            }

            else {
                incorrectLoginLabel.Visible = true;
                usernameTextbox.Clear();
                passwordTextbox.Clear();
                usernameTextbox.Focus();
            }
        }

        private void showPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (showPasswordCheckBox.Checked)
                passwordTextbox.PasswordChar = '\0';
            else
                passwordTextbox.PasswordChar = '*';
        }

        private void registerLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new RegisterForm().Show();
            this.Hide();
        }

        private void usernameTextbox_TextChanged(object sender, EventArgs e)
        {
            usernameTextbox.Text = string.Concat(usernameTextbox.Text.Where(char.IsLetter));
        }
    }
}