using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Board_Game
{
    public partial class SettingsForm : Form
    {

        private void setSettings(string category, CheckedListBox clb)
        {
            string a = GlobalFunctions.Xelem.Element(category).Value;
            int count = clb.Items.Count;
            int index;

            for (int i = 0; i < count; i++)
            {
                index = (int)Char.GetNumericValue(a[i]);
                if (index == 1)
                    clb.SetItemChecked(i, true);
            }
        } 
        public SettingsForm()
        {

            InitializeComponent();

            setSettings("difficulty", difficultyCheckedListBox);
            setSettings("shape", shapeCheckedListBox);
            setSettings("color", colorCheckedListBox);

            //if (difficultyCheckedListBox.GetSelected(3))
            //{
            //    widthTextbox.Visible=true;
            //    heightTextbox.Visible=true;
            //}

            widthTextbox.Text = GlobalFunctions.Xelem.Element("customDifficultyWidth").Value;
            heightTextbox.Text = GlobalFunctions.Xelem.Element("customDifficultyHeight").Value;
        }

        private void difficultyCheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //
            //one selection
            //
            int index = difficultyCheckedListBox.SelectedIndex;
            int count = difficultyCheckedListBox.Items.Count;
            for(int i = 0; i < count; i++)
                if(index!=i)
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

        private void settingsExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
            new GameForm().Show();
        }


        private void saveSettings(string category, CheckedListBox clb)
        {

            string data = "";

            for (int i = 0; i < clb.Items.Count; i++)
            {
                if (clb.GetItemChecked(i) == true)
                    data += "1";
                else
                    data += "0";
            }

            GlobalFunctions.xmlsave(category, data);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {   


            saveSettings("difficulty", difficultyCheckedListBox);
            saveSettings("shape", shapeCheckedListBox);
            saveSettings("color", colorCheckedListBox);
            GlobalFunctions.xmlsave("customDifficultyWidth", widthTextbox.Text);
            GlobalFunctions.xmlsave("customDifficultyHeight", heightTextbox.Text);


            //XElement node = doc.Element("Users").Elements("user").FirstOrDefault(a => a.Element("username").Value == "username1234");
            //node.SetElementValue("difficulty", a);
            //node.SetElementValue("shape", a);
            //node.SetElementValue("color", a);


            MessageBox.Show("Saved");
        }
    }
}
