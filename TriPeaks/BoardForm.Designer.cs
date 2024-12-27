using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using TriPeaks.CustomControls;
using TriPeaks.GameLib;

namespace TriPeaks
{
    partial class BoardForm
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

        private void InitializeCards()
        {
            Color cornerColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(65)))));

            // 
            // playingCard25
            // 
            this.playingCard25 = new TriPeaks.CustomControls.PlayingCard()
            {
                Location = new System.Drawing.Point(642, 304),
                TopLeftCornerColor = cornerColor,
                TopRightCornerColor = cornerColor
            };
            this.playingCard25.Click += new System.EventHandler(this.PlayingCards_Click);
            // 
            // playingCard22
            // 
            this.playingCard22 = new TriPeaks.CustomControls.PlayingCard()
            {
                Location = new System.Drawing.Point(350, 304),
                TopLeftCornerColor = cornerColor,
                TopRightCornerColor = cornerColor
            };
            this.playingCard22.Click += new System.EventHandler(this.PlayingCards_Click);
            // 
            // playingCard27
            // 
            this.playingCard27 = new TriPeaks.CustomControls.PlayingCard()
            {
                Location = new System.Drawing.Point(834, 303),
                TopLeftCornerColor = cornerColor,
                TopRightCornerColor = cornerColor
            };
            this.playingCard27.Click += new System.EventHandler(this.PlayingCards_Click);
            // 
            // playingCard24
            // 
            this.playingCard24 = new TriPeaks.CustomControls.PlayingCard()
            {
                Location = new System.Drawing.Point(545, 303),
                TopLeftCornerColor = cornerColor,
                TopRightCornerColor = cornerColor
            };
            this.playingCard24.Click += new System.EventHandler(this.PlayingCards_Click);
            // 
            // playingCard21
            // 
            this.playingCard21 = new TriPeaks.CustomControls.PlayingCard()
            {
                Location = new System.Drawing.Point(252, 303),
                TopLeftCornerColor = cornerColor,
                TopRightCornerColor = cornerColor
            };
            this.playingCard21.Click += new System.EventHandler(this.PlayingCards_Click);
            // 
            // playingCard26
            // 
            this.playingCard26 = new TriPeaks.CustomControls.PlayingCard()
            {
                Location = new System.Drawing.Point(738, 303),
                TopLeftCornerColor = cornerColor,
                TopRightCornerColor = cornerColor
            };
            this.playingCard26.Click += new System.EventHandler(this.PlayingCards_Click);
            // 
            // playingCard23
            // 
            this.playingCard23 = new TriPeaks.CustomControls.PlayingCard()
            {
                Location = new System.Drawing.Point(448, 303),
                TopLeftCornerColor = cornerColor,
                TopRightCornerColor = cornerColor
            };
            this.playingCard23.Click += new System.EventHandler(this.PlayingCards_Click);
            //
            //playingCard17
            //
            this.playingCard17 = new TriPeaks.CustomControls.PlayingCard()
            {
                Location = new System.Drawing.Point(783, 225),
                TopLeftCornerColor = cornerColor,
                TopRightCornerColor = cornerColor
            };
            this.playingCard17.Click += new System.EventHandler(this.PlayingCards_Click);
            // 
            // playingCard14
            // 
            this.playingCard14 = new TriPeaks.CustomControls.PlayingCard()
            {
                Location = new System.Drawing.Point(494, 225),
                TopLeftCornerColor = cornerColor,
                TopRightCornerColor = cornerColor
            };
            this.playingCard14.Click += new System.EventHandler(this.PlayingCards_Click);
            // 
            // playingCard20
            // 
            this.playingCard20 = new TriPeaks.CustomControls.PlayingCard()
            {
                Location = new System.Drawing.Point(152, 303),
                TopLeftCornerColor = cornerColor,
                TopRightCornerColor = cornerColor
            };
            this.playingCard20.Click += new System.EventHandler(this.PlayingCards_Click);
            // 
            // playingCard11
            // 
            this.playingCard11 = new TriPeaks.CustomControls.PlayingCard()
            {
                Location = new System.Drawing.Point(201, 225),
                TopLeftCornerColor = cornerColor,
                TopRightCornerColor = cornerColor
            };
            this.playingCard11.Click += new System.EventHandler(this.PlayingCards_Click);
            // 
            // playingCard16
            // 
            this.playingCard16 = new TriPeaks.CustomControls.PlayingCard()
            {
                Location = new System.Drawing.Point(686, 225),
                TopRightCornerColor = cornerColor
            };
            this.playingCard16.Click += new System.EventHandler(this.PlayingCards_Click);
            // 
            // playingCard13
            // 
            this.playingCard13 = new TriPeaks.CustomControls.PlayingCard()
            {
                Location = new System.Drawing.Point(397, 225),
                TopRightCornerColor = cornerColor
            };
            this.playingCard13.Click += new System.EventHandler(this.PlayingCards_Click);
            // 
            // playingCard19
            // 
            this.playingCard19 = new TriPeaks.CustomControls.PlayingCard()
            {
                Location = new System.Drawing.Point(56, 303),
                TopRightCornerColor = cornerColor
            };
            this.playingCard19.Click += new System.EventHandler(this.PlayingCards_Click);
            // 
            // playingCard8
            // 
            this.playingCard8 = new TriPeaks.CustomControls.PlayingCard()
            {
                Location = new System.Drawing.Point(735, 146),
                TopRightCornerColor = cornerColor
            };
            this.playingCard8.Click += new System.EventHandler(this.PlayingCards_Click);
            // 
            // playingCard6
            // 
            this.playingCard6 = new TriPeaks.CustomControls.PlayingCard()
            {
                Location = new System.Drawing.Point(446, 146),
                TopRightCornerColor = cornerColor
            };
            this.playingCard6.Click += new System.EventHandler(this.PlayingCards_Click);
            // 
            // playingCard10
            // 
            this.playingCard10 = new TriPeaks.CustomControls.PlayingCard()
            {
                Location = new System.Drawing.Point(99, 225),
                TopRightCornerColor = cornerColor
            };
            this.playingCard10.Click += new System.EventHandler(this.PlayingCards_Click);
            // 
            // playingCard28
            // 
            this.playingCard28 = new TriPeaks.CustomControls.PlayingCard()
            {
                Location = new System.Drawing.Point(931, 304),
                TopLeftCornerColor = cornerColor
            };
            this.playingCard28.Click += new System.EventHandler(this.PlayingCards_Click);
            //
            //playingCard4
            ///
            this.playingCard4 = new TriPeaks.CustomControls.PlayingCard()
            {
            Location = new System.Drawing.Point(146, 146),
            TopRightCornerColor = cornerColor
            };
            this.playingCard4.Click += new System.EventHandler(this.PlayingCards_Click);
            // 
            // playingCard18
            // 
            this.playingCard18 = new TriPeaks.CustomControls.PlayingCard()
            {
            Location = new System.Drawing.Point(881, 225),
            TopLeftCornerColor = cornerColor
            };
            this.playingCard18.Click += new System.EventHandler(this.PlayingCards_Click);
            // 
            // playingCard15
            // 
            this.playingCard15 = new TriPeaks.CustomControls.PlayingCard()
            {
            Location = new System.Drawing.Point(592, 225),
            TopLeftCornerColor = cornerColor
            };
            this.playingCard15.Click += new System.EventHandler(this.PlayingCards_Click);
            // 
            // playingCard9
            // 
            this.playingCard9 = new TriPeaks.CustomControls.PlayingCard()
            {
            Location = new System.Drawing.Point(834, 146),
            TopLeftCornerColor = cornerColor
            };
            this.playingCard9.Click += new System.EventHandler(this.PlayingCards_Click);
            // 
            // playingCard7
            // 
            this.playingCard7 = new TriPeaks.CustomControls.PlayingCard()
            {
            Location = new System.Drawing.Point(547, 146),
            TopLeftCornerColor = cornerColor
            };
            this.playingCard7.Click += new System.EventHandler(this.PlayingCards_Click);
            // 
            // playingCard12
            // 
            this.playingCard12 = new TriPeaks.CustomControls.PlayingCard()
            {
            Location = new System.Drawing.Point(300, 225),
            TopLeftCornerColor = cornerColor
            };
            this.playingCard12.Click += new System.EventHandler(this.PlayingCards_Click);
            // 
            // playingCard3
            // 
            this.playingCard3 = new TriPeaks.CustomControls.PlayingCard()
            {
            Location = new System.Drawing.Point(784, 68)
            };
            this.playingCard3.Click += new System.EventHandler(this.PlayingCards_Click);
            // 
            // playingCard2
            // 
            this.playingCard2 = new TriPeaks.CustomControls.PlayingCard()
            {
            Location = new System.Drawing.Point(496, 68)
            };
            this.playingCard2.Click += new System.EventHandler(this.PlayingCards_Click);
            // 
            // playingCard5
            // 
            this.playingCard5 = new TriPeaks.CustomControls.PlayingCard()
            {
            Location = new System.Drawing.Point(246, 146),
            TopLeftCornerColor = cornerColor
            };
            this.playingCard5.Click += new System.EventHandler(this.PlayingCards_Click);
            // 
            // playingCard1
            // 
            this.playingCard1 = new TriPeaks.CustomControls.PlayingCard()
            {
            Location = new System.Drawing.Point(199, 68)
            };
            this.playingCard1.Click += new System.EventHandler(this.PlayingCards_Click);

            this.pnlBoard.Controls.Add(this.playingCard25);
            this.pnlBoard.Controls.Add(this.playingCard22);
            this.pnlBoard.Controls.Add(this.playingCard27);
            this.pnlBoard.Controls.Add(this.playingCard24);
            this.pnlBoard.Controls.Add(this.playingCard21);
            this.pnlBoard.Controls.Add(this.playingCard26);
            this.pnlBoard.Controls.Add(this.playingCard23);
            this.pnlBoard.Controls.Add(this.playingCard17);
            this.pnlBoard.Controls.Add(this.playingCard14);
            this.pnlBoard.Controls.Add(this.playingCard20);
            this.pnlBoard.Controls.Add(this.playingCard11);
            this.pnlBoard.Controls.Add(this.playingCard16);
            this.pnlBoard.Controls.Add(this.playingCard13);
            this.pnlBoard.Controls.Add(this.playingCard19);
            this.pnlBoard.Controls.Add(this.playingCard8);
            this.pnlBoard.Controls.Add(this.playingCard6);
            this.pnlBoard.Controls.Add(this.playingCard10);
            this.pnlBoard.Controls.Add(this.playingCard28);
            this.pnlBoard.Controls.Add(this.playingCard4);
            this.pnlBoard.Controls.Add(this.playingCard18);
            this.pnlBoard.Controls.Add(this.playingCard15);
            this.pnlBoard.Controls.Add(this.playingCard9);
            this.pnlBoard.Controls.Add(this.playingCard7);
            this.pnlBoard.Controls.Add(this.playingCard12);
            this.pnlBoard.Controls.Add(this.playingCard3);
            this.pnlBoard.Controls.Add(this.playingCard2);
            this.pnlBoard.Controls.Add(this.playingCard5);
            this.pnlBoard.Controls.Add(this.playingCard1);

        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlBoard = new System.Windows.Forms.Panel();
            this.lblBoard = new System.Windows.Forms.Label();
            this.pnlControls = new System.Windows.Forms.Panel();
            this.rpnlPiles = new TriPeaks.CustomControls.RoundPanel();
            this.cardsPileWaste = new TriPeaks.CustomControls.CardsPile();
            this.cardsPileStock = new TriPeaks.CustomControls.CardsPile();
            this.btnReStock = new System.Windows.Forms.Button();
            this.rpnlOptions = new TriPeaks.CustomControls.RoundPanel();
            this.lblScore = new System.Windows.Forms.Label();
            this.btnHint = new System.Windows.Forms.Button();
            this.btnUndo = new System.Windows.Forms.Button();
            this.btnExitLevel = new System.Windows.Forms.Button();
            this.pnlControls.SuspendLayout();
            this.rpnlPiles.SuspendLayout();
            this.rpnlOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBoard
            // 
            this.pnlBoard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBoard.Location = new System.Drawing.Point(0, 0);
            this.pnlBoard.Name = "pnlBoard";
            this.pnlBoard.Size = new System.Drawing.Size(1084, 721);
            this.pnlBoard.TabIndex = 0;
            // 
            // lblBoard
            // 
            this.lblBoard.AutoSize = true;
            this.lblBoard.BackColor = System.Drawing.Color.Transparent;
            this.lblBoard.Font = new System.Drawing.Font("Segoe UI Black", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBoard.ForeColor = System.Drawing.Color.White;
            this.lblBoard.Location = new System.Drawing.Point(271, 9);
            this.lblBoard.Name = "lblBoard";
            this.lblBoard.Size = new System.Drawing.Size(141, 46);
            this.lblBoard.TabIndex = 2;
            this.lblBoard.Text = "Board: ";
            // 
            // pnlControls
            // 
            this.pnlControls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(176)))), ((int)(((byte)(74)))));
            this.pnlControls.Controls.Add(this.rpnlPiles);
            this.pnlControls.Controls.Add(this.rpnlOptions);
            this.pnlControls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlControls.Location = new System.Drawing.Point(0, 436);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(1084, 285);
            this.pnlControls.TabIndex = 1;
            // 
            // rpnlPiles
            // 
            this.rpnlPiles.Border = 0;
            this.rpnlPiles.BorderColor = System.Drawing.Color.Gray;
            this.rpnlPiles.Controls.Add(this.cardsPileWaste);
            this.rpnlPiles.Controls.Add(this.cardsPileStock);
            this.rpnlPiles.Controls.Add(this.btnReStock);
            this.rpnlPiles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(124)))), ((int)(((byte)(58)))));
            this.rpnlPiles.Location = new System.Drawing.Point(392, 16);
            this.rpnlPiles.MinimumSize = new System.Drawing.Size(45, 22);
            this.rpnlPiles.Name = "rpnlPiles";
            this.rpnlPiles.Radius = 15;
            this.rpnlPiles.Size = new System.Drawing.Size(289, 145);
            this.rpnlPiles.TabIndex = 0;
            // 
            // cardsPileWaste
            // 
            this.cardsPileWaste.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(124)))), ((int)(((byte)(58)))));
            this.cardsPileWaste.Border = 5;
            this.cardsPileWaste.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(124)))), ((int)(((byte)(58)))));
            this.cardsPileWaste.BorderColorEmptyState = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(124)))), ((int)(((byte)(58)))));
            this.cardsPileWaste.BorderColorHolderState = System.Drawing.Color.White;
            this.cardsPileWaste.CardBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(124)))), ((int)(((byte)(58)))));
            this.cardsPileWaste.CardForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(124)))), ((int)(((byte)(58)))));
            this.cardsPileWaste.Filp = true;
            this.cardsPileWaste.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(124)))), ((int)(((byte)(58)))));
            this.cardsPileWaste.ForeColorEmptyState = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(124)))), ((int)(((byte)(58)))));
            this.cardsPileWaste.HolderStateForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(65)))));
            this.cardsPileWaste.LabelFont = new System.Drawing.Font("Segoe UI Black", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cardsPileWaste.Location = new System.Drawing.Point(188, 14);
            this.cardsPileWaste.MinimumSize = new System.Drawing.Size(45, 22);
            this.cardsPileWaste.Name = "cardsPileWaste";
            this.cardsPileWaste.Radius = 20;
            this.cardsPileWaste.Size = new System.Drawing.Size(86, 116);
            this.cardsPileWaste.SuitsColor = System.Drawing.Color.Red;
            this.cardsPileWaste.SuitsImage = null;
            this.cardsPileWaste.SuitsLabel = null;
            this.cardsPileWaste.TabIndex = 1;
            this.cardsPileWaste.TopLeftCornerColor = System.Drawing.Color.Empty;
            this.cardsPileWaste.TopRightCornerColor = System.Drawing.Color.Empty;
            this.cardsPileWaste.Value = 1;
            // 
            // cardsPileStock
            // 
            this.cardsPileStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(124)))), ((int)(((byte)(58)))));
            this.cardsPileStock.Border = 5;
            this.cardsPileStock.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(124)))), ((int)(((byte)(58)))));
            this.cardsPileStock.BorderColorEmptyState = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(124)))), ((int)(((byte)(58)))));
            this.cardsPileStock.BorderColorHolderState = System.Drawing.Color.White;
            this.cardsPileStock.CardBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(124)))), ((int)(((byte)(58)))));
            this.cardsPileStock.CardForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(124)))), ((int)(((byte)(58)))));
            this.cardsPileStock.Filp = false;
            this.cardsPileStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(124)))), ((int)(((byte)(58)))));
            this.cardsPileStock.ForeColorEmptyState = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(124)))), ((int)(((byte)(58)))));
            this.cardsPileStock.HolderStateForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(65)))));
            this.cardsPileStock.LabelFont = new System.Drawing.Font("Segoe UI Black", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cardsPileStock.Location = new System.Drawing.Point(16, 14);
            this.cardsPileStock.MinimumSize = new System.Drawing.Size(45, 22);
            this.cardsPileStock.Name = "cardsPileStock";
            this.cardsPileStock.Radius = 20;
            this.cardsPileStock.Size = new System.Drawing.Size(86, 116);
            this.cardsPileStock.SuitsColor = System.Drawing.Color.Empty;
            this.cardsPileStock.SuitsImage = null;
            this.cardsPileStock.SuitsLabel = null;
            this.cardsPileStock.TabIndex = 2;
            this.cardsPileStock.TopLeftCornerColor = System.Drawing.Color.Empty;
            this.cardsPileStock.TopRightCornerColor = System.Drawing.Color.Empty;
            this.cardsPileStock.Value = 0;
            this.cardsPileStock.PileIsEmpty += new TriPeaks.CustomControls.EventDelegate(this.CardsPileStockIsEmpty);
            this.cardsPileStock.Click += new System.EventHandler(this.CardsPileStock_Click);
            // 
            // btnReStock
            // 
            this.btnReStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(124)))), ((int)(((byte)(58)))));
            this.btnReStock.BackgroundImage = global::TriPeaks.Properties.Resources.ReStock;
            this.btnReStock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReStock.FlatAppearance.BorderSize = 0;
            this.btnReStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReStock.Location = new System.Drawing.Point(119, 50);
            this.btnReStock.Name = "btnReStock";
            this.btnReStock.Size = new System.Drawing.Size(51, 47);
            this.btnReStock.TabIndex = 1;
            this.btnReStock.Tag = "ReStock";
            this.btnReStock.UseVisualStyleBackColor = false;
            this.btnReStock.Visible = false;
            this.btnReStock.Click += new System.EventHandler(this.BtnReStock_Click);
            this.btnReStock.MouseEnter += new System.EventHandler(this.Btns_MouseEnter);
            this.btnReStock.MouseLeave += new System.EventHandler(this.Btn_MouseLeave);
            // 
            // rpnlOptions
            // 
            this.rpnlOptions.Border = 0;
            this.rpnlOptions.BorderColor = System.Drawing.Color.Gray;
            this.rpnlOptions.Controls.Add(this.lblBoard);
            this.rpnlOptions.Controls.Add(this.lblScore);
            this.rpnlOptions.Controls.Add(this.btnHint);
            this.rpnlOptions.Controls.Add(this.btnUndo);
            this.rpnlOptions.Controls.Add(this.btnExitLevel);
            this.rpnlOptions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(124)))), ((int)(((byte)(58)))));
            this.rpnlOptions.Location = new System.Drawing.Point(150, 190);
            this.rpnlOptions.MinimumSize = new System.Drawing.Size(45, 22);
            this.rpnlOptions.Name = "rpnlOptions";
            this.rpnlOptions.Radius = 20;
            this.rpnlOptions.Size = new System.Drawing.Size(760, 69);
            this.rpnlOptions.TabIndex = 0;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.Font = new System.Drawing.Font("Segoe UI Black", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblScore.ForeColor = System.Drawing.Color.White;
            this.lblScore.Location = new System.Drawing.Point(11, 9);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(132, 46);
            this.lblScore.TabIndex = 2;
            this.lblScore.Text = "Score: ";
            // 
            // btnHint
            // 
            this.btnHint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(124)))), ((int)(((byte)(58)))));
            this.btnHint.BackgroundImage = global::TriPeaks.Properties.Resources.Hint;
            this.btnHint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHint.FlatAppearance.BorderSize = 0;
            this.btnHint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHint.Location = new System.Drawing.Point(565, 12);
            this.btnHint.Name = "btnHint";
            this.btnHint.Size = new System.Drawing.Size(48, 47);
            this.btnHint.TabIndex = 1;
            this.btnHint.Tag = "btnHint";
            this.btnHint.UseVisualStyleBackColor = false;
            this.btnHint.Click += new System.EventHandler(this.BtnHint_Click);
            this.btnHint.MouseEnter += new System.EventHandler(this.Btns_MouseEnter);
            this.btnHint.MouseLeave += new System.EventHandler(this.Btn_MouseLeave);
            // 
            // btnUndo
            // 
            this.btnUndo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(124)))), ((int)(((byte)(58)))));
            this.btnUndo.BackgroundImage = global::TriPeaks.Properties.Resources.Undo;
            this.btnUndo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUndo.FlatAppearance.BorderSize = 0;
            this.btnUndo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUndo.Location = new System.Drawing.Point(630, 13);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(43, 49);
            this.btnUndo.TabIndex = 1;
            this.btnUndo.Tag = "Undo";
            this.btnUndo.UseVisualStyleBackColor = false;
            this.btnUndo.Click += new System.EventHandler(this.BtnUndo_Click);
            this.btnUndo.MouseEnter += new System.EventHandler(this.Btns_MouseEnter);
            this.btnUndo.MouseLeave += new System.EventHandler(this.Btn_MouseLeave);
            // 
            // btnExitLevel
            // 
            this.btnExitLevel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(124)))), ((int)(((byte)(58)))));
            this.btnExitLevel.BackgroundImage = global::TriPeaks.Properties.Resources.Exit;
            this.btnExitLevel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExitLevel.FlatAppearance.BorderSize = 0;
            this.btnExitLevel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitLevel.Location = new System.Drawing.Point(694, 16);
            this.btnExitLevel.Name = "btnExitLevel";
            this.btnExitLevel.Size = new System.Drawing.Size(43, 44);
            this.btnExitLevel.TabIndex = 1;
            this.btnExitLevel.Tag = "Exit";
            this.btnExitLevel.UseVisualStyleBackColor = false;
            this.btnExitLevel.Click += new System.EventHandler(this.BtnExit_Click);
            this.btnExitLevel.MouseEnter += new System.EventHandler(this.Btns_MouseEnter);
            this.btnExitLevel.MouseLeave += new System.EventHandler(this.Btn_MouseLeave);
            // 
            // BoardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(176)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1084, 721);
            this.ControlBox = false;
            this.Controls.Add(this.pnlControls);
            this.Controls.Add(this.pnlBoard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BoardForm";
            this.Text = "BoardForm";
            this.pnlControls.ResumeLayout(false);
            this.rpnlPiles.ResumeLayout(false);
            this.rpnlOptions.ResumeLayout(false);
            this.rpnlOptions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBoard;
        private System.Windows.Forms.Panel pnlControls;
        private CustomControls.PlayingCard playingCard1;
        private CustomControls.PlayingCard playingCard2;
        private CustomControls.PlayingCard playingCard3;
        private CustomControls.PlayingCard playingCard4;
        private CustomControls.PlayingCard playingCard5;
        private CustomControls.PlayingCard playingCard6;
        private CustomControls.PlayingCard playingCard7;
        private CustomControls.PlayingCard playingCard8;
        private CustomControls.PlayingCard playingCard9;
        private CustomControls.PlayingCard playingCard10;
        private CustomControls.PlayingCard playingCard11;
        private CustomControls.PlayingCard playingCard12;
        private CustomControls.PlayingCard playingCard13;
        private CustomControls.PlayingCard playingCard14;
        private CustomControls.PlayingCard playingCard15;
        private CustomControls.PlayingCard playingCard16;
        private CustomControls.PlayingCard playingCard17;
        private CustomControls.PlayingCard playingCard18;
        private CustomControls.PlayingCard playingCard19;
        private CustomControls.PlayingCard playingCard20;
        private CustomControls.PlayingCard playingCard21;
        private CustomControls.PlayingCard playingCard22;
        private CustomControls.PlayingCard playingCard23;
        private CustomControls.PlayingCard playingCard24;
        private CustomControls.PlayingCard playingCard25;
        private CustomControls.PlayingCard playingCard26;
        private CustomControls.PlayingCard playingCard27;
        private CustomControls.PlayingCard playingCard28;
        private CustomControls.RoundPanel rpnlOptions;
        private CustomControls.RoundPanel rpnlPiles;
        private CustomControls.CardsPile cardsPileStock;
        private CustomControls.CardsPile cardsPileWaste;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Button btnReStock;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Button btnExitLevel;
        private Button btnHint;
        private Label lblBoard;
    }
}