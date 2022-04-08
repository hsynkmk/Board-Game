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
    public partial class GameForm : Form
    {
        public GameForm()
        {
            InitializeComponent();
            if (UserClass.Xelem.Name == "Admin")
                manageButton.Visible = true;
            else
                manageButton.Visible = false;
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            new SettingsForm().Show();
            this.Hide();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void manageButton_Click(object sender, EventArgs e)
        {
            new AdminForm().Show();
            this.Hide();
        }

        private void profileButton_Click(object sender, EventArgs e)
        {
            new UserForm().Show();
            this.Hide();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            new LoginForm().Show();
            this.Hide();
        }
    }
}
