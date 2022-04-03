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
            XmlDataDocument xdoc=new XmlDataDocument();
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

               XDocument x=XDocument.Load(@"UserData.xml");
            x.Element("Users").Add(new XElement("user", 
                                   new XElement("username", usernameTextbox.Text),
                                   new XElement("password", passwordTextbox.Text),
                                   new XElement("infos",
                                   new XElement("namesurname", nameSurnameTextbox.Text),
                                   new XElement("phonenumber", phoneNumberTextbox.Text),
                                   new XElement("address", addressTextbox.Text),
                                   new XElement("city", cityTextbox.Text),
                                   new XElement("country", countryTextbox.Text),
                                   new XElement("email", emailTextbox.Text)
                                   )));
            x.Save(@"UserData.xml");
            load();
        }

        private void rexitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
