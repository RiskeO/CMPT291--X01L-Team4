using Microsoft.Data.SqlClient;

namespace Movie_Rental_System
{
    public partial class Report_Select_Customer_ID : Form
    {
        DataGridViewRow selectedRow = null;

        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;

        public string SelectedAccountNum { get; private set; } = null;
        public Report_Select_Customer_ID(SqlConnection connection)
        {
            InitializeComponent();

            Customer_GridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Customer_GridView.MultiSelect = false;
            Customer_GridView.ReadOnly = true;
            Customer_GridView.AllowUserToAddRows = false;

            myConnection = connection;
            myCommand = new SqlCommand();
            myCommand.Connection = myConnection;
        }

        private void add_columns(string[] array)
        {
            Customer_GridView.Columns.Clear();

            foreach (string item in array)
            {
                DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();

                column.HeaderText = item;
                column.Name = item;

                Customer_GridView.Columns.Add(column);
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

                Customer_GridView.Rows.Clear();

                while (myReader.Read())
                {
                    string[] row = new string[IDs.Length];
                    for (int i = 0; i < IDs.Length; i++)
                    {
                        row[i] = myReader[IDs[i]].ToString();
                    }
                    Customer_GridView.Rows.Add(row);
                }

                myReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
        }

        private void Submit_button_Click(object sender, EventArgs e)
        {
            selectedRow = null;

            // Add Select from possible users if same first&last name
            string first = Recommend_FirstName_TextBox.Text.Trim();
            string last = Recommend_LastName_TextBox.Text.Trim();


            string command = "Select c.AccountNum [Account #], c.FirstName [First Name], c.LastName [Last Name], c.Email, c.Address, c.City, c.Province, c.PostalCode " +
                "FROM Customer c " +
                "WHERE c.FirstName = @first AND c.LastName = @last";
            string[] ID = { "Account #", "First Name", "Last Name", "Email", "Address", "City", "Province", "PostalCode" };
            var parameters = new Dictionary<string, string> {
                { "@first", first },
                { "@last",  last}
            };

            Report_Query(command, ID, parameters);
        }

        private void Done_Button_Click(object sender, EventArgs e)
        {
            if (Customer_GridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a user. To leave this screen press the X at the top right of the screen");
                return;
            }

            SelectedAccountNum = Customer_GridView.SelectedRows[0].Cells[0].Value?.ToString();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Report_Select_Customer_ID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Submit_button_Click(sender, e);
                e.Handled = true; // Prevents the default "ding" sound
            }
        }

        private void Recommend_LastName_TextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
