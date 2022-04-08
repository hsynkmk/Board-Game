namespace Board_Game
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
            this.adminDataGridView = new System.Windows.Forms.DataGridView();
            this.listUsersButton = new System.Windows.Forms.Button();
            this.userDataGridView = new System.Windows.Forms.DataGridView();
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
            this.deleteUserButton = new System.Windows.Forms.Button();
            this.updateUserButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.adminLabel = new System.Windows.Forms.Label();
            this.userLabel = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.actionsGroupBox = new System.Windows.Forms.GroupBox();
            this.infoGroupBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.adminDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDataGridView)).BeginInit();
            this.actionsGroupBox.SuspendLayout();
            this.infoGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // adminDataGridView
            // 
            this.adminDataGridView.AllowUserToAddRows = false;
            this.adminDataGridView.AllowUserToDeleteRows = false;
            this.adminDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adminDataGridView.Location = new System.Drawing.Point(12, 39);
            this.adminDataGridView.MultiSelect = false;
            this.adminDataGridView.Name = "adminDataGridView";
            this.adminDataGridView.ReadOnly = true;
            this.adminDataGridView.RowHeadersWidth = 51;
            this.adminDataGridView.RowTemplate.Height = 24;
            this.adminDataGridView.Size = new System.Drawing.Size(976, 124);
            this.adminDataGridView.TabIndex = 19;
            this.adminDataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.adminDataGridView_RowHeaderMouseClick);
            // 
            // listUsersButton
            // 
            this.listUsersButton.Location = new System.Drawing.Point(14, 27);
            this.listUsersButton.Name = "listUsersButton";
            this.listUsersButton.Size = new System.Drawing.Size(120, 23);
            this.listUsersButton.TabIndex = 20;
            this.listUsersButton.Text = "List All Users";
            this.listUsersButton.UseVisualStyleBackColor = true;
            this.listUsersButton.Click += new System.EventHandler(this.listUsersButton_Click);
            // 
            // userDataGridView
            // 
            this.userDataGridView.AllowUserToAddRows = false;
            this.userDataGridView.AllowUserToDeleteRows = false;
            this.userDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userDataGridView.Location = new System.Drawing.Point(12, 188);
            this.userDataGridView.MultiSelect = false;
            this.userDataGridView.Name = "userDataGridView";
            this.userDataGridView.ReadOnly = true;
            this.userDataGridView.RowHeadersWidth = 51;
            this.userDataGridView.RowTemplate.Height = 24;
            this.userDataGridView.Size = new System.Drawing.Size(976, 133);
            this.userDataGridView.TabIndex = 21;
            this.userDataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.userDataGridView_RowHeaderMouseClick);
            // 
            // emailTextbox
            // 
            this.emailTextbox.Location = new System.Drawing.Point(399, 83);
            this.emailTextbox.Name = "emailTextbox";
            this.emailTextbox.Size = new System.Drawing.Size(100, 22);
            this.emailTextbox.TabIndex = 37;
            // 
            // countryTextbox
            // 
            this.countryTextbox.Location = new System.Drawing.Point(399, 43);
            this.countryTextbox.Name = "countryTextbox";
            this.countryTextbox.Size = new System.Drawing.Size(100, 22);
            this.countryTextbox.TabIndex = 36;
            // 
            // cityTextbox
            // 
            this.cityTextbox.Location = new System.Drawing.Point(141, 243);
            this.cityTextbox.Name = "cityTextbox";
            this.cityTextbox.Size = new System.Drawing.Size(100, 22);
            this.cityTextbox.TabIndex = 35;
            // 
            // addressTextbox
            // 
            this.addressTextbox.Location = new System.Drawing.Point(141, 203);
            this.addressTextbox.Name = "addressTextbox";
            this.addressTextbox.Size = new System.Drawing.Size(100, 22);
            this.addressTextbox.TabIndex = 34;
            // 
            // phoneNumberTextbox
            // 
            this.phoneNumberTextbox.Location = new System.Drawing.Point(141, 163);
            this.phoneNumberTextbox.Name = "phoneNumberTextbox";
            this.phoneNumberTextbox.Size = new System.Drawing.Size(100, 22);
            this.phoneNumberTextbox.TabIndex = 33;
            // 
            // nameSurnameTextbox
            // 
            this.nameSurnameTextbox.Location = new System.Drawing.Point(141, 123);
            this.nameSurnameTextbox.Name = "nameSurnameTextbox";
            this.nameSurnameTextbox.Size = new System.Drawing.Size(100, 22);
            this.nameSurnameTextbox.TabIndex = 32;
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.Location = new System.Drawing.Point(141, 83);
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.PasswordChar = '*';
            this.passwordTextbox.Size = new System.Drawing.Size(100, 22);
            this.passwordTextbox.TabIndex = 31;
            // 
            // usernameTextbox
            // 
            this.usernameTextbox.Location = new System.Drawing.Point(141, 43);
            this.usernameTextbox.Name = "usernameTextbox";
            this.usernameTextbox.Size = new System.Drawing.Size(100, 22);
            this.usernameTextbox.TabIndex = 30;
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
            // countryLabel
            // 
            this.countryLabel.AutoSize = true;
            this.countryLabel.Location = new System.Drawing.Point(272, 43);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(52, 16);
            this.countryLabel.TabIndex = 28;
            this.countryLabel.Text = "Country";
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
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(14, 203);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(58, 16);
            this.addressLabel.TabIndex = 26;
            this.addressLabel.Text = "Address";
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
            // nameSurnameLabel
            // 
            this.nameSurnameLabel.AutoSize = true;
            this.nameSurnameLabel.Location = new System.Drawing.Point(14, 123);
            this.nameSurnameLabel.Name = "nameSurnameLabel";
            this.nameSurnameLabel.Size = new System.Drawing.Size(102, 16);
            this.nameSurnameLabel.TabIndex = 24;
            this.nameSurnameLabel.Text = "Name-Surname";
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
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(14, 43);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(70, 16);
            this.usernameLabel.TabIndex = 22;
            this.usernameLabel.Text = "Username";
            // 
            // deleteUserButton
            // 
            this.deleteUserButton.Location = new System.Drawing.Point(14, 149);
            this.deleteUserButton.Name = "deleteUserButton";
            this.deleteUserButton.Size = new System.Drawing.Size(120, 23);
            this.deleteUserButton.TabIndex = 40;
            this.deleteUserButton.Text = "Delete";
            this.deleteUserButton.UseVisualStyleBackColor = true;
            this.deleteUserButton.Click += new System.EventHandler(this.deleteUserButton_Click);
            // 
            // updateUserButton
            // 
            this.updateUserButton.Location = new System.Drawing.Point(14, 108);
            this.updateUserButton.Name = "updateUserButton";
            this.updateUserButton.Size = new System.Drawing.Size(120, 23);
            this.updateUserButton.TabIndex = 41;
            this.updateUserButton.Text = "Update";
            this.updateUserButton.UseVisualStyleBackColor = true;
            this.updateUserButton.Click += new System.EventHandler(this.updateUserButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(14, 67);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(120, 23);
            this.addButton.TabIndex = 42;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // adminLabel
            // 
            this.adminLabel.AutoSize = true;
            this.adminLabel.Location = new System.Drawing.Point(9, 20);
            this.adminLabel.Name = "adminLabel";
            this.adminLabel.Size = new System.Drawing.Size(52, 16);
            this.adminLabel.TabIndex = 43;
            this.adminLabel.Text = "Admins";
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Location = new System.Drawing.Point(9, 169);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(43, 16);
            this.userLabel.TabIndex = 44;
            this.userLabel.Text = "Users";
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(399, 163);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(100, 23);
            this.submitButton.TabIndex = 45;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // actionsGroupBox
            // 
            this.actionsGroupBox.Controls.Add(this.listUsersButton);
            this.actionsGroupBox.Controls.Add(this.deleteUserButton);
            this.actionsGroupBox.Controls.Add(this.updateUserButton);
            this.actionsGroupBox.Controls.Add(this.addButton);
            this.actionsGroupBox.Location = new System.Drawing.Point(24, 361);
            this.actionsGroupBox.Name = "actionsGroupBox";
            this.actionsGroupBox.Size = new System.Drawing.Size(156, 191);
            this.actionsGroupBox.TabIndex = 46;
            this.actionsGroupBox.TabStop = false;
            this.actionsGroupBox.Text = "Actions";
            // 
            // infoGroupBox
            // 
            this.infoGroupBox.Controls.Add(this.usernameTextbox);
            this.infoGroupBox.Controls.Add(this.usernameLabel);
            this.infoGroupBox.Controls.Add(this.submitButton);
            this.infoGroupBox.Controls.Add(this.passwordLabel);
            this.infoGroupBox.Controls.Add(this.nameSurnameLabel);
            this.infoGroupBox.Controls.Add(this.phoneNumberLabel);
            this.infoGroupBox.Controls.Add(this.emailTextbox);
            this.infoGroupBox.Controls.Add(this.addressLabel);
            this.infoGroupBox.Controls.Add(this.countryTextbox);
            this.infoGroupBox.Controls.Add(this.cityLabel);
            this.infoGroupBox.Controls.Add(this.cityTextbox);
            this.infoGroupBox.Controls.Add(this.countryLabel);
            this.infoGroupBox.Controls.Add(this.addressTextbox);
            this.infoGroupBox.Controls.Add(this.emailLabel);
            this.infoGroupBox.Controls.Add(this.phoneNumberTextbox);
            this.infoGroupBox.Controls.Add(this.passwordTextbox);
            this.infoGroupBox.Controls.Add(this.nameSurnameTextbox);
            this.infoGroupBox.Location = new System.Drawing.Point(294, 327);
            this.infoGroupBox.Name = "infoGroupBox";
            this.infoGroupBox.Size = new System.Drawing.Size(580, 269);
            this.infoGroupBox.TabIndex = 47;
            this.infoGroupBox.TabStop = false;
            this.infoGroupBox.Text = "Info";
            this.infoGroupBox.Visible = false;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.infoGroupBox);
            this.Controls.Add(this.actionsGroupBox);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.adminLabel);
            this.Controls.Add(this.userDataGridView);
            this.Controls.Add(this.adminDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminForm";
            ((System.ComponentModel.ISupportInitialize)(this.adminDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDataGridView)).EndInit();
            this.actionsGroupBox.ResumeLayout(false);
            this.infoGroupBox.ResumeLayout(false);
            this.infoGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView adminDataGridView;
        private System.Windows.Forms.Button listUsersButton;
        private System.Windows.Forms.DataGridView userDataGridView;
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
        private System.Windows.Forms.Button deleteUserButton;
        private System.Windows.Forms.Button updateUserButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label adminLabel;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.GroupBox actionsGroupBox;
        private System.Windows.Forms.GroupBox infoGroupBox;
    }
}