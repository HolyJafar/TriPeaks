using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace TriPeaks.CustomControls
{
    /// <summary>
    /// A custom control that represents VisualCards
    /// </summary>
    public class PlayingCard : RoundPanel
    {

        #region class fileds

        private Color topLeftCornerColor;  //part of control background color
        private Color topRightCornerColor; //part of control background color
        private bool filp; //Represents which side of the card is shown
        private int value; //Defines a numeric value for the card
        private Font font; //Used for the labels
        private PictureBox pictureBoxSymbol; //Used to show the card symbol
        private Color suitsColor; //The card suite includes colors, symbols and labels
        private string suitsLabel;
        private Label lblLabel;
        private Image suitsImage;

        #endregion

        #region class propertys

        public Color CardBackColor { get => this.ForeColor; set { this.ForeColor = value; this.Invalidate(); } }
        public Color CardForeColor { get => this.BorderColor; set { this.BorderColor = value; this.Invalidate(); } }
        public Color TopLeftCornerColor { get => topLeftCornerColor; set { this.topLeftCornerColor = value; this.Invalidate(); } }
        public Color TopRightCornerColor { get => topRightCornerColor; set { this.topRightCornerColor = value; this.Invalidate(); } }
        public bool Filp { get => filp; set { filp = value; this.CreateSuits(); this.Invalidate(); } }
        public Font LabelFont { get => font; set { this.font = value; if (filp) { this.CreateSuits(); this.Invalidate(); } } }
        public int Value { get => value; set => this.value = value; }
        public Color SuitsColor { get => suitsColor; set { suitsColor = value; if (filp) { this.CreateSuits(); this.Invalidate(); } } }
        public string SuitsLabel { get => suitsLabel; set { suitsLabel = value; if (filp) { this.CreateSuits(); this.Invalidate(); } } }
        public Image SuitsImage { get => suitsImage; set { suitsImage = value; if (filp) { this.CreateSuits(); this.Invalidate(); } } }
        public CardSuits Suits
        {
            get
            {
                CardSuits output = new CardSuits();
                output.suitsColor = suitsColor;
                output.suitsImage = suitsImage;
                output.suitsLabel = suitsLabel;
                output.value = this.value;
                return output;
            }
            set
            {
                suitsImage = value.suitsImage;
                suitsLabel = value.suitsLabel;
                suitsColor = value.suitsColor;
                this.value = value.value;
                this.CreateSuits();
                this.Invalidate();
            }
        }

        #endregion

        // Counstructor
        public PlayingCard()
        {
            //Initialize card
            this.Size = new Size(86, 116);
            this.Radius = 18;
            this.Border = 5;
            this.filp = false;
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(65)))));
            this.BorderColor = Color.White;
            this.font = new Font("Segoe UI Black", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        }

        /// <summary>
        /// Merge card controls clickEvent to one event.
        /// </summary>
        /// <param name="sender">sender is pictureBoxSymbol</param>
        private void MergeClickEvents(object sender, EventArgs e)
        {
            this.InvokeOnClick(this, e);
        }

        #region draw control

        /// <summary>
        /// Create the card suite
        /// </summary>
        private void CreateSuits()
        {
            //The card suite is different in different sides
            //so the boolean that Represents the side is used

            //Create card front side suits
            if (filp)
            {
                //Create card symbol if it exists
                if (suitsImage != null)
                {
                    if (!this.Controls.Contains(pictureBoxSymbol))
                    {
                        this.pictureBoxSymbol = new PictureBox();
                        this.pictureBoxSymbol.Click += new System.EventHandler(MergeClickEvents);
                        this.pictureBoxSymbol.BackColor = Color.Transparent;
                        this.pictureBoxSymbol.Name = "Symbol";
                        this.pictureBoxSymbol.SizeMode = PictureBoxSizeMode.StretchImage;
                        this.pictureBoxSymbol.TabIndex = 1;
                        this.pictureBoxSymbol.TabStop = false;
                        this.Controls.Add(pictureBoxSymbol);
                    }

                    this.pictureBoxSymbol.Size = new Size(this.Width - (Radius), this.Height / 2 + Radius);
                    this.pictureBoxSymbol.Location = new Point(Radius / 2, this.Height / 2 - Radius);
                    this.pictureBoxSymbol.Image = suitsImage;
                }

                //Create card label if it exists
                if (suitsColor != null && suitsLabel != null)
                {
                    if (!this.Controls.Contains(lblLabel))
                    {
                        this.lblLabel = new Label();
                        this.lblLabel.AutoSize = true;
                        this.lblLabel.BackColor = Color.Transparent;
                        this.lblLabel.Margin = new Padding(0);
                        this.lblLabel.Name = "label";
                        this.lblLabel.TabIndex = 0;
                        this.Controls.Add(lblLabel);
                    }

                    this.lblLabel.Size = new Size(38, 37);
                    this.lblLabel.Location = new Point((this.Width / 2) - (this.lblLabel.Width / 2), 0);
                    this.lblLabel.Font = font;
                    this.lblLabel.ForeColor = suitsColor;
                    this.lblLabel.Text = suitsLabel;
                }
            }

            //Create card back side suit It is enough to delete the symbol and the label
            else
            {
                //To create card back suit
                this.Controls.Remove(pictureBoxSymbol);
                pictureBoxSymbol = null;

                this.Controls.Remove(lblLabel);
                lblLabel = null;
            }
        }


        /// <summary>
        /// Update suits sizes and locations
        /// </summary>
        private void UpdateSuits()
        {
            if (this.Controls.Contains(pictureBoxSymbol))
            {
                this.pictureBoxSymbol.Size = new System.Drawing.Size(this.Width - (Radius), this.Height / 2 + Radius);
                this.pictureBoxSymbol.Location = new System.Drawing.Point(Radius / 2, this.Height / 2 - Radius);
            }
            if (this.Controls.Contains(lblLabel))
            {
                this.lblLabel.Size = new System.Drawing.Size(38, 37);
                this.lblLabel.Location = new System.Drawing.Point((this.Width / 2) - (this.lblLabel.Width / 2), 0);
            }
        }


        /// <summary>
        /// override the OnPaint method to draw the card shape
        /// </summary>
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            //Draw Card Fore
            if (filp)
            {
                //Draw Fill
                g.FillRoundedRectangle(new SolidBrush(this.BorderColor), 0, 0, this.Width, this.Height, this.Radius);

                UpdateSuits();
            }
            //Draw Card Back
            else
            {
                //Draw Border
                if (this.Border > 0)
                    g.FillRoundedRectangle(new SolidBrush(this.BorderColor), 0, 0, this.Width, this.Height, this.Radius);

                //Draw Fill
                g.FillRoundedRectangle(new SolidBrush(this.ForeColor), this.Border,  this.Border, this.Width - (this.Border * 2), this.Height- (this.Border * 2), this.Radius - 2);
            }
        }

        /// <summary>
        /// override the OnPaintBackground method to draw the card background
        /// </summary>
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            //Draw Background
            base.OnPaintBackground(e);

            if (this.Name == "playingCard27")
                Console.WriteLine() ;

            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            //Draw Corners
            g.DrawRectangle(new Pen(this.topLeftCornerColor), 0, 0, this.Radius, this.Radius);
            g.FillRectangle(new SolidBrush(this.topLeftCornerColor), 0, 0, this.Radius, this.Radius);
            g.DrawRectangle(new Pen(this.topRightCornerColor), this.Width  - Radius, 0, this.Radius, this.Radius);
            g.FillRectangle(new SolidBrush(this.topRightCornerColor), this.Width -  Radius, 0, this.Radius, this.Radius);
        }

        #endregion

    }

    /// <summary>
    /// A structure for suites
    /// </summary>
    public struct CardSuits
    {
        public Color suitsColor;
        public string suitsLabel;
        public Image suitsImage;
        public int value;
    }
}
