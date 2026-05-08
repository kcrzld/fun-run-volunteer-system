using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        }

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
    }
}
