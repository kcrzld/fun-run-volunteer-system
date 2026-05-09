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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDisplayResults = new System.Windows.Forms.Button();
            this.btnComputeAssignment = new System.Windows.Forms.Button();
            this.btnAddVolunteer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(536, 413);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(200, 80);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDisplayResults
            // 
            this.btnDisplayResults.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDisplayResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplayResults.Location = new System.Drawing.Point(536, 320);
            this.btnDisplayResults.Name = "btnDisplayResults";
            this.btnDisplayResults.Size = new System.Drawing.Size(200, 80);
            this.btnDisplayResults.TabIndex = 0;
            this.btnDisplayResults.Text = "Dsiplay Results";
            this.btnDisplayResults.UseVisualStyleBackColor = true;
            this.btnDisplayResults.Click += new System.EventHandler(this.btnDisplayResults_Click);
            // 
            // btnComputeAssignment
            // 
            this.btnComputeAssignment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnComputeAssignment.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComputeAssignment.Location = new System.Drawing.Point(536, 227);
            this.btnComputeAssignment.Name = "btnComputeAssignment";
            this.btnComputeAssignment.Size = new System.Drawing.Size(200, 80);
            this.btnComputeAssignment.TabIndex = 0;
            this.btnComputeAssignment.Text = "Compute Assignments";
            this.btnComputeAssignment.UseVisualStyleBackColor = true;
            this.btnComputeAssignment.Click += new System.EventHandler(this.btnComputeAssignment_Click);
            // 
            // btnAddVolunteer
            // 
            this.btnAddVolunteer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddVolunteer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddVolunteer.Location = new System.Drawing.Point(536, 134);
            this.btnAddVolunteer.Name = "btnAddVolunteer";
            this.btnAddVolunteer.Size = new System.Drawing.Size(200, 80);
            this.btnAddVolunteer.TabIndex = 0;
            this.btnAddVolunteer.Text = "Add Volunteer";
            this.btnAddVolunteer.UseVisualStyleBackColor = true;
            this.btnAddVolunteer.Click += new System.EventHandler(this.btnAddVolunteer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
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

