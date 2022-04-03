namespace Board_Game
{
    partial class SettingsForm
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
            this.settingsLabel = new System.Windows.Forms.Label();
            this.difficultyLabel = new System.Windows.Forms.Label();
            this.difficultyCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.shapeLabel = new System.Windows.Forms.Label();
            this.shapeCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.widthTextbox = new System.Windows.Forms.TextBox();
            this.heightTextbox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.settingsExitButton = new System.Windows.Forms.Button();
            this.colorCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.colorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // settingsLabel
            // 
            this.settingsLabel.AutoSize = true;
            this.settingsLabel.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.settingsLabel.Location = new System.Drawing.Point(335, 9);
            this.settingsLabel.Name = "settingsLabel";
            this.settingsLabel.Size = new System.Drawing.Size(135, 33);
            this.settingsLabel.TabIndex = 0;
            this.settingsLabel.Text = "Settings";
            // 
            // difficultyLabel
            // 
            this.difficultyLabel.AutoSize = true;
            this.difficultyLabel.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.difficultyLabel.Location = new System.Drawing.Point(108, 69);
            this.difficultyLabel.Name = "difficultyLabel";
            this.difficultyLabel.Size = new System.Drawing.Size(142, 27);
            this.difficultyLabel.TabIndex = 1;
            this.difficultyLabel.Text = "Difficulty";
            // 
            // difficultyCheckedListBox
            // 
            this.difficultyCheckedListBox.CheckOnClick = true;
            this.difficultyCheckedListBox.FormattingEnabled = true;
            this.difficultyCheckedListBox.Items.AddRange(new object[] {
            "Easy",
            "Normal",
            "Hard",
            "Custom"});
            this.difficultyCheckedListBox.Location = new System.Drawing.Point(113, 133);
            this.difficultyCheckedListBox.Name = "difficultyCheckedListBox";
            this.difficultyCheckedListBox.Size = new System.Drawing.Size(155, 89);
            this.difficultyCheckedListBox.TabIndex = 2;
            this.difficultyCheckedListBox.SelectedIndexChanged += new System.EventHandler(this.difficultyCheckedListBox_SelectedIndexChanged);
            // 
            // shapeLabel
            // 
            this.shapeLabel.AutoSize = true;
            this.shapeLabel.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.shapeLabel.Location = new System.Drawing.Point(393, 69);
            this.shapeLabel.Name = "shapeLabel";
            this.shapeLabel.Size = new System.Drawing.Size(77, 27);
            this.shapeLabel.TabIndex = 3;
            this.shapeLabel.Text = "Shape";
            // 
            // shapeCheckedListBox
            // 
            this.shapeCheckedListBox.CheckOnClick = true;
            this.shapeCheckedListBox.FormattingEnabled = true;
            this.shapeCheckedListBox.Items.AddRange(new object[] {
            "Square",
            "Triangle",
            "Round"});
            this.shapeCheckedListBox.Location = new System.Drawing.Point(370, 133);
            this.shapeCheckedListBox.Name = "shapeCheckedListBox";
            this.shapeCheckedListBox.Size = new System.Drawing.Size(150, 89);
            this.shapeCheckedListBox.TabIndex = 4;
            // 
            // widthTextbox
            // 
            this.widthTextbox.Location = new System.Drawing.Point(113, 228);
            this.widthTextbox.Name = "widthTextbox";
            this.widthTextbox.Size = new System.Drawing.Size(39, 22);
            this.widthTextbox.TabIndex = 5;
            this.widthTextbox.Visible = false;
            // 
            // heightTextbox
            // 
            this.heightTextbox.Location = new System.Drawing.Point(189, 228);
            this.heightTextbox.Name = "heightTextbox";
            this.heightTextbox.Size = new System.Drawing.Size(39, 22);
            this.heightTextbox.TabIndex = 6;
            this.heightTextbox.Visible = false;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(280, 337);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 7;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // settingsExitButton
            // 
            this.settingsExitButton.Location = new System.Drawing.Point(394, 337);
            this.settingsExitButton.Name = "settingsExitButton";
            this.settingsExitButton.Size = new System.Drawing.Size(75, 23);
            this.settingsExitButton.TabIndex = 8;
            this.settingsExitButton.Text = "Exit";
            this.settingsExitButton.UseVisualStyleBackColor = true;
            this.settingsExitButton.Click += new System.EventHandler(this.settingsExitButton_Click);
            // 
            // colorCheckedListBox
            // 
            this.colorCheckedListBox.CheckOnClick = true;
            this.colorCheckedListBox.FormattingEnabled = true;
            this.colorCheckedListBox.Items.AddRange(new object[] {
            "Blue",
            "Red",
            "Brown"});
            this.colorCheckedListBox.Location = new System.Drawing.Point(574, 133);
            this.colorCheckedListBox.Name = "colorCheckedListBox";
            this.colorCheckedListBox.Size = new System.Drawing.Size(150, 89);
            this.colorCheckedListBox.TabIndex = 9;
            // 
            // colorLabel
            // 
            this.colorLabel.AutoSize = true;
            this.colorLabel.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colorLabel.Location = new System.Drawing.Point(605, 69);
            this.colorLabel.Name = "colorLabel";
            this.colorLabel.Size = new System.Drawing.Size(77, 27);
            this.colorLabel.TabIndex = 10;
            this.colorLabel.Text = "Color";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.colorLabel);
            this.Controls.Add(this.colorCheckedListBox);
            this.Controls.Add(this.settingsExitButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.heightTextbox);
            this.Controls.Add(this.widthTextbox);
            this.Controls.Add(this.shapeCheckedListBox);
            this.Controls.Add(this.shapeLabel);
            this.Controls.Add(this.difficultyCheckedListBox);
            this.Controls.Add(this.difficultyLabel);
            this.Controls.Add(this.settingsLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SettingsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label settingsLabel;
        private System.Windows.Forms.Label difficultyLabel;
        private System.Windows.Forms.CheckedListBox difficultyCheckedListBox;
        private System.Windows.Forms.Label shapeLabel;
        private System.Windows.Forms.CheckedListBox shapeCheckedListBox;
        private System.Windows.Forms.TextBox widthTextbox;
        private System.Windows.Forms.TextBox heightTextbox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button settingsExitButton;
        private System.Windows.Forms.CheckedListBox colorCheckedListBox;
        private System.Windows.Forms.Label colorLabel;
    }
}