
namespace Synth
{
    partial class voiceSynth
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
            this.txtVoice = new System.Windows.Forms.TextBox();
            this.btnTalk = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.checkBoxSlow = new System.Windows.Forms.CheckBox();
            this.checkBoxNorm = new System.Windows.Forms.CheckBox();
            this.checkBoxFast = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtVoice
            // 
            this.txtVoice.Location = new System.Drawing.Point(41, 42);
            this.txtVoice.Name = "txtVoice";
            this.txtVoice.Size = new System.Drawing.Size(283, 20);
            this.txtVoice.TabIndex = 0;
            // 
            // btnTalk
            // 
            this.btnTalk.Location = new System.Drawing.Point(353, 39);
            this.btnTalk.Name = "btnTalk";
            this.btnTalk.Size = new System.Drawing.Size(75, 23);
            this.btnTalk.TabIndex = 1;
            this.btnTalk.Text = "Talk!";
            this.btnTalk.UseVisualStyleBackColor = true;
            this.btnTalk.Click += new System.EventHandler(this.btnTalk_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(353, 94);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Go back!";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // checkBoxSlow
            // 
            this.checkBoxSlow.AutoSize = true;
            this.checkBoxSlow.Location = new System.Drawing.Point(41, 69);
            this.checkBoxSlow.Name = "checkBoxSlow";
            this.checkBoxSlow.Size = new System.Drawing.Size(81, 17);
            this.checkBoxSlow.TabIndex = 3;
            this.checkBoxSlow.Text = "Slow speed";
            this.checkBoxSlow.UseVisualStyleBackColor = true;
            this.checkBoxSlow.CheckedChanged += new System.EventHandler(this.checkBoxSlow_CheckedChanged);
            // 
            // checkBoxNorm
            // 
            this.checkBoxNorm.AutoSize = true;
            this.checkBoxNorm.Checked = true;
            this.checkBoxNorm.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxNorm.Location = new System.Drawing.Point(127, 69);
            this.checkBoxNorm.Name = "checkBoxNorm";
            this.checkBoxNorm.Size = new System.Drawing.Size(91, 17);
            this.checkBoxNorm.TabIndex = 4;
            this.checkBoxNorm.Text = "Normal speed";
            this.checkBoxNorm.UseVisualStyleBackColor = true;
            this.checkBoxNorm.CheckedChanged += new System.EventHandler(this.checkBoxNorm_CheckedChanged);
            // 
            // checkBoxFast
            // 
            this.checkBoxFast.AutoSize = true;
            this.checkBoxFast.Location = new System.Drawing.Point(224, 69);
            this.checkBoxFast.Name = "checkBoxFast";
            this.checkBoxFast.Size = new System.Drawing.Size(78, 17);
            this.checkBoxFast.TabIndex = 5;
            this.checkBoxFast.Text = "Fast speed";
            this.checkBoxFast.UseVisualStyleBackColor = true;
            this.checkBoxFast.CheckedChanged += new System.EventHandler(this.checkBoxFast_CheckedChanged);
            // 
            // voiceSynth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 129);
            this.Controls.Add(this.checkBoxFast);
            this.Controls.Add(this.checkBoxNorm);
            this.Controls.Add(this.checkBoxSlow);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnTalk);
            this.Controls.Add(this.txtVoice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "voiceSynth";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "voiceSynth";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtVoice;
        private System.Windows.Forms.Button btnTalk;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.CheckBox checkBoxSlow;
        private System.Windows.Forms.CheckBox checkBoxNorm;
        private System.Windows.Forms.CheckBox checkBoxFast;
    }
}