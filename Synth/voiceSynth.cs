using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;

namespace Synth
{
    public partial class voiceSynth : Form
    {

        SpeechSynthesizer speech = new SpeechSynthesizer();
        public voiceSynth()
        {
            InitializeComponent();
            checkBoxNorm.Checked = true;
            speech.Rate = 0;
            
        }

        private void btnTalk_Click(object sender, EventArgs e)
        {


            speech.Speak(txtVoice.Text);
           
            
               

            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBoxFast_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxNorm.Checked = false;
            checkBoxSlow.Checked = false;
            speech.Rate = 10;
        }

        private void checkBoxSlow_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxNorm.Checked = false;
            checkBoxFast.Checked = false;
            speech.Rate = -10;
        }

        private void checkBoxNorm_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxSlow.Checked = false;
            checkBoxFast.Checked = false;
            speech.Rate = 0;
        }
    }
}
