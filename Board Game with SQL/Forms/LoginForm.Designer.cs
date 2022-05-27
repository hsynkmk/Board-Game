namespace Board_Game
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.aboutUsLinkLabel = new System.Windows.Forms.LinkLabel();
            this.IncorrectLoginLabel = new System.Windows.Forms.Label();
            this.GameNameLabel = new System.Windows.Forms.Label();
            this.NoAccountLabel = new System.Windows.Forms.Label();
            this.RegisterLinkLabel = new System.Windows.Forms.LinkLabel();
            this.ShowPasswordCheckBox = new System.Windows.Forms.CheckBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.PasswordTextbox = new System.Windows.Forms.TextBox();
            this.UsernameTextbox = new System.Windows.Forms.TextBox();
            this.LoginLinkLabel = new System.Windows.Forms.LinkLabel();
            this.ExitLinkLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // aboutUsLinkLabel
            // 
            this.aboutUsLinkLabel.ActiveLinkColor = System.Drawing.Color.Yellow;
            this.aboutUsLinkLabel.AutoSize = true;
            this.aboutUsLinkLabel.BackColor = System.Drawing.Color.Transparent;
            this.aboutUsLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.aboutUsLinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.aboutUsLinkLabel.LinkColor = System.Drawing.Color.Yellow;
            this.aboutUsLinkLabel.Location = new System.Drawing.Point(463, 569);
            this.aboutUsLinkLabel.Name = "aboutUsLinkLabel";
            this.aboutUsLinkLabel.Size = new System.Drawing.Size(84, 22);
            this.aboutUsLinkLabel.TabIndex = 5;
            this.aboutUsLinkLabel.TabStop = true;
            this.aboutUsLinkLabel.Text = "About Us";
            this.aboutUsLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.aboutUsLinkLabel_LinkClicked);
            // 
            // IncorrectLoginLabel
            // 
            this.IncorrectLoginLabel.AutoSize = true;
            this.IncorrectLoginLabel.BackColor = System.Drawing.Color.Transparent;
            this.IncorrectLoginLabel.ForeColor = System.Drawing.Color.Red;
            this.IncorrectLoginLabel.Location = new System.Drawing.Point(418, 371);
            this.IncorrectLoginLabel.Name = "IncorrectLoginLabel";
            this.IncorrectLoginLabel.Size = new System.Drawing.Size(198, 16);
            this.IncorrectLoginLabel.TabIndex = 23;
            this.IncorrectLoginLabel.Text = "Incorrect username or password";
            this.IncorrectLoginLabel.Visible = false;
            // 
            // GameNameLabel
            // 
            this.GameNameLabel.AutoSize = true;
            this.GameNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.GameNameLabel.Font = new System.Drawing.Font("Segoe Print", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GameNameLabel.ForeColor = System.Drawing.Color.DarkGreen;
            this.GameNameLabel.Location = new System.Drawing.Point(377, 153);
            this.GameNameLabel.Name = "GameNameLabel";
            this.GameNameLabel.Size = new System.Drawing.Size(282, 71);
            this.GameNameLabel.TabIndex = 22;
            this.GameNameLabel.Text = "Board Game";
            // 
            // NoAccountLabel
            // 
            this.NoAccountLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.NoAccountLabel.AutoSize = true;
            this.NoAccountLabel.BackColor = System.Drawing.Color.Transparent;
            this.NoAccountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.NoAccountLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NoAccountLabel.Location = new System.Drawing.Point(420, 427);
            this.NoAccountLabel.Name = "NoAccountLabel";
            this.NoAccountLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.NoAccountLabel.Size = new System.Drawing.Size(189, 22);
            this.NoAccountLabel.TabIndex = 21;
            this.NoAccountLabel.Text = "Don\'t have an account";
            // 
            // RegisterLinkLabel
            // 
            this.RegisterLinkLabel.ActiveLinkColor = System.Drawing.Color.Yellow;
            this.RegisterLinkLabel.AutoSize = true;
            this.RegisterLinkLabel.BackColor = System.Drawing.Color.Transparent;
            this.RegisterLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RegisterLinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.RegisterLinkLabel.LinkColor = System.Drawing.Color.Yellow;
            this.RegisterLinkLabel.Location = new System.Drawing.Point(470, 463);
            this.RegisterLinkLabel.Name = "RegisterLinkLabel";
            this.RegisterLinkLabel.Size = new System.Drawing.Size(77, 22);
            this.RegisterLinkLabel.TabIndex = 4;
            this.RegisterLinkLabel.TabStop = true;
            this.RegisterLinkLabel.Text = "Register";
            this.RegisterLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.RegisterLinkLabel_LinkClicked);
            // 
            // ShowPasswordCheckBox
            // 
            this.ShowPasswordCheckBox.AutoSize = true;
            this.ShowPasswordCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.ShowPasswordCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ShowPasswordCheckBox.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.ShowPasswordCheckBox.Location = new System.Drawing.Point(645, 342);
            this.ShowPasswordCheckBox.Name = "ShowPasswordCheckBox";
            this.ShowPasswordCheckBox.Size = new System.Drawing.Size(125, 20);
            this.ShowPasswordCheckBox.TabIndex = 19;
            this.ShowPasswordCheckBox.TabStop = false;
            this.ShowPasswordCheckBox.Text = "Show Password";
            this.ShowPasswordCheckBox.UseVisualStyleBackColor = false;
            this.ShowPasswordCheckBox.CheckedChanged += new System.EventHandler(this.ShowPasswordCheckBox_CheckedChanged);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.BackColor = System.Drawing.Color.Transparent;
            this.PasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PasswordLabel.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.PasswordLabel.Location = new System.Drawing.Point(400, 304);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(87, 22);
            this.PasswordLabel.TabIndex = 18;
            this.PasswordLabel.Text = "password";
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.BackColor = System.Drawing.Color.Transparent;
            this.UsernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UsernameLabel.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.UsernameLabel.Location = new System.Drawing.Point(400, 238);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(89, 22);
            this.UsernameLabel.TabIndex = 17;
            this.UsernameLabel.Text = "username";
            // 
            // PasswordTextbox
            // 
            this.PasswordTextbox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.PasswordTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PasswordTextbox.Location = new System.Drawing.Point(400, 329);
            this.PasswordTextbox.Multiline = true;
            this.PasswordTextbox.Name = "PasswordTextbox";
            this.PasswordTextbox.PasswordChar = '*';
            this.PasswordTextbox.Size = new System.Drawing.Size(240, 35);
            this.PasswordTextbox.TabIndex = 2;
            // 
            // UsernameTextbox
            // 
            this.UsernameTextbox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.UsernameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UsernameTextbox.Location = new System.Drawing.Point(400, 263);
            this.UsernameTextbox.Multiline = true;
            this.UsernameTextbox.Name = "UsernameTextbox";
            this.UsernameTextbox.Size = new System.Drawing.Size(240, 35);
            this.UsernameTextbox.TabIndex = 1;
            this.UsernameTextbox.TextChanged += new System.EventHandler(this.UsernameTextbox_TextChanged);
            // 
            // LoginLinkLabel
            // 
            this.LoginLinkLabel.ActiveLinkColor = System.Drawing.Color.Yellow;
            this.LoginLinkLabel.AutoSize = true;
            this.LoginLinkLabel.BackColor = System.Drawing.Color.Transparent;
            this.LoginLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LoginLinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.LoginLinkLabel.LinkColor = System.Drawing.Color.White;
            this.LoginLinkLabel.Location = new System.Drawing.Point(586, 396);
            this.LoginLinkLabel.Name = "LoginLinkLabel";
            this.LoginLinkLabel.Size = new System.Drawing.Size(54, 22);
            this.LoginLinkLabel.TabIndex = 3;
            this.LoginLinkLabel.TabStop = true;
            this.LoginLinkLabel.Text = "Login";
            this.LoginLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LoginLinkLabel_LinkClicked);
            // 
            // ExitLinkLabel
            // 
            this.ExitLinkLabel.ActiveLinkColor = System.Drawing.Color.Yellow;
            this.ExitLinkLabel.AutoSize = true;
            this.ExitLinkLabel.BackColor = System.Drawing.Color.Transparent;
            this.ExitLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ExitLinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.ExitLinkLabel.LinkColor = System.Drawing.Color.White;
            this.ExitLinkLabel.Location = new System.Drawing.Point(948, 569);
            this.ExitLinkLabel.Name = "ExitLinkLabel";
            this.ExitLinkLabel.Size = new System.Drawing.Size(40, 22);
            this.ExitLinkLabel.TabIndex = 6;
            this.ExitLinkLabel.TabStop = true;
            this.ExitLinkLabel.Text = "Exit";
            this.ExitLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ExitLinkLabel_LinkClicked);
            // 
            // LoginForm
            // 
            this.AcceptButton = this.LoginLinkLabel;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.ExitLinkLabel;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.ExitLinkLabel);
            this.Controls.Add(this.LoginLinkLabel);
            this.Controls.Add(this.aboutUsLinkLabel);
            this.Controls.Add(this.IncorrectLoginLabel);
            this.Controls.Add(this.GameNameLabel);
            this.Controls.Add(this.NoAccountLabel);
            this.Controls.Add(this.RegisterLinkLabel);
            this.Controls.Add(this.ShowPasswordCheckBox);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.PasswordTextbox);
            this.Controls.Add(this.UsernameTextbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel aboutUsLinkLabel;
        private System.Windows.Forms.Label IncorrectLoginLabel;
        private System.Windows.Forms.Label GameNameLabel;
        private System.Windows.Forms.Label NoAccountLabel;
        private System.Windows.Forms.LinkLabel RegisterLinkLabel;
        private System.Windows.Forms.CheckBox ShowPasswordCheckBox;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.TextBox PasswordTextbox;
        private System.Windows.Forms.TextBox UsernameTextbox;
        private System.Windows.Forms.LinkLabel LoginLinkLabel;
        private System.Windows.Forms.LinkLabel ExitLinkLabel;
    }
}

