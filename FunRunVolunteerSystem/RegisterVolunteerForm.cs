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
    public partial class RegisterVolunteerForm : Form
    {
        Form1 mainForm;
        public RegisterVolunteerForm(Form1 form)
        {
            InitializeComponent();
            mainForm = form;
        }

        private void RegisterVolunteerForm_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.WindowState = FormWindowState.Maximized;
            this.TopMost = true;

            txtName.Text = "Enter your name here...";
            txtName.ForeColor = Color.Gray;

            this.ActiveControl = btnRegister;
        }

        // register button
        private void btnRegister_Click(object sender, EventArgs e)
        {
            int volunteerID = 0;

            using (SqlConnection con = DatabaseHelper.GetConnection())
            {
                con.Open();

                string query = 
                    @"INSERT INTO Volunteers (VolunteerName) OUTPUT INSERTED.VolunteerID VALUES (@name)";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@name", txtName.Text);

                volunteerID = (int)cmd.ExecuteScalar();
            }

            MessageBox.Show("Volunteer Registered Successfully!");

            PreferenceForm prefForm = new PreferenceForm(volunteerID);

            prefForm.Show();

            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
            "Go back to Main Menu? Unsaved data will be lost.",
            "Confirm",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                mainForm.Show();
                this.Close();
            }
        }

        private void txtName_Enter(object sender, EventArgs e)
        {
            if (txtName.Text.Contains("Enter your name"))
            {
                txtName.Text = "";
                txtName.ForeColor = Color.Black;
            }
        }

        // Placeholderr textz
        private void txtName_Leave(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                txtName.Text = "Enter your name here...";
                txtName.ForeColor = Color.Gray;
            }
        }
   
    }
}
