namespace MobilePhoneWinForm
{
    partial class Form2
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
            this.Audio = new System.Windows.Forms.GroupBox();
            this.SelectAudio = new System.Windows.Forms.Button();
            this.SamsungHeadset = new System.Windows.Forms.RadioButton();
            this.IphoneHeadset = new System.Windows.Forms.RadioButton();
            this.Charge = new System.Windows.Forms.GroupBox();
            this.SelectCharger = new System.Windows.Forms.Button();
            this.WirelessCharger = new System.Windows.Forms.RadioButton();
            this.USBCharger = new System.Windows.Forms.RadioButton();
            this.textBox = new System.Windows.Forms.TextBox();
            this.ClearBox = new System.Windows.Forms.Button();
            this.Audio.SuspendLayout();
            this.Charge.SuspendLayout();
            this.SuspendLayout();
            // 
            // Audio
            // 
            this.Audio.Controls.Add(this.SelectAudio);
            this.Audio.Controls.Add(this.SamsungHeadset);
            this.Audio.Controls.Add(this.IphoneHeadset);
            this.Audio.Location = new System.Drawing.Point(12, 12);
            this.Audio.Name = "Audio";
            this.Audio.Size = new System.Drawing.Size(141, 140);
            this.Audio.TabIndex = 0;
            this.Audio.TabStop = false;
            this.Audio.Text = "Audio";
            // 
            // SelectAudio
            // 
            this.SelectAudio.Location = new System.Drawing.Point(27, 110);
            this.SelectAudio.Name = "SelectAudio";
            this.SelectAudio.Size = new System.Drawing.Size(88, 21);
            this.SelectAudio.TabIndex = 2;
            this.SelectAudio.Text = "SelectAudio";
            this.SelectAudio.UseVisualStyleBackColor = true;
            this.SelectAudio.Click += new System.EventHandler(this.SelectAudio_Click);
            // 
            // SamsungHeadset
            // 
            this.SamsungHeadset.AutoSize = true;
            this.SamsungHeadset.Location = new System.Drawing.Point(27, 65);
            this.SamsungHeadset.Name = "SamsungHeadset";
            this.SamsungHeadset.Size = new System.Drawing.Size(109, 17);
            this.SamsungHeadset.TabIndex = 1;
            this.SamsungHeadset.TabStop = true;
            this.SamsungHeadset.Text = "SamsungHeadset";
            this.SamsungHeadset.UseVisualStyleBackColor = true;
            // 
            // IphoneHeadset
            // 
            this.IphoneHeadset.AutoSize = true;
            this.IphoneHeadset.Checked = true;
            this.IphoneHeadset.Location = new System.Drawing.Point(27, 42);
            this.IphoneHeadset.Name = "IphoneHeadset";
            this.IphoneHeadset.Size = new System.Drawing.Size(98, 17);
            this.IphoneHeadset.TabIndex = 0;
            this.IphoneHeadset.TabStop = true;
            this.IphoneHeadset.Text = "IphoneHeadset";
            this.IphoneHeadset.UseVisualStyleBackColor = true;
            // 
            // Charge
            // 
            this.Charge.Controls.Add(this.SelectCharger);
            this.Charge.Controls.Add(this.WirelessCharger);
            this.Charge.Controls.Add(this.USBCharger);
            this.Charge.Location = new System.Drawing.Point(174, 12);
            this.Charge.Name = "Charge";
            this.Charge.Size = new System.Drawing.Size(152, 140);
            this.Charge.TabIndex = 0;
            this.Charge.TabStop = false;
            this.Charge.Text = "Charge";
            // 
            // SelectCharger
            // 
            this.SelectCharger.Location = new System.Drawing.Point(34, 109);
            this.SelectCharger.Name = "SelectCharger";
            this.SelectCharger.Size = new System.Drawing.Size(85, 23);
            this.SelectCharger.TabIndex = 2;
            this.SelectCharger.Text = "SelectCharger";
            this.SelectCharger.UseVisualStyleBackColor = true;
            this.SelectCharger.Click += new System.EventHandler(this.SelectCharger_Click);
            // 
            // WirelessCharger
            // 
            this.WirelessCharger.AutoSize = true;
            this.WirelessCharger.Location = new System.Drawing.Point(34, 65);
            this.WirelessCharger.Name = "WirelessCharger";
            this.WirelessCharger.Size = new System.Drawing.Size(102, 17);
            this.WirelessCharger.TabIndex = 1;
            this.WirelessCharger.TabStop = true;
            this.WirelessCharger.Text = "WirelessCharger";
            this.WirelessCharger.UseVisualStyleBackColor = true;
            // 
            // USBCharger
            // 
            this.USBCharger.AutoSize = true;
            this.USBCharger.Checked = true;
            this.USBCharger.Location = new System.Drawing.Point(34, 42);
            this.USBCharger.Name = "USBCharger";
            this.USBCharger.Size = new System.Drawing.Size(84, 17);
            this.USBCharger.TabIndex = 0;
            this.USBCharger.TabStop = true;
            this.USBCharger.Text = "USBCharger";
            this.USBCharger.UseVisualStyleBackColor = true;
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(12, 171);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(314, 121);
            this.textBox.TabIndex = 1;
            // 
            // ClearBox
            // 
            this.ClearBox.Location = new System.Drawing.Point(225, 301);
            this.ClearBox.Name = "ClearBox";
            this.ClearBox.Size = new System.Drawing.Size(100, 27);
            this.ClearBox.TabIndex = 2;
            this.ClearBox.Text = "ClearBox";
            this.ClearBox.UseVisualStyleBackColor = true;
            this.ClearBox.Click += new System.EventHandler(this.ClearBox_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 332);
            this.Controls.Add(this.ClearBox);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.Charge);
            this.Controls.Add(this.Audio);
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.Audio.ResumeLayout(false);
            this.Audio.PerformLayout();
            this.Charge.ResumeLayout(false);
            this.Charge.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Audio;
        private System.Windows.Forms.RadioButton SamsungHeadset;
        private System.Windows.Forms.RadioButton IphoneHeadset;
        private System.Windows.Forms.GroupBox Charge;
        private System.Windows.Forms.Button SelectCharger;
        private System.Windows.Forms.RadioButton WirelessCharger;
        private System.Windows.Forms.RadioButton USBCharger;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button ClearBox;
        private System.Windows.Forms.Button SelectAudio;
    }
}