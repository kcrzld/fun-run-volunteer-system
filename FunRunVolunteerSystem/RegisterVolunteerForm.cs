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
            using (SqlConnection con = DatabaseHelper.GetConnection())
            {
                con.Open();

                string query =
                "INSERT INTO Volunteers (VolunteerName) VALUES (@name)";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@name", txtName.Text);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Volunteer Registered Successfully!");

            txtName.Clear();
        }

        private void RegisterVolunteerForm_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;

            this.WindowState = FormWindowState.Maximized;

            this.TopMost = true;
        }
    }
}
