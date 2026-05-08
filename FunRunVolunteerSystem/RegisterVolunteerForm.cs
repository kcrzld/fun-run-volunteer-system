using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FunRunVolunteerSystem
{
    public partial class RegisterVolunteerForm : Form
    {
        public RegisterVolunteerForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            int volunteerID = 0;

            using (SqlConnection con = DatabaseHelper.GetConnection())
            {
                con.Open();

                string query = @"INSERT INTO Volunteers (VolunteerName) OUTPUT INSERTED.VolunteerID VALUES (@name)";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@name", txtName.Text);

                volunteerID = (int)cmd.ExecuteScalar();
            }

            MessageBox.Show("Volunteer Registered Successfully!");

            PreferenceForm prefForm = new PreferenceForm(volunteerID);

            prefForm.Show();

            this.Hide();
        }

        private void RegisterVolunteerForm_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.Sizable;

            this.WindowState = FormWindowState.Maximized;

            this.TopMost = true;
        }
    }
}
