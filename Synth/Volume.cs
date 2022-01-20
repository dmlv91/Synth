using AudioSwitcher.AudioApi.CoreAudio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Synth
{
    public partial class Volume : UserControl
    {

        public Volume()
        {
            InitializeComponent();

            this.Size = new Size(350, 20);
            this.BackColor = Color.Black;
            DoubleBuffered = true;

           
        }


    
        int defVol = 50, minVol = 0, maxVol = 100;
        bool mouse = false;

        public int Max { get { return maxVol; } set { maxVol = value; Invalidate(); } }
        public int Min { get { return minVol; } set { minVol = value; Invalidate(); } }
        public int Default { get { return defVol; } set { defVol = value; Invalidate(); } }
        public int gap = 10;

        Color b_color = Color.GreenYellow;
        public Color Bar_color { get { return b_color; } set { b_color = value; Invalidate(); } }
        private void Volume_Paint(object sender, PaintEventArgs e)
        {
            int start_point = 40;
            SolidBrush sb = new SolidBrush(Color.DimGray);
            for (int j = 0; j < (Max * ClientSize.Width / Max - 75)/ gap; j++)
            {
                e.Graphics.FillRectangle(sb, new Rectangle(start_point, 0, gap - 5, ClientSize.Height));
                start_point += gap;
            }

            int buffer_point = 40;
            SolidBrush br = new SolidBrush(b_color);

            for (int i = 0; i < (defVol * ClientSize.Width/Max - defVol)/ gap; i++)
            {
                e.Graphics.FillRectangle(br, new Rectangle(buffer_point, 0, gap - 2, ClientSize.Height));
                buffer_point += gap;
            }

            int thumSize = 25;
            SolidBrush thum = new SolidBrush(Color.White);
            e.Graphics.FillRectangle(thum, new Rectangle(buffer_point, 0, thumSize, ClientSize.Height));

            if (defVol >= Min)
            {
                Image left_img = Properties.Resources.sound_down;
                e.Graphics.DrawImage(left_img, 5, 0, ClientSize.Height, ClientSize.Height);
            }

            if (defVol <= 50 )
            {
                Image right_img = Properties.Resources.sound_mid;
                e.Graphics.DrawImage(right_img, ClientSize.Width - 35, 0, ClientSize.Height, ClientSize.Height);
            }

            if (defVol <= Min)
            {
                Image left_img = Properties.Resources.sound_mute;
                e.Graphics.DrawImage(left_img, 5, 0, ClientSize.Height, ClientSize.Height);
            }

            if (defVol >= 50)
            {
                Image right_img = Properties.Resources.sound_high;
                e.Graphics.DrawImage(right_img, ClientSize.Width - 35, 0, ClientSize.Height, ClientSize.Height);
            }
        }

        private void Volume_MouseDown(object sender, MouseEventArgs e)
        {
            mouse = true;
            Bar_value(thumValue(e.X));
        }

        private void Volume_MouseMove(object sender, MouseEventArgs e)
        {
            if (!mouse) return;
            Bar_value(thumValue(e.X));
        }

        private void Volume_MouseUp(object sender, MouseEventArgs e)
        {
            mouse = false;
            CoreAudioDevice defaultPlaybackDevice = new CoreAudioController().DefaultPlaybackDevice;
            defaultPlaybackDevice.Volume = defVol;
        }

        private void Bar_value (float value)
        {
            if (value < Min) value = Min;
            if (value > Max) value = Max;
            if (defVol == value) return;
            defVol = (int)value;
            this.Refresh();

            
        }

        private float thumValue (int x)
        {
            return Min + (Max - Min) * x / (float)(ClientSize.Width);
            
        }

      
    }
}
