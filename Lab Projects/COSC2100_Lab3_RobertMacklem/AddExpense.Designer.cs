namespace COSC2100_Lab3_RobertMacklem
{
    partial class AddExpense
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
            this.tlpAddExpenseLayout = new System.Windows.Forms.TableLayoutPanel();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.tbxDescription = new System.Windows.Forms.TextBox();
            this.nudAmount = new System.Windows.Forms.NumericUpDown();
            this.ttpInfo = new System.Windows.Forms.ToolTip(this.components);
            this.tlpAddExpenseLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpAddExpenseLayout
            // 
            this.tlpAddExpenseLayout.ColumnCount = 2;
            this.tlpAddExpenseLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tlpAddExpenseLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpAddExpenseLayout.Controls.Add(this.lblDate, 0, 0);
            this.tlpAddExpenseLayout.Controls.Add(this.lblDescription, 0, 1);
            this.tlpAddExpenseLayout.Controls.Add(this.lblAmount, 0, 2);
            this.tlpAddExpenseLayout.Controls.Add(this.btnCancel, 0, 3);
            this.tlpAddExpenseLayout.Controls.Add(this.btnConfirm, 1, 3);
            this.tlpAddExpenseLayout.Controls.Add(this.dtpDate, 1, 0);
            this.tlpAddExpenseLayout.Controls.Add(this.tbxDescription, 1, 1);
            this.tlpAddExpenseLayout.Controls.Add(this.nudAmount, 1, 2);
            this.tlpAddExpenseLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpAddExpenseLayout.Location = new System.Drawing.Point(0, 0);
            this.tlpAddExpenseLayout.Name = "tlpAddExpenseLayout";
            this.tlpAddExpenseLayout.RowCount = 4;
            this.tlpAddExpenseLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpAddExpenseLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpAddExpenseLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpAddExpenseLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpAddExpenseLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpAddExpenseLayout.Size = new System.Drawing.Size(409, 161);
            this.tlpAddExpenseLayout.TabIndex = 0;
            // 
            // lblDate
            // 
            this.lblDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(3, 11);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(46, 18);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "Date:";
            // 
            // lblDescription
            // 
            this.lblDescription.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(3, 51);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(92, 18);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "Description:";
            // 
            // lblAmount
            // 
            this.lblAmount.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(3, 91);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(65, 18);
            this.lblAmount.TabIndex = 2;
            this.lblAmount.Text = "Amount:";
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(3, 123);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(114, 35);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.ttpInfo.SetToolTip(this.btnCancel, "Return to the expense tracker form.");
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.AutoSize = true;
            this.btnConfirm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnConfirm.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Location = new System.Drawing.Point(123, 123);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(283, 35);
            this.btnConfirm.TabIndex = 4;
            this.btnConfirm.Text = "Confirm";
            this.ttpInfo.SetToolTip(this.btnConfirm, "Submits the expense input as a new expense in the expenses table.");
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // dtpDate
            // 
            this.dtpDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Location = new System.Drawing.Point(123, 7);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(283, 26);
            this.dtpDate.TabIndex = 5;
            this.ttpInfo.SetToolTip(this.dtpDate, "Select the date the expense was incurred.");
            // 
            // tbxDescription
            // 
            this.tbxDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxDescription.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxDescription.Location = new System.Drawing.Point(123, 47);
            this.tbxDescription.Name = "tbxDescription";
            this.tbxDescription.Size = new System.Drawing.Size(283, 26);
            this.tbxDescription.TabIndex = 6;
            this.ttpInfo.SetToolTip(this.tbxDescription, "Input the description or name of the expense item.");
            // 
            // nudAmount
            // 
            this.nudAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nudAmount.DecimalPlaces = 2;
            this.nudAmount.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudAmount.Location = new System.Drawing.Point(123, 87);
            this.nudAmount.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudAmount.Name = "nudAmount";
            this.nudAmount.Size = new System.Drawing.Size(283, 26);
            this.nudAmount.TabIndex = 7;
            this.nudAmount.ThousandsSeparator = true;
            this.ttpInfo.SetToolTip(this.nudAmount, "Input the amount of the expense (in dollars).");
            // 
            // AddExpense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 161);
            this.Controls.Add(this.tlpAddExpenseLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AddExpense";
            this.ShowIcon = false;
            this.Text = "AddExpense";
            this.tlpAddExpenseLayout.ResumeLayout(false);
            this.tlpAddExpenseLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpAddExpenseLayout;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.TextBox tbxDescription;
        private System.Windows.Forms.NumericUpDown nudAmount;
        private System.Windows.Forms.ToolTip ttpInfo;
    }
}