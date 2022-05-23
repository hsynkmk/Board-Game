
namespace Board_Game
{
    partial class RegisterForm
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
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.nameSurnameLabel = new System.Windows.Forms.Label();
            this.phoneNumberLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.countryLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.usernameTextbox = new System.Windows.Forms.TextBox();
            this.passwordTextbox = new System.Windows.Forms.TextBox();
            this.nameSurnameTextbox = new System.Windows.Forms.TextBox();
            this.phoneNumberTextbox = new System.Windows.Forms.TextBox();
            this.addressTextbox = new System.Windows.Forms.TextBox();
            this.cityTextbox = new System.Windows.Forms.TextBox();
            this.countryTextbox = new System.Windows.Forms.TextBox();
            this.emailTextbox = new System.Windows.Forms.TextBox();
            this.rsaveButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.registerLabel = new System.Windows.Forms.Label();
            this.invalidUsernameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(47, 87);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(75, 16);
            this.usernameLabel.TabIndex = 0;
            this.usernameLabel.Text = "*Username";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(47, 127);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(72, 16);
            this.passwordLabel.TabIndex = 1;
            this.passwordLabel.Text = "*Password";
            // 
            // nameSurnameLabel
            // 
            this.nameSurnameLabel.AutoSize = true;
            this.nameSurnameLabel.Location = new System.Drawing.Point(47, 167);
            this.nameSurnameLabel.Name = "nameSurnameLabel";
            this.nameSurnameLabel.Size = new System.Drawing.Size(102, 16);
            this.nameSurnameLabel.TabIndex = 2;
            this.nameSurnameLabel.Text = "Name-Surname";
            // 
            // phoneNumberLabel
            // 
            this.phoneNumberLabel.AutoSize = true;
            this.phoneNumberLabel.Location = new System.Drawing.Point(47, 207);
            this.phoneNumberLabel.Name = "phoneNumberLabel";
            this.phoneNumberLabel.Size = new System.Drawing.Size(97, 16);
            this.phoneNumberLabel.TabIndex = 3;
            this.phoneNumberLabel.Text = "Phone Number";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(47, 247);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(58, 16);
            this.addressLabel.TabIndex = 4;
            this.addressLabel.Text = "Address";
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(47, 287);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(29, 16);
            this.cityLabel.TabIndex = 5;
            this.cityLabel.Text = "City";
            // 
            // countryLabel
            // 
            this.countryLabel.AutoSize = true;
            this.countryLabel.Location = new System.Drawing.Point(47, 327);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(52, 16);
            this.countryLabel.TabIndex = 6;
            this.countryLabel.Text = "Country";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(47, 367);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(45, 16);
            this.emailLabel.TabIndex = 7;
            this.emailLabel.Text = "E-mail";
            // 
            // usernameTextbox
            // 
            this.usernameTextbox.Location = new System.Drawing.Point(174, 87);
            this.usernameTextbox.Name = "usernameTextbox";
            this.usernameTextbox.Size = new System.Drawing.Size(100, 22);
            this.usernameTextbox.TabIndex = 8;
            this.usernameTextbox.TextChanged += new System.EventHandler(this.usernameTextbox_TextChanged);
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.Location = new System.Drawing.Point(174, 127);
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.PasswordChar = '*';
            this.passwordTextbox.Size = new System.Drawing.Size(100, 22);
            this.passwordTextbox.TabIndex = 9;
            // 
            // nameSurnameTextbox
            // 
            this.nameSurnameTextbox.Location = new System.Drawing.Point(174, 167);
            this.nameSurnameTextbox.Name = "nameSurnameTextbox";
            this.nameSurnameTextbox.Size = new System.Drawing.Size(100, 22);
            this.nameSurnameTextbox.TabIndex = 10;
            // 
            // phoneNumberTextbox
            // 
            this.phoneNumberTextbox.Location = new System.Drawing.Point(174, 207);
            this.phoneNumberTextbox.Name = "phoneNumberTextbox";
            this.phoneNumberTextbox.Size = new System.Drawing.Size(100, 22);
            this.phoneNumberTextbox.TabIndex = 11;
            // 
            // addressTextbox
            // 
            this.addressTextbox.Location = new System.Drawing.Point(174, 247);
            this.addressTextbox.Name = "addressTextbox";
            this.addressTextbox.Size = new System.Drawing.Size(100, 22);
            this.addressTextbox.TabIndex = 12;
            // 
            // cityTextbox
            // 
            this.cityTextbox.Location = new System.Drawing.Point(174, 287);
            this.cityTextbox.Name = "cityTextbox";
            this.cityTextbox.Size = new System.Drawing.Size(100, 22);
            this.cityTextbox.TabIndex = 13;
            // 
            // countryTextbox
            // 
            this.countryTextbox.Location = new System.Drawing.Point(174, 327);
            this.countryTextbox.Name = "countryTextbox";
            this.countryTextbox.Size = new System.Drawing.Size(100, 22);
            this.countryTextbox.TabIndex = 14;
            // 
            // emailTextbox
            // 
            this.emailTextbox.Location = new System.Drawing.Point(174, 367);
            this.emailTextbox.Name = "emailTextbox";
            this.emailTextbox.Size = new System.Drawing.Size(100, 22);
            this.emailTextbox.TabIndex = 15;
            // 
            // rsaveButton
            // 
            this.rsaveButton.Location = new System.Drawing.Point(199, 438);
            this.rsaveButton.Name = "rsaveButton";
            this.rsaveButton.Size = new System.Drawing.Size(75, 23);
            this.rsaveButton.TabIndex = 16;
            this.rsaveButton.Text = "Register";
            this.rsaveButton.UseVisualStyleBackColor = true;
            this.rsaveButton.Click += new System.EventHandler(this.rsaveButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(50, 438);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 17;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.rexitButton_Click);
            // 
            // registerLabel
            // 
            this.registerLabel.AutoSize = true;
            this.registerLabel.Font = new System.Drawing.Font("Segoe Print", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.registerLabel.Location = new System.Drawing.Point(92, 9);
            this.registerLabel.Name = "registerLabel";
            this.registerLabel.Size = new System.Drawing.Size(135, 50);
            this.registerLabel.TabIndex = 19;
            this.registerLabel.Text = "Register";
            // 
            // invalidUsernameLabel
            // 
            this.invalidUsernameLabel.AutoSize = true;
            this.invalidUsernameLabel.ForeColor = System.Drawing.Color.Red;
            this.invalidUsernameLabel.Location = new System.Drawing.Point(88, 407);
            this.invalidUsernameLabel.Name = "invalidUsernameLabel";
            this.invalidUsernameLabel.Size = new System.Drawing.Size(149, 16);
            this.invalidUsernameLabel.TabIndex = 20;
            this.invalidUsernameLabel.Text = "Username already exist";
            this.invalidUsernameLabel.Visible = false;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(330, 525);
            this.ControlBox = false;
            this.Controls.Add(this.invalidUsernameLabel);
            this.Controls.Add(this.registerLabel);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.rsaveButton);
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
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label nameSurnameLabel;
        private System.Windows.Forms.Label phoneNumberLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox usernameTextbox;
        private System.Windows.Forms.TextBox passwordTextbox;
        private System.Windows.Forms.TextBox nameSurnameTextbox;
        private System.Windows.Forms.TextBox phoneNumberTextbox;
        private System.Windows.Forms.TextBox addressTextbox;
        private System.Windows.Forms.TextBox cityTextbox;
        private System.Windows.Forms.TextBox countryTextbox;
        private System.Windows.Forms.TextBox emailTextbox;
        private System.Windows.Forms.Button rsaveButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label registerLabel;
        private System.Windows.Forms.Label invalidUsernameLabel;
    }
}