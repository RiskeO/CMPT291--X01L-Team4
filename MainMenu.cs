using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Movie_Rental_System
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void Customer_Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Customer Page was not been added yet");

            /*
            Customer customer = new Customer();
            this.Hide();

            customer.FormClosed += (s, args) => this.Show;
            customer.Show();
            */
        }

        private void Movie_Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Movie Page was not been added yet");

            /*
            Movie movie = new Movie();
            this.Hide();

            movie.FormClosed += (s, args) => this.Show;
            movie.Show();
            */
        }

        private void Rental_Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Rental Page was not been added yet");

            /*
            Rental rental = new rental();
            this.Hide();

            rental.FormClosed += (s, args) => this.Show;
            rental.Show();
            */
        }

        private void Report_Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Report Page was not been added yet");

            /*
            Report report = new Report();
            this.Hide();

            report.FormClosed += (s, args) => this.Show;
            report.Show();
            */
        }
    }
}
