
namespace TriPeaks.CustomControls
{
    partial class GameDialog
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
            this.roundPanelBG = new TriPeaks.CustomControls.RoundPanel();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.roundPanelYes = new TriPeaks.CustomControls.RoundPanel();
            this.lblYes = new System.Windows.Forms.Label();
            this.roundPanelNo = new TriPeaks.CustomControls.RoundPanel();
            this.lblNo = new System.Windows.Forms.Label();
            this.roundPanelBG.SuspendLayout();
            this.roundPanelYes.SuspendLayout();
            this.roundPanelNo.SuspendLayout();
            this.SuspendLayout();
            // 
            // roundPanelBG
            // 
            this.roundPanelBG.BackColor = System.Drawing.Color.Transparent;
            this.roundPanelBG.Border = 0;
            this.roundPanelBG.BorderColor = System.Drawing.Color.Gray;
            this.roundPanelBG.Controls.Add(this.lblQuestion);
            this.roundPanelBG.Controls.Add(this.roundPanelYes);
            this.roundPanelBG.Controls.Add(this.roundPanelNo);
            this.roundPanelBG.ForeColor = System.Drawing.Color.YellowGreen;
            this.roundPanelBG.Location = new System.Drawing.Point(8, 8);
            this.roundPanelBG.MinimumSize = new System.Drawing.Size(45, 22);
            this.roundPanelBG.Name = "roundPanelBG";
            this.roundPanelBG.Radius = 20;
            this.roundPanelBG.Size = new System.Drawing.Size(422, 232);
            this.roundPanelBG.TabIndex = 2;
            // 
            // lblQuestion
            // 
            this.lblQuestion.Font = new System.Drawing.Font("Segoe UI Black", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblQuestion.ForeColor = System.Drawing.Color.White;
            this.lblQuestion.Location = new System.Drawing.Point(0, 0);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(422, 139);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "Do you want return menu?";
            this.lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // roundPanelYes
            // 
            this.roundPanelYes.BackColor = System.Drawing.Color.Transparent;
            this.roundPanelYes.Border = 0;
            this.roundPanelYes.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.roundPanelYes.Controls.Add(this.lblYes);
            this.roundPanelYes.ForeColor = System.Drawing.Color.Gray;
            this.roundPanelYes.Location = new System.Drawing.Point(53, 147);
            this.roundPanelYes.MinimumSize = new System.Drawing.Size(45, 22);
            this.roundPanelYes.Name = "roundPanelYes";
            this.roundPanelYes.Radius = 20;
            this.roundPanelYes.Size = new System.Drawing.Size(138, 52);
            this.roundPanelYes.TabIndex = 1;
            this.roundPanelYes.Click += new System.EventHandler(this.BtnYes_Click);
            // 
            // lblYes
            // 
            this.lblYes.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblYes.ForeColor = System.Drawing.Color.White;
            this.lblYes.Location = new System.Drawing.Point(-2, 0);
            this.lblYes.Name = "lblYes";
            this.lblYes.Size = new System.Drawing.Size(138, 52);
            this.lblYes.TabIndex = 0;
            this.lblYes.Text = "Yes";
            this.lblYes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblYes.Click += new System.EventHandler(this.BtnYes_Click);
            // 
            // roundPanelNo
            // 
            this.roundPanelNo.BackColor = System.Drawing.Color.Transparent;
            this.roundPanelNo.Border = 0;
            this.roundPanelNo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.roundPanelNo.Controls.Add(this.lblNo);
            this.roundPanelNo.ForeColor = System.Drawing.Color.Gray;
            this.roundPanelNo.Location = new System.Drawing.Point(221, 147);
            this.roundPanelNo.MinimumSize = new System.Drawing.Size(45, 22);
            this.roundPanelNo.Name = "roundPanelNo";
            this.roundPanelNo.Radius = 20;
            this.roundPanelNo.Size = new System.Drawing.Size(138, 52);
            this.roundPanelNo.TabIndex = 1;
            this.roundPanelNo.Click += new System.EventHandler(this.BtnNo_Click);
            // 
            // lblNo
            // 
            this.lblNo.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNo.ForeColor = System.Drawing.Color.White;
            this.lblNo.Location = new System.Drawing.Point(3, 0);
            this.lblNo.Name = "lblNo";
            this.lblNo.Size = new System.Drawing.Size(132, 52);
            this.lblNo.TabIndex = 0;
            this.lblNo.Text = "No";
            this.lblNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNo.Click += new System.EventHandler(this.BtnNo_Click);
            // 
            // GameDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(439, 249);
            this.Controls.Add(this.roundPanelBG);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GameDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "GameDialog";
            this.roundPanelBG.ResumeLayout(false);
            this.roundPanelYes.ResumeLayout(false);
            this.roundPanelNo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private RoundPanel roundPanelBG;
        private System.Windows.Forms.Label lblQuestion;
        private RoundPanel roundPanelYes;
        private System.Windows.Forms.Label lblYes;
        private RoundPanel roundPanelNo;
        private System.Windows.Forms.Label lblNo;
    }
}