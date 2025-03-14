namespace COSC2100_ICE7_RobertMacklem
{
    partial class frmGameOver
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
            this.tlpGameOverLayout = new System.Windows.Forms.TableLayoutPanel();
            this.lblGameOver = new System.Windows.Forms.Label();
            this.lblPlayAgain = new System.Windows.Forms.Label();
            this.btnPlayAgain = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.tlpGameOverLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpGameOverLayout
            // 
            this.tlpGameOverLayout.ColumnCount = 2;
            this.tlpGameOverLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpGameOverLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpGameOverLayout.Controls.Add(this.btnQuit, 1, 2);
            this.tlpGameOverLayout.Controls.Add(this.btnPlayAgain, 0, 2);
            this.tlpGameOverLayout.Controls.Add(this.lblPlayAgain, 0, 1);
            this.tlpGameOverLayout.Controls.Add(this.lblGameOver, 0, 0);
            this.tlpGameOverLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpGameOverLayout.Location = new System.Drawing.Point(0, 0);
            this.tlpGameOverLayout.Name = "tlpGameOverLayout";
            this.tlpGameOverLayout.RowCount = 3;
            this.tlpGameOverLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpGameOverLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpGameOverLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpGameOverLayout.Size = new System.Drawing.Size(316, 248);
            this.tlpGameOverLayout.TabIndex = 0;
            // 
            // lblGameOver
            // 
            this.lblGameOver.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGameOver.AutoSize = true;
            this.tlpGameOverLayout.SetColumnSpan(this.lblGameOver, 2);
            this.lblGameOver.Font = new System.Drawing.Font("Kristen ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameOver.Location = new System.Drawing.Point(93, 59);
            this.lblGameOver.Name = "lblGameOver";
            this.lblGameOver.Size = new System.Drawing.Size(129, 29);
            this.lblGameOver.TabIndex = 0;
            this.lblGameOver.Text = "Game Over";
            // 
            // lblPlayAgain
            // 
            this.lblPlayAgain.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPlayAgain.AutoSize = true;
            this.tlpGameOverLayout.SetColumnSpan(this.lblPlayAgain, 2);
            this.lblPlayAgain.Font = new System.Drawing.Font("Kristen ITC", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayAgain.Location = new System.Drawing.Point(104, 159);
            this.lblPlayAgain.Name = "lblPlayAgain";
            this.lblPlayAgain.Size = new System.Drawing.Size(107, 27);
            this.lblPlayAgain.TabIndex = 1;
            this.lblPlayAgain.Text = "Play again?";
            // 
            // btnPlayAgain
            // 
            this.btnPlayAgain.BackColor = System.Drawing.Color.Plum;
            this.btnPlayAgain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPlayAgain.Font = new System.Drawing.Font("Kristen ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayAgain.Location = new System.Drawing.Point(3, 201);
            this.btnPlayAgain.Name = "btnPlayAgain";
            this.btnPlayAgain.Size = new System.Drawing.Size(152, 44);
            this.btnPlayAgain.TabIndex = 2;
            this.btnPlayAgain.Text = "Yes";
            this.btnPlayAgain.UseVisualStyleBackColor = false;
            this.btnPlayAgain.Click += new System.EventHandler(this.btnPlayAgain_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.Color.Plum;
            this.btnQuit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnQuit.Font = new System.Drawing.Font("Kristen ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.Location = new System.Drawing.Point(161, 201);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(152, 44);
            this.btnQuit.TabIndex = 3;
            this.btnQuit.Text = "No";
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // frmGameOver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(316, 248);
            this.Controls.Add(this.tlpGameOverLayout);
            this.Name = "frmGameOver";
            this.ShowIcon = false;
            this.Text = "Game Over";
            this.tlpGameOverLayout.ResumeLayout(false);
            this.tlpGameOverLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpGameOverLayout;
        private System.Windows.Forms.Label lblGameOver;
        private System.Windows.Forms.Label lblPlayAgain;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnPlayAgain;
    }
}