namespace WeAreTheChampions
{
    partial class Form1
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
            if (disposing)
            {
                db.Dispose();
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.teamsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvMatch = new System.Windows.Forms.DataGridView();
            this.MatchNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cboTeam1 = new System.Windows.Forms.ComboBox();
            this.cboTeam2 = new System.Windows.Forms.ComboBox();
            this.nudScore1 = new System.Windows.Forms.NumericUpDown();
            this.dtpMatchTime = new System.Windows.Forms.DateTimePicker();
            this.nudScore2 = new System.Windows.Forms.NumericUpDown();
            this.lblHome = new System.Windows.Forms.Label();
            this.lblScores = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblVisitor = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gboItems = new System.Windows.Forms.GroupBox();
            this.lblBg4 = new System.Windows.Forms.Label();
            this.lblBg3 = new System.Windows.Forms.Label();
            this.lblBg2 = new System.Windows.Forms.Label();
            this.lblBg = new System.Windows.Forms.Label();
            this.chkScores = new System.Windows.Forms.CheckBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.chkHideMatches = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudScore1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudScore2)).BeginInit();
            this.gboItems.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.teamsToolStripMenuItem,
            this.colorsToolStripMenuItem,
            this.playersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(753, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // teamsToolStripMenuItem
            // 
            this.teamsToolStripMenuItem.Name = "teamsToolStripMenuItem";
            this.teamsToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.teamsToolStripMenuItem.Text = "Teams";
            this.teamsToolStripMenuItem.Click += new System.EventHandler(this.teamsToolStripMenuItem_Click);
            // 
            // colorsToolStripMenuItem
            // 
            this.colorsToolStripMenuItem.Name = "colorsToolStripMenuItem";
            this.colorsToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.colorsToolStripMenuItem.Text = "Colors";
            this.colorsToolStripMenuItem.Click += new System.EventHandler(this.colorsToolStripMenuItem_Click);
            // 
            // playersToolStripMenuItem
            // 
            this.playersToolStripMenuItem.Name = "playersToolStripMenuItem";
            this.playersToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.playersToolStripMenuItem.Text = "Players";
            this.playersToolStripMenuItem.Click += new System.EventHandler(this.playersToolStripMenuItem_Click);
            // 
            // dgvMatch
            // 
            this.dgvMatch.AllowUserToAddRows = false;
            this.dgvMatch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMatch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMatch.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvMatch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MatchNo,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column8});
            this.dgvMatch.Location = new System.Drawing.Point(12, 27);
            this.dgvMatch.MultiSelect = false;
            this.dgvMatch.Name = "dgvMatch";
            this.dgvMatch.RowHeadersVisible = false;
            this.dgvMatch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMatch.Size = new System.Drawing.Size(722, 338);
            this.dgvMatch.TabIndex = 1;
            this.dgvMatch.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMatch_CellContentDoubleClick);
            this.dgvMatch.SelectionChanged += new System.EventHandler(this.dgvMatch_SelectionChanged);
            // 
            // MatchNo
            // 
            this.MatchNo.DataPropertyName = "MatchNo";
            this.MatchNo.HeaderText = "MatchNo";
            this.MatchNo.Name = "MatchNo";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Team1";
            this.Column2.HeaderText = "Home";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Team2";
            this.Column3.HeaderText = "Visitor";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Date";
            dataGridViewCellStyle1.Format = "MM/dd/yyyy";
            this.Column4.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column4.HeaderText = "Date";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Time";
            dataGridViewCellStyle2.Format = "hh:mm:ss tt";
            this.Column5.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column5.HeaderText = "Time";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Score";
            this.Column6.HeaderText = "Score";
            this.Column6.Name = "Column6";
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "Result";
            this.Column8.HeaderText = "Result";
            this.Column8.Name = "Column8";
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Goldenrod;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEdit.Location = new System.Drawing.Point(20, 371);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 25);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit ✎";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDelete.Location = new System.Drawing.Point(101, 371);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(87, 25);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete ⌫";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cboTeam1
            // 
            this.cboTeam1.DisplayMember = "TeamName";
            this.cboTeam1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTeam1.FormattingEnabled = true;
            this.cboTeam1.Location = new System.Drawing.Point(68, 28);
            this.cboTeam1.Name = "cboTeam1";
            this.cboTeam1.Size = new System.Drawing.Size(121, 21);
            this.cboTeam1.TabIndex = 4;
            this.cboTeam1.ValueMember = "Id";
            this.cboTeam1.SelectedIndexChanged += new System.EventHandler(this.cboTeam1_SelectedIndexChanged);
            // 
            // cboTeam2
            // 
            this.cboTeam2.DisplayMember = "TeamName";
            this.cboTeam2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTeam2.FormattingEnabled = true;
            this.cboTeam2.Location = new System.Drawing.Point(68, 56);
            this.cboTeam2.Name = "cboTeam2";
            this.cboTeam2.Size = new System.Drawing.Size(121, 21);
            this.cboTeam2.TabIndex = 5;
            this.cboTeam2.ValueMember = "Id";
            this.cboTeam2.SelectedIndexChanged += new System.EventHandler(this.cboTeam2_SelectedIndexChanged);
            // 
            // nudScore1
            // 
            this.nudScore1.Location = new System.Drawing.Point(280, 29);
            this.nudScore1.Name = "nudScore1";
            this.nudScore1.Size = new System.Drawing.Size(120, 20);
            this.nudScore1.TabIndex = 6;
            // 
            // dtpMatchTime
            // 
            this.dtpMatchTime.CustomFormat = "MM/dd/yyyy hh:mm tt";
            this.dtpMatchTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpMatchTime.Location = new System.Drawing.Point(418, 30);
            this.dtpMatchTime.Name = "dtpMatchTime";
            this.dtpMatchTime.Size = new System.Drawing.Size(269, 20);
            this.dtpMatchTime.TabIndex = 7;
            // 
            // nudScore2
            // 
            this.nudScore2.Location = new System.Drawing.Point(280, 57);
            this.nudScore2.Name = "nudScore2";
            this.nudScore2.Size = new System.Drawing.Size(120, 20);
            this.nudScore2.TabIndex = 8;
            // 
            // lblHome
            // 
            this.lblHome.AutoSize = true;
            this.lblHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHome.ForeColor = System.Drawing.Color.Firebrick;
            this.lblHome.Location = new System.Drawing.Point(7, 28);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(49, 17);
            this.lblHome.TabIndex = 9;
            this.lblHome.Text = "Home";
            // 
            // lblScores
            // 
            this.lblScores.AutoSize = true;
            this.lblScores.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblScores.Location = new System.Drawing.Point(277, 9);
            this.lblScores.Name = "lblScores";
            this.lblScores.Size = new System.Drawing.Size(52, 17);
            this.lblScores.TabIndex = 11;
            this.lblScores.Text = "Scores";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Turquoise;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdd.Location = new System.Drawing.Point(194, 371);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 25);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "NewMatch";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblVisitor
            // 
            this.lblVisitor.AutoSize = true;
            this.lblVisitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblVisitor.ForeColor = System.Drawing.Color.Green;
            this.lblVisitor.Location = new System.Drawing.Point(7, 56);
            this.lblVisitor.Name = "lblVisitor";
            this.lblVisitor.Size = new System.Drawing.Size(54, 17);
            this.lblVisitor.TabIndex = 14;
            this.lblVisitor.Text = "Visitor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(415, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "DateAndTime";
            // 
            // gboItems
            // 
            this.gboItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gboItems.Controls.Add(this.lblBg4);
            this.gboItems.Controls.Add(this.lblBg3);
            this.gboItems.Controls.Add(this.lblBg2);
            this.gboItems.Controls.Add(this.lblBg);
            this.gboItems.Controls.Add(this.chkScores);
            this.gboItems.Controls.Add(this.btnCancel);
            this.gboItems.Controls.Add(this.nudScore1);
            this.gboItems.Controls.Add(this.lblHome);
            this.gboItems.Controls.Add(this.label2);
            this.gboItems.Controls.Add(this.lblScores);
            this.gboItems.Controls.Add(this.nudScore2);
            this.gboItems.Controls.Add(this.cboTeam1);
            this.gboItems.Controls.Add(this.cboTeam2);
            this.gboItems.Controls.Add(this.lblVisitor);
            this.gboItems.Controls.Add(this.dtpMatchTime);
            this.gboItems.Location = new System.Drawing.Point(12, 321);
            this.gboItems.Name = "gboItems";
            this.gboItems.Size = new System.Drawing.Size(722, 84);
            this.gboItems.TabIndex = 16;
            this.gboItems.TabStop = false;
            this.gboItems.Text = "groupBox1";
            this.gboItems.Visible = false;
            // 
            // lblBg4
            // 
            this.lblBg4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBg4.Location = new System.Drawing.Point(236, 57);
            this.lblBg4.Name = "lblBg4";
            this.lblBg4.Size = new System.Drawing.Size(35, 21);
            this.lblBg4.TabIndex = 21;
            // 
            // lblBg3
            // 
            this.lblBg3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBg3.Location = new System.Drawing.Point(195, 57);
            this.lblBg3.Name = "lblBg3";
            this.lblBg3.Size = new System.Drawing.Size(35, 21);
            this.lblBg3.TabIndex = 20;
            // 
            // lblBg2
            // 
            this.lblBg2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBg2.Location = new System.Drawing.Point(236, 29);
            this.lblBg2.Name = "lblBg2";
            this.lblBg2.Size = new System.Drawing.Size(35, 21);
            this.lblBg2.TabIndex = 19;
            // 
            // lblBg
            // 
            this.lblBg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBg.Location = new System.Drawing.Point(195, 28);
            this.lblBg.Name = "lblBg";
            this.lblBg.Size = new System.Drawing.Size(35, 21);
            this.lblBg.TabIndex = 18;
            // 
            // chkScores
            // 
            this.chkScores.AutoSize = true;
            this.chkScores.Location = new System.Drawing.Point(418, 58);
            this.chkScores.Name = "chkScores";
            this.chkScores.Size = new System.Drawing.Size(15, 14);
            this.chkScores.TabIndex = 17;
            this.chkScores.UseVisualStyleBackColor = true;
            this.chkScores.CheckedChanged += new System.EventHandler(this.chkScores_CheckedChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.Location = new System.Drawing.Point(693, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(26, 23);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "X";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // chkHideMatches
            // 
            this.chkHideMatches.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkHideMatches.AutoSize = true;
            this.chkHideMatches.Location = new System.Drawing.Point(604, 7);
            this.chkHideMatches.Name = "chkHideMatches";
            this.chkHideMatches.Size = new System.Drawing.Size(127, 17);
            this.chkHideMatches.TabIndex = 18;
            this.chkHideMatches.Text = "Hide Played Matches";
            this.chkHideMatches.UseVisualStyleBackColor = true;
            this.chkHideMatches.CheckedChanged += new System.EventHandler(this.chkHideMatches_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 408);
            this.Controls.Add(this.chkHideMatches);
            this.Controls.Add(this.gboItems);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.dgvMatch);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(769, 447);
            this.MinimumSize = new System.Drawing.Size(769, 447);
            this.Name = "Form1";
            this.Text = "WeAreTheChampions v1.0";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudScore1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudScore2)).EndInit();
            this.gboItems.ResumeLayout(false);
            this.gboItems.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem teamsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playersToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvMatch;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox cboTeam1;
        private System.Windows.Forms.ComboBox cboTeam2;
        private System.Windows.Forms.NumericUpDown nudScore1;
        private System.Windows.Forms.DateTimePicker dtpMatchTime;
        private System.Windows.Forms.NumericUpDown nudScore2;
        private System.Windows.Forms.Label lblHome;
        private System.Windows.Forms.Label lblScores;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblVisitor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gboItems;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox chkScores;
        private System.Windows.Forms.DataGridViewTextBoxColumn MatchNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.CheckBox chkHideMatches;
        private System.Windows.Forms.Label lblBg4;
        private System.Windows.Forms.Label lblBg3;
        private System.Windows.Forms.Label lblBg2;
        private System.Windows.Forms.Label lblBg;
    }
}

