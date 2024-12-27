using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using TriPeaks.CustomControls;

namespace TriPeaks
{
    /// <summary>
    /// Application main form
    /// </summary>
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Properties.Settings.Default.HighScores.Remove(0.ToString());
        }

        #region Buttons & Labels hover effect
        /// <summary>
        /// this method called by mouse enter event. used by all mainsForm buttons.
        /// </summary>
        /// <param name="sender"></param>
        private void Btns_MouseEnter(object sender, EventArgs e)
        {
            Button temp = sender as Button; 
            Label[] btnLabels = new Label[3] { lblNew, lblScores, lblExit };

            temp.Size = new Size(temp.Size.Width + 13, temp.Size.Height + 10);
            temp.Location = new Point(temp.Location.X - 7, temp.Location.Y - 8);
            btnLabels[int.Parse(temp.Tag.ToString())].ForeColor = Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(220)))), ((int)(((byte)(20)))));
        }

        /// <summary>
        /// this method called by mouse leve event. used by all mainsForm buttons.
        /// </summary>
        /// <param name="sender">sender can be any of mainform buttons</param>
        private void Btns_MouseLeave(object sender, EventArgs e)
        {
            Button temp = sender as Button;
            Label[] btnLabels = new Label[3] { lblNew, lblScores, lblExit };

            temp.Size = new Size(temp.Size.Width - 13, temp.Size.Height - 10);
            temp.Location = new Point(temp.Location.X + 7, temp.Location.Y + 8);
            btnLabels[int.Parse(temp.Tag.ToString())].ForeColor = Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(224)))), ((int)(((byte)(211)))));
        }
        #endregion

        #region Buttons click events
        private void BtnNewGame_Click(object sender, EventArgs e)
        {
            this.SetChildForm(new BoardForm());
        }

        private void BtnScores_Click(object sender, EventArgs e)
        {
            this.SetChildForm(new HighScoresForm());
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            GameDialog dialog = new GameDialog("Do you want to exit?", true);
            dialog.ShowDialog();
            if (dialog.Result)
            {
                Btns_MouseLeave(sender, e);
                this.Close();
            }
        }
        #endregion

        #region public methods that used to navigate between forms
        public void ReturnToMainForm()
        {
            foreach (Control i in this.Controls)
                if (i is Form)
                    this.Controls.Remove(i);
        }

        public void SetChildForm(Form childForm)
        {
            childForm.TopLevel = false; //Allow Form to be added another Form Controls.
            this.Controls.Add(childForm);
            childForm.Dock = DockStyle.Fill;
            childForm.BringToFront();
            childForm.Show();
        } 
        #endregion

    }
}
