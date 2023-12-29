using NAudio.Wave;
using System.Runtime.InteropServices;

namespace Proje
{
    public partial class Sesler : Form
    {
        string[] sounds = Directory.GetFiles("E:\\Projects\\Proje\\Sounds\\");
        readonly WaveOutEvent waveOut = new WaveOutEvent();

        //------------
        private const int MOD_CONTROL = 0x0002;
        private const int MOD_ALT = 0x0001;

        // Constants for hotkey IDs
        private const int HOTKEY_ID_1 = 1;
        private const int HOTKEY_ID_2 = 2;

        [DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vk);

        [DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        //---------
        public Sesler()
        {
            InitializeComponent();
            SesleriEkle();
            RegisterHotkeys();
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

        //-----------------------
        private void RegisterHotkeys()
        {
            // Register hotkeys (Ctrl + Alt + 1, Ctrl + Alt + 2)
            RegisterHotKey(Handle, HOTKEY_ID_1, MOD_CONTROL | MOD_ALT, (int)Keys.D1);
            RegisterHotKey(Handle, HOTKEY_ID_2, MOD_CONTROL | MOD_ALT, (int)Keys.D2);
        }

        private void UnregisterHotkeys()
        {
            // Unregister hotkeys when closing the form
            UnregisterHotKey(Handle, HOTKEY_ID_1);
            UnregisterHotKey(Handle, HOTKEY_ID_2);
        }

        protected override void WndProc(ref Message m)
        {
            // Handle hotkey messages
            if (m.Msg == 0x0312)
            {
                int id = m.WParam.ToInt32();
                PlaySoundByHotkey(id);
            }

            base.WndProc(ref m);
        }
        private void PlaySoundByHotkey(int id)
        {
            int index = id - HOTKEY_ID_1;
            if (index >= 0 && index < sounds.Length)
            {
                try
                {
                    waveOut.Stop();
                    using (var reader = new MediaFoundationReader(sounds[index]))
                    {
                        waveOut.Init(reader);
                        waveOut.Play();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error playing sound: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        //--------------------

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            // Dispose of resources when the form is closed
            waveOut.Dispose();
            UnregisterHotkeys();
            base.OnFormClosed(e);
        }
    }
}
