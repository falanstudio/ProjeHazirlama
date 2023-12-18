namespace Proje
{
    public partial class Form2 : Form
    {
        public Form2()
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
