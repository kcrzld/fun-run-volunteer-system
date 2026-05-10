using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FunRunVolunteerSystem
{
    public partial class ResultsForm : Form
    {
        public ResultsForm()
        {
            InitializeComponent();
        }

        private void ResultsForm_Load(object sender, EventArgs e)
        {
            LoadResults();
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.WindowState = FormWindowState.Maximized;
        }

        

        // load results
        private void LoadResults()
        {
            using (SqlConnection con = DatabaseHelper.GetConnection())
            {
                con.Open();

                SqlDataAdapter da = new SqlDataAdapter(@"
            SELECT 
                v.VolunteerID,
                v.VolunteerName AS Volunteer,
                b.BoothName AS Booth
            FROM Assignments a
            INNER JOIN Volunteers v ON a.VolunteerID = v.VolunteerID
            INNER JOIN Booths b ON a.BoothID = b.BoothID
            ORDER BY
            CASE b.BoothName
                WHEN 'Hydration 1km' THEN 1
                WHEN 'Medical 1km' THEN 2
                WHEN 'Freebie 1km' THEN 3
                WHEN 'Hydration 2km' THEN 4
                WHEN 'Snack 3km' THEN 5
                WHEN 'Medical 3km' THEN 6
                WHEN 'Freebie 3km' THEN 7
                WHEN 'Hydration 4km' THEN 8
                WHEN 'Snack 5km' THEN 9
                WHEN 'Medical 5km' THEN 10
                WHEN 'Freebie 5km' THEN 11
                ELSE 999
            END,
            v.VolunteerName ASC
        ", con);

                DataTable dt = new DataTable();
                da.Fill(dt);

                // 🔥 IMPORTANT FIX: remove designer columns
                dgvPreferencesResult.Columns.Clear();

                dgvPreferencesResult.AutoGenerateColumns = true;
                dgvPreferencesResult.DataSource = dt;

                dgvPreferencesResult.AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill;

                dgvPreferencesResult.SelectionMode =
                    DataGridViewSelectionMode.FullRowSelect;

                // hide ID
                dgvPreferencesResult.Columns["VolunteerID"].Visible = false;

                // fix display order
                dgvPreferencesResult.Columns["Volunteer"].DisplayIndex = 0;
                dgvPreferencesResult.Columns["Booth"].DisplayIndex = 1;
            }
        }

        private void dgvPreferencesResult_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = DatabaseHelper.GetConnection())
            {
                con.Open();

                // total volunteers
                SqlCommand cmd1 = new SqlCommand(
                    "SELECT COUNT(*) FROM Volunteers", con);

                int totalVolunteers = (int)cmd1.ExecuteScalar();

                // assigned volunteers
                SqlCommand cmd2 = new SqlCommand(
                    "SELECT COUNT(*) FROM Assignments", con);

                int assigned = (int)cmd2.ExecuteScalar();

                // total booths
                SqlCommand cmd3 = new SqlCommand(
                    "SELECT COUNT(*) FROM Booths", con);

                int totalBooths = (int)cmd3.ExecuteScalar();

                MessageBox.Show(
                    "Total Volunteers: " + totalVolunteers +
                    "\nAssigned Volunteers: " + assigned +
                    "\nTotal Booths: " + totalBooths,
                    "Assignment Statistics",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void btnMatchRate_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = DatabaseHelper.GetConnection())
            {
                con.Open();

                SqlCommand cmd = new SqlCommand(@"
            SELECT 
                a.VolunteerID,
                a.BoothID,
                p.PreferenceScore
            FROM Assignments a
            LEFT JOIN Preferences p
                ON a.VolunteerID = p.VolunteerID
               AND a.BoothID = p.BoothID
        ", con);

                SqlDataReader reader = cmd.ExecuteReader();

                int total = 0;
                int best = 0;
                int second = 0;
                int third = 0;
                int poor = 0;
                int totalCost = 0;

                while (reader.Read())
                {
                    int score = (reader["PreferenceScore"] == DBNull.Value)
                        ? 11
                        : Convert.ToInt32(reader["PreferenceScore"]);

                    total++;
                    totalCost += score;

                    if (score == 1) best++;
                    else if (score == 2) second++;
                    else if (score == 3) third++;
                    else poor++;
                }

                double avg = total == 0 ? 0 : (double)totalCost / total;
                double bestRate = total == 0 ? 0 : (double)best / total * 100;

                MessageBox.Show(
                    $"Total: {total}\n" +
                    $"Best: {best}\nSecond: {second}\nThird: {third}\nPoor: {poor}\n\n" +
                    $"Total Cost: {totalCost}\n" +
                    $"Average Cost: {avg:0.00}\n" +
                    $"Optimal Rate: {bestRate:0.00}%",
                    "Hungarian Analysis"
                );
            }
        }

        private void btnViewPreferences_Click(object sender, EventArgs e)
        {
            if (dgvPreferencesResult.CurrentRow == null)
            {
                MessageBox.Show("Select a volunteer first.");
                return;
            }

            int volunteerID =
                Convert.ToInt32(dgvPreferencesResult.CurrentRow.Cells["VolunteerID"].Value);

            using (SqlConnection con = DatabaseHelper.GetConnection())
            {
                con.Open();

                SqlDataAdapter da = new SqlDataAdapter(@"
            SELECT 
                p.PreferenceScore,
                b.BoothName
            FROM Preferences p
            INNER JOIN Booths b ON p.BoothID = b.BoothID
            WHERE p.VolunteerID = @VolunteerID
            ORDER BY p.PreferenceScore ASC
        ", con);

                da.SelectCommand.Parameters.AddWithValue("@VolunteerID", volunteerID);

                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvDetails.Visible = true;
                dgvDetails.DataSource = dt;

                dgvDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }
        

        private void btnCapacityMonitor_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = DatabaseHelper.GetConnection())
            {
                con.Open();

                SqlCommand cmd = new SqlCommand(@"
            SELECT 
                b.BoothName,
                COUNT(a.AssignmentID) AS AssignedCount
            FROM Booths b
            LEFT JOIN Assignments a
                ON b.BoothID = a.BoothID
            GROUP BY b.BoothName
        ", con);

                SqlDataReader reader = cmd.ExecuteReader();

                string result = "";

                while (reader.Read())
                {
                    result +=
                        reader["BoothName"].ToString() +
                        " → " +
                        reader["AssignedCount"].ToString() +
                        " Volunteers\n";
                }

                MessageBox.Show(
                    result,
                    "Booth Capacity Monitor",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
    }
}
