
namespace Synth
{
    partial class Synth
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Synth));
            this.btnTalk = new System.Windows.Forms.Button();
            this.lblVolAdj = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.mnHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.lblVolume = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.volume_control = new Volume();
            this.oscillator3 = new Oscillator();
            this.oscillator2 = new Oscillator();
            this.oscillator1 = new Oscillator();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTalk
            // 
            this.btnTalk.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTalk.Location = new System.Drawing.Point(286, 28);
            this.btnTalk.Name = "btnTalk";
            this.btnTalk.Size = new System.Drawing.Size(110, 23);
            this.btnTalk.TabIndex = 3;
            this.btnTalk.Text = "I want to Talk!";
            this.btnTalk.UseVisualStyleBackColor = true;
            this.btnTalk.Click += new System.EventHandler(this.btnTalk_Click);
            // 
            // lblVolAdj
            // 
            this.lblVolAdj.AutoSize = true;
            this.lblVolAdj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVolAdj.Location = new System.Drawing.Point(169, 359);
            this.lblVolAdj.Name = "lblVolAdj";
            this.lblVolAdj.Size = new System.Drawing.Size(69, 20);
            this.lblVolAdj.TabIndex = 5;
            this.lblVolAdj.Text = "Volume";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(417, 25);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnHelp});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(38, 22);
            this.toolStripDropDownButton1.Text = "File";
            // 
            // mnHelp
            // 
            this.mnHelp.Name = "mnHelp";
            this.mnHelp.Size = new System.Drawing.Size(99, 22);
            this.mnHelp.Text = "Help";
            this.mnHelp.Click += new System.EventHandler(this.mnHelp_Click);
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVolume.Location = new System.Drawing.Point(25, 364);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(97, 16);
            this.lblVolume.TabIndex = 7;
            this.lblVolume.Text = "Volume: 30%";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // volume_control
            // 
            this.volume_control.BackColor = System.Drawing.Color.Black;
            this.volume_control.Bar_color = System.Drawing.Color.GreenYellow;
            this.volume_control.Default = 50;
            this.volume_control.Location = new System.Drawing.Point(28, 382);
            this.volume_control.Max = 100;
            this.volume_control.Min = 0;
            this.volume_control.Name = "volume_control";
            this.volume_control.Size = new System.Drawing.Size(350, 20);
            this.volume_control.TabIndex = 4;
            // 
            // oscillator3
            // 
            this.oscillator3.Location = new System.Drawing.Point(12, 249);
            this.oscillator3.Name = "oscillator3";
            this.oscillator3.Size = new System.Drawing.Size(257, 110);
            this.oscillator3.TabIndex = 2;
            this.oscillator3.TabStop = false;
            this.oscillator3.Text = "Oscillator 3";
            // 
            // oscillator2
            // 
            this.oscillator2.Location = new System.Drawing.Point(12, 143);
            this.oscillator2.Name = "oscillator2";
            this.oscillator2.Size = new System.Drawing.Size(257, 100);
            this.oscillator2.TabIndex = 1;
            this.oscillator2.TabStop = false;
            this.oscillator2.Text = "Oscillator 2";
            // 
            // oscillator1
            // 
            this.oscillator1.Location = new System.Drawing.Point(12, 28);
            this.oscillator1.Name = "oscillator1";
            this.oscillator1.Size = new System.Drawing.Size(257, 109);
            this.oscillator1.TabIndex = 0;
            this.oscillator1.TabStop = false;
            this.oscillator1.Text = "Oscillator 1";
            // 
            // Synth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 425);
            this.Controls.Add(this.lblVolume);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.lblVolAdj);
            this.Controls.Add(this.volume_control);
            this.Controls.Add(this.btnTalk);
            this.Controls.Add(this.oscillator3);
            this.Controls.Add(this.oscillator2);
            this.Controls.Add(this.oscillator1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "Synth";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Synth";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Synth_KeyDown);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Oscillator oscillator1;
        private Oscillator oscillator2;
        private Oscillator oscillator3;
        private System.Windows.Forms.Button btnTalk;
        private Volume volume_control;
        private System.Windows.Forms.Label lblVolAdj;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem mnHelp;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.Timer timer1;
    }
}

