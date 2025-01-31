namespace COSC2100_ICE1_RobertMacklem
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
            this.lblStudentNumber = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblProgramName = new System.Windows.Forms.Label();
            this.lblSemesters = new System.Windows.Forms.Label();
            this.lopLayout = new System.Windows.Forms.TableLayoutPanel();
            this.mtbStudentNumber = new System.Windows.Forms.MaskedTextBox();
            this.cmbProgram = new System.Windows.Forms.ComboBox();
            this.nudSemesters = new System.Windows.Forms.NumericUpDown();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.ttpTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.ttpError = new System.Windows.Forms.ToolTip(this.components);
            this.lopLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSemesters)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStudentNumber
            // 
            this.lblStudentNumber.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblStudentNumber.AutoSize = true;
            this.lblStudentNumber.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(43)))), ((int)(((byte)(47)))));
            this.lblStudentNumber.Location = new System.Drawing.Point(89, 6);
            this.lblStudentNumber.Name = "lblStudentNumber";
            this.lblStudentNumber.Size = new System.Drawing.Size(95, 15);
            this.lblStudentNumber.TabIndex = 0;
            this.lblStudentNumber.Text = "Student Number:";
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(43)))), ((int)(((byte)(47)))));
            this.lblName.Location = new System.Drawing.Point(145, 34);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(39, 15);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name:";
            // 
            // lblProgramName
            // 
            this.lblProgramName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblProgramName.AutoSize = true;
            this.lblProgramName.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgramName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(43)))), ((int)(((byte)(47)))));
            this.lblProgramName.Location = new System.Drawing.Point(99, 63);
            this.lblProgramName.Name = "lblProgramName";
            this.lblProgramName.Size = new System.Drawing.Size(85, 15);
            this.lblProgramName.TabIndex = 4;
            this.lblProgramName.Text = "Program Name:";
            // 
            // lblSemesters
            // 
            this.lblSemesters.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblSemesters.AutoSize = true;
            this.lblSemesters.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSemesters.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(43)))), ((int)(((byte)(47)))));
            this.lblSemesters.Location = new System.Drawing.Point(3, 91);
            this.lblSemesters.Name = "lblSemesters";
            this.lblSemesters.Size = new System.Drawing.Size(181, 15);
            this.lblSemesters.TabIndex = 6;
            this.lblSemesters.Text = "Duration Remaining in Semesters:";
            // 
            // lopLayout
            // 
            this.lopLayout.ColumnCount = 2;
            this.lopLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.lopLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.lopLayout.Controls.Add(this.lblSemesters, 0, 3);
            this.lopLayout.Controls.Add(this.mtbStudentNumber, 1, 0);
            this.lopLayout.Controls.Add(this.cmbProgram, 1, 2);
            this.lopLayout.Controls.Add(this.nudSemesters, 1, 3);
            this.lopLayout.Controls.Add(this.tbxName, 1, 1);
            this.lopLayout.Controls.Add(this.lblStudentNumber, 0, 0);
            this.lopLayout.Controls.Add(this.lblProgramName, 0, 2);
            this.lopLayout.Controls.Add(this.lblName, 0, 1);
            this.lopLayout.Controls.Add(this.btnRegister, 1, 4);
            this.lopLayout.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lopLayout.Location = new System.Drawing.Point(12, 14);
            this.lopLayout.Name = "lopLayout";
            this.lopLayout.RowCount = 5;
            this.lopLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.lopLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.lopLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.lopLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.lopLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.lopLayout.Size = new System.Drawing.Size(406, 181);
            this.lopLayout.TabIndex = 4;
            // 
            // mtbStudentNumber
            // 
            this.mtbStudentNumber.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbStudentNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(43)))), ((int)(((byte)(47)))));
            this.mtbStudentNumber.Location = new System.Drawing.Point(190, 3);
            this.mtbStudentNumber.Mask = "1\\0\\0######";
            this.mtbStudentNumber.Name = "mtbStudentNumber";
            this.mtbStudentNumber.Size = new System.Drawing.Size(206, 22);
            this.mtbStudentNumber.TabIndex = 1;
            this.ttpTooltip.SetToolTip(this.mtbStudentNumber, "Enter your student ID.");
            // 
            // cmbProgram
            // 
            this.cmbProgram.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProgram.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProgram.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(43)))), ((int)(((byte)(47)))));
            this.cmbProgram.FormattingEnabled = true;
            this.cmbProgram.Items.AddRange(new object[] {
            "Computer Programming",
            "Computer Programming and Analysis",
            "Computer Systems Technician",
            "Computer Systems Technology"});
            this.cmbProgram.Location = new System.Drawing.Point(190, 59);
            this.cmbProgram.Name = "cmbProgram";
            this.cmbProgram.Size = new System.Drawing.Size(206, 23);
            this.cmbProgram.TabIndex = 5;
            this.ttpTooltip.SetToolTip(this.cmbProgram, "Select your program.");
            // 
            // nudSemesters
            // 
            this.nudSemesters.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudSemesters.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(43)))), ((int)(((byte)(47)))));
            this.nudSemesters.Location = new System.Drawing.Point(190, 88);
            this.nudSemesters.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nudSemesters.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudSemesters.Name = "nudSemesters";
            this.nudSemesters.ReadOnly = true;
            this.nudSemesters.Size = new System.Drawing.Size(206, 22);
            this.nudSemesters.TabIndex = 7;
            this.ttpTooltip.SetToolTip(this.nudSemesters, "Select the number of semesters remaining in your program.");
            this.nudSemesters.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudSemesters.ValueChanged += new System.EventHandler(this.nudSemesters_ValueChanged);
            // 
            // tbxName
            // 
            this.tbxName.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(43)))), ((int)(((byte)(47)))));
            this.tbxName.Location = new System.Drawing.Point(190, 31);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(206, 22);
            this.tbxName.TabIndex = 3;
            this.ttpTooltip.SetToolTip(this.tbxName, "Enter your name.");
            // 
            // btnRegister
            // 
            this.btnRegister.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(71)))), ((int)(((byte)(19)))));
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRegister.Location = new System.Drawing.Point(297, 139);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(3, 3, 9, 3);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(100, 39);
            this.btnRegister.TabIndex = 8;
            this.btnRegister.Text = "Register";
            this.ttpTooltip.SetToolTip(this.btnRegister, "Submit your data.");
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // ttpError
            // 
            this.ttpError.ForeColor = System.Drawing.Color.Red;
            this.ttpError.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Error;
            this.ttpError.ToolTipTitle = "Error";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(430, 209);
            this.Controls.Add(this.lopLayout);
            this.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Registration Form — Robert Macklem";
            this.lopLayout.ResumeLayout(false);
            this.lopLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSemesters)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblStudentNumber;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblProgramName;
        private System.Windows.Forms.Label lblSemesters;
        private System.Windows.Forms.TableLayoutPanel lopLayout;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.MaskedTextBox mtbStudentNumber;
        private System.Windows.Forms.ToolTip ttpTooltip;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.ComboBox cmbProgram;
        private System.Windows.Forms.NumericUpDown nudSemesters;
        private System.Windows.Forms.ToolTip ttpError;
    }
}

