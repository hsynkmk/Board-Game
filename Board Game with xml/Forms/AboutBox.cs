﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Board_Game
{
    partial class AboutBox : Form
    {
        public AboutBox()
        {
            InitializeComponent();
            
        }

        private void backButton_Click(object sender, EventArgs e)
        {   
            this.Owner.Enabled = true;
            this.Close();
        }
    }
}
