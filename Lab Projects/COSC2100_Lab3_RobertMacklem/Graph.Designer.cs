namespace COSC2100_Lab3_RobertMacklem
{
    partial class Graph
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.chrGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tlpGraphLayout = new System.Windows.Forms.TableLayoutPanel();
            this.btnClose = new System.Windows.Forms.Button();
            this.ttpInfo = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chrGraph)).BeginInit();
            this.tlpGraphLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // chrGraph
            // 
            this.chrGraph.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chrGraph.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chrGraph.Legends.Add(legend1);
            this.chrGraph.Location = new System.Drawing.Point(20, 20);
            this.chrGraph.Margin = new System.Windows.Forms.Padding(20, 20, 20, 10);
            this.chrGraph.Name = "chrGraph";
            this.chrGraph.Padding = new System.Windows.Forms.Padding(10);
            this.chrGraph.Size = new System.Drawing.Size(575, 370);
            this.chrGraph.TabIndex = 0;
            this.chrGraph.Text = "+";
            // 
            // tlpGraphLayout
            // 
            this.tlpGraphLayout.ColumnCount = 1;
            this.tlpGraphLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpGraphLayout.Controls.Add(this.btnClose, 0, 1);
            this.tlpGraphLayout.Controls.Add(this.chrGraph, 0, 0);
            this.tlpGraphLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpGraphLayout.Location = new System.Drawing.Point(0, 0);
            this.tlpGraphLayout.Name = "tlpGraphLayout";
            this.tlpGraphLayout.RowCount = 2;
            this.tlpGraphLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpGraphLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpGraphLayout.Size = new System.Drawing.Size(615, 450);
            this.tlpGraphLayout.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClose.AutoSize = true;
            this.btnClose.Font = new System.Drawing.Font("Arial", 12F);
            this.btnClose.Location = new System.Drawing.Point(270, 411);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 28);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.ttpInfo.SetToolTip(this.btnClose, "Click to return to the main form.");
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Graph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 450);
            this.Controls.Add(this.tlpGraphLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Graph";
            this.ShowIcon = false;
            this.Text = "Visualization of Daily Expenses";
            ((System.ComponentModel.ISupportInitialize)(this.chrGraph)).EndInit();
            this.tlpGraphLayout.ResumeLayout(false);
            this.tlpGraphLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chrGraph;
        private System.Windows.Forms.TableLayoutPanel tlpGraphLayout;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ToolTip ttpInfo;
    }
}