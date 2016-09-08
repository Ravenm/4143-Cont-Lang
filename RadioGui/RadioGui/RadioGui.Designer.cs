namespace RadioGui
{
    partial class RadioGui
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
            this.PreSets = new System.Windows.Forms.GroupBox();
            this.Station1 = new System.Windows.Forms.Button();
            this.Station2 = new System.Windows.Forms.Button();
            this.Station3 = new System.Windows.Forms.Button();
            this.Station6 = new System.Windows.Forms.Button();
            this.Station5 = new System.Windows.Forms.Button();
            this.Station4 = new System.Windows.Forms.Button();
            this.Speakers = new System.Windows.Forms.GroupBox();
            this.SpeakerRear = new System.Windows.Forms.CheckBox();
            this.SpeakerFront = new System.Windows.Forms.CheckBox();
            this.PowerBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Mute = new System.Windows.Forms.CheckBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.Tuning = new System.Windows.Forms.GroupBox();
            this.CurrentStation = new System.Windows.Forms.Label();
            this.AmBtn = new System.Windows.Forms.RadioButton();
            this.FmBtn = new System.Windows.Forms.RadioButton();
            this.PicBox = new System.Windows.Forms.PictureBox();
            this.PreSets.SuspendLayout();
            this.Speakers.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.Tuning.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // PreSets
            // 
            this.PreSets.Controls.Add(this.Station6);
            this.PreSets.Controls.Add(this.Station5);
            this.PreSets.Controls.Add(this.Station4);
            this.PreSets.Controls.Add(this.Station3);
            this.PreSets.Controls.Add(this.Station2);
            this.PreSets.Controls.Add(this.Station1);
            this.PreSets.Location = new System.Drawing.Point(12, 12);
            this.PreSets.Name = "PreSets";
            this.PreSets.Size = new System.Drawing.Size(180, 55);
            this.PreSets.TabIndex = 0;
            this.PreSets.TabStop = false;
            this.PreSets.Text = "Pre-Set Stations";
            // 
            // Station1
            // 
            this.Station1.Location = new System.Drawing.Point(6, 19);
            this.Station1.Name = "Station1";
            this.Station1.Size = new System.Drawing.Size(23, 23);
            this.Station1.TabIndex = 0;
            this.Station1.Text = "1";
            this.Station1.UseVisualStyleBackColor = true;
            // 
            // Station2
            // 
            this.Station2.Location = new System.Drawing.Point(35, 19);
            this.Station2.Name = "Station2";
            this.Station2.Size = new System.Drawing.Size(23, 23);
            this.Station2.TabIndex = 1;
            this.Station2.Text = "2";
            this.Station2.UseVisualStyleBackColor = true;
            // 
            // Station3
            // 
            this.Station3.Location = new System.Drawing.Point(64, 19);
            this.Station3.Name = "Station3";
            this.Station3.Size = new System.Drawing.Size(23, 23);
            this.Station3.TabIndex = 2;
            this.Station3.Text = "3";
            this.Station3.UseVisualStyleBackColor = true;
            // 
            // Station6
            // 
            this.Station6.Location = new System.Drawing.Point(151, 19);
            this.Station6.Name = "Station6";
            this.Station6.Size = new System.Drawing.Size(23, 23);
            this.Station6.TabIndex = 5;
            this.Station6.Text = "6";
            this.Station6.UseVisualStyleBackColor = true;
            // 
            // Station5
            // 
            this.Station5.Location = new System.Drawing.Point(122, 19);
            this.Station5.Name = "Station5";
            this.Station5.Size = new System.Drawing.Size(23, 23);
            this.Station5.TabIndex = 4;
            this.Station5.Text = "5";
            this.Station5.UseVisualStyleBackColor = true;
            // 
            // Station4
            // 
            this.Station4.Location = new System.Drawing.Point(93, 19);
            this.Station4.Name = "Station4";
            this.Station4.Size = new System.Drawing.Size(23, 23);
            this.Station4.TabIndex = 3;
            this.Station4.Text = "4";
            this.Station4.UseVisualStyleBackColor = true;
            // 
            // Speakers
            // 
            this.Speakers.Controls.Add(this.SpeakerFront);
            this.Speakers.Controls.Add(this.SpeakerRear);
            this.Speakers.Location = new System.Drawing.Point(199, 12);
            this.Speakers.Name = "Speakers";
            this.Speakers.Size = new System.Drawing.Size(120, 55);
            this.Speakers.TabIndex = 1;
            this.Speakers.TabStop = false;
            this.Speakers.Text = "Speakers";
            // 
            // SpeakerRear
            // 
            this.SpeakerRear.AutoSize = true;
            this.SpeakerRear.Location = new System.Drawing.Point(7, 24);
            this.SpeakerRear.Name = "SpeakerRear";
            this.SpeakerRear.Size = new System.Drawing.Size(49, 17);
            this.SpeakerRear.TabIndex = 0;
            this.SpeakerRear.Text = "Rear";
            this.SpeakerRear.UseVisualStyleBackColor = true;
            // 
            // SpeakerFront
            // 
            this.SpeakerFront.AutoSize = true;
            this.SpeakerFront.Location = new System.Drawing.Point(63, 24);
            this.SpeakerFront.Name = "SpeakerFront";
            this.SpeakerFront.Size = new System.Drawing.Size(50, 17);
            this.SpeakerFront.TabIndex = 1;
            this.SpeakerFront.Text = "Front";
            this.SpeakerFront.UseVisualStyleBackColor = true;
            // 
            // PowerBtn
            // 
            this.PowerBtn.Location = new System.Drawing.Point(326, 13);
            this.PowerBtn.Name = "PowerBtn";
            this.PowerBtn.Size = new System.Drawing.Size(75, 55);
            this.PowerBtn.TabIndex = 2;
            this.PowerBtn.Text = "Power On/Off";
            this.PowerBtn.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.trackBar1);
            this.groupBox1.Controls.Add(this.Mute);
            this.groupBox1.Location = new System.Drawing.Point(12, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(180, 70);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // Mute
            // 
            this.Mute.AutoSize = true;
            this.Mute.Location = new System.Drawing.Point(6, 19);
            this.Mute.Name = "Mute";
            this.Mute.Size = new System.Drawing.Size(50, 17);
            this.Mute.TabIndex = 0;
            this.Mute.Text = "Mute";
            this.Mute.UseVisualStyleBackColor = true;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(63, 20);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(104, 45);
            this.trackBar1.TabIndex = 1;
            // 
            // Tuning
            // 
            this.Tuning.Controls.Add(this.FmBtn);
            this.Tuning.Controls.Add(this.AmBtn);
            this.Tuning.Controls.Add(this.CurrentStation);
            this.Tuning.Location = new System.Drawing.Point(199, 74);
            this.Tuning.Name = "Tuning";
            this.Tuning.Size = new System.Drawing.Size(120, 70);
            this.Tuning.TabIndex = 4;
            this.Tuning.TabStop = false;
            this.Tuning.Text = "Tuning";
            // 
            // CurrentStation
            // 
            this.CurrentStation.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CurrentStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentStation.ForeColor = System.Drawing.Color.Silver;
            this.CurrentStation.Location = new System.Drawing.Point(7, 20);
            this.CurrentStation.Name = "CurrentStation";
            this.CurrentStation.Size = new System.Drawing.Size(50, 44);
            this.CurrentStation.TabIndex = 0;
            this.CurrentStation.Text = "92.9";
            this.CurrentStation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AmBtn
            // 
            this.AmBtn.AutoSize = true;
            this.AmBtn.Location = new System.Drawing.Point(64, 20);
            this.AmBtn.Name = "AmBtn";
            this.AmBtn.Size = new System.Drawing.Size(41, 17);
            this.AmBtn.TabIndex = 1;
            this.AmBtn.TabStop = true;
            this.AmBtn.Text = "AM";
            this.AmBtn.UseVisualStyleBackColor = true;
            // 
            // FmBtn
            // 
            this.FmBtn.AutoSize = true;
            this.FmBtn.Location = new System.Drawing.Point(64, 44);
            this.FmBtn.Name = "FmBtn";
            this.FmBtn.Size = new System.Drawing.Size(40, 17);
            this.FmBtn.TabIndex = 2;
            this.FmBtn.TabStop = true;
            this.FmBtn.Text = "FM";
            this.FmBtn.UseVisualStyleBackColor = true;
            // 
            // PicBox
            // 
            this.PicBox.Image = global::RadioGui.Properties.Resources.musicnote;
            this.PicBox.Location = new System.Drawing.Point(326, 75);
            this.PicBox.Name = "PicBox";
            this.PicBox.Size = new System.Drawing.Size(55, 70);
            this.PicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicBox.TabIndex = 5;
            this.PicBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 156);
            this.Controls.Add(this.PicBox);
            this.Controls.Add(this.Tuning);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PowerBtn);
            this.Controls.Add(this.Speakers);
            this.Controls.Add(this.PreSets);
            this.Name = "Form1";
            this.Text = "Radio";
            this.PreSets.ResumeLayout(false);
            this.Speakers.ResumeLayout(false);
            this.Speakers.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.Tuning.ResumeLayout(false);
            this.Tuning.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox PreSets;
        private System.Windows.Forms.Button Station1;
        private System.Windows.Forms.Button Station6;
        private System.Windows.Forms.Button Station5;
        private System.Windows.Forms.Button Station4;
        private System.Windows.Forms.Button Station3;
        private System.Windows.Forms.Button Station2;
        private System.Windows.Forms.GroupBox Speakers;
        private System.Windows.Forms.CheckBox SpeakerFront;
        private System.Windows.Forms.CheckBox SpeakerRear;
        private System.Windows.Forms.Button PowerBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.CheckBox Mute;
        private System.Windows.Forms.GroupBox Tuning;
        private System.Windows.Forms.RadioButton FmBtn;
        private System.Windows.Forms.RadioButton AmBtn;
        private System.Windows.Forms.Label CurrentStation;
        private System.Windows.Forms.PictureBox PicBox;
    }
}

