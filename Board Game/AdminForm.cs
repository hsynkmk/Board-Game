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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }



        private void userDataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            usernameTextbox.Text = userDataGridView.CurrentRow.Cells[0].Value.ToString();
            passwordTextbox.Text = userDataGridView.CurrentRow.Cells[1].Value.ToString();
            nameSurnameTextbox.Text = userDataGridView.CurrentRow.Cells[2].Value.ToString();
            phoneNumberTextbox.Text = userDataGridView.CurrentRow.Cells[3].Value.ToString();
            addressTextbox.Text = userDataGridView.CurrentRow.Cells[4].Value.ToString();
            cityTextbox.Text = userDataGridView.CurrentRow.Cells[5].Value.ToString();
            countryTextbox.Text = userDataGridView.CurrentRow.Cells[6].Value.ToString();
            emailTextbox.Text = userDataGridView.CurrentRow.Cells[7].Value.ToString();
        }
        private void adminDataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            usernameTextbox.Text = adminDataGridView.CurrentRow.Cells[0].Value.ToString();
            passwordTextbox.Text = adminDataGridView.CurrentRow.Cells[1].Value.ToString();
            nameSurnameTextbox.Text = adminDataGridView.CurrentRow.Cells[2].Value.ToString();
            phoneNumberTextbox.Text = adminDataGridView.CurrentRow.Cells[3].Value.ToString();
            addressTextbox.Text = adminDataGridView.CurrentRow.Cells[4].Value.ToString();
            cityTextbox.Text = adminDataGridView.CurrentRow.Cells[5].Value.ToString();
            countryTextbox.Text = adminDataGridView.CurrentRow.Cells[6].Value.ToString();
            emailTextbox.Text = adminDataGridView.CurrentRow.Cells[7].Value.ToString();
        }

        private void listUsersButton_Click(object sender, EventArgs e)
        {
            DataSet dataSet = new DataSet();
            dataSet.ReadXml(@"../../UserData.xml");
            adminDataGridView.DataSource = dataSet.Tables["Admin"];
            userDataGridView.DataSource = dataSet.Tables["user"];

            usernameTextbox.Enabled = false;
            listUsersButton.BackColor = Color.Blue;
            updateUserButton.BackColor = Color.White;
            addButton.BackColor = Color.White;
            deleteUserButton.BackColor = Color.White;

        }

        private void updateUserButton_Click(object sender, EventArgs e)
        {
            usernameTextbox.Enabled = false;
            infoGroupBox.Visible = true;
            updateUserButton.BackColor = Color.Blue;
            listUsersButton.BackColor = Color.White;
            addButton.BackColor = Color.White;
            deleteUserButton.BackColor = Color.White;
        }


        private void addButton_Click(object sender, EventArgs e)
        {
            usernameTextbox.Enabled = true;
            infoGroupBox.Visible = true;
            addButton.BackColor = Color.Blue;
            listUsersButton.BackColor = Color.White;
            updateUserButton.BackColor = Color.White;
            deleteUserButton.BackColor = Color.White;
        }

        private void deleteUserButton_Click(object sender, EventArgs e)
        {
            usernameTextbox.Enabled = true;
            infoGroupBox.Visible = true;
            deleteUserButton.BackColor = Color.Blue;
            listUsersButton.BackColor = Color.White;
            updateUserButton.BackColor = Color.White;
            addButton.BackColor = Color.White;
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (updateUserButton.BackColor == Color.Blue)
                {

                    string hash;
                    using (SHA256 sha256Hash = SHA256.Create())
                    {
                        //From String to byte array
                        byte[] sourceBytes = Encoding.UTF8.GetBytes(passwordTextbox.Text);
                        byte[] hashBytes = sha256Hash.ComputeHash(sourceBytes);
                        hash = BitConverter.ToString(hashBytes).Replace("-", String.Empty);
                    }

                    XDocument doc = XDocument.Load(@"../../UserData.xml");
                    foreach (XElement elem in doc.Descendants("Admin"))
                    {
                        if (elem.Element("username").Value == usernameTextbox.Text)
                        {
                            elem.SetElementValue("namesurname", nameSurnameTextbox.Text);
                            elem.SetElementValue("password", hash);
                            elem.SetElementValue("namesurname", nameSurnameTextbox.Text);
                            elem.SetElementValue("phonenumber", phoneNumberTextbox.Text);
                            elem.SetElementValue("address", addressTextbox.Text);
                            elem.SetElementValue("city", cityTextbox.Text);
                            elem.SetElementValue("country", countryTextbox.Text);
                            elem.SetElementValue("email", emailTextbox.Text);
                            doc.Save(@"../../UserData.xml");
                        }
                    }

                    foreach (XElement elem in doc.Descendants("user"))
                    {
                        if (elem.Element("username").Value == usernameTextbox.Text)
                        {
                            elem.SetElementValue("namesurname", nameSurnameTextbox.Text);
                            elem.SetElementValue("password", hash);
                            elem.SetElementValue("namesurname", nameSurnameTextbox.Text);
                            elem.SetElementValue("phonenumber", phoneNumberTextbox.Text);
                            elem.SetElementValue("address", addressTextbox.Text);
                            elem.SetElementValue("city", cityTextbox.Text);
                            elem.SetElementValue("country", countryTextbox.Text);
                            elem.SetElementValue("email", emailTextbox.Text);
                            doc.Save(@"../../UserData.xml");

                        }
                    }
                }
                if (addButton.BackColor == Color.Blue)
                {

                    string hash;
                    using (SHA256 sha256Hash = SHA256.Create())
                    {
                        //From String to byte array
                        byte[] sourceBytes = Encoding.UTF8.GetBytes(passwordTextbox.Text);
                        byte[] hashBytes = sha256Hash.ComputeHash(sourceBytes);
                        hash = BitConverter.ToString(hashBytes).Replace("-", String.Empty);
                    }

                    XDocument doc = XDocument.Load(@"../../UserData.xml");
                    doc.Element("Users").Add(new XElement("user",
                                           new XElement("username", usernameTextbox.Text),
                                           new XElement("password", hash),
                                           new XElement("namesurname", nameSurnameTextbox.Text),
                                           new XElement("phonenumber", phoneNumberTextbox.Text),
                                           new XElement("address", addressTextbox.Text),
                                           new XElement("city", cityTextbox.Text),
                                           new XElement("country", countryTextbox.Text),
                                           new XElement("email", emailTextbox.Text),
                                           new XElement("difficulty", "1000"),
                                           new XElement("customDifficultyWidth", 0),
                                           new XElement("customDifficultyHeight", 0),
                                           new XElement("shape", "100"),
                                           new XElement("color", "100")
                                           ));
                    doc.Save(@"../../UserData.xml");

                }
                if (deleteUserButton.BackColor == Color.Blue)
                {
                    XDocument doc = XDocument.Load(@"../../UserData.xml");
                    foreach (XElement elem in doc.Descendants("Admin"))
                    {
                        if (elem.Element("username").Value == usernameTextbox.Text)
                        {
                            elem.Remove();
                            doc.Save(@"../../UserData.xml");
                            break;
                        }
                    }

                    foreach (XElement elem in doc.Descendants("user"))
                    {
                        if (elem.Element("username").Value == usernameTextbox.Text)
                        {
                            elem.Remove();
                            doc.Save(@"../../UserData.xml");
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            completedLabel.Visible = true;
        }

        private void usernameTextbox_TextChanged(object sender, EventArgs e)
        {
            usernameTextbox.Text = string.Concat(usernameTextbox.Text.Where(char.IsLetter));
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new GameForm().Show();
        }
    }   
}
