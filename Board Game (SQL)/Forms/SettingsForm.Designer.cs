namespace Board_Game__SQL_
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.colorLabel = new System.Windows.Forms.Label();
            this.colorCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.backButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.heightTextbox = new System.Windows.Forms.TextBox();
            this.widthTextbox = new System.Windows.Forms.TextBox();
            this.shapeCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.shapeLabel = new System.Windows.Forms.Label();
            this.difficultyCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.difficultyLabel = new System.Windows.Forms.Label();
            this.settingsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // colorLabel
            // 
            this.colorLabel.AutoSize = true;
            this.colorLabel.BackColor = System.Drawing.Color.Black;
            this.colorLabel.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colorLabel.ForeColor = System.Drawing.Color.White;
            this.colorLabel.Location = new System.Drawing.Point(623, 175);
            this.colorLabel.Name = "colorLabel";
            this.colorLabel.Size = new System.Drawing.Size(77, 27);
            this.colorLabel.TabIndex = 21;
            this.colorLabel.Text = "Color";
            // 
            // colorCheckedListBox
            // 
            this.colorCheckedListBox.BackColor = System.Drawing.Color.Black;
            this.colorCheckedListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.colorCheckedListBox.CheckOnClick = true;
            this.colorCheckedListBox.ForeColor = System.Drawing.Color.White;
            this.colorCheckedListBox.FormattingEnabled = true;
            this.colorCheckedListBox.Items.AddRange(new object[] {
            "Blue",
            "Red",
            "Purple"});
            this.colorCheckedListBox.Location = new System.Drawing.Point(628, 229);
            this.colorCheckedListBox.Name = "colorCheckedListBox";
            this.colorCheckedListBox.Size = new System.Drawing.Size(114, 68);
            this.colorCheckedListBox.TabIndex = 20;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Black;
            this.backButton.ForeColor = System.Drawing.Color.White;
            this.backButton.Location = new System.Drawing.Point(12, 565);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 19;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.Black;
            this.saveButton.ForeColor = System.Drawing.Color.White;
            this.saveButton.Location = new System.Drawing.Point(913, 565);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 18;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // heightTextbox
            // 
            this.heightTextbox.Location = new System.Drawing.Point(370, 337);
            this.heightTextbox.Name = "heightTextbox";
            this.heightTextbox.Size = new System.Drawing.Size(39, 22);
            this.heightTextbox.TabIndex = 17;
            this.heightTextbox.Visible = false;
            this.heightTextbox.TextChanged += new System.EventHandler(this.HeightTextbox_TextChanged);
            // 
            // widthTextbox
            // 
            this.widthTextbox.Location = new System.Drawing.Point(306, 337);
            this.widthTextbox.Name = "widthTextbox";
            this.widthTextbox.Size = new System.Drawing.Size(39, 22);
            this.widthTextbox.TabIndex = 16;
            this.widthTextbox.Visible = false;
            this.widthTextbox.TextChanged += new System.EventHandler(this.WidthTextbox_TextChanged);
            // 
            // shapeCheckedListBox
            // 
            this.shapeCheckedListBox.BackColor = System.Drawing.Color.Black;
            this.shapeCheckedListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.shapeCheckedListBox.CheckOnClick = true;
            this.shapeCheckedListBox.ForeColor = System.Drawing.Color.White;
            this.shapeCheckedListBox.FormattingEnabled = true;
            this.shapeCheckedListBox.Items.AddRange(new object[] {
            "Square",
            "Triangle",
            "Round"});
            this.shapeCheckedListBox.Location = new System.Drawing.Point(468, 229);
            this.shapeCheckedListBox.Name = "shapeCheckedListBox";
            this.shapeCheckedListBox.Size = new System.Drawing.Size(150, 68);
            this.shapeCheckedListBox.TabIndex = 15;
            // 
            // shapeLabel
            // 
            this.shapeLabel.AutoSize = true;
            this.shapeLabel.BackColor = System.Drawing.Color.Black;
            this.shapeLabel.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.shapeLabel.ForeColor = System.Drawing.Color.White;
            this.shapeLabel.Location = new System.Drawing.Point(463, 175);
            this.shapeLabel.Name = "shapeLabel";
            this.shapeLabel.Size = new System.Drawing.Size(77, 27);
            this.shapeLabel.TabIndex = 14;
            this.shapeLabel.Text = "Shape";
            // 
            // difficultyCheckedListBox
            // 
            this.difficultyCheckedListBox.BackColor = System.Drawing.Color.Black;
            this.difficultyCheckedListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.difficultyCheckedListBox.CheckOnClick = true;
            this.difficultyCheckedListBox.ForeColor = System.Drawing.Color.White;
            this.difficultyCheckedListBox.FormattingEnabled = true;
            this.difficultyCheckedListBox.Items.AddRange(new object[] {
            "Easy",
            "Normal",
            "Hard",
            "Custom"});
            this.difficultyCheckedListBox.Location = new System.Drawing.Point(306, 229);
            this.difficultyCheckedListBox.Name = "difficultyCheckedListBox";
            this.difficultyCheckedListBox.Size = new System.Drawing.Size(112, 102);
            this.difficultyCheckedListBox.TabIndex = 13;
            this.difficultyCheckedListBox.SelectedIndexChanged += new System.EventHandler(this.DifficultyCheckedListBox_SelectedIndexChanged);
            // 
            // difficultyLabel
            // 
            this.difficultyLabel.AutoSize = true;
            this.difficultyLabel.BackColor = System.Drawing.Color.Black;
            this.difficultyLabel.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.difficultyLabel.ForeColor = System.Drawing.Color.White;
            this.difficultyLabel.Location = new System.Drawing.Point(301, 175);
            this.difficultyLabel.Name = "difficultyLabel";
            this.difficultyLabel.Size = new System.Drawing.Size(142, 27);
            this.difficultyLabel.TabIndex = 12;
            this.difficultyLabel.Text = "Difficulty";
            // 
            // settingsLabel
            // 
            this.settingsLabel.AutoSize = true;
            this.settingsLabel.BackColor = System.Drawing.Color.Black;
            this.settingsLabel.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.settingsLabel.ForeColor = System.Drawing.Color.White;
            this.settingsLabel.Location = new System.Drawing.Point(447, 115);
            this.settingsLabel.Name = "settingsLabel";
            this.settingsLabel.Size = new System.Drawing.Size(135, 33);
            this.settingsLabel.TabIndex = 11;
            this.settingsLabel.Text = "Settings";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Board_Game__SQL_.Properties.Resources.Background2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.colorLabel);
            this.Controls.Add(this.colorCheckedListBox);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.heightTextbox);
            this.Controls.Add(this.widthTextbox);
            this.Controls.Add(this.shapeCheckedListBox);
            this.Controls.Add(this.shapeLabel);
            this.Controls.Add(this.difficultyCheckedListBox);
            this.Controls.Add(this.difficultyLabel);
            this.Controls.Add(this.settingsLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SettingsForm";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label colorLabel;
        private System.Windows.Forms.CheckedListBox colorCheckedListBox;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox heightTextbox;
        private System.Windows.Forms.TextBox widthTextbox;
        private System.Windows.Forms.CheckedListBox shapeCheckedListBox;
        private System.Windows.Forms.Label shapeLabel;
        private System.Windows.Forms.CheckedListBox difficultyCheckedListBox;
        private System.Windows.Forms.Label difficultyLabel;
        private System.Windows.Forms.Label settingsLabel;
    }
}