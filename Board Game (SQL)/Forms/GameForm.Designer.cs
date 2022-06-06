namespace Board_Game__SQL_
{
    partial class GameForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.ExitLinkLabel = new System.Windows.Forms.LinkLabel();
            this.HelpLinkLabel = new System.Windows.Forms.LinkLabel();
            this.playButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.profileButton = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.manageButton = new System.Windows.Forms.Button();
            this.MultiplayerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ExitLinkLabel
            // 
            this.ExitLinkLabel.AutoSize = true;
            this.ExitLinkLabel.BackColor = System.Drawing.Color.Transparent;
            this.ExitLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ExitLinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.ExitLinkLabel.LinkColor = System.Drawing.Color.White;
            this.ExitLinkLabel.Location = new System.Drawing.Point(925, 555);
            this.ExitLinkLabel.Name = "ExitLinkLabel";
            this.ExitLinkLabel.Size = new System.Drawing.Size(44, 25);
            this.ExitLinkLabel.TabIndex = 28;
            this.ExitLinkLabel.TabStop = true;
            this.ExitLinkLabel.Text = "Exit";
            this.ExitLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ExitLinkLabel_LinkClicked_1);
            // 
            // HelpLinkLabel
            // 
            this.HelpLinkLabel.AutoSize = true;
            this.HelpLinkLabel.BackColor = System.Drawing.Color.Transparent;
            this.HelpLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.HelpLinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.HelpLinkLabel.LinkColor = System.Drawing.Color.White;
            this.HelpLinkLabel.Location = new System.Drawing.Point(936, 9);
            this.HelpLinkLabel.Name = "HelpLinkLabel";
            this.HelpLinkLabel.Size = new System.Drawing.Size(52, 25);
            this.HelpLinkLabel.TabIndex = 29;
            this.HelpLinkLabel.TabStop = true;
            this.HelpLinkLabel.Text = "Help";
            this.HelpLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.HelpLinkLabel_LinkClicked_1);
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.Color.GhostWhite;
            this.playButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.playButton.Location = new System.Drawing.Point(30, 303);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(263, 47);
            this.playButton.TabIndex = 27;
            this.playButton.Text = "Play";
            this.playButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.playButton.UseVisualStyleBackColor = false;
            this.playButton.Click += new System.EventHandler(this.PlayButton_Click_1);
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.Color.GhostWhite;
            this.logoutButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutButton.Location = new System.Drawing.Point(30, 513);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(263, 47);
            this.logoutButton.TabIndex = 26;
            this.logoutButton.Text = "Log out";
            this.logoutButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.LogoutButton_Click_1);
            // 
            // profileButton
            // 
            this.profileButton.BackColor = System.Drawing.Color.GhostWhite;
            this.profileButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.profileButton.Location = new System.Drawing.Point(30, 407);
            this.profileButton.Name = "profileButton";
            this.profileButton.Size = new System.Drawing.Size(263, 47);
            this.profileButton.TabIndex = 25;
            this.profileButton.Text = "Profile";
            this.profileButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.profileButton.UseVisualStyleBackColor = false;
            this.profileButton.Click += new System.EventHandler(this.ProfileButton_Click_1);
            // 
            // settingsButton
            // 
            this.settingsButton.BackColor = System.Drawing.Color.GhostWhite;
            this.settingsButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingsButton.Location = new System.Drawing.Point(30, 460);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(263, 47);
            this.settingsButton.TabIndex = 24;
            this.settingsButton.Text = "Settings";
            this.settingsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.settingsButton.UseVisualStyleBackColor = false;
            this.settingsButton.Click += new System.EventHandler(this.SettingsButton_Click_1);
            // 
            // manageButton
            // 
            this.manageButton.BackColor = System.Drawing.Color.GhostWhite;
            this.manageButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.manageButton.Location = new System.Drawing.Point(30, 120);
            this.manageButton.Name = "manageButton";
            this.manageButton.Size = new System.Drawing.Size(263, 47);
            this.manageButton.TabIndex = 23;
            this.manageButton.Text = "Manage";
            this.manageButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.manageButton.UseVisualStyleBackColor = false;
            this.manageButton.Visible = false;
            this.manageButton.Click += new System.EventHandler(this.ManageButton_Click_1);
            // 
            // MultiplayerButton
            // 
            this.MultiplayerButton.BackColor = System.Drawing.Color.GhostWhite;
            this.MultiplayerButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MultiplayerButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MultiplayerButton.Location = new System.Drawing.Point(30, 356);
            this.MultiplayerButton.Name = "MultiplayerButton";
            this.MultiplayerButton.Size = new System.Drawing.Size(263, 47);
            this.MultiplayerButton.TabIndex = 30;
            this.MultiplayerButton.Text = "Multiplayer";
            this.MultiplayerButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.MultiplayerButton.UseVisualStyleBackColor = false;
            this.MultiplayerButton.Click += new System.EventHandler(this.MultiplayerButton_Click);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.MultiplayerButton);
            this.Controls.Add(this.ExitLinkLabel);
            this.Controls.Add(this.HelpLinkLabel);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.profileButton);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.manageButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel ExitLinkLabel;
        private System.Windows.Forms.LinkLabel HelpLinkLabel;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button profileButton;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Button manageButton;
        private System.Windows.Forms.Button MultiplayerButton;
    }
}