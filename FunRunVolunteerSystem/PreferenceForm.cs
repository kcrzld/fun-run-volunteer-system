using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunRunVolunteerSystem
{
    public partial class PreferenceForm : Form
    {
        private int volunteerID;
        public PreferenceForm(int vID)
        {
            InitializeComponent();
            volunteerID = vID;
        }

        private void PreferenceForm_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.WindowState = FormWindowState.Maximized;
            this.TopMost = false;

            // adding colums for the dgv
            dgvPreferences.Columns.Clear();

            dgvPreferences.Columns.Add("Booth", "Booth");

            dgvPreferences.Columns.Add("Score", "Preference Score");

            dgvPreferences.Columns["Booth"].ReadOnly = true;

            dgvPreferences.Rows.Add("Hydration 2km");
            dgvPreferences.Rows.Add("Hydration 4km");
            dgvPreferences.Rows.Add("Snack 3km");
            dgvPreferences.Rows.Add("Snack 5km");
            dgvPreferences.Rows.Add("Medical 1km");
            dgvPreferences.Rows.Add("Medical 3km");
            dgvPreferences.Rows.Add("Medical 5km");
            dgvPreferences.Rows.Add("Freebie 1km");
            dgvPreferences.Rows.Add("Freebie 3km");
            dgvPreferences.Rows.Add("Freebie 5km");
            dgvPreferences.Rows.Add("Finish Line");

            // UI FIX
            dgvPreferences.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPreferences.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvPreferences.RowHeadersVisible = false;
            dgvPreferences.AllowUserToResizeRows = false; 

            // DESIGN STYLE
            dgvPreferences.BackgroundColor = Color.White;

            dgvPreferences.BorderStyle = BorderStyle.None;

            dgvPreferences.EnableHeadersVisualStyles = false;

            dgvPreferences.ColumnHeadersDefaultCellStyle.BackColor =
                Color.FromArgb(0, 120, 215);

            dgvPreferences.ColumnHeadersDefaultCellStyle.ForeColor =
                Color.White;

            dgvPreferences.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 10, FontStyle.Bold);

            dgvPreferences.DefaultCellStyle.Font =
                new Font("Segoe UI", 10);

            dgvPreferences.DefaultCellStyle.SelectionBackColor =
                Color.LightSkyBlue;

            dgvPreferences.DefaultCellStyle.SelectionForeColor =
                Color.Black;

            dgvPreferences.GridColor = Color.LightGray;

            dgvPreferences.CellBorderStyle =
                DataGridViewCellBorderStyle.Single;

            dgvPreferences.ColumnHeadersBorderStyle =
                DataGridViewHeaderBorderStyle.None;
        }

        // save preferences button
        private void btnSave_Click(object sender, EventArgs e)
        {
            List<int> ranks = new List<int>();

            // temporary storage before SQL insert
            List<(string boothName, int rank)> preferences =
                new List<(string boothName, int rank)>();

            // validation phase

            for (int i = 0; i < dgvPreferences.Rows.Count; i++)
            {
                // validate booth
                if (dgvPreferences.Rows[i].Cells[0].Value == null)
                {
                    MessageBox.Show(
                        $"Row {i + 1}: Booth name is missing.",
                        "Input Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                string boothName =
                    dgvPreferences.Rows[i].Cells[0].Value.ToString();

                // validate rank input
                if (dgvPreferences.Rows[i].Cells[1].Value == null ||
                    !int.TryParse(
                        dgvPreferences.Rows[i].Cells[1].Value.ToString(),
                        out int rank))
                {
                    MessageBox.Show(
                        $"Row {i + 1} ({boothName}): Invalid rank.",
                        "Input Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                // validate range
                if (rank < 1 || rank > 11)
                {
                    MessageBox.Show(
                        $"Row {i + 1} ({boothName}): Rank must be between 1 and 11.",
                        "Invalid Range",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                ranks.Add(rank);

                // store temporarily
                preferences.Add((boothName, rank));
            }

            // check duplicates

            if (ranks.Distinct().Count() != ranks.Count)
            {
                MessageBox.Show(
                    "Duplicate ranks detected!\nEach booth must have a unique rank (1–11).",
                    "Ranking Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            // database insert phase

            using (SqlConnection con = DatabaseHelper.GetConnection())
            {
                con.Open();

                // delete old preferences first
                SqlCommand clearCmd = new SqlCommand(
                    "DELETE FROM Preferences WHERE VolunteerID = @id", con);

                clearCmd.Parameters.AddWithValue("@id", volunteerID);

                clearCmd.ExecuteNonQuery();

                foreach (var pref in preferences)
                {
                    // get booth ID
                    SqlCommand boothCmd = new SqlCommand(
                        "SELECT BoothID FROM Booths WHERE BoothName = @name", con);

                    boothCmd.Parameters.AddWithValue("@name", pref.boothName);

                    object result = boothCmd.ExecuteScalar();

                    if (result == null)
                    {
                        MessageBox.Show(
                            $"Booth '{pref.boothName}' not found in database.",
                            "Database Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);

                        return;
                    }

                    int boothID = (int)result;

                    // insert preference
                    SqlCommand insertCmd = new SqlCommand(@"
                INSERT INTO Preferences
                (VolunteerID, BoothID, PreferenceScore)
                VALUES
                (@volunteerID, @boothID, @score)", con);

                    insertCmd.Parameters.AddWithValue("@volunteerID", volunteerID);
                    insertCmd.Parameters.AddWithValue("@boothID", boothID);
                    insertCmd.Parameters.AddWithValue("@score", pref.rank);

                    try
                    {
                        insertCmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(
                            ex.Message,
                            "SQL Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);

                        return;
                    }
                }
            }

            MessageBox.Show(
                "Preferences Saved Successfully!",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            Form1 main = new Form1();
            main.Show();
            this.Close();
        }

        private void dgvPreferences_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
        "Are you sure you want to go back to the Main Menu?\n\nThis will remove the current volunteer record.",
        "Confirm Navigation",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                using (SqlConnection con = DatabaseHelper.GetConnection())
                {
                    con.Open();

                    // delete preferences first (if exists)
                    SqlCommand deletePrefs = new SqlCommand(
                        "DELETE FROM Preferences WHERE VolunteerID = @id", con);

                    deletePrefs.Parameters.AddWithValue("@id", volunteerID);
                    deletePrefs.ExecuteNonQuery();

                    // delete volunteer
                    SqlCommand deleteVolunteer = new SqlCommand(
                        "DELETE FROM Volunteers WHERE VolunteerID = @id", con);

                    deleteVolunteer.Parameters.AddWithValue("@id", volunteerID);
                    deleteVolunteer.ExecuteNonQuery();
                }

                Form1 main = new Form1();
                main.Show();
                this.Close();
            }
        }
    }
}
