using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FunRunVolunteerSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.WindowState = FormWindowState.Maximized;
           // this.TopMost = true;
        }

        /*
         
                    ---------- BUTTONS -----------
         
        */

        // add volunteer button
        private void btnAddVolunteer_Click(object sender, EventArgs e)
        {
            RegisterVolunteerForm registerForm = new RegisterVolunteerForm(this);
            registerForm.Show();
            this.Hide();
        }

        // compute assignment button
        private void btnComputeAssignment_Click(object sender, EventArgs e)
        {
            int count = GetVolunteerCount();

            if (count < 55)
            {
                MessageBox.Show("Not enough volunteers yet.");
                return;
            }

            List<int> volunteerIds;
            List<int> boothSlots;
            Dictionary<int, int> slotToBooth;

            int[,] cost = BuildCostMatrix(out volunteerIds, out boothSlots, out slotToBooth);

            int[] result = HungarianAlgorithm.Run(cost);

            SaveAssignments(result, volunteerIds, boothSlots, slotToBooth);

            MessageBox.Show("Assignment Completed!");
        }

        // display results button
        private void btnDisplayResults_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = DatabaseHelper.GetConnection())
            {
                con.Open();

                SqlCommand cmd = new SqlCommand(
                    "SELECT COUNT(*) FROM Assignments", con);

                int count = (int)cmd.ExecuteScalar();

                if (count == 0)
                {
                    MessageBox.Show(
                        "No assignments found. Please compute assignments first before viewing results.",
                        "Warning",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }
            }

            ResultsForm form = new ResultsForm();
            form.Show();
            this.Hide();
        }

        // exit button
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        /*
         
                  ---------- HELPERS -----------
         
        */

        // method to get the volunteer's count
        private int GetVolunteerCount()
        {
            using (SqlConnection con = DatabaseHelper.GetConnection())
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Volunteers", con);

                return (int)cmd.ExecuteScalar();
            }
        }

        /* build cost matrix for the hungarian method - 
         * converts the real-world data (preferences) into a numerical 
         * matrix that the Hungarian algorithm can understand and process */
        private int[,] BuildCostMatrix(out List<int> volunteerIds, out List<int> boothSlots, out Dictionary<int, int> slotToBooth)
        {
            volunteerIds = new List<int>();
            boothSlots = new List<int>();
            slotToBooth = new Dictionary<int, int>();

            using (SqlConnection con = DatabaseHelper.GetConnection())
            {
                con.Open();

                // GET VOLUNTEERS
                SqlCommand vcmd = new SqlCommand(
                    "SELECT VolunteerID FROM Volunteers ORDER BY VolunteerID", con);

                SqlDataReader vr = vcmd.ExecuteReader();
                while (vr.Read())
                    volunteerIds.Add(Convert.ToInt32(vr[0]));
                vr.Close();

                // GET BOOTH SLOTS (FIXED)
                SqlCommand bcmd = new SqlCommand(
                    "SELECT BoothID FROM Booths ORDER BY BoothID", con);

                SqlDataReader br = bcmd.ExecuteReader();
                while (br.Read())
                {
                    int boothID = Convert.ToInt32(br[0]);

                    for (int i = 0; i < 5; i++)
                    {
                        int slotId = boothID * 10 + i; // unique slot ID

                        boothSlots.Add(slotId);
                        slotToBooth[slotId] = boothID;
                    }
                }
                br.Close();

                int n = Math.Max(volunteerIds.Count, boothSlots.Count);

                int[,] matrix = new int[n, n];

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (i < volunteerIds.Count && j < boothSlots.Count)
                        {
                            int slotId = boothSlots[j];
                            int boothID = slotToBooth[slotId];

                            SqlCommand pcmd = new SqlCommand(@"
                        SELECT PreferenceScore
                        FROM Preferences
                        WHERE VolunteerID = @v AND BoothID = @b", con);

                            pcmd.Parameters.AddWithValue("@v", volunteerIds[i]);
                            pcmd.Parameters.AddWithValue("@b", boothID);

                            object res = pcmd.ExecuteScalar();

                            matrix[i, j] = (res != null && res != DBNull.Value)
                                ? Convert.ToInt32(res)
                                : 11; // worst cost
                        }
                        else
                        {
                            matrix[i, j] = 11;
                        }
                    }
                }

                return matrix;
            }
        }

        // fixed saving with 5-slot capacity rule
        private void SaveAssignments(int[] result, List<int> volunteerIds, List<int> boothSlots, Dictionary<int, int> slotToBooth)
        {
            using (SqlConnection con = DatabaseHelper.GetConnection())
            {
                con.Open();

                SqlCommand delete = new SqlCommand("DELETE FROM Assignments", con);
                delete.ExecuteNonQuery();

                for (int i = 0; i < result.Length; i++)
                {
                    if (i >= volunteerIds.Count) continue;
                    if (result[i] >= boothSlots.Count) continue;

                    int volunteerId = volunteerIds[i];

                    int slotId = boothSlots[result[i]];
                    int boothId = slotToBooth[slotId];

                    SqlCommand insert = new SqlCommand(@"
                INSERT INTO Assignments (VolunteerID, BoothID)
                VALUES (@v, @b)", con);

                    insert.Parameters.AddWithValue("@v", volunteerId);
                    insert.Parameters.AddWithValue("@b", boothId);

                    insert.ExecuteNonQuery();
                }
            }
        }
    }
}