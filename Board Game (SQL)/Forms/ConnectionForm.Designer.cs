namespace Board_Game__SQL_
{
    partial class ConnectionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConnectionForm));
            this.IPLabel = new System.Windows.Forms.Label();
            this.PortLabel = new System.Windows.Forms.Label();
            this.IPTextBox = new System.Windows.Forms.TextBox();
            this.PortTextBox = new System.Windows.Forms.TextBox();
            this.ConnectToServerButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.YourPortTextBox = new System.Windows.Forms.TextBox();
            this.YourIPTextBox = new System.Windows.Forms.TextBox();
            this.StartServerButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.ORLabel = new System.Windows.Forms.Label();
            this.ConnectionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // IPLabel
            // 
            this.IPLabel.AutoSize = true;
            this.IPLabel.Location = new System.Drawing.Point(125, 256);
            this.IPLabel.Name = "IPLabel";
            this.IPLabel.Size = new System.Drawing.Size(19, 16);
            this.IPLabel.TabIndex = 0;
            this.IPLabel.Text = "IP";
            // 
            // PortLabel
            // 
            this.PortLabel.AutoSize = true;
            this.PortLabel.Location = new System.Drawing.Point(125, 305);
            this.PortLabel.Name = "PortLabel";
            this.PortLabel.Size = new System.Drawing.Size(31, 16);
            this.PortLabel.TabIndex = 1;
            this.PortLabel.Text = "Port";
            // 
            // IPTextBox
            // 
            this.IPTextBox.Location = new System.Drawing.Point(183, 256);
            this.IPTextBox.Name = "IPTextBox";
            this.IPTextBox.Size = new System.Drawing.Size(179, 22);
            this.IPTextBox.TabIndex = 2;
            // 
            // PortTextBox
            // 
            this.PortTextBox.Location = new System.Drawing.Point(183, 305);
            this.PortTextBox.Name = "PortTextBox";
            this.PortTextBox.Size = new System.Drawing.Size(179, 22);
            this.PortTextBox.TabIndex = 3;
            // 
            // ConnectToServerButton
            // 
            this.ConnectToServerButton.Location = new System.Drawing.Point(198, 355);
            this.ConnectToServerButton.Name = "ConnectToServerButton";
            this.ConnectToServerButton.Size = new System.Drawing.Size(149, 23);
            this.ConnectToServerButton.TabIndex = 4;
            this.ConnectToServerButton.Text = "Connect To a Server";
            this.ConnectToServerButton.UseVisualStyleBackColor = true;
            this.ConnectToServerButton.Click += new System.EventHandler(this.ConnectToServerButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(484, 414);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // YourPortTextBox
            // 
            this.YourPortTextBox.Location = new System.Drawing.Point(183, 120);
            this.YourPortTextBox.Name = "YourPortTextBox";
            this.YourPortTextBox.Size = new System.Drawing.Size(179, 22);
            this.YourPortTextBox.TabIndex = 7;
            this.YourPortTextBox.TextChanged += new System.EventHandler(this.YourPortTextBox_TextChanged);
            // 
            // YourIPTextBox
            // 
            this.YourIPTextBox.Location = new System.Drawing.Point(183, 71);
            this.YourIPTextBox.Name = "YourIPTextBox";
            this.YourIPTextBox.ReadOnly = true;
            this.YourIPTextBox.Size = new System.Drawing.Size(179, 22);
            this.YourIPTextBox.TabIndex = 6;
            // 
            // StartServerButton
            // 
            this.StartServerButton.Location = new System.Drawing.Point(222, 148);
            this.StartServerButton.Name = "StartServerButton";
            this.StartServerButton.Size = new System.Drawing.Size(107, 23);
            this.StartServerButton.TabIndex = 8;
            this.StartServerButton.Text = "Start Server";
            this.StartServerButton.UseVisualStyleBackColor = true;
            this.StartServerButton.Click += new System.EventHandler(this.StartServerButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Port";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(117, 74);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(50, 16);
            this.label.TabIndex = 9;
            this.label.Text = "Your IP";
            // 
            // ORLabel
            // 
            this.ORLabel.AutoSize = true;
            this.ORLabel.Location = new System.Drawing.Point(263, 215);
            this.ORLabel.Name = "ORLabel";
            this.ORLabel.Size = new System.Drawing.Size(27, 16);
            this.ORLabel.TabIndex = 11;
            this.ORLabel.Text = "OR";
            // 
            // ConnectionLabel
            // 
            this.ConnectionLabel.AutoSize = true;
            this.ConnectionLabel.ForeColor = System.Drawing.Color.Red;
            this.ConnectionLabel.Location = new System.Drawing.Point(209, 174);
            this.ConnectionLabel.Name = "ConnectionLabel";
            this.ConnectionLabel.Size = new System.Drawing.Size(138, 16);
            this.ConnectionLabel.TabIndex = 12;
            this.ConnectionLabel.Text = "Waiting for connection";
            this.ConnectionLabel.Visible = false;
            // 
            // ConnectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 449);
            this.Controls.Add(this.ConnectionLabel);
            this.Controls.Add(this.ORLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label);
            this.Controls.Add(this.StartServerButton);
            this.Controls.Add(this.YourPortTextBox);
            this.Controls.Add(this.YourIPTextBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.ConnectToServerButton);
            this.Controls.Add(this.PortTextBox);
            this.Controls.Add(this.IPTextBox);
            this.Controls.Add(this.PortLabel);
            this.Controls.Add(this.IPLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConnectionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IPLabel;
        private System.Windows.Forms.Label PortLabel;
        private System.Windows.Forms.TextBox IPTextBox;
        private System.Windows.Forms.TextBox PortTextBox;
        private System.Windows.Forms.Button ConnectToServerButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TextBox YourPortTextBox;
        private System.Windows.Forms.TextBox YourIPTextBox;
        private System.Windows.Forms.Button StartServerButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label ORLabel;
        private System.Windows.Forms.Label ConnectionLabel;
    }
}