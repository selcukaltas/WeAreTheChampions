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
    public partial class TeamsForm : Form
    {
        public event EventHandler HasBeenChanged;
        private readonly WeAreTheChampionsContext db;

        public TeamsForm(WeAreTheChampionsContext db)
        {
            this.db = db;
            InitializeComponent();
            dgvTeams.AutoGenerateColumns = false;
            LoadTeams();
            LoadColors();
            cboColor1.SelectedIndex = cboColor2.SelectedIndex = -1;
        }
        private void LoadColors()
        {
            cboColor1.DataSource = db.Colors.ToList();
            cboColor2.DataSource = db.Colors.ToList();
        }
        private void WhenMakeChange(EventArgs args)
        {
            HasBeenChanged?.Invoke(this, args);
        }
        private void LoadTeams()
        {
            dgvTeams.DataSource = db.Teams.ToList();

        }
        private void btnAddPlayer_Click(object sender, EventArgs e)
        {
            if (dgvTeams.Rows.Count < 1)
            {
                MessageBox.Show("There is no team for check player list");
                return;
            }
            int id = (int)dgvTeams.SelectedRows[0].Cells[0].Value;
            Team team = db.Teams.Find(id);
            PlayersForm form2 = new PlayersForm(db, team.TeamName);

            form2.ShowDialog();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            List<Models.Color> colors = new List<Models.Color>();
            var color1 = (Models.Color)cboColor1.SelectedItem;
            var color2 = (Models.Color)cboColor2.SelectedItem;
            string teamName = txtTeamName.Text.UpperCaseFirst().Trim();
            if (btnAdd.Text == "Save")
            {
                if (color1 == null || color2 == null)
                {
                    MessageBox.Show("Have to choose two colors.");
                    return;
                }
                colors.Add(color1);
                colors.Add(color2);
                var selectedTeam = (Team)dgvTeams.SelectedRows[0].DataBoundItem;
                selectedTeam.Colors = colors;
                if (dgvTeams.Rows.Count < 1)
                {
                    MessageBox.Show("There is no team for edit");
                    return;
                }
                int id = (int)dgvTeams.SelectedRows[0].Cells[0].Value;
                Team team = db.Teams.Find(id);
                if (teamName == "")
                {
                    MessageBox.Show("Wrong Name");
                    return;
                }

                int index = dgvTeams.SelectedRows[0].Index;
                if (teamName != team.TeamName)
                {
                    if (db.Teams.Any(x => x.TeamName.Replace(" ", "") == txtTeamName.Text.Replace(" ", "")))
                    {
                        MessageBox.Show("This team already in a list.");
                        return;
                    }
                }
                team.TeamName = teamName;
                db.SaveChanges();
                LoadTeams();
                dgvTeams.ClearSelection();
                dgvTeams.Rows[index].Selected = true;
                txtTeamName.Clear();
                WhenMakeChange(EventArgs.Empty);
                btnAdd.Text = "Add";
                return;
            }
            if (color1 == null || color2 == null)
            {
                MessageBox.Show("Have to choose two colors.");
                return;
            }
            if (teamName == "")
            {
                MessageBox.Show("Please write a correct team name");
                return;
            }
            if (db.Teams.Any(x => x.TeamName.Replace(" ", "") == teamName.Replace(" ", "")))
            {
                MessageBox.Show("This team already in a list.");
                return;
            }
            colors.Add(color1);
            colors.Add(color2);
            db.Teams.Add(new Team() { TeamName = teamName, Colors = colors });
            db.SaveChanges();
            LoadTeams();
            txtTeamName.Clear();
            WhenMakeChange(EventArgs.Empty);
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvTeams.Rows.Count < 1)
            {
                MessageBox.Show("There is no team for edit");
                return;
            }
            int id = (int)dgvTeams.SelectedRows[0].Cells[0].Value;
            Team team = db.Teams.Find(id);
            btnAdd.Text = "Save";
            var renkler = team.Colors.ToList();
            if (renkler.Count == 1)
            {
                cboColor1.SelectedItem = renkler[0];
            }
            else if (renkler.Count == 2)
            {
                cboColor1.SelectedItem = renkler[0];
                cboColor2.SelectedItem = renkler[1];
            }
            if (btnEdit.Text == "Cancel")
            {
                btnEdit.Text = "Edit";
                txtTeamName.Clear();
                btnAdd.Text = "AddNewTeam";
                return;
            }
            btnEdit.Text = "Cancel";
        }
        private void dgvTeams_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTeams.SelectedRows.Count < 1)
            {
                return;
            }
            int id = (int)dgvTeams.SelectedRows[0].Cells[0].Value;
            Team team = db.Teams.Find(id);
            txtTeamName.Text = team.TeamName;
            var pickedTeam = (Team)dgvTeams.SelectedRows[0].DataBoundItem;
            List<Models.Color> renkler = team.Colors.ToList();
            if (renkler.Count == 0 || renkler == null)
            {
                lblBg.BackColor = System.Drawing.Color.Transparent;
                lblBg2.BackColor = System.Drawing.Color.Transparent;
            }
            else if (renkler.Count == 1)
            {
                lblBg.BackColor = System.Drawing.Color.FromArgb(renkler[0].Red, renkler[0].Green, renkler[0].Blue);
                lblBg2.BackColor = System.Drawing.Color.Transparent;
                cboColor1.SelectedItem = renkler[0];
            }
            else
            {
                lblBg.BackColor = System.Drawing.Color.FromArgb(renkler[0].Red, renkler[0].Green, renkler[0].Blue);
                lblBg2.BackColor = System.Drawing.Color.FromArgb(renkler[1].Red, renkler[1].Green, renkler[1].Blue);
                cboColor1.SelectedItem = renkler[0];
                cboColor2.SelectedItem = renkler[1];
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvTeams.Rows.Count < 1)
            {
                MessageBox.Show("There is no team for Delete");
                return;
            }
            int id = (int)dgvTeams.SelectedRows[0].Cells[0].Value;
            Team team = db.Teams.Find(id);
            db.SaveChanges();
            if (team.HomeMatches.Any(x => x.HomeTeam.TeamName == team.TeamName)|| team.AwayMatches.Any(x => x.GuestTeam.TeamName == team.TeamName)|| team.Players.Any(x => x.Team.TeamName == team.TeamName))
            {
                DialogResult dr = MessageBox.Show("You can't delete this team first delete matches and players then you are free to delete :)", "Delete Team", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.OK)
                {
                    return;
                }
            }
            var renkler = team.Colors.ToList();
            foreach (var item in renkler)
            {
                team.Colors.Remove(item);
            }
            if (dgvTeams.Rows.Count < 1)
            {
                MessageBox.Show("There is no team for delete");
                return;
            }
            var index = dgvTeams.SelectedRows[0].Index;
            if (team.Colors.Count != 0)
            {
                MessageBox.Show("First delete colors of this team");
                return;
            }
            db.Teams.Remove(team);
            db.SaveChanges();
            LoadTeams();
            LoadColors();
            cboColor1.SelectedIndex = cboColor2.SelectedIndex = -1;
            if (dgvTeams.SelectedRows.Count > 0)
            {
                if (dgvTeams.Rows.Count > 0)
                {
                    dgvTeams.ClearSelection();
                    int secilecekIndeks = index >= dgvTeams.Rows.Count
                        ? dgvTeams.Rows.Count - 1
                        : index;

                    dgvTeams.Rows[secilecekIndeks].Selected = true;
                }
            }
            WhenMakeChange(EventArgs.Empty);
        }
        private void cboColor1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboColor1.SelectedIndex == -1)
            {
                lblColor1.BackColor = System.Drawing.Color.Transparent;
                return;
            }
            var selectedColor = (Models.Color)cboColor1.SelectedItem;
            lblColor1.BackColor = System.Drawing.Color.FromArgb(selectedColor.Red, selectedColor.Green, selectedColor.Blue);
        }
        private void cboColor2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboColor2.SelectedIndex == -1)
            {
                lblColor2.BackColor = System.Drawing.Color.Transparent;
                return;
            }
            var selectedColor = (Models.Color)cboColor2.SelectedItem;
            lblColor2.BackColor = System.Drawing.Color.FromArgb(selectedColor.Red, selectedColor.Green, selectedColor.Blue);
        }
        private void btnAddColor_Click(object sender, EventArgs e)
        {
            ColorsForm colorsForm = new ColorsForm(db);
            colorsForm.ShowDialog();
            LoadColors();
            cboColor1.SelectedIndex = cboColor2.SelectedIndex = -1;
        }
    }
}
