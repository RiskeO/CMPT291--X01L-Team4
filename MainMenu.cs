using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Windows.Input;

namespace Movie_Rental_System
{
    public partial class MainMenu : Form
    {
        public SqlConnection myConnection;
        public SqlCommand myCommand;

        public MainMenu(SqlConnection connection)
        {
            InitializeComponent();

            myConnection = connection;
            myCommand = new SqlCommand();
            myCommand.Connection = myConnection;
        }

        private void Open_New_Form(Form form)
        {
            if (form == null) return;

            try
            {
                this.Hide();

                form.FormClosed += (s, args) => this.Show();
                form.Show();
            }
            catch (Exception ex)
            { 
                MessageBox.Show(ex.ToString(), "Error");
            }
        }

        private void Customer_Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Customer Page was not been added yet");

            /*
            Customer customer = new Customer(myConnection, myCommand, myReader);
            Open_New_Form(customer);
            */
        }

        private void Movie_Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Movie Page was not been added yet");

            /*
            Movie movie = new Movie(myConnection, myCommand, myReader);
            Open_New_Form(movie);
            */
        }

        private void Rental_Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Rental Page was not been added yet");

            /*
            Rental rental = new Rental(myConnection, myCommand, myReader);
            Open_New_Form(rental);
            */
        }

        private void Report_Button_Click(object sender, EventArgs e)
        {
            Report report = new Report(myConnection);
            Open_New_Form(report);
        }
    }
}
