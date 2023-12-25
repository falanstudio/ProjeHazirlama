using NAudio.Wave;

namespace Proje
{
    public partial class SoundboardForm : Form
    {
        private readonly List<string> soundFilePaths = new List<string>
    {
        "E:\\Projects\\Proje\\a.mp3",
        "E:\\Projects\\Proje\\movie_1.mp3",
    };

        private readonly List<Button> soundButtons = new List<Button>();
        private readonly WaveOutEvent waveOut = new WaveOutEvent();

        public SoundboardForm()
        {
            Text = "Soundboard";
            Width = 300;
            Height = 200;

            // Create sound buttons
            for (int i = 0; i < soundFilePaths.Count; i++)
            {
                Button soundButton = new Button
                {
                    Text = $"Sound {i + 1}",
                    Size = new Size(100, 50),
                    Location = new Point(20, 20 + i * 60)
                };

                soundButton.Click += SoundButton_Click; ;
                soundButton.Tag = i;
                Controls.Add(soundButton);
                soundButtons.Add(soundButton);
            }

            // Initialize audio playback with the first sound 
        }

        private void SoundButton_Click(object? sender, EventArgs e)
        {
            Button? buton = sender as Button;
            PlaySound(soundFilePaths[(int)buton.Tag]);
        }

        private void PlaySound(string filePath)
        {
            waveOut.Stop();
            waveOut.Init(new MediaFoundationReader(filePath));
            waveOut.Play();
        }
    }
//    using System;
//using System.Collections.Generic;
//using System.Windows.Forms;
//using NAudio.Wave;

//static class Program
//    {
//        [STAThread]
//        static void Main()
//        {
//            Application.EnableVisualStyles();
//            Application.SetCompatibleTextRenderingDefault(false);
//            Application.Run(new SoundboardForm());
//        }
//    }

//    public class SoundboardForm : Form
//    {
//        private readonly List<string> soundFilePaths = new List<string>
//    {
//        "path/to/sound1.mp3", // Replace with the actual path to your sound file
//        "path/to/sound2.mp3",
//        // Add more paths as needed
//    };

//        private readonly List<Button> soundButtons = new List<Button>();
//        private readonly WaveOutEvent waveOut = new WaveOutEvent();

//        public SoundboardForm()
//        {
//            Text = "Soundboard";
//            Width = 300;
//            Height = 200;

//            // Create sound buttons
//            for (int i = 0; i < soundFilePaths.Count; i++)
//            {
//                Button soundButton = new Button
//                {
//                    Text = $"Sound {i + 1}",
//                    Size = new System.Drawing.Size(100, 50),
//                    Location = new System.Drawing.Point(20, 20 + i * 60)
//                };

//                soundButton.Click += (sender, e) => PlaySound(soundFilePaths[i]);

//                Controls.Add(soundButton);
//                soundButtons.Add(soundButton);
//            }

//            // Initialize audio playback with the first sound file
//            waveOut.Init(new WaveFileReader(soundFilePaths.FirstOrDefault()));
//        }

//        private void PlaySound(string filePath)
//        {
//            waveOut.Stop();
//            waveOut.Init(new WaveFileReader(filePath));
//            waveOut.Play();
//        }
//    }
}
