using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Board_Game__SQL_
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e)                                  //Load previous settings
        {
            SetSettings(UserClass.Difficulty, difficultyCheckedListBox);
            SetSettings(UserClass.Shape, shapeCheckedListBox);
            SetSettings(UserClass.Color, colorCheckedListBox);

            widthTextbox.Text = UserClass.CustomDifficultyWidth;
            heightTextbox.Text = UserClass.CustomDifficultyHeight;
        }

        private void SetSettings(string category, CheckedListBox clb)                               //Sets settings to listboxes
        {
            int count = clb.Items.Count;
            int index;

            for (int i = 0; i < count; i++)
            {
                index = (int)Char.GetNumericValue(category[i]);
                if (index == 1)
                    clb.SetItemChecked(i, true);
            }
        }

        private void DifficultyCheckedListBox_SelectedIndexChanged(object sender, EventArgs e)      //One selection for difficulty
        {
            int index = difficultyCheckedListBox.SelectedIndex;

            for (int i = 0; i < difficultyCheckedListBox.Items.Count; i++)
                if (index != i)
                    difficultyCheckedListBox.SetItemChecked(i, false);

            if (difficultyCheckedListBox.SelectedIndex == 3)
            {
                widthTextbox.Visible = true;
                heightTextbox.Visible = true;
            }
            if (difficultyCheckedListBox.SelectedIndex != 3)
            {
                widthTextbox.Visible = false;
                heightTextbox.Visible = false;
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)                                   //Save settings
        {
            try
            {
                if (shapeCheckedListBox.CheckedItems.Count >= 2 && colorCheckedListBox.CheckedItems.Count >= 2)
                {
                    SqlCommand SaveCommand = new SqlCommand("Update BoardGameUsers set Difficulty=@diff, CustomDifWidth=@cdiffw, CustomDifHeight=@cdiffh, Sahpe=@shape,Color=@color where username=@usn", SQLClass.connection);
                    SaveCommand.Parameters.AddWithValue("@usn", UserClass.Username);
                    SaveCommand.Parameters.AddWithValue("@diff", SettingString(difficultyCheckedListBox));
                    SaveCommand.Parameters.AddWithValue("@cdiffw", widthTextbox.Text);
                    SaveCommand.Parameters.AddWithValue("@cdiffh", heightTextbox.Text);
                    SaveCommand.Parameters.AddWithValue("@shape", SettingString(shapeCheckedListBox));
                    SaveCommand.Parameters.AddWithValue("@color", SettingString(colorCheckedListBox));
                    SaveCommand.ExecuteNonQuery();
                    UserClass.Difficulty = SettingString(difficultyCheckedListBox);
                    UserClass.Color = SettingString(colorCheckedListBox);
                    UserClass.Shape = SettingString(shapeCheckedListBox);

                    MessageBox.Show("Saved");
                }
                else
                    MessageBox.Show("You have to choose at least two shapes and two colors");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }

        private string SettingString(CheckedListBox clb)                                            //Generates binary digits for settings
        {
            string data = "";

            for (int i = 0; i < clb.Items.Count; i++)
            {
                if (clb.GetItemChecked(i) == true)
                    data += "1";
                else
                    data += "0";
            }
            return data;
        }

        private void BackButton_Click(object sender, EventArgs e)                                   //Back button
        {
            this.Owner.Show();
            this.Close();
        }

        private void WidthTextbox_TextChanged(object sender, EventArgs e)                           //Width textbox only digits
        {
            widthTextbox.Text = string.Concat(widthTextbox.Text.Where(char.IsDigit));
        }

        private void HeightTextbox_TextChanged(object sender, EventArgs e)                          //Height textbox only digits
        {
            heightTextbox.Text = string.Concat(heightTextbox.Text.Where(char.IsDigit));
        }
    }
}
