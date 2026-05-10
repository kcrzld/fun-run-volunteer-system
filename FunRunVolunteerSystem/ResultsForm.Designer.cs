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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResultsForm));
            this.dgvPreferencesResult = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.colVolunteer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAssignedBooth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnStatistics = new System.Windows.Forms.Button();
            this.btnMatchRate = new System.Windows.Forms.Button();
            this.btnViewPreferences = new System.Windows.Forms.Button();
            this.btnCapacityMonitor = new System.Windows.Forms.Button();
            this.dgvDetails = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreferencesResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPreferencesResult
            // 
            this.dgvPreferencesResult.AllowUserToAddRows = false;
            this.dgvPreferencesResult.AllowUserToDeleteRows = false;
            this.dgvPreferencesResult.BackgroundColor = System.Drawing.Color.White;
            this.dgvPreferencesResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPreferencesResult.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPreferencesResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPreferencesResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colVolunteer,
            this.colAssignedBooth});
            this.dgvPreferencesResult.Location = new System.Drawing.Point(279, 39);
            this.dgvPreferencesResult.Name = "dgvPreferencesResult";
            this.dgvPreferencesResult.ReadOnly = true;
            this.dgvPreferencesResult.RowHeadersVisible = false;
            this.dgvPreferencesResult.RowHeadersWidth = 51;
            this.dgvPreferencesResult.RowTemplate.Height = 24;
            this.dgvPreferencesResult.Size = new System.Drawing.Size(1422, 510);
            this.dgvPreferencesResult.TabIndex = 0;
            this.dgvPreferencesResult.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPreferencesResult_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.dgvPreferencesResult);
            this.panel1.Location = new System.Drawing.Point(309, 236);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1458, 521);
            this.panel1.TabIndex = 1;
            // 
            // colVolunteer
            // 
            this.colVolunteer.FillWeight = 50F;
            this.colVolunteer.HeaderText = "Volunteer Name";
            this.colVolunteer.MinimumWidth = 6;
            this.colVolunteer.Name = "colVolunteer";
            this.colVolunteer.ReadOnly = true;
            this.colVolunteer.Width = 125;
            // 
            // colAssignedBooth
            // 
            this.colAssignedBooth.FillWeight = 50F;
            this.colAssignedBooth.HeaderText = "Assigned Booth";
            this.colAssignedBooth.MinimumWidth = 6;
            this.colAssignedBooth.Name = "colAssignedBooth";
            this.colAssignedBooth.ReadOnly = true;
            this.colAssignedBooth.Width = 125;
            // 
            // btnStatistics
            // 
            this.btnStatistics.Location = new System.Drawing.Point(691, 345);
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.Size = new System.Drawing.Size(200, 60);
            this.btnStatistics.TabIndex = 1;
            this.btnStatistics.Text = "Statistics";
            this.btnStatistics.UseVisualStyleBackColor = true;
            this.btnStatistics.Click += new System.EventHandler(this.btnStatistics_Click);
            // 
            // btnMatchRate
            // 
            this.btnMatchRate.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnMatchRate.Location = new System.Drawing.Point(485, 345);
            this.btnMatchRate.Name = "btnMatchRate";
            this.btnMatchRate.Size = new System.Drawing.Size(200, 60);
            this.btnMatchRate.TabIndex = 2;
            this.btnMatchRate.Text = "Match Rate";
            this.btnMatchRate.UseVisualStyleBackColor = true;
            this.btnMatchRate.Click += new System.EventHandler(this.btnMatchRate_Click);
            // 
            // btnViewPreferences
            // 
            this.btnViewPreferences.Location = new System.Drawing.Point(279, 345);
            this.btnViewPreferences.Name = "btnViewPreferences";
            this.btnViewPreferences.Size = new System.Drawing.Size(200, 60);
            this.btnViewPreferences.TabIndex = 3;
            this.btnViewPreferences.Text = "View Preferences";
            this.btnViewPreferences.UseVisualStyleBackColor = true;
            this.btnViewPreferences.Click += new System.EventHandler(this.btnViewPreferences_Click);
            // 
            // btnCapacityMonitor
            // 
            this.btnCapacityMonitor.Location = new System.Drawing.Point(897, 345);
            this.btnCapacityMonitor.Name = "btnCapacityMonitor";
            this.btnCapacityMonitor.Size = new System.Drawing.Size(200, 60);
            this.btnCapacityMonitor.TabIndex = 4;
            this.btnCapacityMonitor.Text = "Capacity Monitor";
            this.btnCapacityMonitor.UseVisualStyleBackColor = true;
            this.btnCapacityMonitor.Click += new System.EventHandler(this.btnCapacityMonitor_Click);
            // 
            // dgvDetails
            // 
            this.dgvDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetails.Location = new System.Drawing.Point(279, 426);
            this.dgvDetails.Name = "dgvDetails";
            this.dgvDetails.RowHeadersWidth = 51;
            this.dgvDetails.RowTemplate.Height = 24;
            this.dgvDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetails.Size = new System.Drawing.Size(240, 150);
            this.dgvDetails.TabIndex = 5;
            this.dgvDetails.Visible = false;
            // 
            // ResultsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.dgvDetails);
            this.Controls.Add(this.btnCapacityMonitor);
            this.Controls.Add(this.btnViewPreferences);
            this.Controls.Add(this.btnMatchRate);
            this.Controls.Add(this.btnStatistics);
            this.Controls.Add(this.dgvPreferencesResult);
            this.Name = "ResultsForm";
            this.Text = "ResultsForm";
            this.Load += new System.EventHandler(this.ResultsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreferencesResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPreferencesResult;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVolunteer;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAssignedBooth;
        private System.Windows.Forms.Button btnStatistics;
        private System.Windows.Forms.Button btnMatchRate;
        private System.Windows.Forms.Button btnViewPreferences;
        private System.Windows.Forms.Button btnCapacityMonitor;
        private System.Windows.Forms.DataGridView dgvDetails;
    }
}