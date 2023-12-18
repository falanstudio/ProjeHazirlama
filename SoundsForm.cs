namespace Proje
{
    public partial class SoundsForm : Form
    {
        public SoundsForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SesForm sesForm = new SesForm();
            sesForm.StartPosition = FormStartPosition.CenterParent;
            sesForm.ShowDialog();
            var result = sesForm.sound;
        }
    }
}
