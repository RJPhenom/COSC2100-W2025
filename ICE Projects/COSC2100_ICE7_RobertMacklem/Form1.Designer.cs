namespace COSC2100_ICE7_RobertMacklem
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
            this.tlpMainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblAnimalEmoji = new System.Windows.Forms.Label();
            this.tlpButtonsLayout = new System.Windows.Forms.TableLayoutPanel();
            this.btnOption4 = new System.Windows.Forms.Button();
            this.btnOption3 = new System.Windows.Forms.Button();
            this.btnOption2 = new System.Windows.Forms.Button();
            this.btnOption1 = new System.Windows.Forms.Button();
            this.pgbProgress = new System.Windows.Forms.ProgressBar();
            this.tmrTimer = new System.Windows.Forms.Timer(this.components);
            this.tlpMainLayout.SuspendLayout();
            this.tlpButtonsLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMainLayout
            // 
            this.tlpMainLayout.ColumnCount = 1;
            this.tlpMainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMainLayout.Controls.Add(this.lblTitle, 0, 0);
            this.tlpMainLayout.Controls.Add(this.lblAnimalEmoji, 0, 1);
            this.tlpMainLayout.Controls.Add(this.tlpButtonsLayout, 0, 3);
            this.tlpMainLayout.Controls.Add(this.pgbProgress, 0, 2);
            this.tlpMainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMainLayout.Location = new System.Drawing.Point(0, 0);
            this.tlpMainLayout.Name = "tlpMainLayout";
            this.tlpMainLayout.RowCount = 4;
            this.tlpMainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpMainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpMainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpMainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpMainLayout.Size = new System.Drawing.Size(519, 450);
            this.tlpMainLayout.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Kristen ITC", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(41, 39);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(437, 58);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "What animal is this?";
            // 
            // lblAnimalEmoji
            // 
            this.lblAnimalEmoji.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAnimalEmoji.AutoSize = true;
            this.lblAnimalEmoji.Font = new System.Drawing.Font("Kristen ITC", 62F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnimalEmoji.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblAnimalEmoji.Location = new System.Drawing.Point(181, 147);
            this.lblAnimalEmoji.Name = "lblAnimalEmoji";
            this.lblAnimalEmoji.Size = new System.Drawing.Size(157, 114);
            this.lblAnimalEmoji.TabIndex = 1;
            this.lblAnimalEmoji.Text = "🐈";
            // 
            // tlpButtonsLayout
            // 
            this.tlpButtonsLayout.ColumnCount = 2;
            this.tlpButtonsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpButtonsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpButtonsLayout.Controls.Add(this.btnOption4, 1, 1);
            this.tlpButtonsLayout.Controls.Add(this.btnOption3, 0, 1);
            this.tlpButtonsLayout.Controls.Add(this.btnOption2, 1, 0);
            this.tlpButtonsLayout.Controls.Add(this.btnOption1, 0, 0);
            this.tlpButtonsLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpButtonsLayout.Location = new System.Drawing.Point(3, 315);
            this.tlpButtonsLayout.Name = "tlpButtonsLayout";
            this.tlpButtonsLayout.RowCount = 2;
            this.tlpButtonsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpButtonsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpButtonsLayout.Size = new System.Drawing.Size(513, 132);
            this.tlpButtonsLayout.TabIndex = 2;
            // 
            // btnOption4
            // 
            this.btnOption4.BackColor = System.Drawing.Color.Plum;
            this.btnOption4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOption4.Font = new System.Drawing.Font("Kristen ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOption4.Location = new System.Drawing.Point(259, 69);
            this.btnOption4.Name = "btnOption4";
            this.btnOption4.Size = new System.Drawing.Size(251, 60);
            this.btnOption4.TabIndex = 3;
            this.btnOption4.Text = "Option 4";
            this.btnOption4.UseVisualStyleBackColor = false;
            this.btnOption4.Click += new System.EventHandler(this.SelectOption);
            // 
            // btnOption3
            // 
            this.btnOption3.BackColor = System.Drawing.Color.Plum;
            this.btnOption3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOption3.Font = new System.Drawing.Font("Kristen ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOption3.Location = new System.Drawing.Point(3, 69);
            this.btnOption3.Name = "btnOption3";
            this.btnOption3.Size = new System.Drawing.Size(250, 60);
            this.btnOption3.TabIndex = 2;
            this.btnOption3.Text = "Option 3";
            this.btnOption3.UseVisualStyleBackColor = false;
            this.btnOption3.Click += new System.EventHandler(this.SelectOption);
            // 
            // btnOption2
            // 
            this.btnOption2.BackColor = System.Drawing.Color.Plum;
            this.btnOption2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOption2.Font = new System.Drawing.Font("Kristen ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOption2.Location = new System.Drawing.Point(259, 3);
            this.btnOption2.Name = "btnOption2";
            this.btnOption2.Size = new System.Drawing.Size(251, 60);
            this.btnOption2.TabIndex = 1;
            this.btnOption2.Text = "Option 2";
            this.btnOption2.UseVisualStyleBackColor = false;
            this.btnOption2.Click += new System.EventHandler(this.SelectOption);
            // 
            // btnOption1
            // 
            this.btnOption1.BackColor = System.Drawing.Color.Plum;
            this.btnOption1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOption1.Font = new System.Drawing.Font("Kristen ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOption1.Location = new System.Drawing.Point(3, 3);
            this.btnOption1.Name = "btnOption1";
            this.btnOption1.Size = new System.Drawing.Size(250, 60);
            this.btnOption1.TabIndex = 0;
            this.btnOption1.Text = "Option 1";
            this.btnOption1.UseVisualStyleBackColor = false;
            this.btnOption1.Click += new System.EventHandler(this.SelectOption);
            // 
            // pgbProgress
            // 
            this.pgbProgress.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.pgbProgress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pgbProgress.Location = new System.Drawing.Point(3, 275);
            this.pgbProgress.Maximum = 10;
            this.pgbProgress.Name = "pgbProgress";
            this.pgbProgress.Size = new System.Drawing.Size(513, 34);
            this.pgbProgress.Step = 1;
            this.pgbProgress.TabIndex = 3;
            // 
            // tmrTimer
            // 
            this.tmrTimer.Enabled = true;
            this.tmrTimer.Interval = 5000;
            this.tmrTimer.Tick += new System.EventHandler(this.TimerTick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(519, 450);
            this.Controls.Add(this.tlpMainLayout);
            this.Name = "frmMain";
            this.Text = "Guess the Animal — Robert Macklem";
            this.tlpMainLayout.ResumeLayout(false);
            this.tlpMainLayout.PerformLayout();
            this.tlpButtonsLayout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMainLayout;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblAnimalEmoji;
        private System.Windows.Forms.TableLayoutPanel tlpButtonsLayout;
        private System.Windows.Forms.Button btnOption1;
        private System.Windows.Forms.Button btnOption4;
        private System.Windows.Forms.Button btnOption3;
        private System.Windows.Forms.Button btnOption2;
        private System.Windows.Forms.ProgressBar pgbProgress;
        private System.Windows.Forms.Timer tmrTimer;
    }
}

