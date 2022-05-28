namespace Board_Game__SQL_
{
    partial class AdminForm
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
            this.BackButton = new System.Windows.Forms.Button();
            this.infoGroupBox = new System.Windows.Forms.GroupBox();
            this.invalidUsernameLabel = new System.Windows.Forms.Label();
            this.completedLabel = new System.Windows.Forms.Label();
            this.UsernameTextbox = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.nameSurnameLabel = new System.Windows.Forms.Label();
            this.phoneNumberLabel = new System.Windows.Forms.Label();
            this.EmailTextbox = new System.Windows.Forms.TextBox();
            this.addressLabel = new System.Windows.Forms.Label();
            this.CountryTextbox = new System.Windows.Forms.TextBox();
            this.cityLabel = new System.Windows.Forms.Label();
            this.CityTextbox = new System.Windows.Forms.TextBox();
            this.countryLabel = new System.Windows.Forms.Label();
            this.AddressTextbox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.PhoneNumberTextbox = new System.Windows.Forms.TextBox();
            this.PasswordTextbox = new System.Windows.Forms.TextBox();
            this.NameSurnameTextbox = new System.Windows.Forms.TextBox();
            this.UserDataGridView = new System.Windows.Forms.DataGridView();
            this.CommandComboBox = new System.Windows.Forms.ComboBox();
            this.infoGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(900, 540);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(94, 29);
            this.BackButton.TabIndex = 48;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // infoGroupBox
            // 
            this.infoGroupBox.Controls.Add(this.invalidUsernameLabel);
            this.infoGroupBox.Controls.Add(this.completedLabel);
            this.infoGroupBox.Controls.Add(this.UsernameTextbox);
            this.infoGroupBox.Controls.Add(this.usernameLabel);
            this.infoGroupBox.Controls.Add(this.SubmitButton);
            this.infoGroupBox.Controls.Add(this.passwordLabel);
            this.infoGroupBox.Controls.Add(this.nameSurnameLabel);
            this.infoGroupBox.Controls.Add(this.phoneNumberLabel);
            this.infoGroupBox.Controls.Add(this.EmailTextbox);
            this.infoGroupBox.Controls.Add(this.addressLabel);
            this.infoGroupBox.Controls.Add(this.CountryTextbox);
            this.infoGroupBox.Controls.Add(this.cityLabel);
            this.infoGroupBox.Controls.Add(this.CityTextbox);
            this.infoGroupBox.Controls.Add(this.countryLabel);
            this.infoGroupBox.Controls.Add(this.AddressTextbox);
            this.infoGroupBox.Controls.Add(this.emailLabel);
            this.infoGroupBox.Controls.Add(this.PhoneNumberTextbox);
            this.infoGroupBox.Controls.Add(this.PasswordTextbox);
            this.infoGroupBox.Controls.Add(this.NameSurnameTextbox);
            this.infoGroupBox.Location = new System.Drawing.Point(300, 319);
            this.infoGroupBox.Name = "infoGroupBox";
            this.infoGroupBox.Size = new System.Drawing.Size(580, 269);
            this.infoGroupBox.TabIndex = 49;
            this.infoGroupBox.TabStop = false;
            this.infoGroupBox.Text = "Info";
            // 
            // invalidUsernameLabel
            // 
            this.invalidUsernameLabel.AutoSize = true;
            this.invalidUsernameLabel.ForeColor = System.Drawing.Color.Maroon;
            this.invalidUsernameLabel.Location = new System.Drawing.Point(384, 183);
            this.invalidUsernameLabel.Name = "invalidUsernameLabel";
            this.invalidUsernameLabel.Size = new System.Drawing.Size(115, 16);
            this.invalidUsernameLabel.TabIndex = 47;
            this.invalidUsernameLabel.Text = "User already exist";
            this.invalidUsernameLabel.Visible = false;
            // 
            // completedLabel
            // 
            this.completedLabel.AutoSize = true;
            this.completedLabel.ForeColor = System.Drawing.Color.Maroon;
            this.completedLabel.Location = new System.Drawing.Point(406, 203);
            this.completedLabel.Name = "completedLabel";
            this.completedLabel.Size = new System.Drawing.Size(73, 16);
            this.completedLabel.TabIndex = 46;
            this.completedLabel.Text = "Completed";
            this.completedLabel.Visible = false;
            // 
            // UsernameTextbox
            // 
            this.UsernameTextbox.Location = new System.Drawing.Point(141, 43);
            this.UsernameTextbox.Name = "UsernameTextbox";
            this.UsernameTextbox.Size = new System.Drawing.Size(100, 22);
            this.UsernameTextbox.TabIndex = 30;
            this.UsernameTextbox.TextChanged += new System.EventHandler(this.UsernameTextbox_TextChanged);
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(14, 43);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(70, 16);
            this.usernameLabel.TabIndex = 22;
            this.usernameLabel.Text = "Username";
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(399, 142);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(100, 23);
            this.SubmitButton.TabIndex = 45;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(14, 83);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(67, 16);
            this.passwordLabel.TabIndex = 23;
            this.passwordLabel.Text = "Password";
            // 
            // nameSurnameLabel
            // 
            this.nameSurnameLabel.AutoSize = true;
            this.nameSurnameLabel.Location = new System.Drawing.Point(14, 123);
            this.nameSurnameLabel.Name = "nameSurnameLabel";
            this.nameSurnameLabel.Size = new System.Drawing.Size(102, 16);
            this.nameSurnameLabel.TabIndex = 24;
            this.nameSurnameLabel.Text = "Name-Surname";
            // 
            // phoneNumberLabel
            // 
            this.phoneNumberLabel.AutoSize = true;
            this.phoneNumberLabel.Location = new System.Drawing.Point(14, 163);
            this.phoneNumberLabel.Name = "phoneNumberLabel";
            this.phoneNumberLabel.Size = new System.Drawing.Size(97, 16);
            this.phoneNumberLabel.TabIndex = 25;
            this.phoneNumberLabel.Text = "Phone Number";
            // 
            // EmailTextbox
            // 
            this.EmailTextbox.Location = new System.Drawing.Point(399, 83);
            this.EmailTextbox.Name = "EmailTextbox";
            this.EmailTextbox.Size = new System.Drawing.Size(100, 22);
            this.EmailTextbox.TabIndex = 37;
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(14, 203);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(58, 16);
            this.addressLabel.TabIndex = 26;
            this.addressLabel.Text = "Address";
            // 
            // CountryTextbox
            // 
            this.CountryTextbox.Location = new System.Drawing.Point(399, 43);
            this.CountryTextbox.Name = "CountryTextbox";
            this.CountryTextbox.Size = new System.Drawing.Size(100, 22);
            this.CountryTextbox.TabIndex = 36;
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(14, 243);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(29, 16);
            this.cityLabel.TabIndex = 27;
            this.cityLabel.Text = "City";
            // 
            // CityTextbox
            // 
            this.CityTextbox.Location = new System.Drawing.Point(141, 243);
            this.CityTextbox.Name = "CityTextbox";
            this.CityTextbox.Size = new System.Drawing.Size(100, 22);
            this.CityTextbox.TabIndex = 35;
            // 
            // countryLabel
            // 
            this.countryLabel.AutoSize = true;
            this.countryLabel.Location = new System.Drawing.Point(272, 43);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(52, 16);
            this.countryLabel.TabIndex = 28;
            this.countryLabel.Text = "Country";
            // 
            // AddressTextbox
            // 
            this.AddressTextbox.Location = new System.Drawing.Point(141, 203);
            this.AddressTextbox.Name = "AddressTextbox";
            this.AddressTextbox.Size = new System.Drawing.Size(100, 22);
            this.AddressTextbox.TabIndex = 34;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(272, 83);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(45, 16);
            this.emailLabel.TabIndex = 29;
            this.emailLabel.Text = "E-mail";
            // 
            // PhoneNumberTextbox
            // 
            this.PhoneNumberTextbox.Location = new System.Drawing.Point(141, 163);
            this.PhoneNumberTextbox.Name = "PhoneNumberTextbox";
            this.PhoneNumberTextbox.Size = new System.Drawing.Size(100, 22);
            this.PhoneNumberTextbox.TabIndex = 33;
            // 
            // PasswordTextbox
            // 
            this.PasswordTextbox.Location = new System.Drawing.Point(141, 83);
            this.PasswordTextbox.Name = "PasswordTextbox";
            this.PasswordTextbox.Size = new System.Drawing.Size(100, 22);
            this.PasswordTextbox.TabIndex = 31;
            // 
            // NameSurnameTextbox
            // 
            this.NameSurnameTextbox.Location = new System.Drawing.Point(141, 123);
            this.NameSurnameTextbox.Name = "NameSurnameTextbox";
            this.NameSurnameTextbox.Size = new System.Drawing.Size(100, 22);
            this.NameSurnameTextbox.TabIndex = 32;
            // 
            // UserDataGridView
            // 
            this.UserDataGridView.AllowUserToAddRows = false;
            this.UserDataGridView.AllowUserToDeleteRows = false;
            this.UserDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserDataGridView.Location = new System.Drawing.Point(3, 31);
            this.UserDataGridView.Name = "UserDataGridView";
            this.UserDataGridView.ReadOnly = true;
            this.UserDataGridView.RowHeadersWidth = 51;
            this.UserDataGridView.RowTemplate.Height = 24;
            this.UserDataGridView.Size = new System.Drawing.Size(991, 208);
            this.UserDataGridView.TabIndex = 50;
            this.UserDataGridView.SelectionChanged += new System.EventHandler(this.UserDataGridView_SelectionChanged);
            // 
            // CommandComboBox
            // 
            this.CommandComboBox.FormattingEnabled = true;
            this.CommandComboBox.Items.AddRange(new object[] {
            "ADD",
            "UPDATE",
            "DELETE"});
            this.CommandComboBox.Location = new System.Drawing.Point(100, 319);
            this.CommandComboBox.Name = "CommandComboBox";
            this.CommandComboBox.Size = new System.Drawing.Size(135, 24);
            this.CommandComboBox.TabIndex = 52;
            this.CommandComboBox.Text = "Select A Comand";
            this.CommandComboBox.SelectedIndexChanged += new System.EventHandler(this.CommandComboBox_SelectedIndexChanged);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.CommandComboBox);
            this.Controls.Add(this.UserDataGridView);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.infoGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminForm";
            this.infoGroupBox.ResumeLayout(false);
            this.infoGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.GroupBox infoGroupBox;
        private System.Windows.Forms.Label invalidUsernameLabel;
        private System.Windows.Forms.Label completedLabel;
        private System.Windows.Forms.TextBox UsernameTextbox;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label nameSurnameLabel;
        private System.Windows.Forms.Label phoneNumberLabel;
        private System.Windows.Forms.TextBox EmailTextbox;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.TextBox CountryTextbox;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.TextBox CityTextbox;
        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.TextBox AddressTextbox;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox PhoneNumberTextbox;
        private System.Windows.Forms.TextBox PasswordTextbox;
        private System.Windows.Forms.TextBox NameSurnameTextbox;
        private System.Windows.Forms.DataGridView UserDataGridView;
        private System.Windows.Forms.ComboBox CommandComboBox;
    }
}