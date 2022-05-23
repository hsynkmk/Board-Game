namespace Board_Game
{
    partial class AboutBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            this.backButton = new System.Windows.Forms.Button();
            this.headLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.releaseDateLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(443, 233);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 0;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // headLabel
            // 
            this.headLabel.AutoSize = true;
            this.headLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.headLabel.ForeColor = System.Drawing.Color.Red;
            this.headLabel.Location = new System.Drawing.Point(175, 11);
            this.headLabel.Name = "headLabel";
            this.headLabel.Size = new System.Drawing.Size(212, 38);
            this.headLabel.TabIndex = 1;
            this.headLabel.Text = "Board Game";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(135, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Developers";
            // 
            // releaseDateLabel
            // 
            this.releaseDateLabel.AutoSize = true;
            this.releaseDateLabel.ForeColor = System.Drawing.Color.DarkGreen;
            this.releaseDateLabel.Location = new System.Drawing.Point(135, 205);
            this.releaseDateLabel.Name = "releaseDateLabel";
            this.releaseDateLabel.Size = new System.Drawing.Size(91, 16);
            this.releaseDateLabel.TabIndex = 3;
            this.releaseDateLabel.Text = "Release Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(231, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Hüseyin Kaymak";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(231, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "14.04.2022";
            // 
            // AboutBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 306);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.releaseDateLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.headLabel);
            this.Controls.Add(this.backButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutBox";
            this.Padding = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About Us";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label headLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label releaseDateLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
    }
}
