namespace Proje
{
    public partial class SesForm : Form
    {
        public Sound sound;
        public SesForm()
        {
            InitializeComponent();
            sound = new Sound { Ad = "132", Hotkey = textBox2.Text, Konum = textBox1.Text };
        }

        private void TextBox2_KeyDown(object? sender, KeyEventArgs e)
        {
            textBox2.Text = $"{e.Modifiers} + {e.KeyCode}";
            e.SuppressKeyPress = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Select a File";
                openFileDialog.Filter = "All Files|*.*"; // You can change the filter based on your requirements

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Get the selected file location and display it in the TextBox
                    textBox1.Text = openFileDialog.FileName;
                }
            }
        }
    }
    public class Sound
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Konum { get; set; }
        public string Hotkey { get; set; }
    }
}
