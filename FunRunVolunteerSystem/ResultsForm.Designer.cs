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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResultsForm));
            this.dgvPreferencesResult = new System.Windows.Forms.DataGridView();
            this.colVolunteer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAssignedBooth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnStatistics = new System.Windows.Forms.Button();
            this.btnMatchRate = new System.Windows.Forms.Button();
            this.btnViewPreferences = new System.Windows.Forms.Button();
            this.btnCapacityMonitor = new System.Windows.Forms.Button();
            this.dgvDetails = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.backbutton1 = new System.Windows.Forms.Button();
            this.lblInsightsTitle = new System.Windows.Forms.Label();
            this.lblInsightsDesc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreferencesResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPreferencesResult
            // 
            this.dgvPreferencesResult.AllowUserToAddRows = false;
            this.dgvPreferencesResult.AllowUserToDeleteRows = false;
            this.dgvPreferencesResult.BackgroundColor = System.Drawing.Color.White;
            this.dgvPreferencesResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPreferencesResult.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPreferencesResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPreferencesResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colVolunteer,
            this.colAssignedBooth});
            this.dgvPreferencesResult.Location = new System.Drawing.Point(84, 260);
            this.dgvPreferencesResult.Name = "dgvPreferencesResult";
            this.dgvPreferencesResult.ReadOnly = true;
            this.dgvPreferencesResult.RowHeadersVisible = false;
            this.dgvPreferencesResult.RowHeadersWidth = 51;
            this.dgvPreferencesResult.RowTemplate.Height = 24;
            this.dgvPreferencesResult.Size = new System.Drawing.Size(1150, 601);
            this.dgvPreferencesResult.TabIndex = 0;
            this.dgvPreferencesResult.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPreferencesResult_CellContentClick);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(309, 236);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1458, 521);
            this.panel1.TabIndex = 1;
            // 
            // btnStatistics
            // 
            this.btnStatistics.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnStatistics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatistics.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnStatistics.ForeColor = System.Drawing.Color.White;
            this.btnStatistics.Location = new System.Drawing.Point(201, 88);
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.Size = new System.Drawing.Size(186, 51);
            this.btnStatistics.TabIndex = 1;
            this.btnStatistics.Text = "Statistics";
            this.btnStatistics.UseVisualStyleBackColor = false;
            this.btnStatistics.Click += new System.EventHandler(this.btnStatistics_Click);
            // 
            // btnMatchRate
            // 
            this.btnMatchRate.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnMatchRate.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnMatchRate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMatchRate.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnMatchRate.ForeColor = System.Drawing.Color.White;
            this.btnMatchRate.Location = new System.Drawing.Point(201, 225);
            this.btnMatchRate.Name = "btnMatchRate";
            this.btnMatchRate.Size = new System.Drawing.Size(186, 51);
            this.btnMatchRate.TabIndex = 2;
            this.btnMatchRate.Text = "Match Rate";
            this.btnMatchRate.UseVisualStyleBackColor = false;
            this.btnMatchRate.Click += new System.EventHandler(this.btnMatchRate_Click);
            // 
            // btnViewPreferences
            // 
            this.btnViewPreferences.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnViewPreferences.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewPreferences.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewPreferences.ForeColor = System.Drawing.Color.White;
            this.btnViewPreferences.Location = new System.Drawing.Point(201, 20);
            this.btnViewPreferences.Name = "btnViewPreferences";
            this.btnViewPreferences.Size = new System.Drawing.Size(186, 51);
            this.btnViewPreferences.TabIndex = 3;
            this.btnViewPreferences.Text = "View Preferences";
            this.btnViewPreferences.UseVisualStyleBackColor = false;
            this.btnViewPreferences.Click += new System.EventHandler(this.btnViewPreferences_Click);
            // 
            // btnCapacityMonitor
            // 
            this.btnCapacityMonitor.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnCapacityMonitor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapacityMonitor.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnCapacityMonitor.ForeColor = System.Drawing.Color.White;
            this.btnCapacityMonitor.Location = new System.Drawing.Point(201, 157);
            this.btnCapacityMonitor.Name = "btnCapacityMonitor";
            this.btnCapacityMonitor.Size = new System.Drawing.Size(186, 51);
            this.btnCapacityMonitor.TabIndex = 4;
            this.btnCapacityMonitor.Text = "Capacity Monitor";
            this.btnCapacityMonitor.UseVisualStyleBackColor = false;
            this.btnCapacityMonitor.Click += new System.EventHandler(this.btnCapacityMonitor_Click);
            // 
            // dgvDetails
            // 
            this.dgvDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetails.Location = new System.Drawing.Point(20, 392);
            this.dgvDetails.Name = "dgvDetails";
            this.dgvDetails.ReadOnly = true;
            this.dgvDetails.RowHeadersWidth = 51;
            this.dgvDetails.RowTemplate.Height = 24;
            this.dgvDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetails.Size = new System.Drawing.Size(555, 188);
            this.dgvDetails.TabIndex = 5;
            this.dgvDetails.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.Controls.Add(this.lblInsightsDesc);
            this.panel2.Controls.Add(this.lblInsightsTitle);
            this.panel2.Controls.Add(this.dgvDetails);
            this.panel2.Controls.Add(this.btnCapacityMonitor);
            this.panel2.Controls.Add(this.btnViewPreferences);
            this.panel2.Controls.Add(this.btnMatchRate);
            this.panel2.Controls.Add(this.btnStatistics);
            this.panel2.Location = new System.Drawing.Point(1276, 263);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(596, 597);
            this.panel2.TabIndex = 6;
            // 
            // backbutton1
            // 
            this.backbutton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backbutton1.BackgroundImage")));
            this.backbutton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.backbutton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backbutton1.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold);
            this.backbutton1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.backbutton1.Location = new System.Drawing.Point(1709, 886);
            this.backbutton1.Name = "backbutton1";
            this.backbutton1.Size = new System.Drawing.Size(163, 68);
            this.backbutton1.TabIndex = 7;
            this.backbutton1.Text = "   Back";
            this.backbutton1.UseVisualStyleBackColor = true;
            this.backbutton1.Click += new System.EventHandler(this.backbutton1_Click);
            // 
            // lblInsightsTitle
            // 
            this.lblInsightsTitle.AutoSize = true;
            this.lblInsightsTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblInsightsTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInsightsTitle.Location = new System.Drawing.Point(13, 307);
            this.lblInsightsTitle.Name = "lblInsightsTitle";
            this.lblInsightsTitle.Size = new System.Drawing.Size(304, 41);
            this.lblInsightsTitle.TabIndex = 6;
            this.lblInsightsTitle.Text = "Assignment Insights";
            // 
            // lblInsightsDesc
            // 
            this.lblInsightsDesc.AutoSize = true;
            this.lblInsightsDesc.BackColor = System.Drawing.Color.Transparent;
            this.lblInsightsDesc.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInsightsDesc.Location = new System.Drawing.Point(16, 354);
            this.lblInsightsDesc.Name = "lblInsightsDesc";
            this.lblInsightsDesc.Size = new System.Drawing.Size(539, 23);
            this.lblInsightsDesc.TabIndex = 7;
            this.lblInsightsDesc.Text = "Overview of volunteer assignment performance and matching results.";
            // 
            // ResultsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1924, 997);
            this.Controls.Add(this.backbutton1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvPreferencesResult);
            this.Name = "ResultsForm";
            this.Text = "ResultsForm";
            this.Load += new System.EventHandler(this.ResultsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreferencesResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button backbutton1;
        private System.Windows.Forms.Label lblInsightsDesc;
        private System.Windows.Forms.Label lblInsightsTitle;
    }
}