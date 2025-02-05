namespace COSC2100_Lab2_RobertMacklem
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
            this.tlpLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.gbxPlayers = new System.Windows.Forms.GroupBox();
            this.tlpPlayers = new System.Windows.Forms.TableLayoutPanel();
            this.lblPlayerX = new System.Windows.Forms.Label();
            this.lblPlayerO = new System.Windows.Forms.Label();
            this.tbxPlayerX = new System.Windows.Forms.TextBox();
            this.tbxPlayerO = new System.Windows.Forms.TextBox();
            this.gbxScore = new System.Windows.Forms.GroupBox();
            this.tlpScore = new System.Windows.Forms.TableLayoutPanel();
            this.tbxScoreX = new System.Windows.Forms.TextBox();
            this.tbxScoreO = new System.Windows.Forms.TextBox();
            this.gbxWinner = new System.Windows.Forms.GroupBox();
            this.tlpWinner = new System.Windows.Forms.TableLayoutPanel();
            this.lblWinner = new System.Windows.Forms.Label();
            this.gbxGameArea = new System.Windows.Forms.GroupBox();
            this.tlpGameAreLayout = new System.Windows.Forms.TableLayoutPanel();
            this.tlpGameArea = new System.Windows.Forms.TableLayoutPanel();
            this.lblSquare8 = new System.Windows.Forms.Label();
            this.lblSquare7 = new System.Windows.Forms.Label();
            this.lblSquare6 = new System.Windows.Forms.Label();
            this.lblSquare5 = new System.Windows.Forms.Label();
            this.lblSquare4 = new System.Windows.Forms.Label();
            this.lblSquare3 = new System.Windows.Forms.Label();
            this.lblSquare2 = new System.Windows.Forms.Label();
            this.lblSquare1 = new System.Windows.Forms.Label();
            this.lblSquare0 = new System.Windows.Forms.Label();
            this.lblGameStatus = new System.Windows.Forms.Label();
            this.ttpToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.tlpLayoutPanel.SuspendLayout();
            this.gbxPlayers.SuspendLayout();
            this.tlpPlayers.SuspendLayout();
            this.gbxScore.SuspendLayout();
            this.tlpScore.SuspendLayout();
            this.gbxWinner.SuspendLayout();
            this.tlpWinner.SuspendLayout();
            this.gbxGameArea.SuspendLayout();
            this.tlpGameAreLayout.SuspendLayout();
            this.tlpGameArea.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpLayoutPanel
            // 
            this.tlpLayoutPanel.ColumnCount = 3;
            this.tlpLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tlpLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpLayoutPanel.Controls.Add(this.gbxPlayers, 0, 0);
            this.tlpLayoutPanel.Controls.Add(this.gbxScore, 1, 0);
            this.tlpLayoutPanel.Controls.Add(this.gbxWinner, 2, 0);
            this.tlpLayoutPanel.Controls.Add(this.gbxGameArea, 0, 1);
            this.tlpLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tlpLayoutPanel.Name = "tlpLayoutPanel";
            this.tlpLayoutPanel.RowCount = 2;
            this.tlpLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlpLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tlpLayoutPanel.Size = new System.Drawing.Size(393, 489);
            this.tlpLayoutPanel.TabIndex = 0;
            // 
            // gbxPlayers
            // 
            this.gbxPlayers.Controls.Add(this.tlpPlayers);
            this.gbxPlayers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxPlayers.Location = new System.Drawing.Point(3, 3);
            this.gbxPlayers.Name = "gbxPlayers";
            this.gbxPlayers.Size = new System.Drawing.Size(229, 67);
            this.gbxPlayers.TabIndex = 0;
            this.gbxPlayers.TabStop = false;
            this.gbxPlayers.Text = "Player Names";
            // 
            // tlpPlayers
            // 
            this.tlpPlayers.ColumnCount = 2;
            this.tlpPlayers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpPlayers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tlpPlayers.Controls.Add(this.lblPlayerX, 0, 0);
            this.tlpPlayers.Controls.Add(this.lblPlayerO, 0, 1);
            this.tlpPlayers.Controls.Add(this.tbxPlayerX, 1, 0);
            this.tlpPlayers.Controls.Add(this.tbxPlayerO, 1, 1);
            this.tlpPlayers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPlayers.Location = new System.Drawing.Point(3, 16);
            this.tlpPlayers.Name = "tlpPlayers";
            this.tlpPlayers.RowCount = 2;
            this.tlpPlayers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPlayers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPlayers.Size = new System.Drawing.Size(223, 48);
            this.tlpPlayers.TabIndex = 0;
            // 
            // lblPlayerX
            // 
            this.lblPlayerX.AutoSize = true;
            this.lblPlayerX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPlayerX.Location = new System.Drawing.Point(3, 0);
            this.lblPlayerX.Name = "lblPlayerX";
            this.lblPlayerX.Size = new System.Drawing.Size(38, 24);
            this.lblPlayerX.TabIndex = 0;
            this.lblPlayerX.Text = "X:";
            this.lblPlayerX.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPlayerO
            // 
            this.lblPlayerO.AutoSize = true;
            this.lblPlayerO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPlayerO.Location = new System.Drawing.Point(3, 24);
            this.lblPlayerO.Name = "lblPlayerO";
            this.lblPlayerO.Size = new System.Drawing.Size(38, 24);
            this.lblPlayerO.TabIndex = 1;
            this.lblPlayerO.Text = "O:";
            this.lblPlayerO.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbxPlayerX
            // 
            this.tbxPlayerX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxPlayerX.Location = new System.Drawing.Point(47, 3);
            this.tbxPlayerX.MaxLength = 16;
            this.tbxPlayerX.Name = "tbxPlayerX";
            this.tbxPlayerX.Size = new System.Drawing.Size(173, 20);
            this.tbxPlayerX.TabIndex = 2;
            this.ttpToolTip.SetToolTip(this.tbxPlayerX, "Please input a name for player X. Names cannot be blank.");
            this.tbxPlayerX.Leave += new System.EventHandler(this.OnPlayerNameChanged);
            // 
            // tbxPlayerO
            // 
            this.tbxPlayerO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxPlayerO.Location = new System.Drawing.Point(47, 27);
            this.tbxPlayerO.MaxLength = 16;
            this.tbxPlayerO.Name = "tbxPlayerO";
            this.tbxPlayerO.Size = new System.Drawing.Size(173, 20);
            this.tbxPlayerO.TabIndex = 3;
            this.ttpToolTip.SetToolTip(this.tbxPlayerO, "Please input a name for player O. Names cannot be blank.");
            this.tbxPlayerO.Leave += new System.EventHandler(this.OnPlayerNameChanged);
            // 
            // gbxScore
            // 
            this.gbxScore.Controls.Add(this.tlpScore);
            this.gbxScore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxScore.Location = new System.Drawing.Point(238, 3);
            this.gbxScore.Name = "gbxScore";
            this.gbxScore.Size = new System.Drawing.Size(72, 67);
            this.gbxScore.TabIndex = 1;
            this.gbxScore.TabStop = false;
            this.gbxScore.Text = "Score";
            // 
            // tlpScore
            // 
            this.tlpScore.ColumnCount = 1;
            this.tlpScore.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpScore.Controls.Add(this.tbxScoreX, 0, 0);
            this.tlpScore.Controls.Add(this.tbxScoreO, 0, 1);
            this.tlpScore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpScore.Location = new System.Drawing.Point(3, 16);
            this.tlpScore.Name = "tlpScore";
            this.tlpScore.RowCount = 2;
            this.tlpScore.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpScore.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpScore.Size = new System.Drawing.Size(66, 48);
            this.tlpScore.TabIndex = 0;
            // 
            // tbxScoreX
            // 
            this.tbxScoreX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxScoreX.Location = new System.Drawing.Point(3, 3);
            this.tbxScoreX.Name = "tbxScoreX";
            this.tbxScoreX.ReadOnly = true;
            this.tbxScoreX.Size = new System.Drawing.Size(60, 20);
            this.tbxScoreX.TabIndex = 0;
            this.tbxScoreX.TabStop = false;
            // 
            // tbxScoreO
            // 
            this.tbxScoreO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxScoreO.Location = new System.Drawing.Point(3, 27);
            this.tbxScoreO.Name = "tbxScoreO";
            this.tbxScoreO.ReadOnly = true;
            this.tbxScoreO.Size = new System.Drawing.Size(60, 20);
            this.tbxScoreO.TabIndex = 1;
            this.tbxScoreO.TabStop = false;
            // 
            // gbxWinner
            // 
            this.gbxWinner.Controls.Add(this.tlpWinner);
            this.gbxWinner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxWinner.Location = new System.Drawing.Point(316, 3);
            this.gbxWinner.Name = "gbxWinner";
            this.gbxWinner.Size = new System.Drawing.Size(74, 67);
            this.gbxWinner.TabIndex = 2;
            this.gbxWinner.TabStop = false;
            this.gbxWinner.Text = "Winner";
            // 
            // tlpWinner
            // 
            this.tlpWinner.ColumnCount = 1;
            this.tlpWinner.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpWinner.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpWinner.Controls.Add(this.lblWinner, 0, 0);
            this.tlpWinner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpWinner.Location = new System.Drawing.Point(3, 16);
            this.tlpWinner.Name = "tlpWinner";
            this.tlpWinner.RowCount = 1;
            this.tlpWinner.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpWinner.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpWinner.Size = new System.Drawing.Size(68, 48);
            this.tlpWinner.TabIndex = 0;
            // 
            // lblWinner
            // 
            this.lblWinner.AutoSize = true;
            this.lblWinner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWinner.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinner.Location = new System.Drawing.Point(3, 0);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(62, 48);
            this.lblWinner.TabIndex = 0;
            this.lblWinner.Text = "_";
            this.lblWinner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbxGameArea
            // 
            this.tlpLayoutPanel.SetColumnSpan(this.gbxGameArea, 3);
            this.gbxGameArea.Controls.Add(this.tlpGameAreLayout);
            this.gbxGameArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxGameArea.Location = new System.Drawing.Point(3, 76);
            this.gbxGameArea.Name = "gbxGameArea";
            this.gbxGameArea.Size = new System.Drawing.Size(387, 410);
            this.gbxGameArea.TabIndex = 3;
            this.gbxGameArea.TabStop = false;
            this.gbxGameArea.Text = "Game Area";
            // 
            // tlpGameAreLayout
            // 
            this.tlpGameAreLayout.ColumnCount = 1;
            this.tlpGameAreLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpGameAreLayout.Controls.Add(this.tlpGameArea, 0, 1);
            this.tlpGameAreLayout.Controls.Add(this.lblGameStatus, 0, 0);
            this.tlpGameAreLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpGameAreLayout.Location = new System.Drawing.Point(3, 16);
            this.tlpGameAreLayout.Name = "tlpGameAreLayout";
            this.tlpGameAreLayout.RowCount = 2;
            this.tlpGameAreLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpGameAreLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tlpGameAreLayout.Size = new System.Drawing.Size(381, 391);
            this.tlpGameAreLayout.TabIndex = 1;
            this.tlpGameAreLayout.Click += new System.EventHandler(this.OnClickedGameArea);
            // 
            // tlpGameArea
            // 
            this.tlpGameArea.ColumnCount = 3;
            this.tlpGameArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpGameArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpGameArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpGameArea.Controls.Add(this.lblSquare8, 2, 2);
            this.tlpGameArea.Controls.Add(this.lblSquare7, 1, 2);
            this.tlpGameArea.Controls.Add(this.lblSquare6, 0, 2);
            this.tlpGameArea.Controls.Add(this.lblSquare5, 2, 1);
            this.tlpGameArea.Controls.Add(this.lblSquare4, 1, 1);
            this.tlpGameArea.Controls.Add(this.lblSquare3, 0, 1);
            this.tlpGameArea.Controls.Add(this.lblSquare2, 2, 0);
            this.tlpGameArea.Controls.Add(this.lblSquare1, 1, 0);
            this.tlpGameArea.Controls.Add(this.lblSquare0, 0, 0);
            this.tlpGameArea.Enabled = false;
            this.tlpGameArea.Location = new System.Drawing.Point(3, 42);
            this.tlpGameArea.Name = "tlpGameArea";
            this.tlpGameArea.RowCount = 3;
            this.tlpGameArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpGameArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpGameArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpGameArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpGameArea.Size = new System.Drawing.Size(375, 346);
            this.tlpGameArea.TabIndex = 0;
            // 
            // lblSquare8
            // 
            this.lblSquare8.AutoSize = true;
            this.lblSquare8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblSquare8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSquare8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSquare8.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSquare8.Location = new System.Drawing.Point(250, 230);
            this.lblSquare8.Margin = new System.Windows.Forms.Padding(0);
            this.lblSquare8.Name = "lblSquare8";
            this.lblSquare8.Size = new System.Drawing.Size(125, 116);
            this.lblSquare8.TabIndex = 9;
            this.lblSquare8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ttpToolTip.SetToolTip(this.lblSquare8, "Click on a square to select it.");
            this.lblSquare8.Click += new System.EventHandler(this.OnSquareClicked);
            // 
            // lblSquare7
            // 
            this.lblSquare7.AutoSize = true;
            this.lblSquare7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblSquare7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSquare7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSquare7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSquare7.Location = new System.Drawing.Point(125, 230);
            this.lblSquare7.Margin = new System.Windows.Forms.Padding(0);
            this.lblSquare7.Name = "lblSquare7";
            this.lblSquare7.Size = new System.Drawing.Size(125, 116);
            this.lblSquare7.TabIndex = 8;
            this.lblSquare7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ttpToolTip.SetToolTip(this.lblSquare7, "Click on a square to select it.");
            this.lblSquare7.Click += new System.EventHandler(this.OnSquareClicked);
            // 
            // lblSquare6
            // 
            this.lblSquare6.AutoSize = true;
            this.lblSquare6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblSquare6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSquare6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSquare6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSquare6.Location = new System.Drawing.Point(0, 230);
            this.lblSquare6.Margin = new System.Windows.Forms.Padding(0);
            this.lblSquare6.Name = "lblSquare6";
            this.lblSquare6.Size = new System.Drawing.Size(125, 116);
            this.lblSquare6.TabIndex = 7;
            this.lblSquare6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ttpToolTip.SetToolTip(this.lblSquare6, "Click on a square to select it.");
            this.lblSquare6.Click += new System.EventHandler(this.OnSquareClicked);
            // 
            // lblSquare5
            // 
            this.lblSquare5.AutoSize = true;
            this.lblSquare5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblSquare5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSquare5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSquare5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSquare5.Location = new System.Drawing.Point(250, 115);
            this.lblSquare5.Margin = new System.Windows.Forms.Padding(0);
            this.lblSquare5.Name = "lblSquare5";
            this.lblSquare5.Size = new System.Drawing.Size(125, 115);
            this.lblSquare5.TabIndex = 6;
            this.lblSquare5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ttpToolTip.SetToolTip(this.lblSquare5, "Click on a square to select it.");
            this.lblSquare5.Click += new System.EventHandler(this.OnSquareClicked);
            // 
            // lblSquare4
            // 
            this.lblSquare4.AutoSize = true;
            this.lblSquare4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblSquare4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSquare4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSquare4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSquare4.Location = new System.Drawing.Point(125, 115);
            this.lblSquare4.Margin = new System.Windows.Forms.Padding(0);
            this.lblSquare4.Name = "lblSquare4";
            this.lblSquare4.Size = new System.Drawing.Size(125, 115);
            this.lblSquare4.TabIndex = 5;
            this.lblSquare4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ttpToolTip.SetToolTip(this.lblSquare4, "Click on a square to select it.");
            this.lblSquare4.Click += new System.EventHandler(this.OnSquareClicked);
            // 
            // lblSquare3
            // 
            this.lblSquare3.AutoSize = true;
            this.lblSquare3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblSquare3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSquare3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSquare3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSquare3.Location = new System.Drawing.Point(0, 115);
            this.lblSquare3.Margin = new System.Windows.Forms.Padding(0);
            this.lblSquare3.Name = "lblSquare3";
            this.lblSquare3.Size = new System.Drawing.Size(125, 115);
            this.lblSquare3.TabIndex = 4;
            this.lblSquare3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ttpToolTip.SetToolTip(this.lblSquare3, "Click on a square to select it.");
            this.lblSquare3.Click += new System.EventHandler(this.OnSquareClicked);
            // 
            // lblSquare2
            // 
            this.lblSquare2.AutoSize = true;
            this.lblSquare2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblSquare2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSquare2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSquare2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSquare2.Location = new System.Drawing.Point(250, 0);
            this.lblSquare2.Margin = new System.Windows.Forms.Padding(0);
            this.lblSquare2.Name = "lblSquare2";
            this.lblSquare2.Size = new System.Drawing.Size(125, 115);
            this.lblSquare2.TabIndex = 3;
            this.lblSquare2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ttpToolTip.SetToolTip(this.lblSquare2, "Click on a square to select it.");
            this.lblSquare2.Click += new System.EventHandler(this.OnSquareClicked);
            // 
            // lblSquare1
            // 
            this.lblSquare1.AutoSize = true;
            this.lblSquare1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblSquare1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSquare1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSquare1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSquare1.Location = new System.Drawing.Point(125, 0);
            this.lblSquare1.Margin = new System.Windows.Forms.Padding(0);
            this.lblSquare1.Name = "lblSquare1";
            this.lblSquare1.Size = new System.Drawing.Size(125, 115);
            this.lblSquare1.TabIndex = 2;
            this.lblSquare1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ttpToolTip.SetToolTip(this.lblSquare1, "Click on a square to select it.");
            this.lblSquare1.Click += new System.EventHandler(this.OnSquareClicked);
            // 
            // lblSquare0
            // 
            this.lblSquare0.AutoSize = true;
            this.lblSquare0.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblSquare0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSquare0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSquare0.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSquare0.Location = new System.Drawing.Point(0, 0);
            this.lblSquare0.Margin = new System.Windows.Forms.Padding(0);
            this.lblSquare0.Name = "lblSquare0";
            this.lblSquare0.Size = new System.Drawing.Size(125, 115);
            this.lblSquare0.TabIndex = 1;
            this.lblSquare0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ttpToolTip.SetToolTip(this.lblSquare0, "Click on a square to select it.");
            this.lblSquare0.Click += new System.EventHandler(this.OnSquareClicked);
            // 
            // lblGameStatus
            // 
            this.lblGameStatus.AutoSize = true;
            this.lblGameStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGameStatus.Location = new System.Drawing.Point(3, 0);
            this.lblGameStatus.Name = "lblGameStatus";
            this.lblGameStatus.Size = new System.Drawing.Size(375, 39);
            this.lblGameStatus.TabIndex = 1;
            this.lblGameStatus.Text = "Waiting for player names!";
            this.lblGameStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ttpToolTip
            // 
            this.ttpToolTip.AutomaticDelay = 300;
            this.ttpToolTip.AutoPopDelay = 3000;
            this.ttpToolTip.InitialDelay = 300;
            this.ttpToolTip.ReshowDelay = 0;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 489);
            this.Controls.Add(this.tlpLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "Tic Tac Toe — Robert Macklem";
            this.tlpLayoutPanel.ResumeLayout(false);
            this.gbxPlayers.ResumeLayout(false);
            this.tlpPlayers.ResumeLayout(false);
            this.tlpPlayers.PerformLayout();
            this.gbxScore.ResumeLayout(false);
            this.tlpScore.ResumeLayout(false);
            this.tlpScore.PerformLayout();
            this.gbxWinner.ResumeLayout(false);
            this.tlpWinner.ResumeLayout(false);
            this.tlpWinner.PerformLayout();
            this.gbxGameArea.ResumeLayout(false);
            this.tlpGameAreLayout.ResumeLayout(false);
            this.tlpGameAreLayout.PerformLayout();
            this.tlpGameArea.ResumeLayout(false);
            this.tlpGameArea.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpLayoutPanel;
        private System.Windows.Forms.GroupBox gbxPlayers;
        private System.Windows.Forms.TableLayoutPanel tlpPlayers;
        private System.Windows.Forms.Label lblPlayerX;
        private System.Windows.Forms.Label lblPlayerO;
        private System.Windows.Forms.TextBox tbxPlayerX;
        private System.Windows.Forms.TextBox tbxPlayerO;
        private System.Windows.Forms.GroupBox gbxScore;
        private System.Windows.Forms.TableLayoutPanel tlpScore;
        private System.Windows.Forms.TextBox tbxScoreX;
        private System.Windows.Forms.TextBox tbxScoreO;
        private System.Windows.Forms.GroupBox gbxWinner;
        private System.Windows.Forms.GroupBox gbxGameArea;
        private System.Windows.Forms.TableLayoutPanel tlpGameArea;
        private System.Windows.Forms.Label lblSquare0;
        private System.Windows.Forms.Label lblSquare8;
        private System.Windows.Forms.Label lblSquare7;
        private System.Windows.Forms.Label lblSquare6;
        private System.Windows.Forms.Label lblSquare5;
        private System.Windows.Forms.Label lblSquare4;
        private System.Windows.Forms.Label lblSquare3;
        private System.Windows.Forms.Label lblSquare2;
        private System.Windows.Forms.Label lblSquare1;
        private System.Windows.Forms.TableLayoutPanel tlpWinner;
        private System.Windows.Forms.Label lblWinner;
        private System.Windows.Forms.ToolTip ttpToolTip;
        private System.Windows.Forms.TableLayoutPanel tlpGameAreLayout;
        private System.Windows.Forms.Label lblGameStatus;
    }
}

