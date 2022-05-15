using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Security.Cryptography;

namespace Board_Game
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            usernameHeadLabel.Text = GlobalFunctions.Xelem.Element("username").Value;

            usernameTextbox.Text = GlobalFunctions.Xelem.Element("username").Value;
            passwordTextbox.Text = GlobalFunctions.UnHashedPassword;
            nameSurnameTextbox.Text = GlobalFunctions.Xelem.Element("namesurname").Value;
            phoneNumberTextbox.Text = GlobalFunctions.Xelem.Element("phonenumber").Value;
            addressTextbox.Text = GlobalFunctions.Xelem.Element("address").Value;
            cityTextbox.Text = GlobalFunctions.Xelem.Element("city").Value;
            countryTextbox.Text = GlobalFunctions.Xelem.Element("country").Value;
            emailTextbox.Text = GlobalFunctions.Xelem.Element("email").Value;
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if(passwordTextbox.Text != GlobalFunctions.UnHashedPassword)
            {
                using (SHA256 sha256Hash = SHA256.Create())
                {
                    byte[] sourceBytes = Encoding.UTF8.GetBytes(passwordTextbox.Text);
                    byte[] hashBytes = sha256Hash.ComputeHash(sourceBytes);
                    passwordTextbox.Text = BitConverter.ToString(hashBytes).Replace("-", String.Empty);
                }
            }

            if (confirmPasswordTextbox.Text == GlobalFunctions.UnHashedPassword)
            {
                GlobalFunctions.xmlsave("password", passwordTextbox.Text);
                GlobalFunctions.xmlsave("namesurname", nameSurnameTextbox.Text);
                GlobalFunctions.xmlsave("phonenumber", phoneNumberTextbox.Text);
                GlobalFunctions.xmlsave("address", addressTextbox.Text);
                GlobalFunctions.xmlsave("city", cityTextbox.Text);
                GlobalFunctions.xmlsave("country", countryTextbox.Text);
                GlobalFunctions.xmlsave("email", emailTextbox.Text);
                MessageBox.Show("Updated");
                this.Close();
                new GameForm().Show();
            }
            else
                MessageBox.Show("Wrong password");

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
            new GameForm().Show();
        }

        private void deleteAccountButton_Click(object sender, EventArgs e)
        {
            if (confirmPasswordTextbox.Text == GlobalFunctions.UnHashedPassword)
            {
                GlobalFunctions.Xelem.Remove();
                GlobalFunctions.doc.Save(@"../../UserData.xml");
                MessageBox.Show("Your account deleted");
                this.Close();
                new LoginForm().Show();
            }
            else
                MessageBox.Show("Wrong password");
        }
    }
}
