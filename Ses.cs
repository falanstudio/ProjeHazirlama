using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje
{
    public partial class Ses : UserControl
    {
        public Ses()
        {
            InitializeComponent();
        }

        #region Properties
        private Button _Button;
        private string _Name;
        private Image _Icon;

        [Category("Ses Props")]
        public string SesName
        {
            get { return _Name; }
            set { _Name = value; label1.Text = value; }
        }

        [Category("Ses Props")]
        public Button Button
        {
            get { return _Button; }
            set { _Button = value; button1 = value; }
        }

        [Category("Ses Props")]
        public Image Icon
        {
            get { return _Icon; }
            set { _Icon = value; pictureBox1.Image = value; }
        }
        #endregion

    }
}
