using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing; // For the Color.

namespace FunRunVolunteerSystem
{
    public partial class ResultsForm : Form
    {
        public ResultsForm()
        {
            InitializeComponent();
            dgvPreferencesResult.DefaultCellStyle.Font =
               new Font("Segoe UI", 9F);

            dgvPreferencesResult.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 10F, FontStyle.Bold);
        }

        private void ResultsForm_Load(object sender, EventArgs e)
        {
            LoadResults();

            dgvPreferencesResult.ClearSelection();

            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.WindowState = FormWindowState.Maximized;

            // ==============================
            // CLEANER DGV DESIGN
            // ==============================

            dgvDetails.BorderStyle = BorderStyle.None;
            dgvDetails.BackgroundColor = Color.White;
            dgvDetails.EnableHeadersVisualStyles = false;

            dgvDetails.ColumnHeadersDefaultCellStyle.BackColor = Color.RoyalBlue;
            dgvDetails.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            dgvDetails.RowHeadersVisible = false;
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

        // RESET DASHBOARD BUTTON COLORS

        private void ResetButtonColors()
        {
            btnViewPreferences.BackColor = Color.RoyalBlue;
            btnStatistics.BackColor = Color.RoyalBlue;
            btnCapacityMonitor.BackColor = Color.RoyalBlue;
            btnMatchRate.BackColor = Color.RoyalBlue;

            btnViewPreferences.ForeColor = Color.White;
            btnStatistics.ForeColor = Color.White;
            btnCapacityMonitor.ForeColor = Color.White;
            btnMatchRate.ForeColor = Color.White;
        }

        private void dgvPreferencesResult_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {

            ResetButtonColors();

            btnStatistics.BackColor = Color.White;
            btnStatistics.ForeColor = Color.RoyalBlue;

            lblInsightsTitle.Text = "Assignment Insights";

            lblInsightsDesc.Text =
                "Overview of volunteer assignment performance and matching results.";

            using (SqlConnection con = DatabaseHelper.GetConnection())
            {
                con.Open();

                SqlDataAdapter da = new SqlDataAdapter(@"
            SELECT 
                COUNT(*) AS TotalAssignments,
                
                SUM(CASE WHEN p.PreferenceScore = 1 THEN 1 ELSE 0 END) AS BestMatches,
                SUM(CASE WHEN p.PreferenceScore = 2 THEN 1 ELSE 0 END) AS SecondMatches,
                SUM(CASE WHEN p.PreferenceScore = 3 THEN 1 ELSE 0 END) AS ThirdMatches,
                SUM(CASE WHEN p.PreferenceScore >= 4 THEN 1 ELSE 0 END) AS PoorMatches
            FROM Assignments a
            INNER JOIN Preferences p 
                ON a.VolunteerID = p.VolunteerID 
                AND a.BoothID = p.BoothID
        ", con);

                DataTable dt = new DataTable();
                da.Fill(dt);

                // Convert to readable format (Metric - Value style)
                DataTable formatted = new DataTable();
                formatted.Columns.Add("Metric");
                formatted.Columns.Add("Value");

                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];

                    formatted.Rows.Add("Total Assignments", row["TotalAssignments"]);
                    formatted.Rows.Add("Best Matches (1st Choice)", row["BestMatches"]);
                    formatted.Rows.Add("Second Matches", row["SecondMatches"]);
                    formatted.Rows.Add("Third Matches", row["ThirdMatches"]);
                    formatted.Rows.Add("Poor Matches (4+)", row["PoorMatches"]);
                }

                dgvDetails.Visible = true;
                dgvDetails.DataSource = formatted;

                dgvDetails.AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void btnMatchRate_Click(object sender, EventArgs e)
        {

            ResetButtonColors();

            btnMatchRate.BackColor = Color.White;
            btnMatchRate.ForeColor = Color.RoyalBlue;

            lblInsightsTitle.Text = "Match Rate Analysis";

            lblInsightsDesc.Text =
                "Evaluation of assignment quality based on volunteer preferences.";

            using (SqlConnection con = DatabaseHelper.GetConnection())
            {
                con.Open();

                // Get raw match data
                SqlDataAdapter da = new SqlDataAdapter(@"
            SELECT 
                p.PreferenceScore
            FROM Assignments a
            INNER JOIN Preferences p 
                ON a.VolunteerID = p.VolunteerID 
                AND a.BoothID = p.BoothID
        ", con);

                DataTable raw = new DataTable();
                da.Fill(raw);

                int total = raw.Rows.Count;
                int best = 0, second = 0, third = 0, poor = 0;

                int totalCost = 0;

                foreach (DataRow row in raw.Rows)
                {
                    int score = Convert.ToInt32(row["PreferenceScore"]);
                    totalCost += score;

                    if (score == 1) best++;
                    else if (score == 2) second++;
                    else if (score == 3) third++;
                    else poor++;
                }

                double avg = (total > 0) ? (double)totalCost / total : 0;
                double bestRate = (total > 0) ? (double)best / total * 100 : 0;

                // Convert to table format
                DataTable dt = new DataTable();
                dt.Columns.Add("Metric");
                dt.Columns.Add("Value");

                dt.Rows.Add("Total Assignments", total);
                dt.Rows.Add("Best (1st Choice)", best);
                dt.Rows.Add("Second Choice", second);
                dt.Rows.Add("Third Choice", third);
                dt.Rows.Add("Poor (4+)", poor);
                dt.Rows.Add("Total Cost", totalCost);
                dt.Rows.Add("Average Cost", avg.ToString("0.00"));
                dt.Rows.Add("Optimal Rate (%)", bestRate.ToString("0.00"));

                dgvDetails.Visible = true;
                dgvDetails.DataSource = dt;
            }
        }

        private void btnViewPreferences_Click(object sender, EventArgs e)
        {

            ResetButtonColors();

            btnViewPreferences.BackColor = Color.White;
            btnViewPreferences.ForeColor = Color.RoyalBlue;

            lblInsightsTitle.Text = "Volunteer Preferences";

            lblInsightsDesc.Text =
                "Ranked booth preferences for the selected volunteer.";

            // Replaced the: if (dgvPreferencesResult.CurrentRow == null) into:

            if (dgvPreferencesResult.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a volunteer first.");
                return;
            }

            // Replaced the: int volunteerID =
            // Convert.ToInt32(dgvPreferencesResult.CurrentRow.Cells["VolunteerID"].Value); into

            int volunteerID =
                Convert.ToInt32(dgvPreferencesResult.SelectedRows[0].Cells["VolunteerID"].Value);

            // Replaced the: string volunteerName =
            // dgvPreferencesResult.CurrentRow.Cells["Volunteer"].Value.ToString(); into

            string volunteerName =
                dgvPreferencesResult.SelectedRows[0].Cells["Volunteer"].Value.ToString();

            using (SqlConnection con = DatabaseHelper.GetConnection())
            {
                con.Open();

                SqlDataAdapter da = new SqlDataAdapter(@"
            SELECT 
                p.PreferenceScore AS Rank,
                b.BoothName AS Booth
            FROM Preferences p
            INNER JOIN Booths b ON p.BoothID = b.BoothID
            WHERE p.VolunteerID = @VolunteerID
            ORDER BY p.PreferenceScore ASC
        ", con);

                da.SelectCommand.Parameters.AddWithValue("@VolunteerID", volunteerID);

                DataTable dt = new DataTable();
                da.Fill(dt);

                // optional: add title row style via label later
                dgvDetails.Visible = true;
                dgvDetails.DataSource = dt;
            }
        }
        

        private void btnCapacityMonitor_Click(object sender, EventArgs e)
        {

            ResetButtonColors();

            btnCapacityMonitor.BackColor = Color.White;
            btnCapacityMonitor.ForeColor = Color.RoyalBlue;

            lblInsightsTitle.Text = "Capacity Monitor";

            lblInsightsDesc.Text =
                "Current booth capacities, assignments, and remaining slots.";

            using (SqlConnection con = DatabaseHelper.GetConnection())
            {
                con.Open();

                SqlDataAdapter da = new SqlDataAdapter(@"
            SELECT 
                b.BoothName AS Booth,
                b.RequiredVolunteers AS Capacity,
                COUNT(a.VolunteerID) AS Assigned,
                (b.RequiredVolunteers - COUNT(a.VolunteerID)) AS Remaining,
                CAST(
                    (COUNT(a.VolunteerID) * 100.0 / b.RequiredVolunteers)
                AS DECIMAL(5,2)) AS FillRate
            FROM Booths b
            LEFT JOIN Assignments a 
                ON b.BoothID = a.BoothID
            GROUP BY b.BoothName, b.RequiredVolunteers
        ", con);

                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvDetails.Visible = true;
                dgvDetails.DataSource = dt;

                dgvDetails.AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void backbutton1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();

            this.Close();
        }
    }
}
