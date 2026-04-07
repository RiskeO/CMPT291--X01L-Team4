using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Movie_Rental_System
{
    public partial class Login : Form
    {
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;

        public Login(SqlConnection connection = null)
        {
            InitializeComponent();

            if (connection == null)
            {
                string connectionString = "user id=Team4;" + 
                        "password=CMPT291;" +
                        "Server=(localdb)\\MSSQLLocalDB;" +
                         "Database=CMP291Project;" +
                         "Trusted_Connection=True;" +
                         "TrustServerCertificate=True;"; 

                try
                {

                    myConnection = new SqlConnection(connectionString);
                    myConnection.Open(); // Open connection
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString(), "Database Error");
                    this.Close();
                }
            }
            else
            {
                myConnection = connection;
            }

            myCommand = new SqlCommand();
            myCommand.Connection = myConnection; // Link the command stream to the connection
        }

        private byte[] HashPassword(string password, byte[] salt, int iterations = 100000, int hashSize = 32)
        {
            return Rfc2898DeriveBytes.Pbkdf2(
                password,
                salt,
                iterations,
                HashAlgorithmName.SHA256,
                hashSize
            );
        }

        private bool ByteArraysEqual(byte[] a, byte[] b)
        {
            if (a == null || b == null || a.Length != b.Length)
                return false;

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != b[i])
                    return false;
            }

            return true;
        }

        private void Login_Process()
        {
            string email = Email_textbox.Text.Trim();
            string password = Password_textbox.Text.Trim();

            byte[] storedHash = null;
            byte[] enteredHash = null;

            // Retrieve stored hash and salt for the given email
            try
            {
                myCommand.CommandText = "SELECT PasswordHash, Salt FROM Employee WHERE Email = @email";
                myCommand.Parameters.Clear();
                myCommand.Parameters.AddWithValue("@email", email);

                // Use ExecuteReader to read the hash and salt from the database
                using (SqlDataReader reader = myCommand.ExecuteReader())
                {

                    // If a record is found, compute the hash of the entered password using the retrieved salt
                    if (reader.Read())
                    {
                        storedHash = (byte[])reader["PasswordHash"];
                        enteredHash = HashPassword(password, (byte[])reader["Salt"]);
                    }
                    // If no record is found, or if the hash comparison fails, show an error message
                    else
                    {
                        MessageBox.Show("The username or password is not correct");
                        return;
                    }
                }
            }
            // Catch any unexpected errors while trying to retrieve the hash and salt
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Password Error");
                return;
            }


            // Open Main Menu Form if Password & Email are correct
            try
            {
                // If the stored hash and the entered hash are both not null and match, open the main menu
                if (storedHash != null && enteredHash != null && ByteArraysEqual(storedHash, enteredHash))
                {

                    // Create an instance of the main menu form and pass the database connection to it
                    MainMenu mainMenu = new MainMenu(myConnection);
                 
                    mainMenu.FormClosed += (s, args) => this.Close();
                    mainMenu.Show();
                    this.Hide();

                }
                // If the hashes do not match, show an error message
                else
                {
                    MessageBox.Show("The username or password is not correct");
                    return;
                }
            }
            // Catch any unexpected errors while trying to open the main menu
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Form Error");
                return;
            }
        }

        private void Login_Button_Click_1(object sender, EventArgs e)
        {
            Login_Process();
        }

        private void Login_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login_Process();
            }
        }
    }
}
