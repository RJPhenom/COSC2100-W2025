namespace COSC2100_ICE8_RobertMacklem
{
    partial class AddVictim
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
            this.tlpAddVictimLayout = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tbxAddVictimName = new System.Windows.Forms.TextBox();
            this.tlpAddVictimButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tlpAddVictimLayout.SuspendLayout();
            this.tlpAddVictimButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpAddVictimLayout
            // 
            this.tlpAddVictimLayout.ColumnCount = 1;
            this.tlpAddVictimLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpAddVictimLayout.Controls.Add(this.lblTitle, 0, 0);
            this.tlpAddVictimLayout.Controls.Add(this.tbxAddVictimName, 0, 1);
            this.tlpAddVictimLayout.Controls.Add(this.tlpAddVictimButtons, 0, 2);
            this.tlpAddVictimLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpAddVictimLayout.Location = new System.Drawing.Point(0, 0);
            this.tlpAddVictimLayout.Name = "tlpAddVictimLayout";
            this.tlpAddVictimLayout.RowCount = 3;
            this.tlpAddVictimLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpAddVictimLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpAddVictimLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpAddVictimLayout.Size = new System.Drawing.Size(293, 127);
            this.tlpAddVictimLayout.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(61, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(171, 29);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Victim\'s Name:";
            // 
            // tbxAddVictimName
            // 
            this.tbxAddVictimName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxAddVictimName.Location = new System.Drawing.Point(3, 53);
            this.tbxAddVictimName.Name = "tbxAddVictimName";
            this.tbxAddVictimName.Size = new System.Drawing.Size(287, 20);
            this.tbxAddVictimName.TabIndex = 2;
            // 
            // tlpAddVictimButtons
            // 
            this.tlpAddVictimButtons.ColumnCount = 2;
            this.tlpAddVictimButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpAddVictimButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpAddVictimButtons.Controls.Add(this.btnAdd, 1, 0);
            this.tlpAddVictimButtons.Controls.Add(this.btnCancel, 0, 0);
            this.tlpAddVictimButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpAddVictimButtons.Location = new System.Drawing.Point(3, 80);
            this.tlpAddVictimButtons.Name = "tlpAddVictimButtons";
            this.tlpAddVictimButtons.RowCount = 1;
            this.tlpAddVictimButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpAddVictimButtons.Size = new System.Drawing.Size(287, 44);
            this.tlpAddVictimButtons.TabIndex = 3;
            // 
            // btnCancel
            // 
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancel.Location = new System.Drawing.Point(3, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(137, 38);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdd.Location = new System.Drawing.Point(146, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(138, 38);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // AddVictim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 127);
            this.Controls.Add(this.tlpAddVictimLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AddVictim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Victim";
            this.tlpAddVictimLayout.ResumeLayout(false);
            this.tlpAddVictimLayout.PerformLayout();
            this.tlpAddVictimButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpAddVictimLayout;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox tbxAddVictimName;
        private System.Windows.Forms.TableLayoutPanel tlpAddVictimButtons;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
    }
}