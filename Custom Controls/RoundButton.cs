using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje.Custom_Controls
{
    public partial class RoundButton : Button
    {
        public RoundButton()
        {
            InitializeComponent();
            Width = 50;
            Height = 20;
        }
        private int _WidthEllipse = 10;

        public int WidthEllipse
        {
            get { return _WidthEllipse; }
            set { _WidthEllipse = value; }
        }
        private int _HeightEllipse = 10;

        public int HeightEllipse
        {
            get { return _HeightEllipse; }
            set { _HeightEllipse = value; }
        }


        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeft,
            int nTop,
            int nRight,
            int nButtom,
            int nWidthEllipse,
            int nHeightEllipse
            );
        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            Region = Region.FromHrgn(CreateRoundRectRgn(3,3,Width,Height, _WidthEllipse, _HeightEllipse));
            
        }
    }
}
