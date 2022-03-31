﻿using System;
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
            usernameTextbox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if ((usernameTextbox.Text == "admin" && passwordTextbox.Text == "admin") || (usernameTextbox.Text == "user" && passwordTextbox.Text == "user"))
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

        private void showPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (showPasswordCheckBox.Checked)
                passwordTextbox.PasswordChar = '\0';
            else
                passwordTextbox.PasswordChar = '*';
        }
    }
}
