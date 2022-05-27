using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace Board_Game
{
    public partial class LoginForm : Form
    {

        public LoginForm()
        {
            InitializeComponent();
            UsernameTextbox.Text = Properties.Settings.Default.username;                                    //fill username textbox with last succesful entrance
            SQLClass.openConn();
        }


        private void LoginLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)             //login
        {
            //try
            //{
                
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("Please check your internet connection!");
            //    Application.Restart();
            //}




            SqlCommand loginComm = new SqlCommand("Select * from BoardGameUsers where Username=@usn and Password=@pass", SQLClass.connection);

            loginComm.Parameters.AddWithValue("@usn", UsernameTextbox.Text);
            loginComm.Parameters.AddWithValue("@pass", GlobalMethods.SHA256Converter(PasswordTextbox.Text));


            SqlDataAdapter dataAdapter=new SqlDataAdapter(loginComm);

            DataTable dataTable=new DataTable();

            dataAdapter.Fill(dataTable);



            if (dataTable.Rows.Count > 0)
            {
                if (dataTable.Rows[0]["UserType"].ToString() == "admin")
                    UserClass.IsAdmin = true;

                UserClass.Username = dataTable.Rows[0]["Username"].ToString();
                UserClass.UnHashedPassword = PasswordTextbox.Text;
                UserClass.HashedPassword = dataTable.Rows[0]["Password"].ToString();
                UserClass.NameSurname = dataTable.Rows[0]["NameSurname"].ToString();
                UserClass.PhoneNumber = dataTable.Rows[0]["PhoneNumber"].ToString();
                UserClass.Address = dataTable.Rows[0]["Address"].ToString();
                UserClass.City = dataTable.Rows[0]["City"].ToString();
                UserClass.Country = dataTable.Rows[0]["Country"].ToString();
                UserClass.Email = dataTable.Rows[0]["Email"].ToString();
                UserClass.Difficulty = dataTable.Rows[0]["Difficulty"].ToString();
                UserClass.CustomDifficultyWidth = dataTable.Rows[0]["CustomDifWidth"].ToString();
                UserClass.CustomDifficultyHeight = dataTable.Rows[0]["CustomDifHeight"].ToString();
                UserClass.Shape = dataTable.Rows[0]["Sahpe"].ToString();
                UserClass.Color = dataTable.Rows[0]["Color"].ToString();


                this.Hide();
                GameForm logedin = new GameForm();
                logedin.Owner = this;
                logedin.Show();

                Properties.Settings.Default.username = UsernameTextbox.Text;                                //save last succesfull entrance
                Properties.Settings.Default.Save();
            }

            else
            {
                IncorrectLoginLabel.Visible = true;
                UsernameTextbox.Clear();
                PasswordTextbox.Clear();
                UsernameTextbox.Focus();
            }

        }

        private void ShowPasswordCheckBox_CheckedChanged(object sender, EventArgs e)                        //show password
        {
            if (ShowPasswordCheckBox.Checked)
                PasswordTextbox.PasswordChar = '\0';
            else
                PasswordTextbox.PasswordChar = '*';
        }

        private void RegisterLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)          //register link
        {
            this.Hide();
            RegisterForm register = new RegisterForm();
            register.Owner = this;
            register.Show();
        }

        private void UsernameTextbox_TextChanged(object sender, EventArgs e)
        {
            UsernameTextbox.Text = string.Concat(UsernameTextbox.Text.Where(char.IsLetter));                //username only letter
        }

        private void ExitLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)              //exit game
        {
            SQLClass.closeConn();
            Application.Exit();
        }

        private void aboutUsLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)           //about link
        {
            this.Enabled = false;
            AboutBox about = new AboutBox();
            about.Owner = this;
            about.Show();
        }
    }
}