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
            SHA1 sha = new SHA1CryptoServiceProvider();

            string hashedData = Convert.ToBase64String(sha.ComputeHash(Encoding.UTF8.GetBytes(passwordTextbox.Text)));

            int width=0, height=0;

            XDocument doc=XDocument.Load(@"../../UserData.xml");
            doc.Element("Users").Add(new XElement("user", 
                                   new XElement("username", usernameTextbox.Text),
                                   new XElement("password", hashedData),
                                   new XElement("namesurname", nameSurnameTextbox.Text),
                                   new XElement("phonenumber", phoneNumberTextbox.Text),
                                   new XElement("address", addressTextbox.Text),
                                   new XElement("city", cityTextbox.Text),
                                   new XElement("country", countryTextbox.Text),
                                   new XElement("email", emailTextbox.Text),
                                   new XElement("difficulty", "1000"),
                                   new XElement("customDifficultyWidth", width),
                                   new XElement("customDifficultyHeight", height),
                                   new XElement("shape", "100"),
                                   new XElement("color", "100")
                                   ));
            doc.Save(@"../../UserData.xml");
        }

        private void rexitButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LoginForm().Show();
        }
    }
}
