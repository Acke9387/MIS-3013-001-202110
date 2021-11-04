using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SimpleMethod_Speak
{
    public static class Sounds
    {
        public static void Dog()
        {
            using (var waveOut = new WaveOutEvent())
            using (var wavReader = new WaveFileReader(@"Files\dog.wav"))
            {
                waveOut.Init(wavReader);
                waveOut.Play();
                Console.WriteLine("Bark Bark");
                Thread.Sleep((int)Math.Floor(wavReader.TotalTime.TotalMilliseconds) + 1);
            }
        }

        public static void Goat()
        {
            using (var waveOut = new WaveOutEvent())
            using (var wavReader = new WaveFileReader(@"Files\goat.wav"))
            {
                waveOut.Init(wavReader);
                waveOut.Play();
                Console.WriteLine("AHHHHHHHHHHH");
                Thread.Sleep((int)Math.Floor(wavReader.TotalTime.TotalMilliseconds) + 1);
            }
        }
        public static void Default()
        {
            using (var waveOut = new WaveOutEvent())
            using (var wavReader = new WaveFileReader(@"Files\default.wav"))
            {
                waveOut.Init(wavReader);
                waveOut.Play();
                Console.WriteLine("Squeeky squeeky squeek");
                Thread.Sleep((int)Math.Floor(wavReader.TotalTime.TotalMilliseconds) + 1);
            }
        }

        public static void Monkey()
        {
            using (var waveOut = new WaveOutEvent())
            using (var wavReader = new WaveFileReader(@"Files\monkey.wav"))
            {
                waveOut.Init(wavReader);
                waveOut.Play();
                Console.WriteLine("OOoo aaah aahh ahhh");
                Thread.Sleep((int)Math.Floor(wavReader.TotalTime.TotalMilliseconds) + 1);
            }
        }
    }
}
