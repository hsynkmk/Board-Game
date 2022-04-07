namespace Board_Game
{
    partial class UserForm
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
            this.rexitButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.emailTextbox = new System.Windows.Forms.TextBox();
            this.countryTextbox = new System.Windows.Forms.TextBox();
            this.cityTextbox = new System.Windows.Forms.TextBox();
            this.addressTextbox = new System.Windows.Forms.TextBox();
            this.phoneNumberTextbox = new System.Windows.Forms.TextBox();
            this.nameSurnameTextbox = new System.Windows.Forms.TextBox();
            this.passwordTextbox = new System.Windows.Forms.TextBox();
            this.usernameTextbox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.countryLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.phoneNumberLabel = new System.Windows.Forms.Label();
            this.nameSurnameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.confirmPasswordTextbox = new System.Windows.Forms.TextBox();
            this.confirmPasswordLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rexitButton
            // 
            this.rexitButton.Location = new System.Drawing.Point(458, 457);
            this.rexitButton.Name = "rexitButton";
            this.rexitButton.Size = new System.Drawing.Size(75, 23);
            this.rexitButton.TabIndex = 35;
            this.rexitButton.Text = "Exit";
            this.rexitButton.UseVisualStyleBackColor = true;
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(325, 457);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 34;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // emailTextbox
            // 
            this.emailTextbox.Location = new System.Drawing.Point(449, 356);
            this.emailTextbox.Name = "emailTextbox";
            this.emailTextbox.Size = new System.Drawing.Size(100, 22);
            this.emailTextbox.TabIndex = 33;
            // 
            // countryTextbox
            // 
            this.countryTextbox.Location = new System.Drawing.Point(449, 316);
            this.countryTextbox.Name = "countryTextbox";
            this.countryTextbox.Size = new System.Drawing.Size(100, 22);
            this.countryTextbox.TabIndex = 32;
            // 
            // cityTextbox
            // 
            this.cityTextbox.Location = new System.Drawing.Point(449, 276);
            this.cityTextbox.Name = "cityTextbox";
            this.cityTextbox.Size = new System.Drawing.Size(100, 22);
            this.cityTextbox.TabIndex = 31;
            // 
            // addressTextbox
            // 
            this.addressTextbox.Location = new System.Drawing.Point(449, 236);
            this.addressTextbox.Name = "addressTextbox";
            this.addressTextbox.Size = new System.Drawing.Size(100, 22);
            this.addressTextbox.TabIndex = 30;
            // 
            // phoneNumberTextbox
            // 
            this.phoneNumberTextbox.Location = new System.Drawing.Point(449, 196);
            this.phoneNumberTextbox.Name = "phoneNumberTextbox";
            this.phoneNumberTextbox.Size = new System.Drawing.Size(100, 22);
            this.phoneNumberTextbox.TabIndex = 29;
            // 
            // nameSurnameTextbox
            // 
            this.nameSurnameTextbox.Location = new System.Drawing.Point(449, 156);
            this.nameSurnameTextbox.Name = "nameSurnameTextbox";
            this.nameSurnameTextbox.Size = new System.Drawing.Size(100, 22);
            this.nameSurnameTextbox.TabIndex = 28;
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.Location = new System.Drawing.Point(449, 116);
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.PasswordChar = '*';
            this.passwordTextbox.Size = new System.Drawing.Size(100, 22);
            this.passwordTextbox.TabIndex = 27;
            // 
            // usernameTextbox
            // 
            this.usernameTextbox.Enabled = false;
            this.usernameTextbox.Location = new System.Drawing.Point(449, 76);
            this.usernameTextbox.Name = "usernameTextbox";
            this.usernameTextbox.Size = new System.Drawing.Size(100, 22);
            this.usernameTextbox.TabIndex = 26;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(322, 356);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(45, 16);
            this.emailLabel.TabIndex = 25;
            this.emailLabel.Text = "E-mail";
            // 
            // countryLabel
            // 
            this.countryLabel.AutoSize = true;
            this.countryLabel.Location = new System.Drawing.Point(322, 316);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(52, 16);
            this.countryLabel.TabIndex = 24;
            this.countryLabel.Text = "Country";
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(322, 276);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(29, 16);
            this.cityLabel.TabIndex = 23;
            this.cityLabel.Text = "City";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(322, 236);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(58, 16);
            this.addressLabel.TabIndex = 22;
            this.addressLabel.Text = "Address";
            // 
            // phoneNumberLabel
            // 
            this.phoneNumberLabel.AutoSize = true;
            this.phoneNumberLabel.Location = new System.Drawing.Point(322, 196);
            this.phoneNumberLabel.Name = "phoneNumberLabel";
            this.phoneNumberLabel.Size = new System.Drawing.Size(97, 16);
            this.phoneNumberLabel.TabIndex = 21;
            this.phoneNumberLabel.Text = "Phone Number";
            // 
            // nameSurnameLabel
            // 
            this.nameSurnameLabel.AutoSize = true;
            this.nameSurnameLabel.Location = new System.Drawing.Point(322, 156);
            this.nameSurnameLabel.Name = "nameSurnameLabel";
            this.nameSurnameLabel.Size = new System.Drawing.Size(102, 16);
            this.nameSurnameLabel.TabIndex = 20;
            this.nameSurnameLabel.Text = "Name-Surname";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(322, 116);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(67, 16);
            this.passwordLabel.TabIndex = 19;
            this.passwordLabel.Text = "Password";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(322, 76);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(70, 16);
            this.usernameLabel.TabIndex = 18;
            this.usernameLabel.Text = "Username";
            // 
            // confirmPasswordTextbox
            // 
            this.confirmPasswordTextbox.Location = new System.Drawing.Point(449, 420);
            this.confirmPasswordTextbox.Name = "confirmPasswordTextbox";
            this.confirmPasswordTextbox.Size = new System.Drawing.Size(100, 22);
            this.confirmPasswordTextbox.TabIndex = 37;
            // 
            // confirmPasswordLabel
            // 
            this.confirmPasswordLabel.AutoSize = true;
            this.confirmPasswordLabel.Location = new System.Drawing.Point(322, 423);
            this.confirmPasswordLabel.Name = "confirmPasswordLabel";
            this.confirmPasswordLabel.Size = new System.Drawing.Size(67, 16);
            this.confirmPasswordLabel.TabIndex = 36;
            this.confirmPasswordLabel.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(331, 401);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 16);
            this.label1.TabIndex = 38;
            this.label1.Text = "Enter password to save changes";
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 528);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.confirmPasswordTextbox);
            this.Controls.Add(this.confirmPasswordLabel);
            this.Controls.Add(this.rexitButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.emailTextbox);
            this.Controls.Add(this.countryTextbox);
            this.Controls.Add(this.cityTextbox);
            this.Controls.Add(this.addressTextbox);
            this.Controls.Add(this.phoneNumberTextbox);
            this.Controls.Add(this.nameSurnameTextbox);
            this.Controls.Add(this.passwordTextbox);
            this.Controls.Add(this.usernameTextbox);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.countryLabel);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.phoneNumberLabel);
            this.Controls.Add(this.nameSurnameLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserForm";
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button rexitButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.TextBox emailTextbox;
        private System.Windows.Forms.TextBox countryTextbox;
        private System.Windows.Forms.TextBox cityTextbox;
        private System.Windows.Forms.TextBox addressTextbox;
        private System.Windows.Forms.TextBox phoneNumberTextbox;
        private System.Windows.Forms.TextBox nameSurnameTextbox;
        private System.Windows.Forms.TextBox passwordTextbox;
        private System.Windows.Forms.TextBox usernameTextbox;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label phoneNumberLabel;
        private System.Windows.Forms.Label nameSurnameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox confirmPasswordTextbox;
        private System.Windows.Forms.Label confirmPasswordLabel;
        private System.Windows.Forms.Label label1;
    }
}