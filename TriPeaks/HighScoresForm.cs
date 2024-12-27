using System;
using System.Drawing;
using System.Windows.Forms;
using TriPeaks.CustomControls;

namespace TriPeaks
{
    public partial class HighScoresForm : Form
    {
        //Constructor
        public HighScoresForm()
        {
            InitializeComponent();
            updateTable();
        }

        #region  Buttons hover effect

        private void BtnReturn_MouseEnter(object sender, EventArgs e)
        {
            this.btnBackToMenue.BackgroundImage = global::TriPeaks.Properties.Resources.Exit_2_State2;
        }

        private void BtnReturn_MouseLeave(object sender, EventArgs e)
        {
            this.btnBackToMenue.BackgroundImage = global::TriPeaks.Properties.Resources.Exit_2;
        }

        #endregion

        #region Click events

        /// <summary>
        /// return the mainForm
        /// </summary>
        /// <param name="sender">BtnReturnToMenue</param>
        /// <param name="e">Click Event</param>
        private void BtnReturnToMenue_Click(object sender, EventArgs e)
        {
            MainForm a = this.Parent as MainForm;
            a.ReturnToMainForm();
        }

        /// <summary>
        /// clear all highscores
        /// </summary>
        /// <param name="sender">Link</param>
        /// <param name="e">Click Event<</param>
        private void LinkClicked_Click(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GameDialog dialog = new GameDialog("Do you want deleat scores ?", true);
            dialog.BackColor = Color.LightGray;
            dialog.ShowDialog();

            if (dialog.Result)
            {
                Properties.Settings.Default.HighScores.Clear();
                Properties.Settings.Default.Save();
                Properties.Settings.Default.Reload();
                updateTable();
            }

        }
        #endregion
    }
}
