using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace TriPeaks.CustomControls
{

    /// <summary>
    /// A custom control that draw a rounded Panel
    /// </summary>
    public class RoundPanel : Panel
    {
        #region Fields
        private Color borderColor;
        private int radius;
        private int border;
        #endregion

        #region Propertys
        public Color BorderColor { get => borderColor; set { borderColor = value; this.Invalidate(); } }
        public int Radius { get => radius; set { radius = value; this.Invalidate(); } }
        public int Border { get => border; set { border = value; this.Invalidate(); } }
        #endregion

        //constructor
        public RoundPanel()
        {
            this.MinimumSize = new Size(45, 22);
            borderColor = Color.Gray;
            this.ForeColor = Color.White;
            border = 0;
            radius = 20;
        }

        /// <summary>
        /// Draw control
        /// </summary>
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            //Draw Border
            if(border>0)
            g.FillRoundedRectangle(new SolidBrush(borderColor), 0, 0, this.Width, this.Height, radius);

            //Draw Fill
            g.FillRoundedRectangle(new SolidBrush(this.ForeColor), border,border, this.Width - (border * 2), this.Height - (border * 2), radius);
        }
    }

}
