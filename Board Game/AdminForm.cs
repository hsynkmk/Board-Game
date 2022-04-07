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

namespace Board_Game
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void listUsersButton_Click(object sender, EventArgs e)
        {
            //UserClass.Xelem

            DataSet dataSet = new DataSet();
            dataSet.ReadXml(@"../../UserData.xml");
            adminDataGridView.DataSource = dataSet.Tables["Admin"];
            userDataGridView.DataSource = dataSet.Tables["user"];

            //XmlDataDocument xdoc=new XmlDataDocument();
            //DataSet ds = new DataSet();
            //XmlReader xmlFile;

            //xmlFile = XmlReader.Create(@"../../UserData.xml", new XmlReaderSettings());
            //ds.ReadXml(xmlFile);
            //adminDataGridView.DataSource = ds.Tables["Admin"];
            //userDataGridView.DataSource = ds.Tables["user"];
            
            //xmlFile.Close();

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
        
    }
}
