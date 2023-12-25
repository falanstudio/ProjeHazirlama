using NAudio.Wave;
using System.Media;

namespace Proje
{
    public partial class Sesler : Form
    {
        string[] sounds = Directory.GetFiles("E:\\Projects\\Proje\\Sounds\\");
        private readonly WaveOutEvent waveOut = new WaveOutEvent();
        public Sesler()
        {
            InitializeComponent();
            SesleriEkle();
        }

        void SesleriEkle()
        {
            
            var sayac = 0;
            foreach (string sound in sounds)
            {
                Ses ses = new Ses();
                ses.Button.Tag = sayac;
                sayac++;
                ses.Button.Text = (sayac).ToString() + ". Ses";
                ses.Button.Click += SesÇal;
                ses.SesName = Path.GetFileName(sound);
                flowLayoutPanel1.Controls.Add(ses);
            }
        }

        private void SesÇal(object? sender, EventArgs e)
        {
            Button? buton = sender as Button;
            waveOut.Stop();
            waveOut.Init(new MediaFoundationReader(sounds[(int)buton.Tag]));
            waveOut.Play();
        }
    }
}
