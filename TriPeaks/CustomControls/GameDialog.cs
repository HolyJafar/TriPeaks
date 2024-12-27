using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace TriPeaks.CustomControls
{
    /// <summary>
    /// A custom Dialog
    /// </summary>
    public partial class GameDialog : Form
    {
        #region Fields and Propertys

        private bool result; //return user selected option as true or false
        public bool Result { get => result; }
        public string BtnYesText { get => lblYes.Text; set => lblYes.Text = value; }
        public string BtnNoText { get => lblNo.Text; set => lblNo.Text = value; }

        #endregion

        /// <summary>
        /// this codes make form corners round
        /// </summary>
        /// <param name="nLeftRect">  x-coordinate of upper-left corner  </param>
        /// <param name="nTopRect">   y-coordinate of upper-left corner  </param>
        /// <param name="nRightRect"> x-coordinate of lower-right corner </param>
        /// <param name="nBottomRect">  y-coordinate of lower-right corner </param>
        /// <param name="nWidthEllipse">  eight of ellipses </param>
        /// <param name="nHeightEllipse">  width of ellipses </param>
        /// <returns></returns>
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
             int nLeftRect,  
             int nTopRect,      
             int nRightRect,    
             int nBottomRect,   
             int nWidthEllipse, 
             int nHeightEllipse 
         );

        //Constructor
        public GameDialog(string Question,bool isYesNoQuestion=false)
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 50, 50)); 

            this.lblQuestion.Text = Question;

            if (!isYesNoQuestion)
            {
                this.roundPanelNo.Dispose();
                this.roundPanelYes.Location = new Point(134, this.roundPanelYes.Location.Y);
                this.lblYes.Text = "Ok";
            }
        }

        #region Click Events

        private void BtnNo_Click(object sender, EventArgs e)
        {
            this.result = false;
            this.Close();
        }

        private void BtnYes_Click(object sender, EventArgs e)
        {
            this.result = true;
            this.Close();
        }

        #endregion
    }
}
