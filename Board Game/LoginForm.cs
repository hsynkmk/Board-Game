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
using System.Security.Cryptography;

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
            XDocument doc = XDocument.Load(@"UserData.xml");
            SHA1 sha = new SHA1CryptoServiceProvider();

            string hashedData = Convert.ToBase64String(sha.ComputeHash(Encoding.UTF8.GetBytes(passwordTextbox.Text)));

            bool isValid = false;
            foreach (XElement elem in doc.Descendants("user"))
            {
                if(elem.Element("username")?.Value==usernameTextbox.Text && elem.Element("password")?.Value == hashedData)
                {
                    new GameForm(usernameTextbox.Text, hashedData).Show();
                    this.Hide();
                    isValid = true;
                    Properties.Settings.Default.username = usernameTextbox.Text;
                    Properties.Settings.Default.Save();
                    break;
                }
            }

            if(isValid == false){
                incorrectLogin.Text = "Incorrect Username or Password";
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