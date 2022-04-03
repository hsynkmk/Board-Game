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
        public SettingsForm()
        {
            InitializeComponent();

            XDocument doc = XDocument.Load(@"UserData.xml");
            foreach (XElement elem in doc.Descendants("user"))
            {
                if (elem.Element("username")?.Value == "alik" && elem.Element("password")?.Value == "DHPE2fUXbxKmZ+t5bF2fbTBptMk=")
                {
                    string a = elem.Element("difficulty").Value;
                    int count = difficultyCheckedListBox.Items.Count;
                    int index;

                    for (int i = 0; i < count; i++)
                    {
                        index = (int)Char.GetNumericValue(a[i]);
                        if(index == 1)
                            difficultyCheckedListBox.SetItemChecked(i, true);
                    }
                    a = elem.Element("shape").Value;
                    count = shapeCheckedListBox.Items.Count;

                    for (int i = 0; i < count; i++)
                    {
                        index = (int)Char.GetNumericValue(a[i]);
                        if (index == 1)
                            shapeCheckedListBox.SetItemChecked(i, true);
                    }

                    a = elem.Element("color").Value;
                    count = colorCheckedListBox.Items.Count;

                    for (int i = 0; i < count; i++)
                    {
                        index = (int)Char.GetNumericValue(a[i]);
                        if (index == 1)
                            colorCheckedListBox.SetItemChecked(i, true);
                    }
                }
            }
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

        private void saveButton_Click(object sender, EventArgs e)
        {

        }
    }
}
