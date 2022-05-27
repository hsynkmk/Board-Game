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

namespace Board_Game
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SqlCommand registerComm = new SqlCommand("Insert into BoardGameUsers (BestScore,Username,Password,UserType,NameSurname,PhoneNumber,Address,City,Country,Email,Difficulty,CustomDifWidth,CustomDifHeight,Sahpe,Color) values (@bstscre,@usn,@pass,@usrtyp,@namesrn,@phnn,@add,@city,@contr,@email,@diff,@cdiffw,@cdiffh,@shape,@color)", SQLClass.connection);
            
            registerComm.Parameters.AddWithValue("@bstscre", 0);
            registerComm.Parameters.AddWithValue("@usn", usernameTextbox.Text);
            registerComm.Parameters.AddWithValue("@pass", GlobalMethods.SHA256Converter(passwordTextbox.Text));
            registerComm.Parameters.AddWithValue("@usrtyp", "user");
            registerComm.Parameters.AddWithValue("@namesrn", nameSurnameTextbox.Text);
            registerComm.Parameters.AddWithValue("@phnn", phoneNumberTextbox.Text);
            registerComm.Parameters.AddWithValue("@add", addressTextbox.Text);
            registerComm.Parameters.AddWithValue("@city", cityTextbox.Text);
            registerComm.Parameters.AddWithValue("@contr", countryTextbox.Text);
            registerComm.Parameters.AddWithValue("@email", emailTextbox.Text);
            registerComm.Parameters.AddWithValue("@diff", "1000");
            registerComm.Parameters.AddWithValue("@cdiffw", 0);
            registerComm.Parameters.AddWithValue("@cdiffh", 0);
            registerComm.Parameters.AddWithValue("@shape", "111");
            registerComm.Parameters.AddWithValue("@color", "111");
            registerComm.ExecuteNonQuery();
        }

        private void BackLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }
    }
}
