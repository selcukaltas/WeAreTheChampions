using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeAreTheChampions.Models;

namespace WeAreTheChampions
{
    public partial class Form1 : Form
    {
        WeAreTheChampionsContext db = new WeAreTheChampionsContext();
        public Form1()
        {
            InitializeComponent();
            dgvMatch.AutoGenerateColumns = false;
            ShowMatches();
        }
        private void ShowMatches()
        {
            dgvMatch.DataSource = db.Matches.OrderByDescending(x => x.MatchTime).Select(x => new
            {
                MatchNo = x.Id,
                Team1 = x.HomeTeam.TeamName,
                Team2 = x.GuestTeam.TeamName,
                //Color = x.HomeTeam.Colors.FirstOrDefault(y => y.Id == x.HomeTeamId),
                Date = x.MatchTime,
                Time = x.MatchTime,
                Score = x.Score1 + "-" + x.Score2,
                x.Result,
            }).ToList();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvMatch.Rows.Count < 1)
            {
                MessageBox.Show("There is no match for edit");
                return;
            }
            chkScores.Text = "CancelledMatch";
            btnAdd.Enabled = false;
            gboItems.Text = "EditYourMatch";
            int id = (int)dgvMatch.SelectedRows[0].Cells[0].Value;
            Match match = db.Matches.Find(id);

            if (btnEdit.Text == "Save ▼")
            {
                int index = dgvMatch.SelectedRows[0].Index;
                match.HomeTeamId = (int)cboTeam1.SelectedValue;                 //COLOR MENUSU DAHA SONRA EKLENECEK
                match.GuestTeamId = (int)cboTeam2.SelectedValue;
                if (chkScores.Checked)
                {
                    match.Score1 = null;
                    match.Score2 = null;
                    match.Result = (Result)0;
                }
                else
                {
                    match.Score1 = (int)nudScore1.Value;
                    match.Score2 = (int)nudScore2.Value;
                    match.Result = match.Score1 > match.Score2 ? (Result)2 : (Result)3;
                    if (match.Score1 == match.Score2)
                        match.Result = (Result)1;
                }
                match.MatchTime = dtpMatchTime.Value;
                if (match.HomeTeamId == match.GuestTeamId)
                {
                    MessageBox.Show("That compare not allowed. Check the teams!");
                    return;
                }
                btnAdd.Enabled = true;
                gboItems.Text = "EditYourMatch";
                ButtonLocationVisiblePositive();
                db.SaveChanges();
                ShowMatches();
                dgvMatch.ClearSelection();
                btnEdit.Text = "Edit ✎";
                dgvMatch.Rows[index].Selected = true;
                return;
            }
            ButtonLocationVisibleNegative();

            cboTeam1.DataSource = db.Teams.ToList();
            cboTeam2.DataSource = db.Teams.ToList();
            if (match.Score1 == null || match.Score2 == null)
            {
                nudScore1.Value = 0;
                nudScore2.Value = 0;
            }
            else
            {
                nudScore1.Value = (int)match.Score1;
                nudScore2.Value = (int)match.Score2;
            }
            cboTeam1.Text = dgvMatch.SelectedRows[0].Cells[1].Value.ToString();
            cboTeam2.Text = dgvMatch.SelectedRows[0].Cells[2].Value.ToString();
            dtpMatchTime.Value = (DateTime)dgvMatch.SelectedRows[0].Cells[4].Value;
            btnEdit.Text = "Save ▼";
        }
        private void ButtonLocationVisiblePositive()
        {
            btnAdd.Top += 84;
            btnEdit.Top += 84;
            btnDelete.Top += 84;
            dgvMatch.Height += 84;
            gboItems.Visible = false;
        }
        private void ButtonLocationVisibleNegative()
        {
            btnAdd.Top -= 84;
            btnEdit.Top -= 84;
            btnDelete.Top -= 84;
            dgvMatch.Height -= 84;
            gboItems.Visible = true;
        }
        private void dgvMatch_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnAdd.Enabled = false;
            if (btnEdit.Text == "Save ▼")
            {
                int id = (int)dgvMatch.SelectedRows[0].Cells[0].Value;
                Match match = db.Matches.Find(id);
                match.HomeTeamId = (int)cboTeam1.SelectedValue;
                match.GuestTeamId = (int)cboTeam2.SelectedValue;
                match.Score1 = (int)nudScore1.Value;
                match.Score2 = (int)nudScore2.Value;
                match.MatchTime = dtpMatchTime.Value;
                match.Result = match.Score1 > match.Score2 ? (Result)2 : (Result)3;
                if (match.Score1 == match.Score2)
                    match.Result = (Result)1;
                if (match.HomeTeamId == match.GuestTeamId)
                {
                    MessageBox.Show("That compare not allowed. Check the teams!");
                    return;
                }
                btnAdd.Enabled = true;
                ButtonLocationVisiblePositive();
                db.SaveChanges();
                ShowMatches();
                btnEdit.Text = "Edit ✎";
                return;
            }
            ButtonLocationVisibleNegative();
            DataNames();
            btnEdit.Text = "Save ▼";
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            chkScores.Text = "UpcomingMatch";
            gboItems.Text = "AddNewMatch";
            if (btnAdd.Text == "Add")
            {
                if (cboTeam1.Items.Count < 1)
                {
                    MessageBox.Show("There is no team");
                    return;
                }
                if (chkScores.Checked)
                {
                    Match match = new Match()
                    {
                        HomeTeamId = (int)cboTeam1.SelectedValue,
                        GuestTeamId = (int)cboTeam2.SelectedValue,
                        Score1 = null,
                        Score2 = null,
                        MatchTime = dtpMatchTime.Value,    //COLOR MENUSU DAHA SONRA EKLENECEK
                    };
                    match.Result = (Result)0;
                    if (match.HomeTeamId == match.GuestTeamId)
                    {
                        MessageBox.Show("That compare not allowed. Check the teams!");
                        return;
                    }
                    db.Matches.Add(match);
                    db.SaveChanges();
                    ShowMatches();
                    return;
                }
                else
                {
                    Match match = new Match()
                    {
                        HomeTeamId = (int)cboTeam1.SelectedValue,
                        GuestTeamId = (int)cboTeam2.SelectedValue,
                        Score1 = (int)nudScore1.Value,
                        Score2 = (int)nudScore2.Value,
                        MatchTime = dtpMatchTime.Value,    //COLOR MENUSU DAHA SONRA EKLENECEK
                    };
                    match.Result = match.Score1 > match.Score2 ? (Result)2 : (Result)3;
                    if (match.Score1 == match.Score2)
                        match.Result = (Result)1;
                    if (match.HomeTeamId == match.GuestTeamId)
                    {
                        MessageBox.Show("That compare not allowed. Check the teams!");
                        return;
                    }
                    db.Matches.Add(match);
                    db.SaveChanges();
                    ShowMatches();
                    return;
                }
            }
            cboTeam1.DataSource = db.Teams.ToList();
            cboTeam2.DataSource = db.Teams.ToList();
            dtpMatchTime.Value = DateTime.Now;
            nudScore1.Value = 0;
            nudScore2.Value = 0;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnAdd.Text = "Add";
            ButtonLocationVisibleNegative();
        }
        private void dgvMatch_SelectionChanged(object sender, EventArgs e)
        {
            DataNames();
        }
        private void DataNames()
        {
            if (dgvMatch.SelectedRows.Count < 1)
                return;
            cboTeam1.DataSource = db.Teams.ToList();
            cboTeam2.DataSource = db.Teams.ToList();
            if (dgvMatch.SelectedRows[0].Cells[0].Value == null)
            {
                return;
            }
            int id = (int)dgvMatch.SelectedRows[0].Cells[0].Value;
            Match match = db.Matches.Find(id);

            if (match.Score1 == null || match.Score2 == null)
            {
                nudScore1.Value = 0;
                nudScore2.Value = 0;
            }
            else
            {
                nudScore1.Value = (int)match.Score1;
                nudScore2.Value = (int)match.Score2;
            }
            cboTeam1.Text = dgvMatch.SelectedRows[0].Cells[1].Value.ToString();
            cboTeam2.Text = dgvMatch.SelectedRows[0].Cells[2].Value.ToString();
            dtpMatchTime.Value = (DateTime)dgvMatch.SelectedRows[0].Cells[4].Value;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {

            ButtonLocationVisiblePositive();
            if (btnEdit.Text == "Save ▼")
            {
                btnEdit.Text = "Edit ✎";
                btnAdd.Enabled = true;
            }
            if (btnAdd.Text == "Add")
            {
                btnAdd.Text = "NewMatch";
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvMatch.Rows.Count < 1)
            {
                return;
            }
            int id = (int)dgvMatch.SelectedRows[0].Cells[0].Value;
            var index = dgvMatch.SelectedRows[0].Index;
            Match match = db.Matches.Find(id);
            db.Matches.Remove(match);
            db.SaveChanges();
            ShowMatches();
            if (dgvMatch.SelectedRows.Count > 0)
            {
                if (dgvMatch.Rows.Count > 0)
                {
                    dgvMatch.ClearSelection();
                    int secilecekIndeks = index >= dgvMatch.Rows.Count
                        ? dgvMatch.Rows.Count - 1
                        : index;
                    dgvMatch.Rows[secilecekIndeks].Selected = true;
                }
            }
        }
        private void playersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlayersForm frm = new PlayersForm(db);
            frm.ShowDialog();
        }
        private void chkScores_CheckedChanged(object sender, EventArgs e)
        {
            if (chkScores.Checked)
            {
                nudScore1.Enabled = false;
                nudScore2.Enabled = false;
            }
            else
            {
                nudScore1.Enabled = true;
                nudScore2.Enabled = true;
            }

        }
        private void teamsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TeamsForm frmTeam = new TeamsForm(db);
            frmTeam.HasBeenChanged += FrmTeam_HasBeenChanged;
            frmTeam.ShowDialog();
        }
        private void FrmTeam_HasBeenChanged(object sender, EventArgs e)
        {
            ShowMatches();
            cboTeam1.DataSource = db.Teams.ToList();
            cboTeam2.DataSource = db.Teams.ToList();
            cboTeam1.Text = "";
            cboTeam2.Text = "";
        }
        private void chkHideMatches_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHideMatches.Checked)
                dgvMatch.DataSource = db.Matches.OrderByDescending(x => x.MatchTime).Where(x => x.Result == 0).ToList().Select(x => new
                {
                    MatchNo = x.Id,
                    Team1 = x.HomeTeam.TeamName,
                    Team2 = x.GuestTeam.TeamName,
                    //Color = x.HomeTeam.Colors.FirstOrDefault(y => y.Id == x.HomeTeamId),
                    Date = x.MatchTime,
                    Time = x.MatchTime,
                    Score = x.Score1 + "-" + x.Score2,
                    x.Result,
                }).ToList();
            else
                ShowMatches();
        }
        private void colorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorsForm colorsForm = new ColorsForm(db);
            colorsForm.ShowDialog();
        }
        private void cboTeam1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var team = (Team)cboTeam1.SelectedItem;
            if (team==null)
            {
                return;
            }
            var renkler = team.Colors.ToList();

            if (renkler.Count == 0)
            {
                return;
            }
            else if (renkler.Count == 1)
            {
                lblBg.BackColor = System.Drawing.Color.FromArgb(renkler[0].Red, renkler[0].Green, renkler[0].Blue);
            }
            else if (renkler.Count == 2)
            {
                lblBg.BackColor = System.Drawing.Color.FromArgb(renkler[0].Red, renkler[0].Green, renkler[0].Blue);
                lblBg2.BackColor = System.Drawing.Color.FromArgb(renkler[1].Red, renkler[1].Green, renkler[1].Blue);
            }
        }
        private void cboTeam2_SelectedIndexChanged(object sender, EventArgs e)
        {
            var team2 = (Team)cboTeam2.SelectedItem;
            if (team2==null)
            {
                return;
            }
            var renkler2 = team2.Colors.ToList();
            if (renkler2.Count == 0)
            {
                return;
            }
            else if (renkler2.Count == 1)
            {
                lblBg3.BackColor = System.Drawing.Color.FromArgb(renkler2[0].Red, renkler2[0].Green, renkler2[0].Blue);
            }
            else if (renkler2.Count == 2)
            {
                lblBg3.BackColor = System.Drawing.Color.FromArgb(renkler2[0].Red, renkler2[0].Green, renkler2[0].Blue);
                lblBg4.BackColor = System.Drawing.Color.FromArgb(renkler2[1].Red, renkler2[1].Green, renkler2[1].Blue);
            }
        }
    }
}
