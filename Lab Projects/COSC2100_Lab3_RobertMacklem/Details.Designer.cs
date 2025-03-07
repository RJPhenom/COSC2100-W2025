namespace COSC2100_Lab3_RobertMacklem
{
    partial class Details
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
            this.tlpDetailsLayout = new System.Windows.Forms.TableLayoutPanel();
            this.gbxExpenseDates = new System.Windows.Forms.GroupBox();
            this.tlpExpenseDates = new System.Windows.Forms.TableLayoutPanel();
            this.lblMostDate = new System.Windows.Forms.Label();
            this.lblLeastDate = new System.Windows.Forms.Label();
            this.gbxExpenseAmounts = new System.Windows.Forms.GroupBox();
            this.tlpExpenseAmounts = new System.Windows.Forms.TableLayoutPanel();
            this.tbxMostAmount = new System.Windows.Forms.TextBox();
            this.lblLeastAmount = new System.Windows.Forms.Label();
            this.lblMostAmount = new System.Windows.Forms.Label();
            this.tbxLeastAmount = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.ttpInfo = new System.Windows.Forms.ToolTip(this.components);
            this.tbxLeastDate = new System.Windows.Forms.TextBox();
            this.tbxMostDate = new System.Windows.Forms.TextBox();
            this.tlpDetailsLayout.SuspendLayout();
            this.gbxExpenseDates.SuspendLayout();
            this.tlpExpenseDates.SuspendLayout();
            this.gbxExpenseAmounts.SuspendLayout();
            this.tlpExpenseAmounts.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpDetailsLayout
            // 
            this.tlpDetailsLayout.ColumnCount = 1;
            this.tlpDetailsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDetailsLayout.Controls.Add(this.gbxExpenseDates, 0, 1);
            this.tlpDetailsLayout.Controls.Add(this.gbxExpenseAmounts, 0, 0);
            this.tlpDetailsLayout.Controls.Add(this.btnClose, 0, 2);
            this.tlpDetailsLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpDetailsLayout.Location = new System.Drawing.Point(0, 0);
            this.tlpDetailsLayout.Name = "tlpDetailsLayout";
            this.tlpDetailsLayout.RowCount = 3;
            this.tlpDetailsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tlpDetailsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tlpDetailsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpDetailsLayout.Size = new System.Drawing.Size(433, 356);
            this.tlpDetailsLayout.TabIndex = 0;
            // 
            // gbxExpenseDates
            // 
            this.gbxExpenseDates.Controls.Add(this.tlpExpenseDates);
            this.gbxExpenseDates.Font = new System.Drawing.Font("Arial", 12F);
            this.gbxExpenseDates.Location = new System.Drawing.Point(3, 201);
            this.gbxExpenseDates.Name = "gbxExpenseDates";
            this.gbxExpenseDates.Size = new System.Drawing.Size(427, 101);
            this.gbxExpenseDates.TabIndex = 1;
            this.gbxExpenseDates.TabStop = false;
            this.gbxExpenseDates.Text = "Expense Dates:";
            // 
            // tlpExpenseDates
            // 
            this.tlpExpenseDates.ColumnCount = 2;
            this.tlpExpenseDates.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpExpenseDates.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpExpenseDates.Controls.Add(this.tbxMostDate, 1, 1);
            this.tlpExpenseDates.Controls.Add(this.tbxLeastDate, 0, 1);
            this.tlpExpenseDates.Controls.Add(this.lblMostDate, 1, 0);
            this.tlpExpenseDates.Controls.Add(this.lblLeastDate, 0, 0);
            this.tlpExpenseDates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpExpenseDates.Location = new System.Drawing.Point(3, 22);
            this.tlpExpenseDates.Name = "tlpExpenseDates";
            this.tlpExpenseDates.Padding = new System.Windows.Forms.Padding(10);
            this.tlpExpenseDates.RowCount = 2;
            this.tlpExpenseDates.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpExpenseDates.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpExpenseDates.Size = new System.Drawing.Size(421, 76);
            this.tlpExpenseDates.TabIndex = 0;
            // 
            // lblMostDate
            // 
            this.lblMostDate.AutoSize = true;
            this.lblMostDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblMostDate.Location = new System.Drawing.Point(213, 10);
            this.lblMostDate.Name = "lblMostDate";
            this.lblMostDate.Size = new System.Drawing.Size(154, 19);
            this.lblMostDate.TabIndex = 2;
            this.lblMostDate.Text = "Spent the most on:";
            // 
            // lblLeastDate
            // 
            this.lblLeastDate.AutoSize = true;
            this.lblLeastDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblLeastDate.Location = new System.Drawing.Point(13, 10);
            this.lblLeastDate.Name = "lblLeastDate";
            this.lblLeastDate.Size = new System.Drawing.Size(152, 19);
            this.lblLeastDate.TabIndex = 1;
            this.lblLeastDate.Text = "Spent the least on:";
            // 
            // gbxExpenseAmounts
            // 
            this.gbxExpenseAmounts.Controls.Add(this.tlpExpenseAmounts);
            this.gbxExpenseAmounts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxExpenseAmounts.Font = new System.Drawing.Font("Arial", 12F);
            this.gbxExpenseAmounts.Location = new System.Drawing.Point(10, 10);
            this.gbxExpenseAmounts.Margin = new System.Windows.Forms.Padding(10);
            this.gbxExpenseAmounts.Name = "gbxExpenseAmounts";
            this.gbxExpenseAmounts.Size = new System.Drawing.Size(413, 178);
            this.gbxExpenseAmounts.TabIndex = 0;
            this.gbxExpenseAmounts.TabStop = false;
            this.gbxExpenseAmounts.Text = "Expense Amounts:";
            // 
            // tlpExpenseAmounts
            // 
            this.tlpExpenseAmounts.ColumnCount = 1;
            this.tlpExpenseAmounts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpExpenseAmounts.Controls.Add(this.tbxMostAmount, 0, 3);
            this.tlpExpenseAmounts.Controls.Add(this.lblLeastAmount, 0, 0);
            this.tlpExpenseAmounts.Controls.Add(this.lblMostAmount, 0, 2);
            this.tlpExpenseAmounts.Controls.Add(this.tbxLeastAmount, 0, 1);
            this.tlpExpenseAmounts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpExpenseAmounts.Location = new System.Drawing.Point(3, 22);
            this.tlpExpenseAmounts.Margin = new System.Windows.Forms.Padding(0);
            this.tlpExpenseAmounts.Name = "tlpExpenseAmounts";
            this.tlpExpenseAmounts.Padding = new System.Windows.Forms.Padding(10);
            this.tlpExpenseAmounts.RowCount = 4;
            this.tlpExpenseAmounts.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpExpenseAmounts.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpExpenseAmounts.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpExpenseAmounts.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpExpenseAmounts.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpExpenseAmounts.Size = new System.Drawing.Size(407, 153);
            this.tlpExpenseAmounts.TabIndex = 0;
            // 
            // tbxMostAmount
            // 
            this.tbxMostAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxMostAmount.Location = new System.Drawing.Point(13, 113);
            this.tbxMostAmount.Name = "tbxMostAmount";
            this.tbxMostAmount.ReadOnly = true;
            this.tbxMostAmount.Size = new System.Drawing.Size(381, 26);
            this.tbxMostAmount.TabIndex = 3;
            this.tbxMostAmount.TabStop = false;
            // 
            // lblLeastAmount
            // 
            this.lblLeastAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblLeastAmount.AutoSize = true;
            this.lblLeastAmount.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblLeastAmount.Location = new System.Drawing.Point(13, 24);
            this.lblLeastAmount.Name = "lblLeastAmount";
            this.lblLeastAmount.Size = new System.Drawing.Size(177, 19);
            this.lblLeastAmount.TabIndex = 0;
            this.lblLeastAmount.Text = "Least Expensive Item:";
            // 
            // lblMostAmount
            // 
            this.lblMostAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMostAmount.AutoSize = true;
            this.lblMostAmount.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblMostAmount.Location = new System.Drawing.Point(13, 90);
            this.lblMostAmount.Name = "lblMostAmount";
            this.lblMostAmount.Size = new System.Drawing.Size(172, 19);
            this.lblMostAmount.TabIndex = 1;
            this.lblMostAmount.Text = "Most Expensive Item:";
            // 
            // tbxLeastAmount
            // 
            this.tbxLeastAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxLeastAmount.Location = new System.Drawing.Point(13, 46);
            this.tbxLeastAmount.Name = "tbxLeastAmount";
            this.tbxLeastAmount.ReadOnly = true;
            this.tbxLeastAmount.Size = new System.Drawing.Size(381, 26);
            this.tbxLeastAmount.TabIndex = 2;
            this.tbxLeastAmount.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClose.AutoSize = true;
            this.btnClose.Font = new System.Drawing.Font("Arial", 12F);
            this.btnClose.Location = new System.Drawing.Point(179, 316);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 28);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.ttpInfo.SetToolTip(this.btnClose, "Click to return to the main form.");
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tbxLeastDate
            // 
            this.tbxLeastDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxLeastDate.Location = new System.Drawing.Point(13, 41);
            this.tbxLeastDate.Name = "tbxLeastDate";
            this.tbxLeastDate.ReadOnly = true;
            this.tbxLeastDate.Size = new System.Drawing.Size(194, 26);
            this.tbxLeastDate.TabIndex = 4;
            this.tbxLeastDate.TabStop = false;
            // 
            // tbxMostDate
            // 
            this.tbxMostDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxMostDate.Location = new System.Drawing.Point(213, 41);
            this.tbxMostDate.Name = "tbxMostDate";
            this.tbxMostDate.ReadOnly = true;
            this.tbxMostDate.Size = new System.Drawing.Size(195, 26);
            this.tbxMostDate.TabIndex = 5;
            this.tbxMostDate.TabStop = false;
            // 
            // Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 356);
            this.Controls.Add(this.tlpDetailsLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Details";
            this.ShowIcon = false;
            this.Text = "Expense Details";
            this.tlpDetailsLayout.ResumeLayout(false);
            this.tlpDetailsLayout.PerformLayout();
            this.gbxExpenseDates.ResumeLayout(false);
            this.tlpExpenseDates.ResumeLayout(false);
            this.tlpExpenseDates.PerformLayout();
            this.gbxExpenseAmounts.ResumeLayout(false);
            this.tlpExpenseAmounts.ResumeLayout(false);
            this.tlpExpenseAmounts.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpDetailsLayout;
        private System.Windows.Forms.GroupBox gbxExpenseAmounts;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ToolTip ttpInfo;
        private System.Windows.Forms.GroupBox gbxExpenseDates;
        private System.Windows.Forms.TableLayoutPanel tlpExpenseAmounts;
        private System.Windows.Forms.TextBox tbxMostAmount;
        private System.Windows.Forms.Label lblLeastAmount;
        private System.Windows.Forms.Label lblMostAmount;
        private System.Windows.Forms.TextBox tbxLeastAmount;
        private System.Windows.Forms.TableLayoutPanel tlpExpenseDates;
        private System.Windows.Forms.Label lblMostDate;
        private System.Windows.Forms.Label lblLeastDate;
        private System.Windows.Forms.TextBox tbxMostDate;
        private System.Windows.Forms.TextBox tbxLeastDate;
    }
}