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
        string susername;
        string spassword;
        public SettingsForm(string username, string password)
        {
            susername = username;
            spassword = password;
            InitializeComponent();

            XDocument doc = XDocument.Load(@"UserData.xml");
            foreach (XElement elem in doc.Descendants("user"))
            {
                if (elem.Element("username")?.Value == username && elem.Element("password")?.Value == password)
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
            new GameForm(susername, spassword).Show();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            XDocument doc = XDocument.Load(@"UserData.xml");

            //XElement node = doc.Element("Users").Elements("user").FirstOrDefault(a => a.Element("username").Value == "username1234");

            foreach (XElement elem in doc.Descendants("user"))
            {

                if (elem.Element("username")?.Value == susername && elem.Element("password")?.Value == spassword)
                {
                    string a = "";
                    
                    
                    
                    int count = difficultyCheckedListBox.Items.Count;
                    for (int i = 0; i < count; i++)
                    {
                        if (difficultyCheckedListBox.GetItemChecked(i) == true)
                            a += "1";
                        else
                            a += "0";
                    }
                    //node.SetElementValue("difficulty", a);
                    elem.Element("difficulty").Value = a;


                    a = "";


                    count = shapeCheckedListBox.Items.Count;
                    for (int i = 0; i < count; i++)
                    {
                        if (shapeCheckedListBox.GetItemChecked(i) == true)
                            a += "1";
                        else
                            a += "0";
                    }
                    //node.SetElementValue("shape", a);
                    elem.Element("shape").Value = a;




                    a = "";

                    count = colorCheckedListBox.Items.Count;
                    for (int i = 0; i < count; i++)
                    {
                        if (colorCheckedListBox.GetItemChecked(i) == true)
                            a += "1";
                        else
                            a += "0";
                    }
                    //node.SetElementValue("color", a);
                    elem.Element("color").Value = a;


                    elem.Element("customDifficultyWidth").Value = widthTextbox.Text;
                    elem.Element("customDifficultyHeight").Value = heightTextbox.Text;


                    doc.Save(@"UserData.xml");
                    MessageBox.Show("Saved");
                }
            }
        }
    }
}
