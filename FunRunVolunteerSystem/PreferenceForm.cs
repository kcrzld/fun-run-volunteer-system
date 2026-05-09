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


        }

        // save preferences button
        private void btnSave_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = DatabaseHelper.GetConnection())
            {
                con.Open();

                for (int i = 0; i < dgvPreferences.Rows.Count; i++)
                {
                    string boothName =
                        dgvPreferences.Rows[i]
                        .Cells[0]
                        .Value
                        .ToString();

                    int score = Convert.ToInt32(dgvPreferences.Rows[i].Cells[1].Value);

                    string boothQuery = "SELECT BoothID FROM Booths WHERE BoothName=@name";

                    SqlCommand boothCmd = new SqlCommand(boothQuery, con);

                    boothCmd.Parameters.AddWithValue("@name", boothName);

                    int boothID = (int)boothCmd.ExecuteScalar();

                    string insertQuery = @"INSERT INTO Preferences(VolunteerID, BoothID, PreferenceScore) VALUES(@volunteerID, @boothID, @score)";

                    SqlCommand insertCmd = new SqlCommand(insertQuery, con);

                    insertCmd.Parameters.AddWithValue("@volunteerID", volunteerID);

                    insertCmd.Parameters.AddWithValue("@boothID", boothID);

                    insertCmd.Parameters.AddWithValue("@score", score);

                    insertCmd.ExecuteNonQuery();
                }
            }
                
            MessageBox.Show("Preferences Saved Successfully!");
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
