using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices.JavaScript;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace test2
    /* you will need to change the code to it doesn't used the datagrid to do everything.
     * In the main you will select the movie, and that will be in all the other datagrid, which you can edit, add delete
     */
{



    public partial class Tab : Form
    {
        private string _selectedMovieID = "";
        private string _originalMovieName = "";
        private string connStr = "Server=(localdb)\\MSSQLLocalDB;Database=CMP291Project;Integrated Security=True;TrustServerCertificate=true;";
        public Tab()
        {
            InitializeComponent();
            //CallLoadMovies();


        }

        private void LoadMovies(string searchTitle, string searchType, decimal maxCost, decimal miniCost,
    int maxCopy, int miniCopy, int maxRent, int miniRent, DataGridView datagrid)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string sql = @"SELECT MovieID,MovieName, MovieType, Fee, NumOfCopy, NumOfRented
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



        private void Edit_Click(object sender, EventArgs e)
        {

        }

        private void M_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            //CallLoadMovies();
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
            //CallLoadMovies();
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

        private void E_search_TextChanged(object sender, EventArgs e)
        {

        }

        private void E_type_SelectedIndexChanged(object sender, EventArgs e)
        {

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

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string sql = @"UPDATE Movie
                       SET MovieName   = @name,
                           MovieType   = @type,
                           Fee         = @fee,
                           NumOfCopy   = @copy,
                           NumOfRented = @rent
                       WHERE MovieName = @originalName";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@name", E_search.Text.Trim());
                cmd.Parameters.AddWithValue("@type", E_type.Text.Trim());
                cmd.Parameters.AddWithValue("@fee", E_cost.Text.Trim());
                cmd.Parameters.AddWithValue("@copy", E_copy.Text.Trim());
                cmd.Parameters.AddWithValue("@rent", E_rent.Text.Trim());
                cmd.Parameters.AddWithValue("@originalName", _originalMovieName);

                conn.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Movie updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            _originalMovieName = "";
        }
        private void MB_delete_Click_Click(object sender, EventArgs e)
        {
            if (M_data.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a movie first.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string movieName = M_data.SelectedRows[0].Cells["MovieName"].Value.ToString();

            var confirm = MessageBox.Show($"Are you sure you want to delete '{movieName}'?",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes) return;

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM Movie WHERE MovieName = @name", conn);
                cmd.Parameters.AddWithValue("@name", movieName);
                conn.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Movie deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CallLoadMovies();
        }

        private void MB_edit_Click_Click(object sender, EventArgs e)
        {
            if (M_data.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a movie first.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow row = M_data.SelectedRows[0];

            _originalMovieName = row.Cells["MovieName"].Value.ToString().Trim();

            tabControl1.SelectedIndex = 2;


            E_search.Text = row.Cells["MovieName"].Value.ToString();
            E_type.Text = row.Cells["MovieType"].Value.ToString();
            E_cost.Text = row.Cells["Fee"].Value.ToString();
            E_copy.Text = row.Cells["NumOfCopy"].Value.ToString();
            E_rent.Text = row.Cells["NumOfRented"].Value.ToString();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void MB_assign_Click(object sender, EventArgs e)
        {
            if (M_data.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a movie first.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _selectedMovieID = M_data.SelectedRows[0].Cells["MovieID"].Value.ToString();

            tabControl1.SelectedIndex = 3; // adjust to your tab index

            LoadAssignedActors();
            LoadAvailableActors();
        }
        private void LoadAssignedActors()
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string sql = @"SELECT a.ActorID, a.Name
                       FROM Actor a
                       INNER JOIN Actor_Appear aa ON a.ActorID = aa.ActorID
                       WHERE aa.MovieID = @movieID";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@movieID", _selectedMovieID);
                conn.Open();

                list_assign.Items.Clear();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list_assign.Items.Add(new ActorItem(
                        reader["ActorID"].ToString(),
                        reader["Name"].ToString()
                    ));
                }
            }
        }

        private void LoadAvailableActors()
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string sql = @"SELECT a.ActorID, a.Name
                       FROM Actor a
                       WHERE a.ActorID NOT IN (
                           SELECT ActorID FROM Actor_Appear WHERE MovieID = @movieID
                       )";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@movieID", _selectedMovieID);
                conn.Open();

                list_ava.Items.Clear();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list_ava.Items.Add(new ActorItem(
                        reader["ActorID"].ToString(),
                        reader["Name"].ToString()
                    ));
                }
            }
        }
        private void list_ava_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void list_assign_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AA_add_Click(object sender, EventArgs e)
        {
            if (list_ava.SelectedItem == null)
            {
                MessageBox.Show("Please select an actor to add.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ActorItem actor = (ActorItem)list_ava.SelectedItem;

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Actor_Appear (MovieID, ActorID) VALUES (@movieID, @actorID)", conn);
                cmd.Parameters.AddWithValue("@movieID", _selectedMovieID);
                cmd.Parameters.AddWithValue("@actorID", actor.ID);
                conn.Open();
                cmd.ExecuteNonQuery();
            }

            LoadAssignedActors();
            LoadAvailableActors();
        }

        private void AA_remove_Click(object sender, EventArgs e)
        {
            if (list_assign.SelectedItem == null)
            {
                MessageBox.Show("Please select an actor to remove.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ActorItem actor = (ActorItem)list_assign.SelectedItem;

            var confirm = MessageBox.Show($"Are you sure you want to remove '{actor.Name}' from this movie?",
                "Confirm Remove", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes) return;

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM Actor_Appear WHERE MovieID = @movieID AND ActorID = @actorID", conn);
                cmd.Parameters.AddWithValue("@movieID", _selectedMovieID);
                cmd.Parameters.AddWithValue("@actorID", actor.ID);
                conn.Open();
                cmd.ExecuteNonQuery();
            }

            LoadAssignedActors();
            LoadAvailableActors();
        }
    }

    public class ActorItem
    {
        public string ID { get; set; }
        public string Name { get; set; }

        public ActorItem(string id, string name)
        {
            ID = id;
            Name = name;
        }

        public override string ToString() => Name;
    }
}
