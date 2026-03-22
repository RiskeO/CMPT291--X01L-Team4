using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Movie_Rental_System
{
    public partial class Login : Form
    {
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;

        public Login()
            {
            InitializeComponent();

            string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=CMP291Project;Trusted_Connection=yes;";


            try
            {
                myConnection = new SqlConnection(connectionString); // Timeout in seconds
                myConnection.Open(); // Open connection

                myCommand = new SqlCommand();
                myCommand.Connection = myConnection; // Link the command stream to the connection
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Database Error");
                this.Close();
            }
        }

        private void Login_Button_Click_1(object sender, EventArgs e)
        {
            string email = Email_textbox.Text.Trim();
            string password = Password_textbox.Text.Trim();

            myCommand.CommandText = "SELECT COUNT(*) FROM Employee e WHERE e.Email = @email AND e.password = @password";
            myCommand.Parameters.Clear();
            myCommand.Parameters.AddWithValue("@email", email);
            myCommand.Parameters.AddWithValue("@password", password);

            try
            {
                object result = myCommand.ExecuteScalar();
                int hits = Convert.ToInt32(result);

                if (hits >= 1)
                {
                    MessageBox.Show("Successfully Logged In!");

                    MainMenu mainMenu = new MainMenu(myConnection);
                    
                    this.Hide();
                    mainMenu.FormClosed += (s, args) => this.Close();
                    mainMenu.Show();
                }
                else
                {
                    MessageBox.Show("The username or password is not correct");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
        }
    }
}
