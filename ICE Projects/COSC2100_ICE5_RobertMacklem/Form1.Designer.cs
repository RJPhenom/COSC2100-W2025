namespace COSC2100_ICE5_RobertMacklem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.tlpLayoutTable = new System.Windows.Forms.TableLayoutPanel();
            this.lblPasswordEntr = new System.Windows.Forms.Label();
            this.lblPasswordStr = new System.Windows.Forms.Label();
            this.lblPasswordReq = new System.Windows.Forms.Label();
            this.tlpPasswordInputs = new System.Windows.Forms.TableLayoutPanel();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.btnShowPassword = new System.Windows.Forms.Button();
            this.btnRandomize = new System.Windows.Forms.Button();
            this.pgbStrength = new System.Windows.Forms.ProgressBar();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTenCharReq = new System.Windows.Forms.Label();
            this.lblSpecialCharReq = new System.Windows.Forms.Label();
            this.lblNumericReq = new System.Windows.Forms.Label();
            this.lblUpperAlphaReq = new System.Windows.Forms.Label();
            this.lblLowerAlphaReq = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tlpLayoutTable.SuspendLayout();
            this.tlpPasswordInputs.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpLayoutTable
            // 
            this.tlpLayoutTable.ColumnCount = 1;
            this.tlpLayoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpLayoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpLayoutTable.Controls.Add(this.lblPasswordEntr, 0, 0);
            this.tlpLayoutTable.Controls.Add(this.lblPasswordStr, 0, 2);
            this.tlpLayoutTable.Controls.Add(this.lblPasswordReq, 0, 4);
            this.tlpLayoutTable.Controls.Add(this.tlpPasswordInputs, 0, 1);
            this.tlpLayoutTable.Controls.Add(this.pgbStrength, 0, 3);
            this.tlpLayoutTable.Controls.Add(this.tableLayoutPanel1, 0, 5);
            this.tlpLayoutTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpLayoutTable.Location = new System.Drawing.Point(0, 0);
            this.tlpLayoutTable.Name = "tlpLayoutTable";
            this.tlpLayoutTable.RowCount = 6;
            this.tlpLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpLayoutTable.Size = new System.Drawing.Size(494, 339);
            this.tlpLayoutTable.TabIndex = 0;
            // 
            // lblPasswordEntr
            // 
            this.lblPasswordEntr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPasswordEntr.AutoSize = true;
            this.lblPasswordEntr.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordEntr.Location = new System.Drawing.Point(3, 25);
            this.lblPasswordEntr.Name = "lblPasswordEntr";
            this.lblPasswordEntr.Size = new System.Drawing.Size(211, 31);
            this.lblPasswordEntr.TabIndex = 0;
            this.lblPasswordEntr.Text = "Enter password:";
            // 
            // lblPasswordStr
            // 
            this.lblPasswordStr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPasswordStr.AutoSize = true;
            this.lblPasswordStr.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordStr.Location = new System.Drawing.Point(3, 137);
            this.lblPasswordStr.Name = "lblPasswordStr";
            this.lblPasswordStr.Size = new System.Drawing.Size(248, 31);
            this.lblPasswordStr.TabIndex = 1;
            this.lblPasswordStr.Text = "Password strength:";
            // 
            // lblPasswordReq
            // 
            this.lblPasswordReq.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPasswordReq.AutoSize = true;
            this.lblPasswordReq.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordReq.Location = new System.Drawing.Point(3, 249);
            this.lblPasswordReq.Name = "lblPasswordReq";
            this.lblPasswordReq.Size = new System.Drawing.Size(191, 31);
            this.lblPasswordReq.TabIndex = 2;
            this.lblPasswordReq.Text = "Requirements:";
            this.lblPasswordReq.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tlpPasswordInputs
            // 
            this.tlpPasswordInputs.ColumnCount = 3;
            this.tlpPasswordInputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpPasswordInputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tlpPasswordInputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpPasswordInputs.Controls.Add(this.tbxPassword, 1, 0);
            this.tlpPasswordInputs.Controls.Add(this.btnShowPassword, 2, 0);
            this.tlpPasswordInputs.Controls.Add(this.btnRandomize, 0, 0);
            this.tlpPasswordInputs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPasswordInputs.Location = new System.Drawing.Point(3, 59);
            this.tlpPasswordInputs.Name = "tlpPasswordInputs";
            this.tlpPasswordInputs.RowCount = 1;
            this.tlpPasswordInputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPasswordInputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tlpPasswordInputs.Size = new System.Drawing.Size(488, 50);
            this.tlpPasswordInputs.TabIndex = 3;
            // 
            // tbxPassword
            // 
            this.tbxPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPassword.Location = new System.Drawing.Point(51, 6);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.PasswordChar = '•';
            this.tbxPassword.Size = new System.Drawing.Size(384, 38);
            this.tbxPassword.TabIndex = 1;
            this.toolTip1.SetToolTip(this.tbxPassword, "Enter a password.");
            this.tbxPassword.TextChanged += new System.EventHandler(this.OnPasswordTextChanged);
            // 
            // btnShowPassword
            // 
            this.btnShowPassword.BackColor = System.Drawing.Color.Transparent;
            this.btnShowPassword.BackgroundImage = global::COSC2100_ICE5_RobertMacklem.Properties.Resources.imgHidePassword;
            this.btnShowPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnShowPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnShowPassword.FlatAppearance.BorderSize = 0;
            this.btnShowPassword.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnShowPassword.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnShowPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowPassword.Location = new System.Drawing.Point(441, 3);
            this.btnShowPassword.Name = "btnShowPassword";
            this.btnShowPassword.Size = new System.Drawing.Size(44, 44);
            this.btnShowPassword.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btnShowPassword, "Click to Show/Hide password.");
            this.btnShowPassword.UseVisualStyleBackColor = false;
            this.btnShowPassword.Click += new System.EventHandler(this.btnShowPassword_Click);
            // 
            // btnRandomize
            // 
            this.btnRandomize.BackColor = System.Drawing.Color.Transparent;
            this.btnRandomize.BackgroundImage = global::COSC2100_ICE5_RobertMacklem.Properties.Resources.imgRandomize;
            this.btnRandomize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRandomize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRandomize.FlatAppearance.BorderSize = 0;
            this.btnRandomize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnRandomize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRandomize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRandomize.Location = new System.Drawing.Point(3, 3);
            this.btnRandomize.Name = "btnRandomize";
            this.btnRandomize.Size = new System.Drawing.Size(42, 44);
            this.btnRandomize.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btnRandomize, "Click to randomly generate a strong password.");
            this.btnRandomize.UseVisualStyleBackColor = false;
            this.btnRandomize.Click += new System.EventHandler(this.btnRandomize_Click);
            // 
            // pgbStrength
            // 
            this.pgbStrength.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pgbStrength.Location = new System.Drawing.Point(3, 171);
            this.pgbStrength.Maximum = 5;
            this.pgbStrength.Name = "pgbStrength";
            this.pgbStrength.Size = new System.Drawing.Size(488, 50);
            this.pgbStrength.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.lblTenCharReq, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblSpecialCharReq, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblNumericReq, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblUpperAlphaReq, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblLowerAlphaReq, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 283);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(488, 53);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // lblTenCharReq
            // 
            this.lblTenCharReq.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTenCharReq.AutoSize = true;
            this.lblTenCharReq.BackColor = System.Drawing.Color.Red;
            this.lblTenCharReq.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTenCharReq.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenCharReq.Location = new System.Drawing.Point(412, 12);
            this.lblTenCharReq.Margin = new System.Windows.Forms.Padding(3);
            this.lblTenCharReq.Name = "lblTenCharReq";
            this.lblTenCharReq.Size = new System.Drawing.Size(51, 28);
            this.lblTenCharReq.TabIndex = 4;
            this.lblTenCharReq.Text = "10+";
            this.toolTip1.SetToolTip(this.lblTenCharReq, "Passwords must contain at least 10 characters.");
            // 
            // lblSpecialCharReq
            // 
            this.lblSpecialCharReq.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSpecialCharReq.AutoSize = true;
            this.lblSpecialCharReq.BackColor = System.Drawing.Color.Red;
            this.lblSpecialCharReq.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSpecialCharReq.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpecialCharReq.Location = new System.Drawing.Point(296, 12);
            this.lblSpecialCharReq.Margin = new System.Windows.Forms.Padding(3);
            this.lblSpecialCharReq.Name = "lblSpecialCharReq";
            this.lblSpecialCharReq.Size = new System.Drawing.Size(86, 28);
            this.lblSpecialCharReq.TabIndex = 3;
            this.lblSpecialCharReq.Text = "!@#$%";
            this.toolTip1.SetToolTip(this.lblSpecialCharReq, "Passwords must contain at least 1 special character.");
            // 
            // lblNumericReq
            // 
            this.lblNumericReq.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNumericReq.AutoSize = true;
            this.lblNumericReq.BackColor = System.Drawing.Color.Red;
            this.lblNumericReq.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNumericReq.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumericReq.Location = new System.Drawing.Point(220, 12);
            this.lblNumericReq.Margin = new System.Windows.Forms.Padding(3);
            this.lblNumericReq.Name = "lblNumericReq";
            this.lblNumericReq.Size = new System.Drawing.Size(45, 28);
            this.lblNumericReq.TabIndex = 2;
            this.lblNumericReq.Text = "0-9";
            this.toolTip1.SetToolTip(this.lblNumericReq, "Passwords must contain at least 1 numeric character.");
            // 
            // lblUpperAlphaReq
            // 
            this.lblUpperAlphaReq.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUpperAlphaReq.AutoSize = true;
            this.lblUpperAlphaReq.BackColor = System.Drawing.Color.Red;
            this.lblUpperAlphaReq.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblUpperAlphaReq.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpperAlphaReq.Location = new System.Drawing.Point(121, 12);
            this.lblUpperAlphaReq.Margin = new System.Windows.Forms.Padding(3);
            this.lblUpperAlphaReq.Name = "lblUpperAlphaReq";
            this.lblUpperAlphaReq.Size = new System.Drawing.Size(49, 28);
            this.lblUpperAlphaReq.TabIndex = 1;
            this.lblUpperAlphaReq.Text = "A-Z";
            this.toolTip1.SetToolTip(this.lblUpperAlphaReq, "Passwords must contain at least 1 uppercase letter.");
            // 
            // lblLowerAlphaReq
            // 
            this.lblLowerAlphaReq.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLowerAlphaReq.AutoSize = true;
            this.lblLowerAlphaReq.BackColor = System.Drawing.Color.Red;
            this.lblLowerAlphaReq.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLowerAlphaReq.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLowerAlphaReq.Location = new System.Drawing.Point(26, 12);
            this.lblLowerAlphaReq.Margin = new System.Windows.Forms.Padding(3);
            this.lblLowerAlphaReq.Name = "lblLowerAlphaReq";
            this.lblLowerAlphaReq.Size = new System.Drawing.Size(44, 28);
            this.lblLowerAlphaReq.TabIndex = 0;
            this.lblLowerAlphaReq.Text = "a-z";
            this.toolTip1.SetToolTip(this.lblLowerAlphaReq, "Passwords must contain at least 1 lowercase letter.");
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 339);
            this.Controls.Add(this.tlpLayoutTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(510, 375);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Password Generator — Robert Macklem";
            this.tlpLayoutTable.ResumeLayout(false);
            this.tlpLayoutTable.PerformLayout();
            this.tlpPasswordInputs.ResumeLayout(false);
            this.tlpPasswordInputs.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpLayoutTable;
        private System.Windows.Forms.Label lblPasswordEntr;
        private System.Windows.Forms.Label lblPasswordStr;
        private System.Windows.Forms.Label lblPasswordReq;
        private System.Windows.Forms.TableLayoutPanel tlpPasswordInputs;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.Button btnShowPassword;
        private System.Windows.Forms.Button btnRandomize;
        private System.Windows.Forms.ProgressBar pgbStrength;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblTenCharReq;
        private System.Windows.Forms.Label lblSpecialCharReq;
        private System.Windows.Forms.Label lblNumericReq;
        private System.Windows.Forms.Label lblUpperAlphaReq;
        private System.Windows.Forms.Label lblLowerAlphaReq;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

