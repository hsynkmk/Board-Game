using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Board_Game__SQL_
{
    public partial class ProfileForm : Form
    {
        public ProfileForm()
        {
            InitializeComponent();
        }
        private void ProfileForm_Load(object sender, EventArgs e)                               //Load current settings
        {
            usernameHeadLabel.Text = UserClass.Username;

            usernameTextbox.Text = UserClass.Username;
            passwordTextbox.Text = UserClass.UnHashedPassword;
            nameSurnameTextbox.Text = UserClass.NameSurname;
            phoneNumberTextbox.Text = UserClass.PhoneNumber;
            addressTextbox.Text = UserClass.Address;
            cityTextbox.Text = UserClass.City;
            countryTextbox.Text = UserClass.Country;
            emailTextbox.Text = UserClass.Email;
        }

        private void UpdateButton_Click(object sender, EventArgs e)                             //Update profile info
        {
            if (confirmPasswordTextbox.Text == UserClass.UnHashedPassword)
            {

                SqlCommand UpdateCommand = new SqlCommand("Update BoardGameUsers set Username=@usn, Password=@pass, NameSurname=@namesrn, PhoneNumber=@phnn, Address=@add, City=@city, Country=@contr, Email=@email where username=@pusn", SQLClass.connection);

                UpdateCommand.Parameters.AddWithValue("@usn", UserClass.Username);
                UpdateCommand.Parameters.AddWithValue("@pass", GlobalMethods.SHA256Converter(passwordTextbox.Text));
                UpdateCommand.Parameters.AddWithValue("@namesrn", nameSurnameTextbox.Text);
                UpdateCommand.Parameters.AddWithValue("@phnn", phoneNumberTextbox.Text);
                UpdateCommand.Parameters.AddWithValue("@add", addressTextbox.Text);
                UpdateCommand.Parameters.AddWithValue("@city", cityTextbox.Text);
                UpdateCommand.Parameters.AddWithValue("@contr", countryTextbox.Text);
                UpdateCommand.Parameters.AddWithValue("@email", emailTextbox.Text);

                UpdateCommand.Parameters.AddWithValue("@pusn", UserClass.Username);
                UpdateCommand.ExecuteNonQuery();

                MessageBox.Show("Updated");
            }
            else
                MessageBox.Show("Wrong password");
        }

        private void DeleteAccountButton_Click(object sender, EventArgs e)                      //Delete account
        {
            if (confirmPasswordTextbox.Text != UserClass.UnHashedPassword)
                MessageBox.Show("Wrong password");
                                                                                                //Valiation
            else if (MessageBox.Show("Your account will be deleted permanently.", "DELETE", MessageBoxButtons.OKCancel) == DialogResult.OK && confirmPasswordTextbox.Text == UserClass.UnHashedPassword)
            {
                SqlCommand DeleteCommand = new SqlCommand("Delete from BoardGameUsers where username=@usn", SQLClass.connection);
                DeleteCommand.Parameters.AddWithValue("@usn", usernameTextbox.Text);
                DeleteCommand.ExecuteNonQuery();

                MessageBox.Show("Your account deleted");

                this.Owner.Owner.Show();
                this.Owner.Close();
                this.Close();
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)                             //Cancel
        {
            this.Owner.Show();
            this.Close();
        }
    }
}