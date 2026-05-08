namespace FunRunVolunteerSystem
{
    partial class ResultsForm
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
            this.dgvPreferencesResult = new System.Windows.Forms.DataGridView();
            this.colVolunteer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAssignedBooth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreferencesResult)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPreferencesResult
            // 
            this.dgvPreferencesResult.AllowUserToAddRows = false;
            this.dgvPreferencesResult.AllowUserToDeleteRows = false;
            this.dgvPreferencesResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPreferencesResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colVolunteer,
            this.colAssignedBooth});
            this.dgvPreferencesResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPreferencesResult.Location = new System.Drawing.Point(0, 0);
            this.dgvPreferencesResult.Name = "dgvPreferencesResult";
            this.dgvPreferencesResult.ReadOnly = true;
            this.dgvPreferencesResult.RowHeadersWidth = 51;
            this.dgvPreferencesResult.RowTemplate.Height = 24;
            this.dgvPreferencesResult.Size = new System.Drawing.Size(1262, 673);
            this.dgvPreferencesResult.TabIndex = 0;
            this.dgvPreferencesResult.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPreferencesResult_CellContentClick);
            // 
            // colVolunteer
            // 
            this.colVolunteer.HeaderText = "Volunteer Name";
            this.colVolunteer.MinimumWidth = 6;
            this.colVolunteer.Name = "colVolunteer";
            this.colVolunteer.Width = 125;
            // 
            // colAssignedBooth
            // 
            this.colAssignedBooth.HeaderText = "Assigned Booth";
            this.colAssignedBooth.MinimumWidth = 6;
            this.colAssignedBooth.Name = "colAssignedBooth";
            this.colAssignedBooth.Width = 125;
            // 
            // ResultsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.dgvPreferencesResult);
            this.Name = "ResultsForm";
            this.Text = "ResultsForm";
            this.Load += new System.EventHandler(this.ResultsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreferencesResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPreferencesResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVolunteer;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAssignedBooth;
    }
}