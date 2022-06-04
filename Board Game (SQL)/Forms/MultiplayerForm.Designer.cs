namespace Board_Game__SQL_
{
    partial class MultiplayerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MultiplayerForm));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.ExitButton = new System.Windows.Forms.Button();
            this.YourTurnButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker1_DoWork);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker2_DoWork);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ExitButton.Location = new System.Drawing.Point(629, 12);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(60, 25);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // YourTurnButton
            // 
            this.YourTurnButton.BackColor = System.Drawing.Color.Green;
            this.YourTurnButton.Enabled = false;
            this.YourTurnButton.Font = new System.Drawing.Font("Comic Sans MS", 7.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.YourTurnButton.ForeColor = System.Drawing.Color.Navy;
            this.YourTurnButton.Location = new System.Drawing.Point(297, 1);
            this.YourTurnButton.Name = "YourTurnButton";
            this.YourTurnButton.Size = new System.Drawing.Size(86, 25);
            this.YourTurnButton.TabIndex = 3;
            this.YourTurnButton.Text = "Your Turn";
            this.YourTurnButton.UseVisualStyleBackColor = false;
            // 
            // MultiplayerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 501);
            this.Controls.Add(this.YourTurnButton);
            this.Controls.Add(this.ExitButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MultiplayerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MultiplayerForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button YourTurnButton;
    }
}