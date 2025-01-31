namespace COSC2100_Lab1_RobertMacklem
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
            this.ttpInfoTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.tlpMainTable = new System.Windows.Forms.TableLayoutPanel();
            this.lblHumanYears = new System.Windows.Forms.Label();
            this.lblDogYears = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.nudHumanYears = new System.Windows.Forms.NumericUpDown();
            this.tbxDogYears = new System.Windows.Forms.TextBox();
            this.lblFlavourText = new System.Windows.Forms.Label();
            this.pbxDogImage = new System.Windows.Forms.PictureBox();
            this.tlpFlavourText = new System.Windows.Forms.TableLayoutPanel();
            this.tlpMainTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHumanYears)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDogImage)).BeginInit();
            this.tlpFlavourText.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMainTable
            // 
            this.tlpMainTable.ColumnCount = 2;
            this.tlpMainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMainTable.Controls.Add(this.lblHumanYears, 0, 0);
            this.tlpMainTable.Controls.Add(this.lblDogYears, 0, 1);
            this.tlpMainTable.Controls.Add(this.btnReset, 0, 2);
            this.tlpMainTable.Controls.Add(this.btnCalculate, 1, 2);
            this.tlpMainTable.Controls.Add(this.nudHumanYears, 1, 0);
            this.tlpMainTable.Controls.Add(this.tbxDogYears, 1, 1);
            this.tlpMainTable.Controls.Add(this.tlpFlavourText, 0, 3);
            this.tlpMainTable.Location = new System.Drawing.Point(12, 12);
            this.tlpMainTable.Name = "tlpMainTable";
            this.tlpMainTable.RowCount = 4;
            this.tlpMainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpMainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpMainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlpMainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tlpMainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMainTable.Size = new System.Drawing.Size(276, 247);
            this.tlpMainTable.TabIndex = 1;
            // 
            // lblHumanYears
            // 
            this.lblHumanYears.AutoSize = true;
            this.lblHumanYears.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHumanYears.Location = new System.Drawing.Point(3, 0);
            this.lblHumanYears.Name = "lblHumanYears";
            this.lblHumanYears.Size = new System.Drawing.Size(132, 24);
            this.lblHumanYears.TabIndex = 0;
            this.lblHumanYears.Text = "Dog Age in Human Years";
            this.lblHumanYears.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDogYears
            // 
            this.lblDogYears.AutoSize = true;
            this.lblDogYears.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDogYears.Location = new System.Drawing.Point(3, 24);
            this.lblDogYears.Name = "lblDogYears";
            this.lblDogYears.Size = new System.Drawing.Size(132, 24);
            this.lblDogYears.TabIndex = 1;
            this.lblDogYears.Text = "Dog Age in Dog Years";
            this.lblDogYears.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnReset
            // 
            this.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnReset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnReset.Location = new System.Drawing.Point(3, 51);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(132, 31);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset";
            this.ttpInfoTooltip.SetToolTip(this.btnReset, "Click to reset the form.");
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCalculate.Location = new System.Drawing.Point(141, 51);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(132, 31);
            this.btnCalculate.TabIndex = 1;
            this.btnCalculate.Text = "Calculate";
            this.ttpInfoTooltip.SetToolTip(this.btnCalculate, "Click to calcuate dog years.");
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // nudHumanYears
            // 
            this.nudHumanYears.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudHumanYears.Location = new System.Drawing.Point(141, 3);
            this.nudHumanYears.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.nudHumanYears.Name = "nudHumanYears";
            this.nudHumanYears.Size = new System.Drawing.Size(132, 20);
            this.nudHumanYears.TabIndex = 0;
            this.ttpInfoTooltip.SetToolTip(this.nudHumanYears, "Input your dog\'s age in human years.");
            // 
            // tbxDogYears
            // 
            this.tbxDogYears.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxDogYears.Location = new System.Drawing.Point(141, 27);
            this.tbxDogYears.Name = "tbxDogYears";
            this.tbxDogYears.ReadOnly = true;
            this.tbxDogYears.Size = new System.Drawing.Size(132, 20);
            this.tbxDogYears.TabIndex = 0;
            this.tbxDogYears.Text = "0";
            this.ttpInfoTooltip.SetToolTip(this.tbxDogYears, "Your dog\'s age, in dog years.");
            // 
            // lblFlavourText
            // 
            this.lblFlavourText.AutoSize = true;
            this.lblFlavourText.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblFlavourText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFlavourText.Location = new System.Drawing.Point(3, 0);
            this.lblFlavourText.Name = "lblFlavourText";
            this.lblFlavourText.Size = new System.Drawing.Size(264, 31);
            this.lblFlavourText.TabIndex = 0;
            this.lblFlavourText.Text = "Flavour Text";
            this.lblFlavourText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbxDogImage
            // 
            this.pbxDogImage.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pbxDogImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbxDogImage.Location = new System.Drawing.Point(3, 34);
            this.pbxDogImage.Name = "pbxDogImage";
            this.pbxDogImage.Size = new System.Drawing.Size(264, 119);
            this.pbxDogImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxDogImage.TabIndex = 6;
            this.pbxDogImage.TabStop = false;
            // 
            // tlpFlavourText
            // 
            this.tlpFlavourText.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tlpFlavourText.ColumnCount = 1;
            this.tlpMainTable.SetColumnSpan(this.tlpFlavourText, 2);
            this.tlpFlavourText.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFlavourText.Controls.Add(this.pbxDogImage, 0, 1);
            this.tlpFlavourText.Controls.Add(this.lblFlavourText, 0, 0);
            this.tlpFlavourText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpFlavourText.Location = new System.Drawing.Point(3, 88);
            this.tlpFlavourText.Name = "tlpFlavourText";
            this.tlpFlavourText.RowCount = 2;
            this.tlpFlavourText.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpFlavourText.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tlpFlavourText.Size = new System.Drawing.Size(270, 156);
            this.tlpFlavourText.TabIndex = 7;
            // 
            // frmMain
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnReset;
            this.ClientSize = new System.Drawing.Size(300, 271);
            this.Controls.Add(this.tlpMainTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dog Years Converter — Robert Macklem";
            this.tlpMainTable.ResumeLayout(false);
            this.tlpMainTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHumanYears)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDogImage)).EndInit();
            this.tlpFlavourText.ResumeLayout(false);
            this.tlpFlavourText.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolTip ttpInfoTooltip;
        private System.Windows.Forms.TableLayoutPanel tlpMainTable;
        private System.Windows.Forms.Label lblHumanYears;
        private System.Windows.Forms.Label lblDogYears;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.NumericUpDown nudHumanYears;
        private System.Windows.Forms.TextBox tbxDogYears;
        private System.Windows.Forms.Label lblFlavourText;
        private System.Windows.Forms.PictureBox pbxDogImage;
        private System.Windows.Forms.TableLayoutPanel tlpFlavourText;
    }
}

