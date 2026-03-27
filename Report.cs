using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Movie_Rental_System
{
    public partial class Report : Form
    {
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;

        public Report(SqlConnection connection)
        {
            InitializeComponent();

            myConnection = connection;
            myCommand = new SqlCommand();
            myCommand.Connection = myConnection;
        }

        private void add_columns(string[] array)
        {
            Data.Columns.Clear();

            foreach (string item in array)
            {
                DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();

                column.HeaderText = item;
                column.Name = item;

                Data.Columns.Add(column);
            }
        }

        private void Report_Query(string sql_command, string[] IDs, Dictionary<string, string> parameters)
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

                Data.Rows.Clear();

                while (myReader.Read())
                {
                    string[] row = new string[IDs.Length];
                    for (int i = 0; i < IDs.Length; i++)
                    {
                        row[i] = myReader[IDs[i]].ToString();
                    }
                    Data.Rows.Add(row);
                }

                myReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
        }

        private void Monthly_Sales_Report_Button_Click(object sender, EventArgs e)
        {
            string command = "Select TOP(12) DATEPART(YEAR, r.CheckoutTime) as [Year], DATENAME(MONTH, r.CheckoutTime) as [Month], SUM(m.Fee) as [Total Made] " +
                            "FROM Rental_Record r, Movie m Where r.MovieID = m.MovieID " +
                            "Group by DATEPART(YEAR, r.CheckoutTime), DATENAME(MONTH, r.CheckoutTime), MONTH(r.CheckoutTime), m.Fee " +
                            "ORDER BY DATEPART(YEAR, r.CheckoutTime),DATEPART(MONTH, r.CheckoutTime)";
            string[] ID = { "Year", "Month", "Total Made" };
            var parameters = new Dictionary<string, string> { };

            Report_Query(command, ID, parameters);
        }

        private void Sort_Movies_Button_Click(object sender, EventArgs e)
        {
            string command = "Select TOP(10) m.MovieName, m.MovieType, AVG(r.MovieRate) AS [Rating], m.Fee, (m.NumOfCopy - m.NumOfRented) AS [Available Copies] " +
                "FROM Movie m, Rental_Record r " +
                "WHERE m.MovieID = r.MovieID " +
                "Group by r.MovieID, m.MovieName, m.MovieType, r.MovieRate, m.Fee, m.NumOfCopy, m.NumOfRented ";
            if (Movie_Report_ComboBox.SelectedIndex == 0)
            {
                command += "ORDER BY m.MovieType DESC";
            }
            else if (Movie_Report_ComboBox.SelectedIndex == 1)
            {
                command += "ORDER BY m.MovieName DESC";
            }
            else if (Movie_Report_ComboBox.SelectedIndex == 2)
            {
                command += "ORDER BY m.Fee DESC";
            }
            else if (Movie_Report_ComboBox.SelectedIndex == 3)
            {
                command += "ORDER BY Rating DESC";
            }
            else
            {
                command += "ORDER BY r.MovieID DESC";
            }

            string[] ID = { "MovieName", "MovieType", "Rating", "Fee", "Available Copies" };
            var parameters = new Dictionary<string, string> { };

            Report_Query(command, ID, parameters);
        }

        private void Actor_Rating_Button_Click(object sender, EventArgs e)
        {
            string command = "Select TOP(10) a.ActorID AS [Actor ID], a.Name, r.ActorRate AS [Rating] " +
                            "FROM Actor_Rate r, Actor a " +
                            "WHERE r.ActorID = a.ActorID " +
                            "Group by r.ActorRate, a.Name, a.ActorID " +
                            "Order by r.ActorRate DESC";
            string[] ID = { "Actor ID", "Name", "Rating" };
            var parameters = new Dictionary<string, string> { };

            Report_Query(command, ID, parameters);
        }

        private void Most_Frequent_Customers_Button_Click(object sender, EventArgs e)
        {
            string command = "SELECT TOP(10) r.CustomerID AS [Customer ID], c.FirstName, c.LastName, COUNT(r.CustomerID) AS [Orders] " +
                "FROM Rental_Record r, Customer c " +
                "Where r.CustomerID = c.CustomerID " +
                "Group by r.CustomerID, c.FirstName, c.LastName " +
                "Order by [Orders] DESC";
            string[] ID = { "Customer ID", "FirstName", "LastName", "Orders" };
            var parameters = new Dictionary<string, string> { };

            Report_Query(command, ID, parameters);
        }

        private void Recommended_Movie_Button_Click(object sender, EventArgs e)
        {
            string first = Recommend_FirstName_TextBox.Text.Trim();
            string last = Recommend_LastName_TextBox.Text.Trim();

            string command = "Select TOP(10) m.MovieName, m.MovieType, AVG(r.MovieRate) AS Rating, m.Fee, (m.NumOfCopy - m.NumOfRented) AS [Available Copies] " +
                "From Movie m, Rental_Record r, " +
                    // Find the most frequently rented movie type by the given customer
                    "(Select TOP(1) m.MovieType, COUNT(*) AS NumOfMovie " +
                    "From Movie m, Rental_Record r " +
                    "Where m.MovieID = r.MovieID " +
                    "AND r.CustomerID IN " +
                        // Find CustomerID of the given name
                        "(Select c.CustomerID " +
                        "From Customer c " +
                        "Where c.LastName = @last and c.FirstName = @first) " +
                        "Group by m.MovieType, m.MovieID " +
                        "Order by NumOfMovie DESC) type " +
                    "Where m.MovieID = r.MovieID " +
                    "AND m.MovieType = type.MovieType " +
                    "Group by m.MovieID, r.MovieRate, m.MovieName, m.MovieType, m.Fee, m.NumOfCopy, m.NumOfRented " +
                    "Order by Rating DESC ";

            string[] ID = { "MovieName", "MovieType", "Rating", "Fee", "Available Copies"};
            var parameters = new Dictionary<string, string> {
                { "@first", first },
                { "@last",  last}
            };

            Report_Query(command, ID, parameters);
        }

        private void Home_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Movie_Report_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
