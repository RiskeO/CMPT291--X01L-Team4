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

            //this.Report_TabControl.SelectedIndex = 1;
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
            string LastName = LastNameTextBox.Text;
            string FirstName = FirstNameTextBox.Text;

            string command = " SELECT AccountNum [Account #], FirstName [First Name], LastName [Family Name], Address [Address], City [City], CreationDate [Date Added]" +
                "FROM Customer " +
                "WHERE LastName LIKE @LastName AND FirstName LIKE @FirstName";

            string[] ID = { "Account #", "First Name", "Family Name", "Address", "City", "Date Added" };
            var parameters = new Dictionary<string, string> {
                {"@LastName", "%" + LastName + "%" },
                {"@FirstName", "%" + FirstName + "%" }
            };

            Customer_Query(command, ID, parameters);
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void ProvinceTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
