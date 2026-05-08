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

            this.TopMost = true;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAddVolunteer_Click(object sender, EventArgs e)
        {
            RegisterVolunteerForm registerForm = new RegisterVolunteerForm();

            registerForm.Show();

            this.Hide();

        }


        private void btnComputeAssignment_Click(object sender, EventArgs e)
        {
            int count = GetVolunteerCount();

            if (count < 55)
            {
                MessageBox.Show("Not enough volunteers yet.");
                return;
            }

            int[,] cost = BuildCostMatrix();

            int[] result = HungarianAlgorithm.Run(cost);

            SaveAssignments(result);

            MessageBox.Show("Assignment Completed!");
        }

        private int GetVolunteerCount()
        {
            int count = 0;

            using (SqlConnection con = DatabaseHelper.GetConnection())
            {
                con.Open();

                SqlCommand cmd = new SqlCommand(
                    "SELECT COUNT(*) FROM Volunteers", con);

                count = (int)cmd.ExecuteScalar();
            }

            return count;
        }

        private int[,] BuildCostMatrix()
        {
            // your SQL + matrix logic here
            return new int[1, 1]; // temporary placeholder
        }

        private void SaveAssignments(int[] result)
        {
            using (SqlConnection con = DatabaseHelper.GetConnection())
            {
                con.Open();

                // STEP 1: GET VOLUNTEERS
                List<int> volunteerIds = new List<int>();

                SqlCommand vcmd = new SqlCommand(
                    "SELECT VolunteerID FROM Volunteers ORDER BY VolunteerID", con);

                SqlDataReader vr = vcmd.ExecuteReader();
                while (vr.Read())
                {
                    volunteerIds.Add((int)vr[0]);
                }
                vr.Close();

                // STEP 2: GET BOOTHS
                List<int> boothIds = new List<int>();

                SqlCommand bcmd = new SqlCommand(
                    "SELECT BoothID FROM Booths ORDER BY BoothID", con);

                SqlDataReader br = bcmd.ExecuteReader();
                while (br.Read())
                {
                    boothIds.Add((int)br[0]);
                }
                br.Close();

                // capacity tracking
                Dictionary<int, int> boothCount = new Dictionary<int, int>();

                foreach (int b in boothIds)
                    boothCount[b] = 0;

                int maxPerBooth = 5;

                // 🔥 STEP 3: INSERT ASSIGNMENTS
                for (int i = 0; i < result.Length; i++)
                {
                    int boothIndex = result[i];
                    int boothID = boothIds[boothIndex];

                    if (boothCount[boothID] < maxPerBooth)
                    {
                        SqlCommand cmd = new SqlCommand(@"
                    INSERT INTO Assignments (VolunteerID, BoothID)
                    VALUES (@v, @b)", con);

                        cmd.Parameters.AddWithValue("@v", volunteerIds[i]);
                        cmd.Parameters.AddWithValue("@b", boothID);

                        cmd.ExecuteNonQuery();

                        boothCount[boothID]++;
                    }
                }
            }
        }


        private void btnDisplayResults_Click(object sender, EventArgs e)
        {
            ResultsForm form = new ResultsForm();
            form.Show();
            this.Hide();
        }
    }
}
