namespace COSC2100_ICE8_RobertMacklem
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.tlpMainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tlpButtonsLayout = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddVictim = new System.Windows.Forms.Button();
            this.btnClearJobs = new System.Windows.Forms.Button();
            this.dgvVictims = new System.Windows.Forms.DataGridView();
            this.JobDoneCbx = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.VictimName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlpMainLayout.SuspendLayout();
            this.tlpButtonsLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVictims)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpMainLayout
            // 
            this.tlpMainLayout.ColumnCount = 1;
            this.tlpMainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMainLayout.Controls.Add(this.lblTitle, 0, 0);
            this.tlpMainLayout.Controls.Add(this.tlpButtonsLayout, 0, 2);
            this.tlpMainLayout.Controls.Add(this.dgvVictims, 0, 1);
            this.tlpMainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMainLayout.Location = new System.Drawing.Point(0, 0);
            this.tlpMainLayout.Name = "tlpMainLayout";
            this.tlpMainLayout.RowCount = 3;
            this.tlpMainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpMainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpMainLayout.Size = new System.Drawing.Size(380, 441);
            this.tlpMainLayout.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(86, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(207, 29);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Jason\'s Victim List";
            // 
            // tlpButtonsLayout
            // 
            this.tlpButtonsLayout.ColumnCount = 2;
            this.tlpButtonsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpButtonsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpButtonsLayout.Controls.Add(this.btnAddVictim, 1, 0);
            this.tlpButtonsLayout.Controls.Add(this.btnClearJobs, 0, 0);
            this.tlpButtonsLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpButtonsLayout.Location = new System.Drawing.Point(3, 394);
            this.tlpButtonsLayout.Name = "tlpButtonsLayout";
            this.tlpButtonsLayout.RowCount = 1;
            this.tlpButtonsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpButtonsLayout.Size = new System.Drawing.Size(374, 44);
            this.tlpButtonsLayout.TabIndex = 1;
            // 
            // btnAddVictim
            // 
            this.btnAddVictim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddVictim.Location = new System.Drawing.Point(190, 3);
            this.btnAddVictim.Name = "btnAddVictim";
            this.btnAddVictim.Size = new System.Drawing.Size(181, 38);
            this.btnAddVictim.TabIndex = 1;
            this.btnAddVictim.Text = "Add New Victim";
            this.btnAddVictim.UseVisualStyleBackColor = true;
            this.btnAddVictim.Click += new System.EventHandler(this.btnAddVictim_Click);
            // 
            // btnClearJobs
            // 
            this.btnClearJobs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClearJobs.Location = new System.Drawing.Point(3, 3);
            this.btnClearJobs.Name = "btnClearJobs";
            this.btnClearJobs.Size = new System.Drawing.Size(181, 38);
            this.btnClearJobs.TabIndex = 0;
            this.btnClearJobs.Text = "Clear Compelted Jobs";
            this.btnClearJobs.UseVisualStyleBackColor = true;
            this.btnClearJobs.Click += new System.EventHandler(this.btnClearJobs_Click);
            // 
            // dgvVictims
            // 
            this.dgvVictims.AllowUserToAddRows = false;
            this.dgvVictims.AllowUserToDeleteRows = false;
            this.dgvVictims.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVictims.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.JobDoneCbx,
            this.VictimName});
            this.dgvVictims.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVictims.Location = new System.Drawing.Point(3, 53);
            this.dgvVictims.Name = "dgvVictims";
            this.dgvVictims.RowHeadersVisible = false;
            this.dgvVictims.Size = new System.Drawing.Size(374, 335);
            this.dgvVictims.TabIndex = 2;
            this.dgvVictims.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVictims_CellContentClick);
            // 
            // JobDoneCbx
            // 
            this.JobDoneCbx.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.JobDoneCbx.DataPropertyName = "IsDead";
            this.JobDoneCbx.FalseValue = "false";
            this.JobDoneCbx.HeaderText = "Job Done ";
            this.JobDoneCbx.Name = "JobDoneCbx";
            this.JobDoneCbx.TrueValue = "true";
            this.JobDoneCbx.Width = 62;
            // 
            // VictimName
            // 
            this.VictimName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.VictimName.DataPropertyName = "Name";
            this.VictimName.HeaderText = "Victim\'s Name";
            this.VictimName.Name = "VictimName";
            this.VictimName.ReadOnly = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 441);
            this.Controls.Add(this.tlpMainLayout);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(360, 480);
            this.Name = "frmMain";
            this.Text = "Jason\'s Victim List";
            this.tlpMainLayout.ResumeLayout(false);
            this.tlpMainLayout.PerformLayout();
            this.tlpButtonsLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVictims)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMainLayout;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TableLayoutPanel tlpButtonsLayout;
        private System.Windows.Forms.Button btnAddVictim;
        private System.Windows.Forms.Button btnClearJobs;
        private System.Windows.Forms.DataGridView dgvVictims;
        private System.Windows.Forms.DataGridViewCheckBoxColumn JobDoneCbx;
        private System.Windows.Forms.DataGridViewTextBoxColumn VictimName;
    }
}

