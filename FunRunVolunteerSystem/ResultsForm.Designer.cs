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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreferencesResult)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.dgvPreferencesResult.EnableHeadersVisualStyles = false;
            this.dgvPreferencesResult.GridColor = System.Drawing.Color.LightSteelBlue;
            this.dgvPreferencesResult.Location = new System.Drawing.Point(20, 8);
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
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button1.Location = new System.Drawing.Point(309, 797);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 68);
            this.button1.TabIndex = 2;
            this.button1.Text = "   Back";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(1608, 797);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(163, 68);
            this.button2.TabIndex = 3;
            this.button2.Text = "   Export";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // ResultsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Name = "ResultsForm";
            this.Text = "ResultsForm";
            this.Load += new System.EventHandler(this.ResultsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreferencesResult)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPreferencesResult;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVolunteer;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAssignedBooth;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}