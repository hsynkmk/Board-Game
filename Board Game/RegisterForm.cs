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

        void load()
        {
            //XmlDataDocument xdoc=new XmlDataDocument();
            DataSet ds = new DataSet();
            XmlReader xmlFile;
            string absolutePath = Path.GetFullPath("UserData.xml");
            xmlFile = XmlReader.Create(absolutePath, new XmlReaderSettings());
            ds.ReadXml(xmlFile);
            dataGridView1.DataSource = ds.Tables[0];
            xmlFile.Close();
        }

        private void rsaveButton_Click(object sender, EventArgs e)
        {
            SHA1 sha = new SHA1CryptoServiceProvider();

            string hashedData = Convert.ToBase64String(sha.ComputeHash(Encoding.UTF8.GetBytes(passwordTextbox.Text)));

            int width=0, height=0;

            //Console.ReadLine();
            XDocument x=XDocument.Load(@"UserData.xml");
            x.Element("Users").Add(new XElement("user", 
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
            x.Save(@"UserData.xml");
            load();
        }

        private void rexitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
