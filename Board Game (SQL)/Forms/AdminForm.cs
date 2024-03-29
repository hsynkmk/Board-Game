﻿using System;
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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
            Display();
        }

        private void Display()                                                          //Refresh data grid view
        {
            SqlCommand command = new SqlCommand("Select * from BoardGameUsers", SQLClass.connection);
            SqlDataAdapter DAdapter = new SqlDataAdapter(command);

            DataTable dt = new DataTable();
            DAdapter.Fill(dt);
            UserDataGridView.DataSource = dt;
        }


        private void SubmitButton_Click(object sender, EventArgs e)                     //Submit the action
        {
            try
            {
                if (CommandComboBox.SelectedIndex == 0)                                 //Add an account
                {
                    SqlCommand AddCommand = new SqlCommand("Insert into BoardGameUsers (BestScore,Username,Password,UserType,NameSurname,PhoneNumber,Address,City,Country,Email,Difficulty,CustomDifWidth,CustomDifHeight,Sahpe,Color) values (@bstscre,@usn,@pass,@usrtyp,@namesrn,@phnn,@add,@city,@contr,@email,@diff,@cdiffw,@cdiffh,@shape,@color)", SQLClass.connection);

                    AddCommand.Parameters.AddWithValue("@bstscre", 0);
                    AddCommand.Parameters.AddWithValue("@usn", UsernameTextbox.Text);
                    AddCommand.Parameters.AddWithValue("@pass", GlobalMethods.SHA256Converter(PasswordTextbox.Text));
                    AddCommand.Parameters.AddWithValue("@usrtyp", "user");
                    AddCommand.Parameters.AddWithValue("@namesrn", NameSurnameTextbox.Text);
                    AddCommand.Parameters.AddWithValue("@phnn", PhoneNumberTextbox.Text);
                    AddCommand.Parameters.AddWithValue("@add", AddressTextbox.Text);
                    AddCommand.Parameters.AddWithValue("@city", CityTextbox.Text);
                    AddCommand.Parameters.AddWithValue("@contr", CountryTextbox.Text);
                    AddCommand.Parameters.AddWithValue("@email", EmailTextbox.Text);
                    AddCommand.Parameters.AddWithValue("@diff", "1000");
                    AddCommand.Parameters.AddWithValue("@cdiffw", 0);
                    AddCommand.Parameters.AddWithValue("@cdiffh", 0);
                    AddCommand.Parameters.AddWithValue("@shape", "111");
                    AddCommand.Parameters.AddWithValue("@color", "111");
                    AddCommand.ExecuteNonQuery();

                    Display();
                }

                else if (CommandComboBox.SelectedIndex == 1)                             //Update an account
                {
                    SqlCommand UpdateCommand = new SqlCommand("Update BoardGameUsers set Username=@usn, Password=@pass, NameSurname=@namesrn, PhoneNumber=@phnn, Address=@add, City=@city, Country=@contr, Email=@email where username=@pusn", SQLClass.connection);

                    UpdateCommand.Parameters.AddWithValue("@usn", UsernameTextbox.Text);

                    if (PasswordTextbox.Text == UserDataGridView.CurrentRow.Cells["Password"].Value.ToString())
                        UpdateCommand.Parameters.AddWithValue("@pass", PasswordTextbox.Text);
                    else
                        UpdateCommand.Parameters.AddWithValue("@pass", GlobalMethods.SHA256Converter(PasswordTextbox.Text));

                    UpdateCommand.Parameters.AddWithValue("@namesrn", NameSurnameTextbox.Text);
                    UpdateCommand.Parameters.AddWithValue("@phnn", PhoneNumberTextbox.Text);
                    UpdateCommand.Parameters.AddWithValue("@add", AddressTextbox.Text);
                    UpdateCommand.Parameters.AddWithValue("@city", CityTextbox.Text);
                    UpdateCommand.Parameters.AddWithValue("@contr", CountryTextbox.Text);
                    UpdateCommand.Parameters.AddWithValue("@email", EmailTextbox.Text);
                    UpdateCommand.Parameters.AddWithValue("@pusn", UserDataGridView.CurrentRow.Cells["Username"].Value.ToString());
                    UpdateCommand.ExecuteNonQuery();

                    Display();
                }
                else if (CommandComboBox.SelectedIndex == 2)                            //Delete an account
                {
                    if (MessageBox.Show("The account will be deleted permanently.", "DELETE", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        SqlCommand DeleteCommand = new SqlCommand("Delete from BoardGameUsers where username=@usn", SQLClass.connection);
                        DeleteCommand.Parameters.AddWithValue("@usn", UsernameTextbox.Text);
                        DeleteCommand.ExecuteNonQuery();
                        Display();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }

        private void UsernameTextbox_TextChanged(object sender, EventArgs e)            //username only letters
        {
            UsernameTextbox.Text = string.Concat(UsernameTextbox.Text.Where(char.IsLetter));
        }

        private void CommandComboBox_SelectedIndexChanged(object sender, EventArgs e)    //Enable or disable username
        {
            if (CommandComboBox.SelectedIndex == 1)
                UsernameTextbox.Enabled = false;
            else
                UsernameTextbox.Enabled = true;
        }

        private void BackButton_Click(object sender, EventArgs e)                       //Back button
        {
            this.Owner.Show();
            this.Close();
        }

        private void UserDataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)                                      //Set textboxes with selected cell
        {
            UsernameTextbox.Text = UserDataGridView.CurrentRow.Cells["Username"].Value.ToString();
            PasswordTextbox.Text = UserDataGridView.CurrentRow.Cells["Password"].Value.ToString();
            NameSurnameTextbox.Text = UserDataGridView.CurrentRow.Cells["NameSurname"].Value.ToString();
            PhoneNumberTextbox.Text = UserDataGridView.CurrentRow.Cells["PhoneNumber"].Value.ToString();
            AddressTextbox.Text = UserDataGridView.CurrentRow.Cells["Address"].Value.ToString();
            CityTextbox.Text = UserDataGridView.CurrentRow.Cells["City"].Value.ToString();
            CountryTextbox.Text = UserDataGridView.CurrentRow.Cells["Country"].Value.ToString();
            EmailTextbox.Text = UserDataGridView.CurrentRow.Cells["Email"].Value.ToString();
        }

        private void MakeAdminButton_Click(object sender, EventArgs e)                                                                          //Make admin
        {
            SqlCommand UpdateCommand = new SqlCommand("Update BoardGameUsers set UserType=@usrtype where username=@usn", SQLClass.connection);

            UpdateCommand.Parameters.AddWithValue("@usn", UsernameTextbox.Text);
            UpdateCommand.Parameters.AddWithValue("@usrtype", "admin");
            UpdateCommand.ExecuteNonQuery();

            Display();

        }

        private void MakeUserButton_Click(object sender, EventArgs e)                                                                           //Make user
        {
            SqlCommand UpdateCommand = new SqlCommand("Update BoardGameUsers set UserType=@usrtype where username=@usn", SQLClass.connection);

            UpdateCommand.Parameters.AddWithValue("@usn", UsernameTextbox.Text);
            UpdateCommand.Parameters.AddWithValue("@usrtype", "user");
            UpdateCommand.ExecuteNonQuery();

            Display();
        }
    }
}