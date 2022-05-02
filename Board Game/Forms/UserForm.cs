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
            usernameHeadLabel.Text = UserClass.Xelem.Element("username").Value;

            usernameTextbox.Text = UserClass.Xelem.Element("username").Value;
            passwordTextbox.Text = UserClass.UnHashedPassword;
            nameSurnameTextbox.Text = UserClass.Xelem.Element("namesurname").Value;
            phoneNumberTextbox.Text = UserClass.Xelem.Element("phonenumber").Value;
            addressTextbox.Text = UserClass.Xelem.Element("address").Value;
            cityTextbox.Text = UserClass.Xelem.Element("city").Value;
            countryTextbox.Text = UserClass.Xelem.Element("country").Value;
            emailTextbox.Text = UserClass.Xelem.Element("email").Value;
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if(passwordTextbox.Text != UserClass.UnHashedPassword)
            {
                using (SHA256 sha256Hash = SHA256.Create())
                {
                    byte[] sourceBytes = Encoding.UTF8.GetBytes(passwordTextbox.Text);
                    byte[] hashBytes = sha256Hash.ComputeHash(sourceBytes);
                    passwordTextbox.Text = BitConverter.ToString(hashBytes).Replace("-", String.Empty);
                }
            }

            if (confirmPasswordTextbox.Text == UserClass.UnHashedPassword)
            {
                UserClass.xmlsave("password", passwordTextbox.Text);
                UserClass.xmlsave("namesurname", nameSurnameTextbox.Text);
                UserClass.xmlsave("phonenumber", phoneNumberTextbox.Text);
                UserClass.xmlsave("address", addressTextbox.Text);
                UserClass.xmlsave("city", cityTextbox.Text);
                UserClass.xmlsave("country", countryTextbox.Text);
                UserClass.xmlsave("email", emailTextbox.Text);
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
            if (confirmPasswordTextbox.Text == UserClass.UnHashedPassword)
            {
                UserClass.Xelem.Remove();
                UserClass.doc.Save(@"../../UserData.xml");
                MessageBox.Show("Your account deleted");
                this.Close();
                new LoginForm().Show();
            }
            else
                MessageBox.Show("Wrong password");
        }
    }
}
