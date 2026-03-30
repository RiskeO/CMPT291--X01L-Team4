using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace test2
{
    public partial class Tab : Form
    {
        private string connStr = "Server=DEVICE2;Database=CMP291Project;Integrated Security=True;TrustServerCertificate=true;";
        public Tab()
        {
            InitializeComponent();
            CallLoadMovies();
            CallLoadMoviesDelete();
            CallLoadMoviesEdit();

        }

        private void LoadMovies(string searchTitle, string searchType, decimal maxCost, decimal miniCost,
    int maxCopy, int miniCopy, int maxRent, int miniRent, DataGridView datagrid)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string sql = @"SELECT MovieName, MovieType, Fee, NumOfCopy, NumOfRented
                       FROM Movie
                       WHERE MovieName LIKE @title
                       AND (@type = '' OR MovieType = @type)
                       AND Fee >= @minCost AND Fee <= @maxCost
                       AND NumOfCopy >= @minCopy AND NumOfCopy <= @maxCopy
                       AND NumOfRented >= @minRent AND NumOfRented <= @maxRent
                       ORDER BY MovieName";

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.SelectCommand.Parameters.AddWithValue("@title", "%" + searchTitle + "%");
                da.SelectCommand.Parameters.AddWithValue("@type", searchType);
                da.SelectCommand.Parameters.AddWithValue("@minCost", miniCost);
                da.SelectCommand.Parameters.AddWithValue("@maxCost", maxCost);
                da.SelectCommand.Parameters.AddWithValue("@minCopy", miniCopy);
                da.SelectCommand.Parameters.AddWithValue("@maxCopy", maxCopy);
                da.SelectCommand.Parameters.AddWithValue("@minRent", miniRent);
                da.SelectCommand.Parameters.AddWithValue("@maxRent", maxRent);

                DataTable dt = new DataTable();
                da.Fill(dt);

                datagrid.DataSource = dt;
            }
        }

        private void CallLoadMovies()
        {
            LoadMovies(
                M_search.Text.Trim(),
                M_type.SelectedItem != null ? M_type.SelectedItem.ToString() : "",
                S_max_cost.Value, S_mini_cost.Value,
                (int)S_max_copy.Value, (int)S_mini_copy.Value,
                (int)S_max_rent.Value, (int)S_mini_rent.Value, M_data);
        }

        private void CallLoadMoviesDelete()
        {
            LoadMovies(
                D_search.Text.Trim(),
                D_type.SelectedItem != null ? D_type.SelectedItem.ToString() : "",
                D_man_cost.Value, D_mini_cost.Value,
                (int)D_max_copy.Value, (int)D_mini_copy.Value,
                (int)D_max_rent.Value, (int)D_mini_rent.Value,
                D_data
            );
        }

        private void CallLoadMoviesEdit()//
        {
            LoadMovies(
                E_search.Text.Trim(),
                E_type.SelectedItem != null ? E_type.SelectedItem.ToString() : "",
                100, 0,
                100, 0,
                100, 0,
                dataGridView4
            );
        }

        private void Edit_Click(object sender, EventArgs e)
        {

        }

        private void M_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            CallLoadMovies();
        }

        private void MB_search_Click(object sender, EventArgs e)
        {
            CallLoadMovies();
        }

        private void M_data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void M_search_TextChanged(object sender, EventArgs e)
        {
            CallLoadMovies();
        }

        private void S_max_copy_ValueChanged(object sender, EventArgs e)
        {

        }

        private void S_mini_copy_ValueChanged(object sender, EventArgs e)
        {

        }

        private void S_max_rent_ValueChanged(object sender, EventArgs e)
        {

        }

        private void S_mini_rent_ValueChanged(object sender, EventArgs e)
        {

        }

        private void S_max_cost_ValueChanged(object sender, EventArgs e)
        {

        }

        private void S_mini_cost_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Search_Click(object sender, EventArgs e)
        {

        }

        private void A_search_TextChanged(object sender, EventArgs e)//
        {

        }

        private void A_type_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void A_cost_TextChanged(object sender, EventArgs e)
        {

        }

        private void A_data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AB_add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(A_search.Text))
            {
                MessageBox.Show("Please enter a movie name.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string sql = @"INSERT INTO Movie (MovieName, MovieType, Fee, NumOfCopy, NumOfRented)
                       VALUES (@name, @type, @fee, @copy, @rent)";

                SqlDataAdapter da = new SqlDataAdapter();
                da.InsertCommand = new SqlCommand(sql, conn);
                da.InsertCommand.Parameters.AddWithValue("@name", A_search.Text.Trim());
                da.InsertCommand.Parameters.AddWithValue("@type", A_type.SelectedItem != null ? A_type.SelectedItem.ToString() : "");
                da.InsertCommand.Parameters.AddWithValue("@fee", A_cost.Text.Trim());
                da.InsertCommand.Parameters.AddWithValue("@copy", A_copy.Text.Trim());
                da.InsertCommand.Parameters.AddWithValue("@rent", A_rent.Text.Trim());

                conn.Open();
                da.InsertCommand.ExecuteNonQuery();
            }

            MessageBox.Show("Movie added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            AB_clear_Click(sender, e);
        }

        private void AB_clear_Click(object sender, EventArgs e)
        {
            A_search.Clear();
            A_type.SelectedIndex = -1;
            A_cost.Clear();
            A_copy.Clear();
            A_rent.Clear();
        }

        private void A_copy_TextChanged(object sender, EventArgs e)
        {

        }

        private void A_rent_TextChanged(object sender, EventArgs e)
        {

        }

        private void D_search_TextChanged(object sender, EventArgs e)
        {
            CallLoadMoviesDelete();
        }

        private void D_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            CallLoadMoviesDelete();
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DB_delete_Click(object sender, EventArgs e)
        {
            if (D_data.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a movie to delete.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string sql = @"INSERT INTO Movie (MovieName, MovieType, Fee, NumOfCopy, NumOfRented)
                       VALUES (@name, @type, @fee, @copy, @rent)";
                SqlDataAdapter da = new SqlDataAdapter();


                da.DeleteCommand = new SqlCommand("DELETE FROM Movie WHERE MovieName = @name", conn);
                da.DeleteCommand.Parameters.AddWithValue("@name", D_search.Text.Trim());
                conn.Open();
                da.DeleteCommand.ExecuteNonQuery();

            }
            CallLoadMoviesDelete();

        }

        private void DB_clear_Click(object sender, EventArgs e)
        {
            D_search.Clear();
            D_type.SelectedIndex = -1;
            D_man_cost.Value = D_man_cost.Maximum;
            D_mini_cost.Value = 0;
            D_max_copy.Value = D_max_copy.Maximum;
            D_mini_copy.Value = 0;
            D_max_rent.Value = D_max_rent.Maximum;
            D_mini_rent.Value = 0;
            D_data.DataSource = null;
        }

        private void D_max_copy_ValueChanged(object sender, EventArgs e)
        {
            CallLoadMoviesDelete();
        }

        private void D_mini_copy_ValueChanged(object sender, EventArgs e)
        {
            CallLoadMoviesDelete();
        }

        private void D_max_rent_ValueChanged(object sender, EventArgs e)
        {
            CallLoadMoviesDelete();
        }

        private void D_mini_rent_ValueChanged(object sender, EventArgs e)
        {
            CallLoadMoviesDelete();
        }

        private void D_man_cost_ValueChanged(object sender, EventArgs e)
        {
            CallLoadMoviesDelete();
        }

        private void D_mini_cost_ValueChanged(object sender, EventArgs e)
        {
            CallLoadMoviesDelete();
        }

        private void E_search_TextChanged(object sender, EventArgs e)
        {
            CallLoadMoviesEdit();
        }

        private void E_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            CallLoadMoviesEdit();
        }

        private void E_copy_TextChanged(object sender, EventArgs e)
        {

        }

        private void E_rent_TextChanged(object sender, EventArgs e)
        {

        }

        private void E_cost_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)//
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dataGridView4.Rows[e.RowIndex];
            E_search.Text = row.Cells["MovieName"].Value.ToString();
            E_type.Text = row.Cells["MovieType"].Value.ToString();
            E_cost.Text = row.Cells["Fee"].Value.ToString();
            E_copy.Text = row.Cells["NumOfCopy"].Value.ToString();
            E_rent.Text = row.Cells["NumOfRented"].Value.ToString();
        }

        private void E_cancel_Click(object sender, EventArgs e)
        {
            E_search.Clear();
            E_type.SelectedIndex = -1;
            E_cost.Clear();
            E_copy.Clear();
            E_rent.Clear();
        }

        private void EB_change_Click(object sender, EventArgs e)
        {
            if (dataGridView4.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a movie to edit.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string originalName = dataGridView4.SelectedRows[0].Cells["MovieName"].Value.ToString();

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string sql = @"UPDATE Movie
                       SET MovieName  = @name,
                           MovieType  = @type,
                           Fee        = @fee,
                           NumOfCopy  = @copy,
                           NumOfRented = @rent
                       WHERE MovieName = @originalName";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@name", E_search.Text.Trim());
                cmd.Parameters.AddWithValue("@type", E_type.Text.Trim());
                cmd.Parameters.AddWithValue("@fee", E_cost.Text.Trim());
                cmd.Parameters.AddWithValue("@copy", E_copy.Text.Trim());
                cmd.Parameters.AddWithValue("@rent", E_rent.Text.Trim());
                cmd.Parameters.AddWithValue("@originalName", originalName);

                conn.Open();
                cmd.ExecuteNonQuery();
            }

            CallLoadMoviesEdit();
        }
    }
}
