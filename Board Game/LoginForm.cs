using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Xml;
using System.Xml.Linq;
using System.IO;

namespace Board_Game
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            usernameTextbox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            XDocument doc = XDocument.Load(@"UserData.xml");

            foreach (XElement elem in doc.Descendants("user"))
            {
                if(elem.Element("username")?.Value==usernameTextbox.Text && elem.Element("password")?.Value == passwordTextbox.Text)
                {
                    new GameForm().Show();
                    this.Hide();
                }
                else
                {
                    incorrectLogin.Text = " Incorrect Username or Password";
                    usernameTextbox.Clear();
                    passwordTextbox.Clear();
                    usernameTextbox.Focus();
                }
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
    }
}
