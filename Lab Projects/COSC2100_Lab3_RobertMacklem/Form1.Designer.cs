namespace COSC2100_Lab3_RobertMacklem
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.tlpMainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.tlpHeader = new System.Windows.Forms.TableLayoutPanel();
            this.lblName = new System.Windows.Forms.Label();
            this.tlpBudgetIOLayout = new System.Windows.Forms.TableLayoutPanel();
            this.tbxNetBal = new System.Windows.Forms.TextBox();
            this.lblNetBal = new System.Windows.Forms.Label();
            this.lblExpenses = new System.Windows.Forms.Label();
            this.lblBudget = new System.Windows.Forms.Label();
            this.nudBudget = new System.Windows.Forms.NumericUpDown();
            this.tbxExpenses = new System.Windows.Forms.TextBox();
            this.tlpButtonsLayout = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddExpense = new System.Windows.Forms.Button();
            this.btnRemoveExpense = new System.Windows.Forms.Button();
            this.gbxDataBox = new System.Windows.Forms.GroupBox();
            this.dgvExpenseData = new System.Windows.Forms.DataGridView();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ttpInfo = new System.Windows.Forms.ToolTip(this.components);
            this.btnDetails = new System.Windows.Forms.Button();
            this.btnVisualize = new System.Windows.Forms.Button();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.tlpMainLayout.SuspendLayout();
            this.tlpHeader.SuspendLayout();
            this.tlpBudgetIOLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBudget)).BeginInit();
            this.tlpButtonsLayout.SuspendLayout();
            this.gbxDataBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpenseData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpMainLayout
            // 
            this.tlpMainLayout.BackColor = System.Drawing.Color.White;
            this.tlpMainLayout.ColumnCount = 1;
            this.tlpMainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMainLayout.Controls.Add(this.tlpHeader, 0, 0);
            this.tlpMainLayout.Controls.Add(this.tlpBudgetIOLayout, 0, 1);
            this.tlpMainLayout.Controls.Add(this.tlpButtonsLayout, 0, 3);
            this.tlpMainLayout.Controls.Add(this.gbxDataBox, 0, 2);
            this.tlpMainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMainLayout.Location = new System.Drawing.Point(0, 0);
            this.tlpMainLayout.Name = "tlpMainLayout";
            this.tlpMainLayout.RowCount = 4;
            this.tlpMainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpMainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tlpMainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpMainLayout.Size = new System.Drawing.Size(516, 547);
            this.tlpMainLayout.TabIndex = 0;
            // 
            // tlpHeader
            // 
            this.tlpHeader.ColumnCount = 2;
            this.tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpHeader.Controls.Add(this.pbxLogo, 0, 0);
            this.tlpHeader.Controls.Add(this.lblName, 1, 0);
            this.tlpHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpHeader.Location = new System.Drawing.Point(3, 3);
            this.tlpHeader.Name = "tlpHeader";
            this.tlpHeader.RowCount = 1;
            this.tlpHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpHeader.Size = new System.Drawing.Size(510, 94);
            this.tlpHeader.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblName.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(110, 10);
            this.lblName.Margin = new System.Windows.Forms.Padding(10);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(390, 74);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Expense Tracker";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tlpBudgetIOLayout
            // 
            this.tlpBudgetIOLayout.BackColor = System.Drawing.Color.Transparent;
            this.tlpBudgetIOLayout.ColumnCount = 3;
            this.tlpBudgetIOLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpBudgetIOLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tlpBudgetIOLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tlpBudgetIOLayout.Controls.Add(this.tbxNetBal, 2, 1);
            this.tlpBudgetIOLayout.Controls.Add(this.lblNetBal, 2, 0);
            this.tlpBudgetIOLayout.Controls.Add(this.lblExpenses, 1, 0);
            this.tlpBudgetIOLayout.Controls.Add(this.lblBudget, 0, 0);
            this.tlpBudgetIOLayout.Controls.Add(this.nudBudget, 0, 1);
            this.tlpBudgetIOLayout.Controls.Add(this.tbxExpenses, 1, 1);
            this.tlpBudgetIOLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpBudgetIOLayout.Location = new System.Drawing.Point(8, 108);
            this.tlpBudgetIOLayout.Margin = new System.Windows.Forms.Padding(8);
            this.tlpBudgetIOLayout.Name = "tlpBudgetIOLayout";
            this.tlpBudgetIOLayout.RowCount = 2;
            this.tlpBudgetIOLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tlpBudgetIOLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tlpBudgetIOLayout.Size = new System.Drawing.Size(500, 74);
            this.tlpBudgetIOLayout.TabIndex = 1;
            // 
            // tbxNetBal
            // 
            this.tbxNetBal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxNetBal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxNetBal.Location = new System.Drawing.Point(335, 48);
            this.tbxNetBal.Name = "tbxNetBal";
            this.tbxNetBal.ReadOnly = true;
            this.tbxNetBal.Size = new System.Drawing.Size(162, 26);
            this.tbxNetBal.TabIndex = 7;
            this.tbxNetBal.TabStop = false;
            // 
            // lblNetBal
            // 
            this.lblNetBal.AutoSize = true;
            this.lblNetBal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNetBal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNetBal.Location = new System.Drawing.Point(335, 3);
            this.lblNetBal.Margin = new System.Windows.Forms.Padding(3);
            this.lblNetBal.Name = "lblNetBal";
            this.lblNetBal.Size = new System.Drawing.Size(162, 39);
            this.lblNetBal.TabIndex = 4;
            this.lblNetBal.Text = "Net Balance:";
            this.lblNetBal.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblExpenses
            // 
            this.lblExpenses.AutoSize = true;
            this.lblExpenses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblExpenses.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpenses.Location = new System.Drawing.Point(169, 3);
            this.lblExpenses.Margin = new System.Windows.Forms.Padding(3);
            this.lblExpenses.Name = "lblExpenses";
            this.lblExpenses.Size = new System.Drawing.Size(160, 39);
            this.lblExpenses.TabIndex = 3;
            this.lblExpenses.Text = "Expenses:";
            this.lblExpenses.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblBudget
            // 
            this.lblBudget.AutoSize = true;
            this.lblBudget.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBudget.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBudget.Location = new System.Drawing.Point(3, 3);
            this.lblBudget.Margin = new System.Windows.Forms.Padding(3);
            this.lblBudget.Name = "lblBudget";
            this.lblBudget.Size = new System.Drawing.Size(160, 39);
            this.lblBudget.TabIndex = 2;
            this.lblBudget.Text = "Budget:";
            this.lblBudget.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // nudBudget
            // 
            this.nudBudget.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudBudget.DecimalPlaces = 2;
            this.nudBudget.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudBudget.Location = new System.Drawing.Point(3, 48);
            this.nudBudget.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudBudget.Name = "nudBudget";
            this.nudBudget.Size = new System.Drawing.Size(160, 26);
            this.nudBudget.TabIndex = 0;
            this.nudBudget.ThousandsSeparator = true;
            this.ttpInfo.SetToolTip(this.nudBudget, "Input your budget (in dollars).");
            this.nudBudget.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nudBudget.ValueChanged += new System.EventHandler(this.nudBudget_ValueChanged);
            // 
            // tbxExpenses
            // 
            this.tbxExpenses.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxExpenses.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxExpenses.Location = new System.Drawing.Point(169, 48);
            this.tbxExpenses.Name = "tbxExpenses";
            this.tbxExpenses.ReadOnly = true;
            this.tbxExpenses.Size = new System.Drawing.Size(160, 26);
            this.tbxExpenses.TabIndex = 6;
            this.tbxExpenses.TabStop = false;
            // 
            // tlpButtonsLayout
            // 
            this.tlpButtonsLayout.ColumnCount = 4;
            this.tlpButtonsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpButtonsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlpButtonsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpButtonsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpButtonsLayout.Controls.Add(this.btnVisualize, 2, 0);
            this.tlpButtonsLayout.Controls.Add(this.btnDetails, 1, 0);
            this.tlpButtonsLayout.Controls.Add(this.btnRemoveExpense, 0, 0);
            this.tlpButtonsLayout.Controls.Add(this.btnAddExpense, 3, 0);
            this.tlpButtonsLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpButtonsLayout.Location = new System.Drawing.Point(3, 500);
            this.tlpButtonsLayout.Name = "tlpButtonsLayout";
            this.tlpButtonsLayout.RowCount = 1;
            this.tlpButtonsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpButtonsLayout.Size = new System.Drawing.Size(510, 44);
            this.tlpButtonsLayout.TabIndex = 2;
            // 
            // btnAddExpense
            // 
            this.btnAddExpense.BackColor = System.Drawing.Color.White;
            this.btnAddExpense.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddExpense.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAddExpense.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddExpense.Location = new System.Drawing.Point(385, 3);
            this.btnAddExpense.Name = "btnAddExpense";
            this.btnAddExpense.Size = new System.Drawing.Size(122, 38);
            this.btnAddExpense.TabIndex = 3;
            this.btnAddExpense.Text = "Add Expense";
            this.ttpInfo.SetToolTip(this.btnAddExpense, "Opens the expense adding form.");
            this.btnAddExpense.UseVisualStyleBackColor = false;
            this.btnAddExpense.Click += new System.EventHandler(this.btnAddExpense_Click);
            // 
            // btnRemoveExpense
            // 
            this.btnRemoveExpense.BackColor = System.Drawing.Color.White;
            this.btnRemoveExpense.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnRemoveExpense.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRemoveExpense.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnRemoveExpense.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveExpense.Location = new System.Drawing.Point(3, 3);
            this.btnRemoveExpense.Name = "btnRemoveExpense";
            this.btnRemoveExpense.Size = new System.Drawing.Size(198, 38);
            this.btnRemoveExpense.TabIndex = 2;
            this.btnRemoveExpense.Text = "Remove Selected Expense";
            this.ttpInfo.SetToolTip(this.btnRemoveExpense, "Removes the highlighted expense item.");
            this.btnRemoveExpense.UseVisualStyleBackColor = false;
            this.btnRemoveExpense.Click += new System.EventHandler(this.btnRemoveExpense_Click);
            // 
            // gbxDataBox
            // 
            this.gbxDataBox.Controls.Add(this.dgvExpenseData);
            this.gbxDataBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxDataBox.Location = new System.Drawing.Point(5, 190);
            this.gbxDataBox.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.gbxDataBox.Name = "gbxDataBox";
            this.gbxDataBox.Size = new System.Drawing.Size(506, 307);
            this.gbxDataBox.TabIndex = 3;
            this.gbxDataBox.TabStop = false;
            // 
            // dgvExpenseData
            // 
            this.dgvExpenseData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvExpenseData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvExpenseData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExpenseData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.Description,
            this.Amount});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvExpenseData.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvExpenseData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvExpenseData.Location = new System.Drawing.Point(3, 16);
            this.dgvExpenseData.MultiSelect = false;
            this.dgvExpenseData.Name = "dgvExpenseData";
            this.dgvExpenseData.RowHeadersVisible = false;
            this.dgvExpenseData.Size = new System.Drawing.Size(500, 288);
            this.dgvExpenseData.TabIndex = 1;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.FillWeight = 55F;
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            // 
            // Amount
            // 
            this.Amount.DataPropertyName = "Amount";
            this.Amount.FillWeight = 50F;
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            // 
            // btnDetails
            // 
            this.btnDetails.BackColor = System.Drawing.Color.White;
            this.btnDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDetails.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDetails.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetails.Location = new System.Drawing.Point(207, 3);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(70, 38);
            this.btnDetails.TabIndex = 4;
            this.btnDetails.Text = "Details";
            this.ttpInfo.SetToolTip(this.btnDetails, "Opens the overall expense details window.");
            this.btnDetails.UseVisualStyleBackColor = false;
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // btnVisualize
            // 
            this.btnVisualize.BackColor = System.Drawing.Color.White;
            this.btnVisualize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnVisualize.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnVisualize.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisualize.Location = new System.Drawing.Point(283, 3);
            this.btnVisualize.Name = "btnVisualize";
            this.btnVisualize.Size = new System.Drawing.Size(96, 38);
            this.btnVisualize.TabIndex = 5;
            this.btnVisualize.Text = "Visualize";
            this.ttpInfo.SetToolTip(this.btnVisualize, "Opens the graph visualization window.");
            this.btnVisualize.UseVisualStyleBackColor = false;
            this.btnVisualize.Click += new System.EventHandler(this.btnVisualize_Click);
            // 
            // pbxLogo
            // 
            this.pbxLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbxLogo.Image = global::COSC2100_Lab3_RobertMacklem.Properties.Resources.imgLogo;
            this.pbxLogo.Location = new System.Drawing.Point(3, 3);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(94, 88);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxLogo.TabIndex = 0;
            this.pbxLogo.TabStop = false;
            // 
            // frmMain
            // 
            this.AcceptButton = this.btnAddExpense;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnRemoveExpense;
            this.ClientSize = new System.Drawing.Size(516, 547);
            this.Controls.Add(this.tlpMainLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "Expense Tracker — Robert Macklem";
            this.tlpMainLayout.ResumeLayout(false);
            this.tlpHeader.ResumeLayout(false);
            this.tlpHeader.PerformLayout();
            this.tlpBudgetIOLayout.ResumeLayout(false);
            this.tlpBudgetIOLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBudget)).EndInit();
            this.tlpButtonsLayout.ResumeLayout(false);
            this.gbxDataBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpenseData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMainLayout;
        private System.Windows.Forms.TableLayoutPanel tlpHeader;
        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TableLayoutPanel tlpBudgetIOLayout;
        private System.Windows.Forms.Label lblNetBal;
        private System.Windows.Forms.Label lblExpenses;
        private System.Windows.Forms.Label lblBudget;
        private System.Windows.Forms.NumericUpDown nudBudget;
        private System.Windows.Forms.TextBox tbxExpenses;
        private System.Windows.Forms.TextBox tbxNetBal;
        private System.Windows.Forms.TableLayoutPanel tlpButtonsLayout;
        private System.Windows.Forms.Button btnRemoveExpense;
        private System.Windows.Forms.GroupBox gbxDataBox;
        private System.Windows.Forms.DataGridView dgvExpenseData;
        private System.Windows.Forms.Button btnAddExpense;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.ToolTip ttpInfo;
        private System.Windows.Forms.Button btnVisualize;
        private System.Windows.Forms.Button btnDetails;
    }
}

