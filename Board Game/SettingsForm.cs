using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Xml;
using System.Xml.Linq;
using System.IO;
using System.Security.Cryptography;

namespace Board_Game
{
    public partial class SettingsForm : Form
    {

        private void setSettings(string category, CheckedListBox clb)
        {
            string a = UserClass.xelem.Element(category).Value;
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
            widthTextbox.Text = UserClass.xelem.Element("customDifficultyWidth").Value;
            heightTextbox.Text = UserClass.xelem.Element("customDifficultyHeight").Value;
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
            this.Hide();
            new GameForm().Show();
        }


        private void saveSettings(string category, CheckedListBox clb)
        {

            string data = "";

            int count = clb.Items.Count;
            for (int i = 0; i < count; i++)
            {
                if (clb.GetItemChecked(i) == true)
                    data += "1";
                else
                    data += "0";
            }

            UserClass.xmlsave(category, data);

        }

        private void saveButton_Click(object sender, EventArgs e)
        {   


            saveSettings("difficulty", difficultyCheckedListBox);
            saveSettings("shape", shapeCheckedListBox);
            saveSettings("color", colorCheckedListBox);
            UserClass.xmlsave("customDifficultyWidth", widthTextbox.Text);
            UserClass.xmlsave("customDifficultyHeight", heightTextbox.Text);


            //XElement node = doc.Element("Users").Elements("user").FirstOrDefault(a => a.Element("username").Value == "username1234");
            //node.SetElementValue("difficulty", a);
            //node.SetElementValue("shape", a);
            //node.SetElementValue("color", a);


            MessageBox.Show("Saved");
        }
    }
}
