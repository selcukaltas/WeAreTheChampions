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
    public partial class ColorsForm : Form
    {
        private readonly WeAreTheChampionsContext db;
        public ColorsForm(WeAreTheChampionsContext db)
        {
            this.db = db;
            InitializeComponent();
            ListColors();
        }
        private void ListColors()
        {
            lstColors.DataSource = db.Colors.ToList();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            var colorName = txtColorName.Text.Trim();
            if (colorName == "")
            {
                MessageBox.Show("Please fill all fields correctly.");
                return;
            }
            if (btnAdd.Text == "💾 Save")
            {
                if (colorName == "")
                {
                    MessageBox.Show("Please fill all fields correctly.");
                    return;
                }
                var selectedColor = (Models.Color)lstColors.SelectedItem;
                selectedColor.ColorName = txtColorName.Text;
                if (db.Colors.Any(x => x.ColorName == selectedColor.ColorName))
                {
                    MessageBox.Show("Please enter different color name.");
                    return;
                }
                selectedColor.Red = Convert.ToByte(lblRed.Text);
                selectedColor.Green = Convert.ToByte(lblGreen.Text);
                selectedColor.Blue = Convert.ToByte(lblBlue.Text);
                db.SaveChanges();
                ListColors();
                ResetForm();
                return;

            }
            var color = new Models.Color
            {
                ColorName = txtColorName.Text.UpperCaseFirst(),
                Red = Convert.ToByte(lblRed.Text),
                Green = Convert.ToByte(lblGreen.Text),
                Blue = Convert.ToByte(lblBlue.Text)
            };
            if (db.Colors.Any(x => x.ColorName == color.ColorName))
            {
                MessageBox.Show("Please enter different color name.");
                return;
            }
            db.Colors.Add(color);
            db.SaveChanges();
            ListColors();
            ResetForm();

        }
        private void ResetForm()
        {
            lstColors.Enabled = true;
            btnAdd.Text = "➕ Add ";
            txtColorName.Clear();
            lblBlue.Text = lblRed.Text = lblGreen.Text = "000";
            lblColor.BackColor = System.Drawing.Color.Black;
            hsBlue.Value = hsRed.Value = hsGreen.Value = hsBlue.Minimum;
        }
        #region Scroll Events
        private void hsRed_Scroll(object sender, ScrollEventArgs e)
        {
            lblRed.Text = hsRed.Value.ToString();
            lblColor.BackColor = System.Drawing.Color.FromArgb(Convert.ToByte(lblRed.Text), Convert.ToByte(lblGreen.Text), Convert.ToByte(lblBlue.Text));
        }
        private void hsGreen_Scroll(object sender, ScrollEventArgs e)
        {
            lblGreen.Text = hsGreen.Value.ToString();
            lblColor.BackColor = System.Drawing.Color.FromArgb(Convert.ToByte(lblRed.Text), Convert.ToByte(lblGreen.Text), Convert.ToByte(lblBlue.Text));
        }
        private void hsBlue_Scroll(object sender, ScrollEventArgs e)
        {
            lblBlue.Text = hsBlue.Value.ToString();
            lblColor.BackColor = System.Drawing.Color.FromArgb(Convert.ToByte(lblRed.Text), Convert.ToByte(lblGreen.Text), Convert.ToByte(lblBlue.Text));
        }
        #endregion
        private void lstColors_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedColor = (Models.Color)lstColors.SelectedItem;
            lblPreview.BackColor = System.Drawing.Color.FromArgb(selectedColor.Red, selectedColor.Green, selectedColor.Blue);
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstColors.SelectedIndex == 0)
                lblPreview.BackColor = System.Drawing.Color.Transparent;
            if (lstColors.SelectedIndex < 0)
                return;
            var selectedColor = (Models.Color)lstColors.SelectedItem;
            db.Colors.Remove(selectedColor);
            db.SaveChanges();
            ListColors();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lstColors.SelectedIndex < 0)
                return;
            var selectedColor = (Models.Color)lstColors.SelectedItem;
            txtColorName.Text = selectedColor.ColorName;
            lblBlue.Text = selectedColor.Blue.ToString();
            lblRed.Text = selectedColor.Red.ToString();
            lblGreen.Text = selectedColor.Green.ToString();
            btnAdd.Text = "💾 Save";
            lstColors.Enabled = false;
            lblColor.BackColor = lblPreview.BackColor;
            hsGreen.Value = Convert.ToInt32(selectedColor.Green);
            hsBlue.Value = Convert.ToInt32(selectedColor.Blue);
            hsRed.Value = Convert.ToInt32(selectedColor.Red);
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            ResetForm();
        }
    }
}