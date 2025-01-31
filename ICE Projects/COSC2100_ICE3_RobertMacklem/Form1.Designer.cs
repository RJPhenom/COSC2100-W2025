namespace COSC2100_ICE3_RobertMacklem
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
            this.lblBugsSquashed = new System.Windows.Forms.Label();
            this.pbxBug = new System.Windows.Forms.PictureBox();
            this.pnlUIHeader = new System.Windows.Forms.Panel();
            this.lblTime = new System.Windows.Forms.Label();
            this.tmrSpawnTimer = new System.Windows.Forms.Timer(this.components);
            this.tmrCountDown = new System.Windows.Forms.Timer(this.components);
            this.tblGameOver = new System.Windows.Forms.TableLayoutPanel();
            this.btnPlayAgain = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.lblGameOver = new System.Windows.Forms.Label();
            this.lblYouSquashedXBugs = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBug)).BeginInit();
            this.pnlUIHeader.SuspendLayout();
            this.tblGameOver.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBugsSquashed
            // 
            this.lblBugsSquashed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBugsSquashed.AutoSize = true;
            this.lblBugsSquashed.Font = new System.Drawing.Font("Ravie", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBugsSquashed.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblBugsSquashed.Location = new System.Drawing.Point(435, 9);
            this.lblBugsSquashed.Name = "lblBugsSquashed";
            this.lblBugsSquashed.Size = new System.Drawing.Size(337, 36);
            this.lblBugsSquashed.TabIndex = 0;
            this.lblBugsSquashed.Text = "Bugs Squashed: 0";
            // 
            // pbxBug
            // 
            this.pbxBug.BackColor = System.Drawing.Color.Transparent;
            this.pbxBug.Image = global::COSC2100_ICE3_RobertMacklem.Properties.Resources.imgLadyBug;
            this.pbxBug.Location = new System.Drawing.Point(351, 247);
            this.pbxBug.Name = "pbxBug";
            this.pbxBug.Size = new System.Drawing.Size(48, 48);
            this.pbxBug.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxBug.TabIndex = 1;
            this.pbxBug.TabStop = false;
            this.pbxBug.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SquishBug);
            // 
            // pnlUIHeader
            // 
            this.pnlUIHeader.BackColor = System.Drawing.Color.RosyBrown;
            this.pnlUIHeader.Controls.Add(this.lblTime);
            this.pnlUIHeader.Controls.Add(this.lblBugsSquashed);
            this.pnlUIHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUIHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlUIHeader.Name = "pnlUIHeader";
            this.pnlUIHeader.Size = new System.Drawing.Size(784, 59);
            this.pnlUIHeader.TabIndex = 2;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Ravie", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTime.Location = new System.Drawing.Point(12, 9);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(296, 36);
            this.lblTime.TabIndex = 1;
            this.lblTime.Text = "Time Left: 20s";
            // 
            // tmrSpawnTimer
            // 
            this.tmrSpawnTimer.Enabled = true;
            this.tmrSpawnTimer.Interval = 2000;
            this.tmrSpawnTimer.Tick += new System.EventHandler(this.SpawnTick);
            // 
            // tmrCountDown
            // 
            this.tmrCountDown.Enabled = true;
            this.tmrCountDown.Interval = 1000;
            this.tmrCountDown.Tick += new System.EventHandler(this.tmrCountDown_Tick);
            // 
            // tblGameOver
            // 
            this.tblGameOver.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblGameOver.BackColor = System.Drawing.Color.Transparent;
            this.tblGameOver.ColumnCount = 2;
            this.tblGameOver.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblGameOver.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblGameOver.Controls.Add(this.btnPlayAgain, 0, 2);
            this.tblGameOver.Controls.Add(this.btnQuit, 1, 2);
            this.tblGameOver.Controls.Add(this.lblGameOver, 0, 0);
            this.tblGameOver.Controls.Add(this.lblYouSquashedXBugs, 0, 1);
            this.tblGameOver.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tblGameOver.Location = new System.Drawing.Point(135, 182);
            this.tblGameOver.MaximumSize = new System.Drawing.Size(500, 125);
            this.tblGameOver.MinimumSize = new System.Drawing.Size(500, 125);
            this.tblGameOver.Name = "tblGameOver";
            this.tblGameOver.RowCount = 3;
            this.tblGameOver.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tblGameOver.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tblGameOver.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tblGameOver.Size = new System.Drawing.Size(500, 125);
            this.tblGameOver.TabIndex = 3;
            this.tblGameOver.Visible = false;
            // 
            // btnPlayAgain
            // 
            this.btnPlayAgain.BackColor = System.Drawing.Color.RosyBrown;
            this.btnPlayAgain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPlayAgain.Font = new System.Drawing.Font("Ravie", 20F, System.Drawing.FontStyle.Bold);
            this.btnPlayAgain.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPlayAgain.Location = new System.Drawing.Point(3, 73);
            this.btnPlayAgain.Name = "btnPlayAgain";
            this.btnPlayAgain.Size = new System.Drawing.Size(244, 49);
            this.btnPlayAgain.TabIndex = 0;
            this.btnPlayAgain.Text = "Play Again";
            this.btnPlayAgain.UseVisualStyleBackColor = false;
            this.btnPlayAgain.Click += new System.EventHandler(this.btnPlayAgain_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.Color.RosyBrown;
            this.btnQuit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnQuit.Font = new System.Drawing.Font("Ravie", 20F, System.Drawing.FontStyle.Bold);
            this.btnQuit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnQuit.Location = new System.Drawing.Point(253, 73);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(244, 49);
            this.btnQuit.TabIndex = 1;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // lblGameOver
            // 
            this.lblGameOver.AutoSize = true;
            this.tblGameOver.SetColumnSpan(this.lblGameOver, 2);
            this.lblGameOver.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGameOver.Font = new System.Drawing.Font("Ravie", 20F, System.Drawing.FontStyle.Bold);
            this.lblGameOver.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblGameOver.Location = new System.Drawing.Point(3, 0);
            this.lblGameOver.Name = "lblGameOver";
            this.lblGameOver.Size = new System.Drawing.Size(494, 35);
            this.lblGameOver.TabIndex = 2;
            this.lblGameOver.Text = "GAME OVER";
            this.lblGameOver.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblYouSquashedXBugs
            // 
            this.lblYouSquashedXBugs.AutoSize = true;
            this.tblGameOver.SetColumnSpan(this.lblYouSquashedXBugs, 2);
            this.lblYouSquashedXBugs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblYouSquashedXBugs.Font = new System.Drawing.Font("Ravie", 14F, System.Drawing.FontStyle.Bold);
            this.lblYouSquashedXBugs.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblYouSquashedXBugs.Location = new System.Drawing.Point(3, 35);
            this.lblYouSquashedXBugs.Name = "lblYouSquashedXBugs";
            this.lblYouSquashedXBugs.Size = new System.Drawing.Size(494, 35);
            this.lblYouSquashedXBugs.TabIndex = 3;
            this.lblYouSquashedXBugs.Text = "You Squashed X Bugs!";
            this.lblYouSquashedXBugs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::COSC2100_ICE3_RobertMacklem.Properties.Resources.imgGrassTexture;
            this.ClientSize = new System.Drawing.Size(784, 441);
            this.Controls.Add(this.tblGameOver);
            this.Controls.Add(this.pnlUIHeader);
            this.Controls.Add(this.pbxBug);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 480);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bug Squasher Game — Robert Macklem";
            ((System.ComponentModel.ISupportInitialize)(this.pbxBug)).EndInit();
            this.pnlUIHeader.ResumeLayout(false);
            this.pnlUIHeader.PerformLayout();
            this.tblGameOver.ResumeLayout(false);
            this.tblGameOver.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblBugsSquashed;
        private System.Windows.Forms.PictureBox pbxBug;
        private System.Windows.Forms.Panel pnlUIHeader;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer tmrSpawnTimer;
        private System.Windows.Forms.Timer tmrCountDown;
        private System.Windows.Forms.TableLayoutPanel tblGameOver;
        private System.Windows.Forms.Button btnPlayAgain;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Label lblGameOver;
        private System.Windows.Forms.Label lblYouSquashedXBugs;
    }
}

