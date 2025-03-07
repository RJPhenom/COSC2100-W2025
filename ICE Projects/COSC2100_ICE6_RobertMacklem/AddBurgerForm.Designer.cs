namespace COSC2100_ICE6_RobertMacklem
{
    partial class AddBurgerForm
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
            this.tlpAddNewBurger = new System.Windows.Forms.TableLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lblBurgerName = new System.Windows.Forms.Label();
            this.lblBurgerPrice = new System.Windows.Forms.Label();
            this.tbxBurgerName = new System.Windows.Forms.TextBox();
            this.nudBurgerPrice = new System.Windows.Forms.NumericUpDown();
            this.tlpAddNewBurger.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBurgerPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpAddNewBurger
            // 
            this.tlpAddNewBurger.ColumnCount = 2;
            this.tlpAddNewBurger.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpAddNewBurger.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpAddNewBurger.Controls.Add(this.btnCancel, 0, 2);
            this.tlpAddNewBurger.Controls.Add(this.btnConfirm, 1, 2);
            this.tlpAddNewBurger.Controls.Add(this.lblBurgerName, 0, 0);
            this.tlpAddNewBurger.Controls.Add(this.lblBurgerPrice, 0, 1);
            this.tlpAddNewBurger.Controls.Add(this.tbxBurgerName, 1, 0);
            this.tlpAddNewBurger.Controls.Add(this.nudBurgerPrice, 1, 1);
            this.tlpAddNewBurger.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpAddNewBurger.Location = new System.Drawing.Point(0, 0);
            this.tlpAddNewBurger.Name = "tlpAddNewBurger";
            this.tlpAddNewBurger.RowCount = 3;
            this.tlpAddNewBurger.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpAddNewBurger.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpAddNewBurger.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpAddNewBurger.Size = new System.Drawing.Size(329, 133);
            this.tlpAddNewBurger.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Salmon;
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancel.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Bisque;
            this.btnCancel.Location = new System.Drawing.Point(3, 91);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(158, 39);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.OliveDrab;
            this.btnConfirm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnConfirm.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.Color.Bisque;
            this.btnConfirm.Location = new System.Drawing.Point(167, 91);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(159, 39);
            this.btnConfirm.TabIndex = 3;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // lblBurgerName
            // 
            this.lblBurgerName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBurgerName.AutoSize = true;
            this.lblBurgerName.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold);
            this.lblBurgerName.Location = new System.Drawing.Point(18, 11);
            this.lblBurgerName.Name = "lblBurgerName";
            this.lblBurgerName.Size = new System.Drawing.Size(128, 21);
            this.lblBurgerName.TabIndex = 4;
            this.lblBurgerName.Text = "Burger Name:";
            // 
            // lblBurgerPrice
            // 
            this.lblBurgerPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBurgerPrice.AutoSize = true;
            this.lblBurgerPrice.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold);
            this.lblBurgerPrice.Location = new System.Drawing.Point(9, 55);
            this.lblBurgerPrice.Name = "lblBurgerPrice";
            this.lblBurgerPrice.Size = new System.Drawing.Size(146, 21);
            this.lblBurgerPrice.TabIndex = 5;
            this.lblBurgerPrice.Text = "Price in dollars:";
            // 
            // tbxBurgerName
            // 
            this.tbxBurgerName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxBurgerName.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold);
            this.tbxBurgerName.Location = new System.Drawing.Point(167, 5);
            this.tbxBurgerName.Name = "tbxBurgerName";
            this.tbxBurgerName.Size = new System.Drawing.Size(159, 33);
            this.tbxBurgerName.TabIndex = 6;
            // 
            // nudBurgerPrice
            // 
            this.nudBurgerPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nudBurgerPrice.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold);
            this.nudBurgerPrice.Location = new System.Drawing.Point(167, 49);
            this.nudBurgerPrice.Name = "nudBurgerPrice";
            this.nudBurgerPrice.Size = new System.Drawing.Size(159, 33);
            this.nudBurgerPrice.TabIndex = 7;
            // 
            // AddBurgerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 133);
            this.ControlBox = false;
            this.Controls.Add(this.tlpAddNewBurger);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddBurgerForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add New Burger";
            this.tlpAddNewBurger.ResumeLayout(false);
            this.tlpAddNewBurger.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBurgerPrice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpAddNewBurger;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label lblBurgerName;
        private System.Windows.Forms.Label lblBurgerPrice;
        private System.Windows.Forms.TextBox tbxBurgerName;
        private System.Windows.Forms.NumericUpDown nudBurgerPrice;
    }
}