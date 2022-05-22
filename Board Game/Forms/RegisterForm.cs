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


    public partial class RegisterForm : Form
    {  
        public RegisterForm()
        {
            InitializeComponent();
            
        }



        private void rsaveButton_Click(object sender, EventArgs e)
        {
            string hash;
            using (SHA256 sha256Hash = SHA256.Create())
            {
                //From String to byte array
                byte[] sourceBytes = Encoding.UTF8.GetBytes(passwordTextbox.Text);
                byte[] hashBytes = sha256Hash.ComputeHash(sourceBytes);
                hash = BitConverter.ToString(hashBytes).Replace("-", String.Empty);
            }
            
            bool isValid()
            {
                foreach (XElement elem in GlobalFunctions.doc.Descendants("Admin"))
                {
                    if (elem.Element("username").Value == usernameTextbox.Text)
                    {
                        invalidUsernameLabel.Visible = true;
                        return false;
                    }
                }

                foreach (XElement elem in GlobalFunctions.doc.Descendants("user"))
                {
                    if (elem.Element("username").Value == usernameTextbox.Text)
                    {
                        invalidUsernameLabel.Visible = true;
                        return false;
                    }
                }
                return true;
            }

            if (usernameTextbox.Text != "" && passwordTextbox.Text != "" && isValid())
            {
                //XDocument doc = XDocument.Load(@"../../UserData.xml");
                GlobalFunctions.doc.Element("Users").Add(new XElement("user",
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
                                       new XElement("color", "100"),
                                       new XElement("bestScore", "0")
                                       ));
                GlobalFunctions.doc.Save(@"../../UserData.xml");
                MessageBox.Show("Registered");
                this.Close();
                new LoginForm().Show();
            }
            
        }

        private void rexitButton_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void usernameTextbox_TextChanged(object sender, EventArgs e)
        {
            usernameTextbox.Text = string.Concat(usernameTextbox.Text.Where(char.IsLetter));
        }
    }
}
