namespace Board_Game
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.playButton = new System.Windows.Forms.Button();
            this.manageButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.profileButton = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.DarkBlue;
            this.splitContainer1.Panel1.Controls.Add(this.playButton);
            this.splitContainer1.Panel1.Controls.Add(this.manageButton);
            this.splitContainer1.Panel1.Controls.Add(this.logoutButton);
            this.splitContainer1.Panel1.Controls.Add(this.profileButton);
            this.splitContainer1.Panel1.Controls.Add(this.settingsButton);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.exitButton);
            this.splitContainer1.Size = new System.Drawing.Size(1000, 500);
            this.splitContainer1.SplitterDistance = 264;
            this.splitContainer1.TabIndex = 0;
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.Color.GhostWhite;
            this.playButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.playButton.Location = new System.Drawing.Point(-2, 288);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(263, 47);
            this.playButton.TabIndex = 5;
            this.playButton.Text = "Play";
            this.playButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.playButton.UseVisualStyleBackColor = false;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // manageButton
            // 
            this.manageButton.BackColor = System.Drawing.Color.GhostWhite;
            this.manageButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.manageButton.Location = new System.Drawing.Point(-2, 162);
            this.manageButton.Name = "manageButton";
            this.manageButton.Size = new System.Drawing.Size(263, 47);
            this.manageButton.TabIndex = 2;
            this.manageButton.Text = "Manage";
            this.manageButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.manageButton.UseVisualStyleBackColor = false;
            this.manageButton.Visible = false;
            this.manageButton.Click += new System.EventHandler(this.manageButton_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.Color.GhostWhite;
            this.logoutButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutButton.Location = new System.Drawing.Point(-2, 447);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(263, 47);
            this.logoutButton.TabIndex = 4;
            this.logoutButton.Text = "Log out";
            this.logoutButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // profileButton
            // 
            this.profileButton.BackColor = System.Drawing.Color.GhostWhite;
            this.profileButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.profileButton.Location = new System.Drawing.Point(-2, 341);
            this.profileButton.Name = "profileButton";
            this.profileButton.Size = new System.Drawing.Size(263, 47);
            this.profileButton.TabIndex = 3;
            this.profileButton.Text = "Profile";
            this.profileButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.profileButton.UseVisualStyleBackColor = false;
            this.profileButton.Click += new System.EventHandler(this.profileButton_Click);
            // 
            // settingsButton
            // 
            this.settingsButton.BackColor = System.Drawing.Color.GhostWhite;
            this.settingsButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingsButton.Location = new System.Drawing.Point(-2, 394);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(263, 47);
            this.settingsButton.TabIndex = 0;
            this.settingsButton.Text = "Settings";
            this.settingsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.settingsButton.UseVisualStyleBackColor = false;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exitButton.Location = new System.Drawing.Point(457, 441);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(263, 47);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Exit";
            this.exitButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 500);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameForm";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button profileButton;
        private System.Windows.Forms.Button manageButton;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button playButton;
    }
}