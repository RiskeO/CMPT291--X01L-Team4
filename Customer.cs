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
    public partial class Customer : Form
    {
        public SqlConnection myConnection;
        public Customer(SqlConnection connection)
        {
            InitializeComponent();
            myConnection = connection;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
