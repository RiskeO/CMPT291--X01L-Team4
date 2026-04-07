using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Movie_Rental_System
{
    public partial class Customer : Form
    {
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;
        public Customer(SqlConnection connection)
        {
            InitializeComponent();
            myConnection = connection;
            myCommand = new SqlCommand();
            myCommand.Connection = myConnection;
        }


        private void add_columns(string[] array)
        {
            CustomerData.Columns.Clear();

            foreach (string item in array)
            {
                DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();

                column.HeaderText = item;
                column.Name = item;

                CustomerData.Columns.Add(column);
            }
        }


        private void Customer_Query(string sql_command, string[] IDs, Dictionary<string, string> parameters)
        {
            try
            {
                myCommand.Parameters.Clear();
                myCommand.CommandText = sql_command;

                foreach (KeyValuePair<string, string> parameter in parameters)
                {
                    myCommand.Parameters.AddWithValue(parameter.Key, parameter.Value);
                }

                myReader = myCommand.ExecuteReader();

                add_columns(IDs);

                CustomerData.Rows.Clear();

                while (myReader.Read())
                {
                    string[] row = new string[IDs.Length];
                    for (int i = 0; i < IDs.Length; i++)
                    {
                        row[i] = myReader[IDs[i]].ToString();
                    }
                    CustomerData.Rows.Add(row);
                }

                myReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
        }

        private void Customer_Add(string sql_command, Dictionary<string, string> parameters)
        {
            bool openedHere = false;
            try
            {
                myCommand.Parameters.Clear();
                myCommand.CommandText = sql_command;

                foreach (KeyValuePair<string, string> parameter in parameters)
                {
                    myCommand.Parameters.AddWithValue(parameter.Key, parameter.Value);
                }

                if (myConnection.State != ConnectionState.Open)
                {
                    myConnection.Open();
                    openedHere = true;
                }

                int rowsAffected = myCommand.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Customer added successfully.", "Success");
                }
                else
                {
                    MessageBox.Show("Failed to add customer.", "Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
            finally
            {
                if (openedHere && myConnection.State == ConnectionState.Open)
                {
                    myConnection.Close();
                }
            }
        }

        private void Customer_Delete(string sql_command, Dictionary<string, string> parameters)
        {
            bool openedHere = false;
            try
            {
                myCommand.Parameters.Clear();
                myCommand.CommandText = sql_command;

                foreach (KeyValuePair<string, string> parameter in parameters)
                {
                    myCommand.Parameters.AddWithValue(parameter.Key, parameter.Value);
                }

                if (myConnection.State != ConnectionState.Open)
                {
                    myConnection.Open();
                    openedHere = true;
                }

                int rowsAffected = myCommand.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Customer deleted successfully.", "Success");
                }
                else
                {
                    MessageBox.Show("Failed to delete customer.", "Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
            finally
            {
                if (openedHere && myConnection.State == ConnectionState.Open)
                {
                    myConnection.Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SearchCustomerTab_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (LastNameTextBox.Text == "" || FirstNameTextBox.Text == "")
            {
                MessageBox.Show("Please enter both a first name and last name to search for a customer.", "Error");
                return;
            }

            else
            {
                string LastName = LastNameTextBox.Text;
                string FirstName = FirstNameTextBox.Text;

                string command = " SELECT AccountNum [Account #], CustomerID [CustomerID], Address [Address], City [City], CreationDate [Date Added]" +
                    "FROM Customer " +
                    "WHERE LastName LIKE @LastName AND FirstName LIKE @FirstName";

                string[] ID = { "Account #", "CustomerID", "Address", "City", "Date Added" };
                var parameters = new Dictionary<string, string> {
                {"@LastName", LastName},
                {"@FirstName", FirstName}
                };

                Customer_Query(command, ID, parameters);
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void ProvinceTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddCustomerButton_Click(object sender, EventArgs e)
        {
            if (FirstNameTextBox2.Text == "" || LastNameTextBox2.Text == "" || EmailTextBox.Text == "" ||
                AccNumTextBox.Text == "" || CcardNumTextBox.Text == "" || CcardExpTextBox.Text == "" ||
                CcardCvvTextBox.Text == "")
            {
                MessageBox.Show("Please fill in all fields  with * to add a customer.", "Error");
                return;
            }
            else
            {
                string LastName = LastNameTextBox2.Text;
                string FirstName = FirstNameTextBox2.Text;
                string Address = AddressTextBox.Text;
                string City = CityTextBox.Text;
                string Province = ProvinceTextBox.Text;
                string Pcode = PcodeTextBox.Text;
                string Email = EmailTextBox.Text;
                string AccNum = AccNumTextBox.Text;
                string CcardNum = CcardNumTextBox.Text;
                string CcardExp = CcardExpTextBox.Text;
                string CcardCvv = CcardCvvTextBox.Text;

                string command = "INSERT INTO Customer (CustomerID, LastName, FirstName, Address, City, Province, PostalCode, Email, AccountNum, CreditCardNum, CreditCardExp, CreditCardCvv) " +
                    "VALUES (NEXT VALUE FOR Customer_CustomerID_Seq, @LastName, @FirstName, @Address, @City, @Province, @Pcode, @Email, @AccNum, @CcardNum, @CcardExp, @CcardCvv)";
                var parameters = new Dictionary<string, string> {
                {"@LastName", LastName },
                {"@FirstName", FirstName },
                {"@Address", Address },
                {"@City", City },
                {"@Province", Province },
                {"@Pcode", Pcode },
                {"@Email", Email },
                {"@AccNum", AccNum },
                {"@CcardNum", CcardNum },
                {"@CcardExp", CcardExp },
                {"@CcardCvv", CcardCvv }
                };

                Customer_Add(command, parameters);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (CustIdTextBox.Text == "")
            {
                MessageBox.Show("Please enter a Customer ID delete a customer.", "Error");
                return;
            }

            else
            {
                string CustID = CustIdTextBox.Text;

                string command = "Delete FROM Actor_Rate " +
                    "WHERE RentalRecordID IN (SELECT RentalRecordID FROM Rental_Record WHERE CustomerID = @CustID) " +
                    "DELETE FROM Rental_Record " +
                    "WHERE CustomerID = @CustID " +
                    "DELETE FROM Customer_Queue " +
                    "WHERE CustomerID = @CustID " +
                    "DELETE FROM Customer_Phone " +
                    "WHERE CustomerID = @CustID " +
                    "DELETE FROM Customer " +
                    "WHERE CustomerID = @CustID";


                var parameters = new Dictionary<string, string> {
                {"@CustID", CustID},
                };

                Customer_Delete(command, parameters);

            }
        }

        private void LastNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void CustIdTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
