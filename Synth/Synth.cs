using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;
using System.Speech.Synthesis;

namespace Synth
{
    public partial class Synth : Form
    {

        private const int sample_rate = 44100;
        private const short bits_per_sample = 16;
        
        
        public Synth()
        {
            InitializeComponent();
            
        }


        private void Synth_KeyDown(object sender, KeyEventArgs e)
        {

            IEnumerable<Oscillator> oscillators = this.Controls.OfType<Oscillator>().Where(o => o.On);

            Random random = new Random();
            short[] wave = new short[sample_rate];
            byte[] binaryWave = new byte[sample_rate * sizeof(short)];
            float frequency;
            int oscillatorsCount = oscillators.Count();

            //Define different key tone frequency
            switch (e.KeyCode)
            {
                case Keys.Z:
                    frequency = 65.4f;
                    break;
                case Keys.X:
                    frequency = 73.4f;
                    break;
                case Keys.C:
                    frequency = 82.4f;
                    break;
                case Keys.V:
                    frequency = 87.3f;
                    break;
                case Keys.B:
                    frequency = 97.99f;
                    break;
                case Keys.N:
                    frequency = 110.00f;
                    break;
                case Keys.M:
                    frequency = 123.47f;
                    break;
                case Keys.Oemcomma:
                    frequency = 130.81f;
                    break;
                case Keys.Q:
                    frequency = 261.62f;
                    break;
                case Keys.W:
                    frequency = 293.66f;
                    break;
                case Keys.E:
                    frequency = 329.63f;
                    break;
                case Keys.R:
                    frequency = 349.23f;
                    break;
                case Keys.T:
                    frequency = 391.99f;
                    break;
                case Keys.Y:
                    frequency = 440.00f;
                    break;
                case Keys.U:
                    frequency = 493.88f;
                    break;
                case Keys.I:
                    frequency = 523.25f;
                    break;
                default:
                    return;
            }
            foreach (Oscillator oscillator in oscillators)
            {
                int samplesPerWaveLength = (int)(sample_rate / frequency);
                short ampStep = (short)((short.MaxValue * 2) / samplesPerWaveLength);
                short tempSample;
                //generate 4 waveforms
                switch (oscillator.WaveForm)
                {
                    case WaveForm.Sine:
                        for (int i = 0; i < sample_rate; i++)
                        {
                            wave[i] += Convert.ToInt16((short.MaxValue * Math.Sin(((Math.PI * 2 * frequency) / sample_rate) * i)) / oscillatorsCount);
                        }
                        break;
                    case WaveForm.Square:
                        for (int i = 0; i < sample_rate; i++)
                        {
                            wave[i] += Convert.ToInt16((short.MaxValue * Math.Sign(Math.Sin((Math.PI * 2 * frequency) / sample_rate * i))) / oscillatorsCount);
                        }
                        break;
                    case WaveForm.Saw:
                        for (int i = 0; i < sample_rate; i++)
                        {
                            tempSample = -short.MaxValue;
                            for (int j = 0; j < samplesPerWaveLength && i < sample_rate; j++)
                            {
                                tempSample += ampStep;
                                wave[i++] += Convert.ToInt16(tempSample / oscillatorsCount);
                            }
                            i--;
                        }
                        break;
                    case WaveForm.Triangle:
                        tempSample = -short.MaxValue;
                        for (int i = 0; i < sample_rate; i++)
                        {
                            if (Math.Abs(tempSample + ampStep) > short.MaxValue)
                            {
                                ampStep = (short)-ampStep;
                            }
                            tempSample += ampStep;
                            wave[i] += Convert.ToInt16(tempSample / oscillatorsCount);
                        }
                        break;
                }


            }
        
            //convert short wave to binarywave.
            Buffer.BlockCopy(wave, 0, binaryWave, 0, wave.Length* sizeof(short));
            
            using (MemoryStream memoryStream = new MemoryStream())
            using (BinaryWriter binaryWriter = new BinaryWriter(memoryStream))
                
            //generate wave format sound wave
            {
                short blockAlign = bits_per_sample / 8;
                int subchunk2Size = sample_rate * blockAlign;
                binaryWriter.Write(new[] { 'R', 'I', 'F', 'F' });
                binaryWriter.Write(36 + subchunk2Size);
                binaryWriter.Write(new[] { 'W', 'A', 'V', 'E', 'f', 'm', 't', ' ' });
                binaryWriter.Write(16);
                binaryWriter.Write((short)1);
                binaryWriter.Write((short)1);
                binaryWriter.Write(sample_rate);
                binaryWriter.Write(sample_rate * blockAlign);
                binaryWriter.Write(blockAlign);
                binaryWriter.Write(bits_per_sample);
                binaryWriter.Write(new[] { 'd', 'a', 't', 'a' });
                binaryWriter.Write(subchunk2Size);
                binaryWriter.Write(binaryWave);
                memoryStream.Position = 0;
                new SoundPlayer(memoryStream).Play();

            }

            
        }

        private void btnTalk_Click(object sender, EventArgs e)
        {
            voiceSynth voice = new voiceSynth();
            voice.Show();
        }

        private void mnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is a basic sound synthesizer! You can generate sounds using 3 oscillators that have 4 different waveform generators!" +
                "Play the sounds using keyboard: Z - comma are low notes, Q - I are high notes." +
                "You can adjust the sound volume and use the speech synthesizer as well!");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblVolume.Text = "Volume: " + volume_control.Default.ToString() + "%";
            
            

            
        }
    }

    public enum WaveForm
{
    Sine, Square, Saw, Triangle
}
}
