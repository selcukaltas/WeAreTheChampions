namespace WeAreTheChampions
{
    partial class PlayersForm
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
            this.dgvPlayers = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboTeams = new System.Windows.Forms.ComboBox();
            this.txtPlayerName = new System.Windows.Forms.TextBox();
            this.txtTeamName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chkNoTeam = new System.Windows.Forms.CheckBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbNoControl = new System.Windows.Forms.RadioButton();
            this.rbAdd = new System.Windows.Forms.RadioButton();
            this.rbEdit = new System.Windows.Forms.RadioButton();
            this.gbEditAndAdd = new System.Windows.Forms.GroupBox();
            this.chkTeam = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayers)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gbEditAndAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPlayers
            // 
            this.dgvPlayers.AllowUserToAddRows = false;
            this.dgvPlayers.AllowUserToDeleteRows = false;
            this.dgvPlayers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPlayers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPlayers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlayers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvPlayers.Location = new System.Drawing.Point(12, 22);
            this.dgvPlayers.MultiSelect = false;
            this.dgvPlayers.Name = "dgvPlayers";
            this.dgvPlayers.ReadOnly = true;
            this.dgvPlayers.RowHeadersVisible = false;
            this.dgvPlayers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPlayers.Size = new System.Drawing.Size(300, 283);
            this.dgvPlayers.TabIndex = 0;
            this.dgvPlayers.SelectionChanged += new System.EventHandler(this.dgvPlayers_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Id";
            this.Column1.FillWeight = 45.68528F;
            this.Column1.HeaderText = "No";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "PlayerName";
            this.Column2.FillWeight = 127.1574F;
            this.Column2.HeaderText = "Player";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Team";
            this.Column3.FillWeight = 127.1574F;
            this.Column3.HeaderText = "Team";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // cboTeams
            // 
            this.cboTeams.DisplayMember = "TeamName";
            this.cboTeams.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTeams.FormattingEnabled = true;
            this.cboTeams.Location = new System.Drawing.Point(14, 35);
            this.cboTeams.Name = "cboTeams";
            this.cboTeams.Size = new System.Drawing.Size(121, 21);
            this.cboTeams.TabIndex = 1;
            this.cboTeams.ValueMember = "Id";
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.Location = new System.Drawing.Point(141, 36);
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.Size = new System.Drawing.Size(100, 20);
            this.txtPlayerName.TabIndex = 2;
            // 
            // txtTeamName
            // 
            this.txtTeamName.Location = new System.Drawing.Point(318, 26);
            this.txtTeamName.Name = "txtTeamName";
            this.txtTeamName.Size = new System.Drawing.Size(125, 20);
            this.txtTeamName.TabIndex = 6;
            this.txtTeamName.TextChanged += new System.EventHandler(this.txtTeamName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Players";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(315, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "SearchForTeam";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(14, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Teams";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(138, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "PlayerName";
            // 
            // chkNoTeam
            // 
            this.chkNoTeam.AutoSize = true;
            this.chkNoTeam.Location = new System.Drawing.Point(247, 35);
            this.chkNoTeam.Name = "chkNoTeam";
            this.chkNoTeam.Size = new System.Drawing.Size(67, 17);
            this.chkNoTeam.TabIndex = 11;
            this.chkNoTeam.Text = "NoTeam";
            this.chkNoTeam.UseVisualStyleBackColor = true;
            this.chkNoTeam.CheckedChanged += new System.EventHandler(this.chkNoTeam_CheckedChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Turquoise;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdd.Location = new System.Drawing.Point(14, 59);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(116, 25);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "AddNewPlayer";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDelete.Location = new System.Drawing.Point(136, 58);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(87, 25);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete ⌫";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Goldenrod;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEdit.Location = new System.Drawing.Point(17, 58);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(113, 25);
            this.btnEdit.TabIndex = 13;
            this.btnEdit.Text = "Edit ✎";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbNoControl);
            this.groupBox1.Controls.Add(this.rbAdd);
            this.groupBox1.Controls.Add(this.rbEdit);
            this.groupBox1.Location = new System.Drawing.Point(317, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(86, 88);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Controller";
            // 
            // rbNoControl
            // 
            this.rbNoControl.AutoSize = true;
            this.rbNoControl.Location = new System.Drawing.Point(6, 62);
            this.rbNoControl.Name = "rbNoControl";
            this.rbNoControl.Size = new System.Drawing.Size(58, 17);
            this.rbNoControl.TabIndex = 20;
            this.rbNoControl.TabStop = true;
            this.rbNoControl.Text = "Cancel";
            this.rbNoControl.UseVisualStyleBackColor = true;
            this.rbNoControl.CheckedChanged += new System.EventHandler(this.rbNoControl_CheckedChanged);
            // 
            // rbAdd
            // 
            this.rbAdd.AutoSize = true;
            this.rbAdd.Location = new System.Drawing.Point(6, 39);
            this.rbAdd.Name = "rbAdd";
            this.rbAdd.Size = new System.Drawing.Size(76, 17);
            this.rbAdd.TabIndex = 21;
            this.rbAdd.TabStop = true;
            this.rbAdd.Text = "NewPlayer";
            this.rbAdd.UseVisualStyleBackColor = true;
            this.rbAdd.CheckedChanged += new System.EventHandler(this.rbAdd_CheckedChanged);
            // 
            // rbEdit
            // 
            this.rbEdit.AutoSize = true;
            this.rbEdit.Location = new System.Drawing.Point(6, 19);
            this.rbEdit.Name = "rbEdit";
            this.rbEdit.Size = new System.Drawing.Size(72, 17);
            this.rbEdit.TabIndex = 19;
            this.rbEdit.TabStop = true;
            this.rbEdit.Text = "EditPlayer";
            this.rbEdit.UseVisualStyleBackColor = true;
            this.rbEdit.CheckedChanged += new System.EventHandler(this.rbEdit_CheckedChanged);
            // 
            // gbEditAndAdd
            // 
            this.gbEditAndAdd.Controls.Add(this.label3);
            this.gbEditAndAdd.Controls.Add(this.cboTeams);
            this.gbEditAndAdd.Controls.Add(this.txtPlayerName);
            this.gbEditAndAdd.Controls.Add(this.label4);
            this.gbEditAndAdd.Controls.Add(this.chkNoTeam);
            this.gbEditAndAdd.Controls.Add(this.btnDelete);
            this.gbEditAndAdd.Controls.Add(this.btnEdit);
            this.gbEditAndAdd.Controls.Add(this.btnAdd);
            this.gbEditAndAdd.Location = new System.Drawing.Point(12, 311);
            this.gbEditAndAdd.Name = "gbEditAndAdd";
            this.gbEditAndAdd.Size = new System.Drawing.Size(416, 84);
            this.gbEditAndAdd.TabIndex = 19;
            this.gbEditAndAdd.TabStop = false;
            this.gbEditAndAdd.Text = "groupBox2";
            this.gbEditAndAdd.Visible = false;
            // 
            // chkTeam
            // 
            this.chkTeam.AutoSize = true;
            this.chkTeam.Location = new System.Drawing.Point(318, 52);
            this.chkTeam.Name = "chkTeam";
            this.chkTeam.Size = new System.Drawing.Size(83, 17);
            this.chkTeam.TabIndex = 20;
            this.chkTeam.Text = "FreeAgency";
            this.chkTeam.UseVisualStyleBackColor = true;
            this.chkTeam.CheckedChanged += new System.EventHandler(this.chkTeam_CheckedChanged);
            // 
            // PlayersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 401);
            this.Controls.Add(this.chkTeam);
            this.Controls.Add(this.gbEditAndAdd);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTeamName);
            this.Controls.Add(this.dgvPlayers);
            this.MinimumSize = new System.Drawing.Size(462, 437);
            this.Name = "PlayersForm";
            this.Text = "PlayersForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayers)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbEditAndAdd.ResumeLayout(false);
            this.gbEditAndAdd.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPlayers;
        private System.Windows.Forms.ComboBox cboTeams;
        private System.Windows.Forms.TextBox txtPlayerName;
        private System.Windows.Forms.TextBox txtTeamName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkNoTeam;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbEdit;
        private System.Windows.Forms.RadioButton rbAdd;
        private System.Windows.Forms.GroupBox gbEditAndAdd;
        private System.Windows.Forms.RadioButton rbNoControl;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.CheckBox chkTeam;
    }
}