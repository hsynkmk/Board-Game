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
        string gusername;
        string gpassword;
        public GameForm(string username, string password)
        {
            InitializeComponent();
            gusername = username;
            gpassword = password;
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            new SettingsForm(gusername, gpassword).Show();
            this.Hide();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
