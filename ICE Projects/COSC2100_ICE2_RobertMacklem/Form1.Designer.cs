namespace COSC2100_ICE2_RobertMacklem
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tlpAppreciationText = new System.Windows.Forms.TableLayoutPanel();
            this.lblAppreciationText = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblGeneration = new System.Windows.Forms.Label();
            this.lblCalendarInput = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnShowResults = new System.Windows.Forms.Button();
            this.dtpCalendarInput = new System.Windows.Forms.DateTimePicker();
            this.pbxGeneration = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tlpAppreciationText.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxGeneration)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tlpAppreciationText, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblCalendarInput, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnReset, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnShowResults, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.dtpCalendarInput, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(285, 357);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tlpAppreciationText
            // 
            this.tlpAppreciationText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpAppreciationText.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tlpAppreciationText.ColumnCount = 1;
            this.tableLayoutPanel1.SetColumnSpan(this.tlpAppreciationText, 2);
            this.tlpAppreciationText.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpAppreciationText.Controls.Add(this.lblAppreciationText, 0, 3);
            this.tlpAppreciationText.Controls.Add(this.lblAge, 0, 0);
            this.tlpAppreciationText.Controls.Add(this.lblGeneration, 0, 1);
            this.tlpAppreciationText.Controls.Add(this.pbxGeneration, 0, 2);
            this.tlpAppreciationText.Location = new System.Drawing.Point(3, 85);
            this.tlpAppreciationText.Name = "tlpAppreciationText";
            this.tlpAppreciationText.RowCount = 4;
            this.tlpAppreciationText.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpAppreciationText.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpAppreciationText.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpAppreciationText.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpAppreciationText.Size = new System.Drawing.Size(279, 269);
            this.tlpAppreciationText.TabIndex = 1;
            // 
            // lblAppreciationText
            // 
            this.lblAppreciationText.AutoSize = true;
            this.lblAppreciationText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAppreciationText.Location = new System.Drawing.Point(5, 218);
            this.lblAppreciationText.Margin = new System.Windows.Forms.Padding(5);
            this.lblAppreciationText.Name = "lblAppreciationText";
            this.lblAppreciationText.Size = new System.Drawing.Size(269, 46);
            this.lblAppreciationText.TabIndex = 2;
            this.lblAppreciationText.Text = "\"Appreciation\" Text";
            this.lblAppreciationText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAge.Location = new System.Drawing.Point(5, 10);
            this.lblAge.Margin = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(269, 13);
            this.lblAge.TabIndex = 0;
            this.lblAge.Text = "User Age";
            this.lblAge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGeneration
            // 
            this.lblGeneration.AutoSize = true;
            this.lblGeneration.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGeneration.Location = new System.Drawing.Point(5, 33);
            this.lblGeneration.Margin = new System.Windows.Forms.Padding(5);
            this.lblGeneration.Name = "lblGeneration";
            this.lblGeneration.Size = new System.Drawing.Size(269, 13);
            this.lblGeneration.TabIndex = 1;
            this.lblGeneration.Text = "Generation";
            this.lblGeneration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCalendarInput
            // 
            this.lblCalendarInput.AutoSize = true;
            this.lblCalendarInput.Location = new System.Drawing.Point(5, 5);
            this.lblCalendarInput.Margin = new System.Windows.Forms.Padding(5);
            this.lblCalendarInput.Name = "lblCalendarInput";
            this.lblCalendarInput.Size = new System.Drawing.Size(104, 13);
            this.lblCalendarInput.TabIndex = 2;
            this.lblCalendarInput.Text = "Select your Birthday:";
            // 
            // btnReset
            // 
            this.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnReset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnReset.Location = new System.Drawing.Point(3, 54);
            this.btnReset.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(136, 23);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnShowResults
            // 
            this.btnShowResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnShowResults.Location = new System.Drawing.Point(145, 54);
            this.btnShowResults.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnShowResults.Name = "btnShowResults";
            this.btnShowResults.Size = new System.Drawing.Size(137, 23);
            this.btnShowResults.TabIndex = 2;
            this.btnShowResults.Text = "Show Results";
            this.btnShowResults.UseVisualStyleBackColor = true;
            this.btnShowResults.Click += new System.EventHandler(this.btnShowResults_Click);
            // 
            // dtpCalendarInput
            // 
            this.dtpCalendarInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.dtpCalendarInput, 2);
            this.dtpCalendarInput.Location = new System.Drawing.Point(3, 26);
            this.dtpCalendarInput.MaxDate = new System.DateTime(2025, 1, 21, 0, 0, 0, 0);
            this.dtpCalendarInput.MinDate = new System.DateTime(1901, 1, 1, 0, 0, 0, 0);
            this.dtpCalendarInput.Name = "dtpCalendarInput";
            this.dtpCalendarInput.Size = new System.Drawing.Size(279, 20);
            this.dtpCalendarInput.TabIndex = 0;
            this.dtpCalendarInput.Value = new System.DateTime(2025, 1, 21, 0, 0, 0, 0);
            // 
            // pbxGeneration
            // 
            this.pbxGeneration.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbxGeneration.Location = new System.Drawing.Point(3, 54);
            this.pbxGeneration.Name = "pbxGeneration";
            this.pbxGeneration.Size = new System.Drawing.Size(273, 156);
            this.pbxGeneration.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxGeneration.TabIndex = 4;
            this.pbxGeneration.TabStop = false;
            // 
            // frmMain
            // 
            this.AcceptButton = this.btnShowResults;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnReset;
            this.ClientSize = new System.Drawing.Size(309, 381);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(325, 420);
            this.Name = "frmMain";
            this.Text = "Generations — Robert Macklem";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tlpAppreciationText.ResumeLayout(false);
            this.tlpAppreciationText.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxGeneration)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnShowResults;
        private System.Windows.Forms.Label lblCalendarInput;
        private System.Windows.Forms.DateTimePicker dtpCalendarInput;
        private System.Windows.Forms.Label lblAppreciationText;
        private System.Windows.Forms.Label lblGeneration;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.PictureBox pbxGeneration;
        private System.Windows.Forms.TableLayoutPanel tlpAppreciationText;
    }
}

