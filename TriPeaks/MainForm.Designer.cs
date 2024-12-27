
using System.Drawing;

namespace TriPeaks
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pnlStart = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnScores = new System.Windows.Forms.Button();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.tirPeaks = new System.Windows.Forms.PictureBox();
            this.lblExit = new System.Windows.Forms.Label();
            this.lblScores = new System.Windows.Forms.Label();
            this.lblNew = new System.Windows.Forms.Label();
            this.lblWaterMark = new System.Windows.Forms.Label();
            this.pnlStart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tirPeaks)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlStart
            // 
            this.pnlStart.Controls.Add(this.btnExit);
            this.pnlStart.Controls.Add(this.btnScores);
            this.pnlStart.Controls.Add(this.btnNewGame);
            this.pnlStart.Controls.Add(this.tirPeaks);
            this.pnlStart.Controls.Add(this.lblExit);
            this.pnlStart.Controls.Add(this.lblScores);
            this.pnlStart.Controls.Add(this.lblNew);
            this.pnlStart.Controls.Add(this.lblWaterMark);
            this.pnlStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlStart.Location = new System.Drawing.Point(0, 0);
            this.pnlStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlStart.Name = "pnlStart";
            this.pnlStart.Size = new System.Drawing.Size(1084, 721);
            this.pnlStart.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImage = global::TriPeaks.Properties.Resources.exitIcon;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(656, 273);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(211, 152);
            this.btnExit.TabIndex = 0;
            this.btnExit.Tag = "2";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            this.btnExit.MouseEnter += new System.EventHandler(this.Btns_MouseEnter);
            this.btnExit.MouseLeave += new System.EventHandler(this.Btns_MouseLeave);
            // 
            // btnScores
            // 
            this.btnScores.BackColor = System.Drawing.Color.Transparent;
            this.btnScores.BackgroundImage = global::TriPeaks.Properties.Resources.scoresIcon;
            this.btnScores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnScores.FlatAppearance.BorderSize = 0;
            this.btnScores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScores.Location = new System.Drawing.Point(430, 273);
            this.btnScores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnScores.Name = "btnScores";
            this.btnScores.Size = new System.Drawing.Size(211, 152);
            this.btnScores.TabIndex = 0;
            this.btnScores.Tag = "1";
            this.btnScores.UseVisualStyleBackColor = false;
            this.btnScores.Click += new System.EventHandler(this.BtnScores_Click);
            this.btnScores.MouseEnter += new System.EventHandler(this.Btns_MouseEnter);
            this.btnScores.MouseLeave += new System.EventHandler(this.Btns_MouseLeave);
            // 
            // btnNewGame
            // 
            this.btnNewGame.BackColor = System.Drawing.Color.Transparent;
            this.btnNewGame.BackgroundImage = global::TriPeaks.Properties.Resources.newGameIcon;
            this.btnNewGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNewGame.FlatAppearance.BorderSize = 0;
            this.btnNewGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewGame.Location = new System.Drawing.Point(202, 273);
            this.btnNewGame.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(211, 152);
            this.btnNewGame.TabIndex = 0;
            this.btnNewGame.Tag = "0";
            this.btnNewGame.UseVisualStyleBackColor = false;
            this.btnNewGame.Click += new System.EventHandler(this.BtnNewGame_Click);
            this.btnNewGame.MouseEnter += new System.EventHandler(this.Btns_MouseEnter);
            this.btnNewGame.MouseLeave += new System.EventHandler(this.Btns_MouseLeave);
            // 
            // tirPeaks
            // 
            this.tirPeaks.BackgroundImage = global::TriPeaks.Properties.Resources.triPeaksText;
            this.tirPeaks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tirPeaks.Location = new System.Drawing.Point(278, 88);
            this.tirPeaks.Name = "tirPeaks";
            this.tirPeaks.Size = new System.Drawing.Size(513, 117);
            this.tirPeaks.TabIndex = 3;
            this.tirPeaks.TabStop = false;
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.BackColor = System.Drawing.Color.Transparent;
            this.lblExit.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(224)))), ((int)(((byte)(211)))));
            this.lblExit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblExit.Location = new System.Drawing.Point(705, 427);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(114, 65);
            this.lblExit.TabIndex = 2;
            this.lblExit.Text = "Exit";
            this.lblExit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblScores
            // 
            this.lblScores.AutoSize = true;
            this.lblScores.BackColor = System.Drawing.Color.Transparent;
            this.lblScores.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblScores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(224)))), ((int)(((byte)(211)))));
            this.lblScores.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblScores.Location = new System.Drawing.Point(446, 427);
            this.lblScores.Name = "lblScores";
            this.lblScores.Size = new System.Drawing.Size(173, 65);
            this.lblScores.TabIndex = 2;
            this.lblScores.Text = "Scores";
            this.lblScores.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblNew
            // 
            this.lblNew.AutoSize = true;
            this.lblNew.BackColor = System.Drawing.Color.Transparent;
            this.lblNew.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(224)))), ((int)(((byte)(211)))));
            this.lblNew.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblNew.Location = new System.Drawing.Point(246, 427);
            this.lblNew.Name = "lblNew";
            this.lblNew.Size = new System.Drawing.Size(130, 65);
            this.lblNew.TabIndex = 2;
            this.lblNew.Text = "New";
            this.lblNew.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblWaterMark
            // 
            this.lblWaterMark.AutoSize = true;
            this.lblWaterMark.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblWaterMark.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(224)))), ((int)(((byte)(211)))));
            this.lblWaterMark.Location = new System.Drawing.Point(319, 629);
            this.lblWaterMark.Name = "lblWaterMark";
            this.lblWaterMark.Size = new System.Drawing.Size(433, 87);
            this.lblWaterMark.TabIndex = 1;
            this.lblWaterMark.Text = "Jafar Mirzaei - Mohammad Arabi\r\nAlgorithms and data structures Final Project\r\n202" +
    "2";
            this.lblWaterMark.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(176)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1084, 721);
            this.Controls.Add(this.pnlStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TriPeaks";
            this.pnlStart.ResumeLayout(false);
            this.pnlStart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tirPeaks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlStart;
        private System.Windows.Forms.Label lblWaterMark;
        private System.Windows.Forms.Label lblNew;
        private System.Windows.Forms.Label lblScores;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnScores;
        private System.Windows.Forms.PictureBox tirPeaks;
    }
}