using System;
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
        }
            
        private void LoadResults()
        {
            using (SqlConnection con = DatabaseHelper.GetConnection())
            {
                con.Open();

                SqlDataAdapter da = new SqlDataAdapter(@"
            SELECT 
                v.VolunteerName AS Volunteer,
                b.BoothName AS Booth
            FROM Assignments a
            INNER JOIN Volunteers v ON a.VolunteerID = v.VolunteerID
            INNER JOIN Booths b ON a.BoothID = b.BoothID
        ", con);

                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvPreferencesResult.Columns.Clear();
                dgvPreferencesResult.AutoGenerateColumns = true;

                dgvPreferencesResult.DataSource = dt;

                dgvPreferencesResult.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvPreferencesResult.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
        }

        private void dgvPreferencesResult_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
