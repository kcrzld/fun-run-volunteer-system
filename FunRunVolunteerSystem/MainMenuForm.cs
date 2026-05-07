using System;
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
            this.FormBorderStyle = FormBorderStyle.None;

            this.WindowState = FormWindowState.Maximized;

            this.TopMost = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAddVolunteer_Click(object sender, EventArgs e)
        {
            RegisterVolunteerForm registerForm =
                new RegisterVolunteerForm();

            registerForm.Show();

            this.Hide();
        }

        private void btnComputeAssignment_Click(object sender, EventArgs e)
        {

        }

        private void btnDisplayResults_Click(object sender, EventArgs e)
        {

        }
    }
}