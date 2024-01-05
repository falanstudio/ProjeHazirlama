using Proje.Custom_Controls;
using System.ComponentModel;
using System.Drawing.Drawing2D;

namespace Proje
{
    public partial class Ses : UserControl
    {
        public Ses()
        {
            InitializeComponent();
            this.DoubleBuffered = true;

        }

        #region Properties
        private string _Name;

        private void customPanel1_Paint(object sender, PaintEventArgs e)
        {
            GraphicsPath path = new GraphicsPath();
            int radius = 15; // You can adjust the radius as needed

            //path.AddArc(0, 0, radius, radius, 180, 90);
            //path.AddArc(customPanel1.Width - radius, 0, radius, radius, 270, 90);
            //path.AddArc(customPanel1.Width - radius, customPanel1.Height - radius, radius, radius, 0, 90);
            //path.AddArc(0, customPanel1.Height - radius, radius, radius, 90, 90);

            //customPanel1.Region = new Region(path);

            //// Apply anti-aliasing
            //e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            //e.Graphics.FillPath(new SolidBrush(customPanel1.BackColor), path);
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            //customPanel1.IsHovered = true;
            //customPanel1.Invalidate();
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            //customPanel1.IsHovered = false;
            //customPanel1.Invalidate();
        }

        [Category("Ses Props")]
        public string SesName
        {
            get { return _Name; }
            set { _Name = value; label1.Text = value; }
        }

        #endregion

    }
}
