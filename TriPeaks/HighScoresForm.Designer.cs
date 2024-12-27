
namespace TriPeaks
{
    partial class HighScoresForm
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

        private void updateTable()
        {
            label1.Text = label2.Text = label3.Text = label4.Text = label5.Text = label6.Text = label7.Text = "-";

            for (int i = 0; i < Properties.Settings.Default.HighScores.Count; i++)
            {
                switch (i)
                {
                    case 0:
                        this.pictureBoxCrown.Visible = true;
                        this.label1.Text = Properties.Settings.Default.HighScores[i];
                        break;

                    case 1:
                        this.label2.Text = Properties.Settings.Default.HighScores[i];
                        break;

                    case 2:
                        this.label3.Text = Properties.Settings.Default.HighScores[i];
                        break;
                    case 3:
                        this.label4.Text = Properties.Settings.Default.HighScores[i];
                        break;
                    case 4:
                        this.label5.Text =  Properties.Settings.Default.HighScores[i];
                        break;
                    case 5:
                        this.label6.Text = Properties.Settings.Default.HighScores[i];
                        break;
                    case 6:
                        this.label7.Text = Properties.Settings.Default.HighScores[i];
                        break;
                }
            }
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.roundPanel1 = new TriPeaks.CustomControls.RoundPanel();
            this.linklblResetScores = new System.Windows.Forms.LinkLabel();
            this.pictureBoxCrown = new System.Windows.Forms.PictureBox();
            this.panel14 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel15 = new System.Windows.Forms.Panel();
            this.labelN7 = new System.Windows.Forms.Label();
            this.panel13 = new System.Windows.Forms.Panel();
            this.labelN6 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.labelN5 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.labelN4 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.labelN13 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labelN2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelN1 = new System.Windows.Forms.Label();
            this.btnBackToMenue = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblHighScores = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.roundPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCrown)).BeginInit();
            this.panel14.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel15.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // roundPanel1
            // 
            this.roundPanel1.Border = 0;
            this.roundPanel1.BorderColor = System.Drawing.Color.Gray;
            this.roundPanel1.Controls.Add(this.linklblResetScores);
            this.roundPanel1.Controls.Add(this.pictureBoxCrown);
            this.roundPanel1.Controls.Add(this.panel14);
            this.roundPanel1.Controls.Add(this.panel12);
            this.roundPanel1.Controls.Add(this.panel11);
            this.roundPanel1.Controls.Add(this.panel9);
            this.roundPanel1.Controls.Add(this.panel7);
            this.roundPanel1.Controls.Add(this.panel5);
            this.roundPanel1.Controls.Add(this.panel2);
            this.roundPanel1.Controls.Add(this.panel15);
            this.roundPanel1.Controls.Add(this.panel13);
            this.roundPanel1.Controls.Add(this.panel10);
            this.roundPanel1.Controls.Add(this.panel8);
            this.roundPanel1.Controls.Add(this.panel6);
            this.roundPanel1.Controls.Add(this.panel4);
            this.roundPanel1.Controls.Add(this.panel3);
            this.roundPanel1.Controls.Add(this.btnBackToMenue);
            this.roundPanel1.Controls.Add(this.panel1);
            this.roundPanel1.Controls.Add(this.lblHighScores);
            this.roundPanel1.ForeColor = System.Drawing.Color.White;
            this.roundPanel1.Location = new System.Drawing.Point(355, 134);
            this.roundPanel1.MinimumSize = new System.Drawing.Size(45, 22);
            this.roundPanel1.Name = "roundPanel1";
            this.roundPanel1.Radius = 20;
            this.roundPanel1.Size = new System.Drawing.Size(362, 456);
            this.roundPanel1.TabIndex = 0;
            // 
            // linklblResetScores
            // 
            this.linklblResetScores.AutoSize = true;
            this.linklblResetScores.BackColor = System.Drawing.Color.Transparent;
            this.linklblResetScores.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.linklblResetScores.LinkColor = System.Drawing.Color.Gray;
            this.linklblResetScores.Location = new System.Drawing.Point(140, 402);
            this.linklblResetScores.Name = "linklblResetScores";
            this.linklblResetScores.Size = new System.Drawing.Size(97, 21);
            this.linklblResetScores.TabIndex = 5;
            this.linklblResetScores.TabStop = true;
            this.linklblResetScores.Text = "Reset Score";
            this.linklblResetScores.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkClicked_Click);
            // 
            // pictureBoxCrown
            // 
            this.pictureBoxCrown.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCrown.Image = global::TriPeaks.Properties.Resources.Crown;
            this.pictureBoxCrown.Location = new System.Drawing.Point(25, 93);
            this.pictureBoxCrown.Name = "pictureBoxCrown";
            this.pictureBoxCrown.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxCrown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCrown.TabIndex = 1;
            this.pictureBoxCrown.TabStop = false;
            this.pictureBoxCrown.Visible = false;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.panel14.Controls.Add(this.label7);
            this.panel14.Location = new System.Drawing.Point(103, 351);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(208, 37);
            this.panel14.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(7, 2);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 32);
            this.label7.TabIndex = 1;
            this.label7.Text = "-";
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.panel12.Controls.Add(this.label6);
            this.panel12.Location = new System.Drawing.Point(103, 308);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(208, 37);
            this.panel12.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(7, 2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 32);
            this.label6.TabIndex = 1;
            this.label6.Text = "-";
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.panel11.Controls.Add(this.label5);
            this.panel11.Location = new System.Drawing.Point(103, 265);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(208, 37);
            this.panel11.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(7, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 32);
            this.label5.TabIndex = 1;
            this.label5.Text = "-";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.panel9.Controls.Add(this.label4);
            this.panel9.Location = new System.Drawing.Point(103, 222);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(208, 37);
            this.panel9.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(7, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 32);
            this.label4.TabIndex = 1;
            this.label4.Text = "-";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.panel7.Controls.Add(this.label3);
            this.panel7.Location = new System.Drawing.Point(103, 179);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(208, 37);
            this.panel7.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(7, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 32);
            this.label3.TabIndex = 1;
            this.label3.Text = "-";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.panel5.Controls.Add(this.label2);
            this.panel5.Location = new System.Drawing.Point(103, 136);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(208, 37);
            this.panel5.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(7, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "-";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(103, 93);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(208, 37);
            this.panel2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(7, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "-";
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel15.Controls.Add(this.labelN7);
            this.panel15.Location = new System.Drawing.Point(61, 351);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(43, 37);
            this.panel15.TabIndex = 4;
            // 
            // labelN7
            // 
            this.labelN7.AutoSize = true;
            this.labelN7.BackColor = System.Drawing.Color.Transparent;
            this.labelN7.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelN7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelN7.Location = new System.Drawing.Point(7, 0);
            this.labelN7.Name = "labelN7";
            this.labelN7.Size = new System.Drawing.Size(28, 32);
            this.labelN7.TabIndex = 1;
            this.labelN7.Text = "7";
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel13.Controls.Add(this.labelN6);
            this.panel13.Location = new System.Drawing.Point(61, 308);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(43, 37);
            this.panel13.TabIndex = 4;
            // 
            // labelN6
            // 
            this.labelN6.AutoSize = true;
            this.labelN6.BackColor = System.Drawing.Color.Transparent;
            this.labelN6.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelN6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelN6.Location = new System.Drawing.Point(7, 0);
            this.labelN6.Name = "labelN6";
            this.labelN6.Size = new System.Drawing.Size(28, 32);
            this.labelN6.TabIndex = 1;
            this.labelN6.Text = "6";
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel10.Controls.Add(this.labelN5);
            this.panel10.Location = new System.Drawing.Point(61, 265);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(43, 37);
            this.panel10.TabIndex = 4;
            // 
            // labelN5
            // 
            this.labelN5.AutoSize = true;
            this.labelN5.BackColor = System.Drawing.Color.Transparent;
            this.labelN5.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelN5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelN5.Location = new System.Drawing.Point(7, 0);
            this.labelN5.Name = "labelN5";
            this.labelN5.Size = new System.Drawing.Size(28, 32);
            this.labelN5.TabIndex = 1;
            this.labelN5.Text = "5";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel8.Controls.Add(this.labelN4);
            this.panel8.Location = new System.Drawing.Point(61, 222);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(43, 37);
            this.panel8.TabIndex = 4;
            // 
            // labelN4
            // 
            this.labelN4.AutoSize = true;
            this.labelN4.BackColor = System.Drawing.Color.Transparent;
            this.labelN4.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelN4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelN4.Location = new System.Drawing.Point(8, 0);
            this.labelN4.Name = "labelN4";
            this.labelN4.Size = new System.Drawing.Size(29, 32);
            this.labelN4.TabIndex = 1;
            this.labelN4.Text = "4";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel6.Controls.Add(this.labelN13);
            this.panel6.Location = new System.Drawing.Point(61, 179);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(43, 37);
            this.panel6.TabIndex = 4;
            // 
            // labelN13
            // 
            this.labelN13.AutoSize = true;
            this.labelN13.BackColor = System.Drawing.Color.Transparent;
            this.labelN13.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelN13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelN13.Location = new System.Drawing.Point(8, 0);
            this.labelN13.Name = "labelN13";
            this.labelN13.Size = new System.Drawing.Size(28, 32);
            this.labelN13.TabIndex = 1;
            this.labelN13.Text = "3";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel4.Controls.Add(this.labelN2);
            this.panel4.Location = new System.Drawing.Point(61, 136);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(43, 37);
            this.panel4.TabIndex = 4;
            // 
            // labelN2
            // 
            this.labelN2.AutoSize = true;
            this.labelN2.BackColor = System.Drawing.Color.Transparent;
            this.labelN2.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelN2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelN2.Location = new System.Drawing.Point(8, 0);
            this.labelN2.Name = "labelN2";
            this.labelN2.Size = new System.Drawing.Size(28, 32);
            this.labelN2.TabIndex = 1;
            this.labelN2.Text = "2";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel3.Controls.Add(this.labelN1);
            this.panel3.Location = new System.Drawing.Point(61, 93);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(43, 37);
            this.panel3.TabIndex = 4;
            // 
            // labelN1
            // 
            this.labelN1.AutoSize = true;
            this.labelN1.BackColor = System.Drawing.Color.Transparent;
            this.labelN1.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelN1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelN1.Location = new System.Drawing.Point(8, 0);
            this.labelN1.Name = "labelN1";
            this.labelN1.Size = new System.Drawing.Size(26, 32);
            this.labelN1.TabIndex = 1;
            this.labelN1.Text = "1";
            // 
            // btnBackToMenue
            // 
            this.btnBackToMenue.BackColor = System.Drawing.Color.White;
            this.btnBackToMenue.BackgroundImage = global::TriPeaks.Properties.Resources.Exit_2;
            this.btnBackToMenue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBackToMenue.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBackToMenue.FlatAppearance.BorderSize = 0;
            this.btnBackToMenue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackToMenue.ForeColor = System.Drawing.Color.Black;
            this.btnBackToMenue.Location = new System.Drawing.Point(319, 14);
            this.btnBackToMenue.Name = "btnBackToMenue";
            this.btnBackToMenue.Size = new System.Drawing.Size(30, 30);
            this.btnBackToMenue.TabIndex = 3;
            this.btnBackToMenue.UseVisualStyleBackColor = false;
            this.btnBackToMenue.Click += new System.EventHandler(this.BtnReturnToMenue_Click);
            this.btnBackToMenue.MouseEnter += new System.EventHandler(this.BtnReturn_MouseEnter);
            this.btnBackToMenue.MouseLeave += new System.EventHandler(this.BtnReturn_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Location = new System.Drawing.Point(61, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 5);
            this.panel1.TabIndex = 2;
            // 
            // lblHighScores
            // 
            this.lblHighScores.AutoSize = true;
            this.lblHighScores.BackColor = System.Drawing.Color.White;
            this.lblHighScores.Font = new System.Drawing.Font("Segoe UI Black", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHighScores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblHighScores.Location = new System.Drawing.Point(76, 13);
            this.lblHighScores.Name = "lblHighScores";
            this.lblHighScores.Size = new System.Drawing.Size(224, 47);
            this.lblHighScores.TabIndex = 0;
            this.lblHighScores.Text = "High Scores";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TriPeaks.Properties.Resources.SuitsSymbols;
            this.pictureBox1.Location = new System.Drawing.Point(0, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(349, 231);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::TriPeaks.Properties.Resources.KQJSymbols;
            this.pictureBox3.Location = new System.Drawing.Point(712, 462);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(360, 261);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // HighScoresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(176)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1084, 721);
            this.Controls.Add(this.roundPanel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HighScoresForm";
            this.Text = "HighScoresForm";
            this.roundPanel1.ResumeLayout(false);
            this.roundPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCrown)).EndInit();
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }



        #endregion

        private CustomControls.RoundPanel roundPanel1;
        private System.Windows.Forms.Button btnBackToMenue;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblHighScores;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBoxCrown;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label labelN5;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label labelN4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label labelN13;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label labelN2;
        private System.Windows.Forms.Label labelN1;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Label labelN7;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Label labelN6;
        private System.Windows.Forms.LinkLabel linklblResetScores;
    }
}