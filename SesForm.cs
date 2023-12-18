namespace Proje
{
    public partial class SesForm : Form
    {
        public Sound sound;
        public SesForm()
        {
            InitializeComponent();
            sound = new Sound { Ad = openFileDialog1.SafeFileName, Hotkey = textBox2.Text, Konum = textBox1.Text };
        }

        private void TextBox2_KeyDown(object? sender, KeyEventArgs e)
        {
            textBox2.Text = $"{e.Modifiers} + {e.KeyCode}";
            e.SuppressKeyPress = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (openFileDialog1)
            {
                openFileDialog1.Title = "Select a File";
                openFileDialog1.Filter = "All Files|*.*"; // You can change the filter based on your requirements

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    // Get the selected file location and display it in the TextBox
                    textBox1.Text = openFileDialog1.FileName;
                }
            }
        }

        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
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
