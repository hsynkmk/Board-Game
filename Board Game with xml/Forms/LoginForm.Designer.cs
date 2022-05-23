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
            this.usernameTextbox = new System.Windows.Forms.TextBox();
            this.passwordTextbox = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.showPasswordCheckBox = new System.Windows.Forms.CheckBox();
            this.registerLinkLabel = new System.Windows.Forms.LinkLabel();
            this.noAccountLabel = new System.Windows.Forms.Label();
            this.gameNameLabel = new System.Windows.Forms.Label();
            this.incorrectLoginLabel = new System.Windows.Forms.Label();
            this.aboutUsLinkLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // usernameTextbox
            // 
            this.usernameTextbox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.usernameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.usernameTextbox.Location = new System.Drawing.Point(412, 250);
            this.usernameTextbox.Multiline = true;
            this.usernameTextbox.Name = "usernameTextbox";
            this.usernameTextbox.Size = new System.Drawing.Size(220, 30);
            this.usernameTextbox.TabIndex = 0;
            this.usernameTextbox.TextChanged += new System.EventHandler(this.usernameTextbox_TextChanged);
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.passwordTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.passwordTextbox.Location = new System.Drawing.Point(412, 316);
            this.passwordTextbox.Multiline = true;
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.PasswordChar = '*';
            this.passwordTextbox.Size = new System.Drawing.Size(220, 30);
            this.passwordTextbox.TabIndex = 1;
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(552, 371);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(80, 25);
            this.loginButton.TabIndex = 2;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(897, 554);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(80, 25);
            this.exitButton.TabIndex = 3;
            this.exitButton.TabStop = false;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.BackColor = System.Drawing.Color.Transparent;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.usernameLabel.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.usernameLabel.Location = new System.Drawing.Point(408, 225);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(89, 22);
            this.usernameLabel.TabIndex = 4;
            this.usernameLabel.Text = "username";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.BackColor = System.Drawing.Color.Transparent;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.passwordLabel.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.passwordLabel.Location = new System.Drawing.Point(408, 291);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(87, 22);
            this.passwordLabel.TabIndex = 5;
            this.passwordLabel.Text = "password";
            // 
            // showPasswordCheckBox
            // 
            this.showPasswordCheckBox.AutoSize = true;
            this.showPasswordCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.showPasswordCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.showPasswordCheckBox.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.showPasswordCheckBox.Location = new System.Drawing.Point(638, 320);
            this.showPasswordCheckBox.Name = "showPasswordCheckBox";
            this.showPasswordCheckBox.Size = new System.Drawing.Size(161, 26);
            this.showPasswordCheckBox.TabIndex = 6;
            this.showPasswordCheckBox.TabStop = false;
            this.showPasswordCheckBox.Text = "Show Password";
            this.showPasswordCheckBox.UseVisualStyleBackColor = false;
            this.showPasswordCheckBox.CheckedChanged += new System.EventHandler(this.showPasswordCheckBox_CheckedChanged);
            // 
            // registerLinkLabel
            // 
            this.registerLinkLabel.ActiveLinkColor = System.Drawing.Color.Yellow;
            this.registerLinkLabel.AutoSize = true;
            this.registerLinkLabel.BackColor = System.Drawing.Color.Transparent;
            this.registerLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.registerLinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.registerLinkLabel.LinkColor = System.Drawing.Color.Yellow;
            this.registerLinkLabel.Location = new System.Drawing.Point(478, 448);
            this.registerLinkLabel.Name = "registerLinkLabel";
            this.registerLinkLabel.Size = new System.Drawing.Size(77, 22);
            this.registerLinkLabel.TabIndex = 8;
            this.registerLinkLabel.TabStop = true;
            this.registerLinkLabel.Text = "Register";
            this.registerLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.registerLinkLabel_LinkClicked);
            // 
            // noAccountLabel
            // 
            this.noAccountLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.noAccountLabel.AutoSize = true;
            this.noAccountLabel.BackColor = System.Drawing.Color.Transparent;
            this.noAccountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.noAccountLabel.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.noAccountLabel.Location = new System.Drawing.Point(428, 414);
            this.noAccountLabel.Name = "noAccountLabel";
            this.noAccountLabel.Size = new System.Drawing.Size(189, 22);
            this.noAccountLabel.TabIndex = 9;
            this.noAccountLabel.Text = "Don\'t have an account";
            // 
            // gameNameLabel
            // 
            this.gameNameLabel.AutoSize = true;
            this.gameNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.gameNameLabel.Font = new System.Drawing.Font("Segoe Print", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gameNameLabel.ForeColor = System.Drawing.Color.Yellow;
            this.gameNameLabel.Location = new System.Drawing.Point(381, 129);
            this.gameNameLabel.Name = "gameNameLabel";
            this.gameNameLabel.Size = new System.Drawing.Size(282, 71);
            this.gameNameLabel.TabIndex = 10;
            this.gameNameLabel.Text = "Board Game";
            // 
            // incorrectLoginLabel
            // 
            this.incorrectLoginLabel.AutoSize = true;
            this.incorrectLoginLabel.BackColor = System.Drawing.Color.Transparent;
            this.incorrectLoginLabel.ForeColor = System.Drawing.Color.Red;
            this.incorrectLoginLabel.Location = new System.Drawing.Point(419, 352);
            this.incorrectLoginLabel.Name = "incorrectLoginLabel";
            this.incorrectLoginLabel.Size = new System.Drawing.Size(198, 16);
            this.incorrectLoginLabel.TabIndex = 11;
            this.incorrectLoginLabel.Text = "Incorrect username or password";
            this.incorrectLoginLabel.Visible = false;
            // 
            // aboutUsLinkLabel
            // 
            this.aboutUsLinkLabel.ActiveLinkColor = System.Drawing.Color.Yellow;
            this.aboutUsLinkLabel.AutoSize = true;
            this.aboutUsLinkLabel.BackColor = System.Drawing.Color.Transparent;
            this.aboutUsLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.aboutUsLinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.aboutUsLinkLabel.LinkColor = System.Drawing.Color.Yellow;
            this.aboutUsLinkLabel.Location = new System.Drawing.Point(471, 569);
            this.aboutUsLinkLabel.Name = "aboutUsLinkLabel";
            this.aboutUsLinkLabel.Size = new System.Drawing.Size(84, 22);
            this.aboutUsLinkLabel.TabIndex = 12;
            this.aboutUsLinkLabel.TabStop = true;
            this.aboutUsLinkLabel.Text = "About Us";
            this.aboutUsLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.aboutUsLinkLabel_LinkClicked);
            // 
            // LoginForm
            // 
            this.AcceptButton = this.loginButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.ControlBox = false;
            this.Controls.Add(this.aboutUsLinkLabel);
            this.Controls.Add(this.incorrectLoginLabel);
            this.Controls.Add(this.gameNameLabel);
            this.Controls.Add(this.noAccountLabel);
            this.Controls.Add(this.registerLinkLabel);
            this.Controls.Add(this.showPasswordCheckBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passwordTextbox);
            this.Controls.Add(this.usernameTextbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usernameTextbox;
        private System.Windows.Forms.TextBox passwordTextbox;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.CheckBox showPasswordCheckBox;
        private System.Windows.Forms.LinkLabel registerLinkLabel;
        private System.Windows.Forms.Label noAccountLabel;
        private System.Windows.Forms.Label gameNameLabel;
        private System.Windows.Forms.Label incorrectLoginLabel;
        private System.Windows.Forms.LinkLabel aboutUsLinkLabel;
    }
}

