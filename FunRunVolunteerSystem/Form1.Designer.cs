namespace FunRunVolunteerSystem
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDisplayResults = new System.Windows.Forms.Button();
            this.btnComputeAssignment = new System.Windows.Forms.Button();
            this.btnAddVolunteer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(486, 693);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(367, 91);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit             ";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDisplayResults
            // 
            this.btnDisplayResults.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDisplayResults.BackColor = System.Drawing.Color.Transparent;
            this.btnDisplayResults.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDisplayResults.BackgroundImage")));
            this.btnDisplayResults.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDisplayResults.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisplayResults.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplayResults.ForeColor = System.Drawing.Color.White;
            this.btnDisplayResults.Location = new System.Drawing.Point(486, 583);
            this.btnDisplayResults.Name = "btnDisplayResults";
            this.btnDisplayResults.Size = new System.Drawing.Size(367, 91);
            this.btnDisplayResults.TabIndex = 0;
            this.btnDisplayResults.Text = "   Display Results";
            this.btnDisplayResults.UseVisualStyleBackColor = false;
            this.btnDisplayResults.Click += new System.EventHandler(this.btnDisplayResults_Click);
            // 
            // btnComputeAssignment
            // 
            this.btnComputeAssignment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnComputeAssignment.BackColor = System.Drawing.Color.Transparent;
            this.btnComputeAssignment.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnComputeAssignment.BackgroundImage")));
            this.btnComputeAssignment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnComputeAssignment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComputeAssignment.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComputeAssignment.ForeColor = System.Drawing.Color.White;
            this.btnComputeAssignment.Location = new System.Drawing.Point(486, 470);
            this.btnComputeAssignment.Name = "btnComputeAssignment";
            this.btnComputeAssignment.Size = new System.Drawing.Size(367, 91);
            this.btnComputeAssignment.TabIndex = 0;
            this.btnComputeAssignment.Text = "            Compute Assignments  ";
            this.btnComputeAssignment.UseVisualStyleBackColor = false;
            this.btnComputeAssignment.Click += new System.EventHandler(this.btnComputeAssignment_Click);
            // 
            // btnAddVolunteer
            // 
            this.btnAddVolunteer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddVolunteer.BackColor = System.Drawing.Color.Transparent;
            this.btnAddVolunteer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddVolunteer.BackgroundImage")));
            this.btnAddVolunteer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddVolunteer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddVolunteer.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddVolunteer.ForeColor = System.Drawing.Color.White;
            this.btnAddVolunteer.Location = new System.Drawing.Point(486, 361);
            this.btnAddVolunteer.Name = "btnAddVolunteer";
            this.btnAddVolunteer.Size = new System.Drawing.Size(367, 90);
            this.btnAddVolunteer.TabIndex = 0;
            this.btnAddVolunteer.Text = "  Add Volunteer";
            this.btnAddVolunteer.UseVisualStyleBackColor = false;
            this.btnAddVolunteer.Click += new System.EventHandler(this.btnAddVolunteer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1342, 1003);
            this.Controls.Add(this.btnComputeAssignment);
            this.Controls.Add(this.btnDisplayResults);
            this.Controls.Add(this.btnAddVolunteer);
            this.Controls.Add(this.btnExit);
            this.Name = "Form1";
            this.Text = "Main Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDisplayResults;
        private System.Windows.Forms.Button btnComputeAssignment;
        private System.Windows.Forms.Button btnAddVolunteer;
    }
}

