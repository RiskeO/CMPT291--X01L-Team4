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

            this.Report_TabControl.SelectedIndex = 1;
        }

        private void Monthly_Sales_Report_Button_Click(object sender, EventArgs e)
        {
            string year = Sale_Report_Year_Picker.Value.Year.ToString();

            string command = " SELECT DATEPART(YEAR, r.CheckoutTime) as [Year], DATENAME(MONTH, r.CheckoutTime) as [Month], SUM(m.Fee) as [Total Made] " +
                            "FROM Rental_Record r, Movie m " +
                            "WHERE r.MovieID = m.MovieID " +
                            "AND DATEPART(YEAR, r.CheckoutTime) = @year " +
                            "GROUP BY DATEPART(YEAR, r.CheckoutTime), DATENAME(MONTH, r.CheckoutTime), MONTH(r.CheckoutTime), m.Fee " +
                            "ORDER BY DATEPART(YEAR, r.CheckoutTime),DATEPART(MONTH, r.CheckoutTime)";
            string[] ID = { "Year", "Month", "Total Made" };
            var parameters = new Dictionary<string, string> {
                { "@year", year }
            };

            Report_Query(command, ID, parameters);
        }

        private void Sort_Movies_Button_Click(object sender, EventArgs e)
        {
            string command = " SELECT TOP(5) WITH TIES m.MovieName [Name], m.MovieType [Type], AVG(r.MovieRate) AS [Rating], m.Fee, (m.NumOfCopy - m.NumOfRented) AS [Available Copies] " +
                "FROM Movie m, Rental_Record r " +
                "WHERE m.MovieID = r.MovieID " +
                "GROUP BY r.MovieID, m.MovieName, m.MovieType, r.MovieRate, m.Fee, m.NumOfCopy, m.NumOfRented ";
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

            string[] ID = { "Name", "Type", "Rating", "Fee", "Available Copies" };
            var parameters = new Dictionary<string, string> { };

            Report_Query(command, ID, parameters);
        }

        private void Actor_Rating_Button_Click(object sender, EventArgs e)
        {
            string command = " SELECT TOP(5) WITH TIES a.ActorID AS [Actor ID], a.Name, r.ActorRate AS [Rating] " +
                            "FROM Actor_Rate r, Actor a " +
                            "WHERE r.ActorID = a.ActorID " +
                            "GROUP BY r.ActorRate, a.Name, a.ActorID " +
                            "ORDER BY r.ActorRate DESC";
            string[] ID = { "Actor ID", "Name", "Rating" };
            var parameters = new Dictionary<string, string> { };

            Report_Query(command, ID, parameters);
        }

        private void Most_Frequent_Customers_Button_Click(object sender, EventArgs e)
        {
            //Use Account Number & If ties has to go over 5
            string command = " SELECT TOP(5) WITH TIES c.AccountNum AS [Account Number], c.FirstName [First Name], c.LastName [Family Name], COUNT(r.CustomerID) AS [Orders] " +
                "FROM Rental_Record r, Customer c " +
                "Where r.CustomerID = c.CustomerID " +
                "GROUP BY c.AccountNum, c.FirstName, c.LastName, r.CustomerID " +
                "ORDER BY [Orders] DESC ";
            string[] ID = { "Account Number", "First Name", "Family Name", "Orders" };
            var parameters = new Dictionary<string, string> { };

            Report_Query(command, ID, parameters);
        }

        private void Recommended_Movie_Button_Click(object sender, EventArgs e)
        {
            string accountNum = null;

            using (Report_Select_Customer_ID selectForm = new Report_Select_Customer_ID(myConnection))
            {
                DialogResult result = selectForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    accountNum = selectForm.SelectedAccountNum;
                }
            }

            if (accountNum == null)
            {
                MessageBox.Show("No customer selected.");
                return;
            }
            string command = " SELECT TOP (5) WITH TIES m.MovieName [Name], m.MovieType [Type], AVG(r.MovieRate) AS Rating, m.Fee, " +
                "(m.NumOfCopy - m.NumOfRented) AS [Available Copies] " +
                "FROM Movie m, Rental_Record r, " +
                    "( SELECT TOP (1) m.MovieType, COUNT(*) AS NumOfMovie " +
                    " FROM Movie m, Rental_Record r, Customer c " +
                    " WHERE m.MovieID = r.MovieID " +
                    " AND c.CustomerID = r.CustomerID " +
                    " AND c.AccountNum = @accountNum " +
                    " GROUP BY m.MovieType " +
                    " ORDER BY NumOfMovie DESC) type " +
                "WHERE m.MovieID = r.MovieID " +
                "AND m.MovieType = type.MovieType " +
                "GROUP BY m.MovieID, m.MovieName, m.MovieType, m.Fee, m.NumOfCopy, m.NumOfRented " +
                "ORDER BY Rating DESC";

            string[] ID = { "Name", "Type", "Rating", "Fee", "Available Copies" };
            var parameters = new Dictionary<string, string> {
                { "@accountNum", accountNum }
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

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
