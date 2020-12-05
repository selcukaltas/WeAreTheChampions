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
    public partial class PlayersForm : Form
    {
        private readonly WeAreTheChampionsContext db;
        public PlayersForm(WeAreTheChampionsContext db)
        {
            this.db = db;
            InitializeComponent();
            dgvPlayers.AutoGenerateColumns = false;
            LoadPlayers();
            LoadTeams();

        }
        public PlayersForm(WeAreTheChampionsContext db, string value)
        {
            this.db = db;
            InitializeComponent();
            LoadTeams();
            LoadPlayers();
            txtTeamName.Text = value;
            cboTeams.Text = value;
            TeamsFormControls();
        }
        private void TeamsFormControls()
        {
            txtTeamName.Enabled = false;
            cboTeams.Enabled = false;
            chkNoTeam.Enabled = false;
        }
        private void LoadTeams()
        {
            cboTeams.DataSource = db.Teams.ToList();
        }
        private void LoadPlayers()
        {
            dgvPlayers.DataSource = db.Players.Select(x => new
            {
                x.Id,
                x.PlayerName,
                Team = x.Team.TeamName,
            }).ToList();
        }
        private void dgvPlayers_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPlayers.SelectedRows.Count < 1)
            {
                return;
            }
            if (dgvPlayers.SelectedRows[0].Cells[0].Value == null)
            {
                return;
            }
            int id = (int)dgvPlayers.SelectedRows[0].Cells[0].Value;
            Player player = db.Players.Find(id);
            txtPlayerName.Text = player.PlayerName;
            if (player.TeamId == null)
            {
                cboTeams.Text = string.Empty;
            }
            else
            {
                cboTeams.SelectedValue = player.TeamId;
                cboTeams.Text = player.Team.TeamName;
            }

        }
        private void chkNoTeam_CheckedChanged(object sender, EventArgs e)
        {
            cboTeams.Enabled = chkNoTeam.Checked ? false : true;
        }
        private void txtTeamName_TextChanged(object sender, EventArgs e)
        {
            if (txtTeamName.Text=="")
            {
                LoadPlayers();
                return;
            }
            FiltreTeams();
        }

        private void FiltreTeams()
        {
            dgvPlayers.DataSource = db.Players.Where(n => n.Team.TeamName.Contains(txtTeamName.Text)).ToList().Select(x => new
            {
                Id = x.Id,
                PlayerName = x.PlayerName,
                Team = x.Team.TeamName
            }).ToList();
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            if (chkNoTeam.Checked)
            {
                string playerName = txtPlayerName.Text.Trim();
                if (playerName==null||playerName=="")
                {
                    MessageBox.Show("Please give the correct name");
                    return;
                }
                if (db.Players.Any(x=>x.Team.TeamName!=cboTeams.Text))
                {
                    if (db.Players.Any(x => x.PlayerName.Replace(" ", "") == playerName.Replace(" ", "")))
                    {
                        MessageBox.Show("This player is already in a team.If you want to change the team please check for edit.");
                        return;
                    }
                }
                Player player = new Player()
                {
                    PlayerName = playerName,
                    TeamId = null,
                };

                db.Players.Add(player);
                db.SaveChanges();
                if (txtTeamName.Text != "")
                {
                    FiltreTeams();
                    return;
                }
                LoadPlayers();
                txtTeamName.Clear();
                return;
            }
            else
            {
                string playerName = txtPlayerName.Text.Trim();
                if (playerName == null || playerName == ""|| cboTeams.SelectedValue == null)
                {
                    MessageBox.Show("Please fill the areas");
                    return;
                }
                if (db.Players.Any(x => x.PlayerName.Replace(" ", "") == playerName.Replace(" ", "")))
                {
                    MessageBox.Show("This player is already in a team.");
                    return;
                }
                Player player = new Player()
                {
                    PlayerName = playerName,
                    TeamId = (int)cboTeams.SelectedValue,
                };
                db.Players.Add(player);
                db.SaveChanges();
                if (txtTeamName.Text != "")
                {
                    dgvPlayers.DataSource = db.Players.Where(n => n.Team.TeamName.Contains(txtTeamName.Text)).ToList().Select(x => new
                    {
                        Id = x.Id,
                        PlayerName = x.PlayerName,
                        Team = x.Team.TeamName
                    }).ToList();
                    return;
                }
                LoadPlayers();
                txtTeamName.Clear();
                return;
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvPlayers.Rows.Count < 1)
            {
                MessageBox.Show("There is no player for delete");
                return;
            }
            int id = (int)dgvPlayers.SelectedRows[0].Cells[0].Value;
            int index = dgvPlayers.SelectedRows[0].Index;
            Player player = db.Players.Find(id);
            db.Players.Remove(player);
            db.SaveChanges();
            if (txtTeamName.Text != "")
            {
                FiltreTeams();
                if (dgvPlayers.SelectedRows.Count > 0)
                {
                    indexMethod(index);
                }
                return;
            }
            LoadPlayers();
            indexMethod(index);
           
        }

        private void indexMethod(int index)
        {
            if (dgvPlayers.SelectedRows.Count > 0)
            {
                if (dgvPlayers.Rows.Count > 0)
                {
                    dgvPlayers.ClearSelection();
                    int secilecekIndeks = index >= dgvPlayers.Rows.Count
                        ? dgvPlayers.Rows.Count - 1
                        : index;

                    dgvPlayers.Rows[secilecekIndeks].Selected = true;
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (cboTeams.Text==string.Empty&&chkNoTeam.Checked==false)
            {
                MessageBox.Show("If you want edit null team please Check it NoTeam box");
                return;
            }
     
            if (dgvPlayers.Rows.Count < 1)
            {
                MessageBox.Show("There is no player for edit");
                return;
            }
            //if (cboTeams.SelectedValue==null&&chkNoTeam.Checked==false)
            //{
            //    MessageBox.Show("If you want edit null team please Check it NoTeam box");
            //    return;
            //}
            string playerName = txtPlayerName.Text.Trim();
            int id = (int)dgvPlayers.SelectedRows[0].Cells[0].Value;
            if (playerName == null || playerName == "")
            {
                MessageBox.Show("Please give the correct name");
                return;
            }
            Player player = db.Players.Find(id);

            if (playerName != player.PlayerName)
            {
                if (db.Players.Any(x => x.PlayerName.Replace(" ", "") == playerName.Replace(" ", "")))
                {
                    MessageBox.Show("This player is already in a team.");
                    return;
                }
               
                int index = dgvPlayers.SelectedRows[0].Index;
                if (chkNoTeam.Checked)
                    player.TeamId = null;
                else
                    player.TeamId = (int)cboTeams.SelectedValue;
                player.PlayerName = playerName;

                db.SaveChanges();
                if (txtTeamName.Text != "")
                {
                    FiltreTeams();
                    dgvPlayers.ClearSelection();
                    dgvPlayers.Rows[index].Selected = true;
                    return;
                }
                LoadPlayers();
                dgvPlayers.ClearSelection();
                dgvPlayers.Rows[index].Selected = true;
            }
            else
            {
                int index = dgvPlayers.SelectedRows[0].Index;
                if (chkNoTeam.Checked)
                    player.TeamId = null;
                else
                    player.TeamId = (int)cboTeams.SelectedValue;
                if (playerName == null || playerName == "")
                {
                    MessageBox.Show("Please give the correct name");
                    return;
                }
                player.PlayerName = playerName;

                db.SaveChanges();
                if (txtTeamName.Text != "")
                {
                    FiltreTeams();
                    dgvPlayers.ClearSelection();
                    dgvPlayers.Rows[index].Selected = true;
                    return;
                }
                LoadPlayers();
                dgvPlayers.ClearSelection();
                dgvPlayers.Rows[index].Selected = true;
            }
          
        }
        private void rbSearch_CheckedChanged(object sender, EventArgs e)
        {
            txtTeamName.Enabled = true;
        }
        private void rbCancel_CheckedChanged(object sender, EventArgs e)
        {
            dgvPlayers.DataSource = db.Players.Where(x =>x.Team.TeamName == null).ToList();
        }
        private void rbAdd_CheckedChanged(object sender, EventArgs e)
        {
            gbEditAndAdd.Visible = true;
            btnEdit.Visible = false;
            gbEditAndAdd.Text = "AddNewPlayer";
            btnAdd.Visible = true;
        }
        private void rbEdit_CheckedChanged(object sender, EventArgs e)
        {
            gbEditAndAdd.Visible = true;
            btnAdd.Visible = false;
            gbEditAndAdd.Text = "EditPlayer";
            btnEdit.Visible = true;
        }
        private void rbNoControl_CheckedChanged(object sender, EventArgs e)
        {
            gbEditAndAdd.Visible = false;
            btnEdit.Visible = true;
            btnAdd.Visible = true;
        }

        private void chkTeam_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTeam.Checked)
                dgvPlayers.DataSource = db.Players.Where(x => x.Team.TeamName == null).ToList();
            else
            {
                if (txtTeamName.Text!="")
                {
                FiltreTeams();
                }
                else
                {
                    LoadPlayers();

                }
            }
           
            

        }
    }
}
