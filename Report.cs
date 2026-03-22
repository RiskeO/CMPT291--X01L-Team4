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

        private void Report_Query(string sql_command, string[] IDs)
        {
            try
            {
                myCommand.CommandText = sql_command;
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

        private void Option1_Button_Click(object sender, EventArgs e)
        {
            string command = "Select * from Movie";
            string[] ID = { "MovieID", "MovieName", "MovieType", "Fee", "NumOfRented" };

            Report_Query(command, ID);
        }

        private void Option2_Button_Click(object sender, EventArgs e)
        {
            string command = "Select * from Movie";
            string[] ID = { "MovieID", "MovieName", "MovieType", "Fee", "NumOfRented" };

            Report_Query(command, ID);
        }

        private void Option3_Button_Click(object sender, EventArgs e)
        {
            string command = "Select * from Movie";
            string[] ID = { "MovieID", "MovieName", "MovieType", "Fee", "NumOfRented" };

            Report_Query(command, ID);
        }

        private void Option4_Button_Click(object sender, EventArgs e)
        {
            string command = "Select * from Movie";
            string[] ID = { "MovieID", "MovieName", "MovieType", "Fee", "NumOfRented" };

            Report_Query(command, ID);
        }

        private void Option5_Button_Click(object sender, EventArgs e)
        {
            string command = "Select * from Movie";
            string[] ID = { "MovieID", "MovieName", "MovieType", "Fee", "NumOfRented" };

            Report_Query(command, ID);
        }

        private void Home_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
