using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Reflection.Metadata;
using System.Text;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Movie_Rental_System
{
    public partial class Rental : Form
    {
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;

        public Rental(SqlConnection connection)
        {
            InitializeComponent();

            myConnection = connection;
            myCommand = new SqlCommand();
            myCommand.Connection = myConnection;

        }
        private void Home_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Rental_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void refresh_Queue(object sender, EventArgs e)
        {
            string query = "SELECT CustomerID, c.MovieID, SortNum AS [Queue Spot], MovieName AS [Movie Name], (NumOfCopy-NumOfRented) AS [Available Copies]" +
                " FROM Customer_Queue AS c, Movie AS m WHERE m.MovieID = c.MovieID" +
                " ORDER BY SortNum";
            string[] columns = { "CustomerID", "MovieID", "Queue Spot", "Movie Name", "Available Copies" };

            Show_Queue(query, columns);
        }

        private void add_columns(string[] array)
        {
            QueueData.Columns.Clear();

            foreach (string item in array)
            {
                DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();

                column.HeaderText = item;
                column.Name = item;

                QueueData.Columns.Add(column);
            }
        }

        private void Show_Queue(string sql_command, string[] IDs)
        {
            try
            {
                myCommand.Parameters.Clear();
                myCommand.CommandText = sql_command;

                myReader = myCommand.ExecuteReader();

                add_columns(IDs);

                QueueData.Rows.Clear();

                while (myReader.Read())
                {
                    string[] row = new string[IDs.Length];
                    for (int i = 0; i < IDs.Length; i++)
                    {
                        row[i] = myReader[IDs[i]].ToString();
                    }
                    QueueData.Rows.Add(row);
                }

                myReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
        }

        private void RentMovieButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(QueueData.CurrentRow.Cells[0].Value);

            if (QueueData.CurrentRow.Cells[0].Value == null)
            {
                System.Windows.Forms.MessageBox.Show("Please select a row to help a customer rent a movie.");
            }
            else if (Convert.ToUInt16(QueueData.CurrentRow.Cells[2].Value) > 1)
            {
                System.Windows.Forms.MessageBox.Show("Please choose the first in the queue.");
            }
            else if (Convert.ToUInt16(QueueData.CurrentRow.Cells[4].Value) < 1)
            {
                System.Windows.Forms.MessageBox.Show("Not enough movies availabe to rent.");
            }
            else
            {
                //Store values if needed
                string customerID = Convert.ToString(QueueData.CurrentRow.Cells[0].Value);
                string movieID = Convert.ToString(QueueData.CurrentRow.Cells[1].Value);

                //Create order
                create_order(customerID, movieID);
                //Adjust copies available
                adjust_copies(movieID);
                //Remove row from queue
                remove_row(customerID, movieID);
                //Change queue numbers
                change_queue(movieID);
            }
        }

        private void create_order(string customerID, string movieID) 
        {
            try
            {
                myCommand.Parameters.Clear();
                myCommand.CommandText = "INSERT INTO Rental_Record (EmployeeID, CustomerID, MovieID, CheckoutTime) VALUES ( @employeeID, @customerID, @movieID, GETDATE() )";

                string employeeID = "1000";
                myCommand.Parameters.AddWithValue("@employeeID", employeeID);
                myCommand.Parameters.AddWithValue("@movieID", movieID);
                myCommand.Parameters.AddWithValue("@customerID", customerID);

                myReader = myCommand.ExecuteReader();

                myReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
        }
        private void adjust_copies(string movieID)
        {
            try
            {
                myCommand.Parameters.Clear();
                myCommand.CommandText = "UPDATE Movie SET NumOfRented += 1 WHERE MovieID = @movieID";

                myCommand.Parameters.AddWithValue("@movieID", movieID);

                myReader = myCommand.ExecuteReader();

                myReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
        }
        private void remove_row(string customerID, string movieID)
        {
            try
            {
                myCommand.Parameters.Clear();
                myCommand.CommandText = "DELETE FROM Customer_Queue WHERE MovieID = @movieID AND CustomerID = @customerID";

                myCommand.Parameters.AddWithValue("@movieID", movieID);
                myCommand.Parameters.AddWithValue("@customerID", customerID);

                myReader = myCommand.ExecuteReader();

                myReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
        }
        private void change_queue(string movieID)
        {
            try
            {
                myCommand.Parameters.Clear();
                myCommand.CommandText = "UPDATE Customer_Queue SET SortNum -= 1 WHERE MovieID = @movieID";

                myCommand.Parameters.AddWithValue("@movieID", movieID);

                myReader = myCommand.ExecuteReader();

                myReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
        }
    }
}
