namespace COSC2100_ICE6_RobertMacklem
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.tlpMainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.tlpHeader = new System.Windows.Forms.TableLayoutPanel();
            this.lblName = new System.Windows.Forms.Label();
            this.tlpButtons = new System.Windows.Forms.TableLayoutPanel();
            this.gbxBurgers = new System.Windows.Forms.GroupBox();
            this.dgvBurgers = new System.Windows.Forms.DataGridView();
            this.btnRemoveBurger = new System.Windows.Forms.Button();
            this.btnAddBurger = new System.Windows.Forms.Button();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BurgerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlpMainLayout.SuspendLayout();
            this.tlpHeader.SuspendLayout();
            this.tlpButtons.SuspendLayout();
            this.gbxBurgers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBurgers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpMainLayout
            // 
            this.tlpMainLayout.ColumnCount = 1;
            this.tlpMainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMainLayout.Controls.Add(this.tlpHeader, 0, 0);
            this.tlpMainLayout.Controls.Add(this.tlpButtons, 0, 2);
            this.tlpMainLayout.Controls.Add(this.gbxBurgers, 0, 1);
            this.tlpMainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMainLayout.Location = new System.Drawing.Point(0, 0);
            this.tlpMainLayout.Name = "tlpMainLayout";
            this.tlpMainLayout.RowCount = 3;
            this.tlpMainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tlpMainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpMainLayout.Size = new System.Drawing.Size(567, 464);
            this.tlpMainLayout.TabIndex = 0;
            // 
            // tlpHeader
            // 
            this.tlpHeader.BackColor = System.Drawing.Color.Bisque;
            this.tlpHeader.ColumnCount = 2;
            this.tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpHeader.Controls.Add(this.pbxLogo, 0, 0);
            this.tlpHeader.Controls.Add(this.lblName, 1, 0);
            this.tlpHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpHeader.Location = new System.Drawing.Point(3, 3);
            this.tlpHeader.Name = "tlpHeader";
            this.tlpHeader.RowCount = 1;
            this.tlpHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpHeader.Size = new System.Drawing.Size(561, 144);
            this.tlpHeader.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("MV Boli", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(212, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(294, 126);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "RJ\'s Tasty Burgers";
            // 
            // tlpButtons
            // 
            this.tlpButtons.BackColor = System.Drawing.Color.Bisque;
            this.tlpButtons.ColumnCount = 2;
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpButtons.Controls.Add(this.btnAddBurger, 1, 0);
            this.tlpButtons.Controls.Add(this.btnRemoveBurger, 0, 0);
            this.tlpButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpButtons.Location = new System.Drawing.Point(3, 417);
            this.tlpButtons.Name = "tlpButtons";
            this.tlpButtons.RowCount = 1;
            this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpButtons.Size = new System.Drawing.Size(561, 44);
            this.tlpButtons.TabIndex = 1;
            // 
            // gbxBurgers
            // 
            this.gbxBurgers.BackColor = System.Drawing.Color.SaddleBrown;
            this.gbxBurgers.Controls.Add(this.dgvBurgers);
            this.gbxBurgers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxBurgers.Font = new System.Drawing.Font("MV Boli", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxBurgers.ForeColor = System.Drawing.Color.Bisque;
            this.gbxBurgers.Location = new System.Drawing.Point(3, 153);
            this.gbxBurgers.Name = "gbxBurgers";
            this.gbxBurgers.Size = new System.Drawing.Size(561, 258);
            this.gbxBurgers.TabIndex = 2;
            this.gbxBurgers.TabStop = false;
            this.gbxBurgers.Text = "Our Menu";
            // 
            // dgvBurgers
            // 
            this.dgvBurgers.AllowUserToAddRows = false;
            this.dgvBurgers.AllowUserToDeleteRows = false;
            this.dgvBurgers.AllowUserToResizeColumns = false;
            this.dgvBurgers.AllowUserToResizeRows = false;
            this.dgvBurgers.BackgroundColor = System.Drawing.Color.SaddleBrown;
            this.dgvBurgers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("MV Boli", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Bisque;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Bisque;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBurgers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBurgers.ColumnHeadersHeight = 40;
            this.dgvBurgers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvBurgers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.BurgerName,
            this.Price});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("MV Boli", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Bisque;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Bisque;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBurgers.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBurgers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBurgers.EnableHeadersVisualStyles = false;
            this.dgvBurgers.Location = new System.Drawing.Point(3, 38);
            this.dgvBurgers.Name = "dgvBurgers";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("MV Boli", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Bisque;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Bisque;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBurgers.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBurgers.RowHeadersVisible = false;
            this.dgvBurgers.Size = new System.Drawing.Size(555, 217);
            this.dgvBurgers.TabIndex = 0;
            this.dgvBurgers.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvBurgers_RowsAdded);
            this.dgvBurgers.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvBurgers_RowsRemoved);
            // 
            // btnRemoveBurger
            // 
            this.btnRemoveBurger.BackColor = System.Drawing.Color.Salmon;
            this.btnRemoveBurger.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRemoveBurger.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveBurger.ForeColor = System.Drawing.Color.Bisque;
            this.btnRemoveBurger.Location = new System.Drawing.Point(3, 3);
            this.btnRemoveBurger.Name = "btnRemoveBurger";
            this.btnRemoveBurger.Size = new System.Drawing.Size(274, 38);
            this.btnRemoveBurger.TabIndex = 0;
            this.btnRemoveBurger.Text = "Remove Selected Burger";
            this.btnRemoveBurger.UseVisualStyleBackColor = false;
            this.btnRemoveBurger.Click += new System.EventHandler(this.btnRemoveBurger_Click);
            // 
            // btnAddBurger
            // 
            this.btnAddBurger.BackColor = System.Drawing.Color.OliveDrab;
            this.btnAddBurger.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddBurger.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBurger.ForeColor = System.Drawing.Color.Bisque;
            this.btnAddBurger.Location = new System.Drawing.Point(283, 3);
            this.btnAddBurger.Name = "btnAddBurger";
            this.btnAddBurger.Size = new System.Drawing.Size(275, 38);
            this.btnAddBurger.TabIndex = 1;
            this.btnAddBurger.Text = "Add Burger";
            this.btnAddBurger.UseVisualStyleBackColor = false;
            this.btnAddBurger.Click += new System.EventHandler(this.btnAddBurger_Click);
            // 
            // pbxLogo
            // 
            this.pbxLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbxLogo.Image = global::COSC2100_ICE6_RobertMacklem.Properties.Resources.imgLogo;
            this.pbxLogo.Location = new System.Drawing.Point(3, 3);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(152, 138);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxLogo.TabIndex = 0;
            this.pbxLogo.TabStop = false;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // BurgerName
            // 
            this.BurgerName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BurgerName.DataPropertyName = "Name";
            this.BurgerName.HeaderText = "Burger Name";
            this.BurgerName.Name = "BurgerName";
            this.BurgerName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 464);
            this.Controls.Add(this.tlpMainLayout);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "Burger Joint — Robert Macklem";
            this.tlpMainLayout.ResumeLayout(false);
            this.tlpHeader.ResumeLayout(false);
            this.tlpHeader.PerformLayout();
            this.tlpButtons.ResumeLayout(false);
            this.gbxBurgers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBurgers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMainLayout;
        private System.Windows.Forms.TableLayoutPanel tlpHeader;
        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TableLayoutPanel tlpButtons;
        private System.Windows.Forms.GroupBox gbxBurgers;
        private System.Windows.Forms.DataGridView dgvBurgers;
        private System.Windows.Forms.Button btnRemoveBurger;
        private System.Windows.Forms.Button btnAddBurger;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BurgerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
    }
}

