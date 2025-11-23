namespace HastaneYonetim
{
    partial class GirisForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GirisForm));
            System.Windows.Forms.PictureBox pictureBox1;
            this.button_Doctor = new System.Windows.Forms.Button();
            this.button_Nurse = new System.Windows.Forms.Button();
            this.button_Hasta = new System.Windows.Forms.Button();
            this.label_Hasta = new System.Windows.Forms.Label();
            this.label_Doktor = new System.Windows.Forms.Label();
            this.label_Sekreter = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Doctor
            // 
            this.button_Doctor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Doctor.BackgroundImage")));
            this.button_Doctor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Doctor.Location = new System.Drawing.Point(138, 190);
            this.button_Doctor.Name = "button_Doctor";
            this.button_Doctor.Size = new System.Drawing.Size(149, 134);
            this.button_Doctor.TabIndex = 0;
            this.button_Doctor.UseVisualStyleBackColor = true;
            // 
            // button_Nurse
            // 
            this.button_Nurse.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Nurse.BackgroundImage")));
            this.button_Nurse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Nurse.Location = new System.Drawing.Point(484, 190);
            this.button_Nurse.Name = "button_Nurse";
            this.button_Nurse.Size = new System.Drawing.Size(149, 134);
            this.button_Nurse.TabIndex = 1;
            this.button_Nurse.UseVisualStyleBackColor = true;
            // 
            // button_Hasta
            // 
            this.button_Hasta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Hasta.BackgroundImage")));
            this.button_Hasta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Hasta.Location = new System.Drawing.Point(311, 190);
            this.button_Hasta.Name = "button_Hasta";
            this.button_Hasta.Size = new System.Drawing.Size(149, 134);
            this.button_Hasta.TabIndex = 2;
            this.button_Hasta.UseVisualStyleBackColor = true;
            // 
            // label_Hasta
            // 
            this.label_Hasta.AutoSize = true;
            this.label_Hasta.Font = new System.Drawing.Font("Playball", 24F, System.Drawing.FontStyle.Bold);
            this.label_Hasta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_Hasta.Location = new System.Drawing.Point(341, 336);
            this.label_Hasta.Name = "label_Hasta";
            this.label_Hasta.Size = new System.Drawing.Size(94, 40);
            this.label_Hasta.TabIndex = 3;
            this.label_Hasta.Text = "Hasta";
            // 
            // label_Doktor
            // 
            this.label_Doktor.AutoSize = true;
            this.label_Doktor.Font = new System.Drawing.Font("Playball", 24F, System.Drawing.FontStyle.Bold);
            this.label_Doktor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_Doktor.Location = new System.Drawing.Point(163, 336);
            this.label_Doktor.Name = "label_Doktor";
            this.label_Doktor.Size = new System.Drawing.Size(106, 40);
            this.label_Doktor.TabIndex = 4;
            this.label_Doktor.Text = "Doktor";
            // 
            // label_Sekreter
            // 
            this.label_Sekreter.AutoSize = true;
            this.label_Sekreter.Font = new System.Drawing.Font("Playball", 24F, System.Drawing.FontStyle.Bold);
            this.label_Sekreter.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_Sekreter.Location = new System.Drawing.Point(499, 336);
            this.label_Sekreter.Name = "label_Sekreter";
            this.label_Sekreter.Size = new System.Drawing.Size(118, 40);
            this.label_Sekreter.TabIndex = 5;
            this.label_Sekreter.Text = "Sekreter";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pictureBox1.Location = new System.Drawing.Point(311, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(322, 152);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.IndianRed;
            this.label1.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(68, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 93);
            this.label1.TabIndex = 7;
            this.label1.Text = "Son Durak Hastanesi";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GirisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(723, 381);
            this.Controls.Add(this.label1);
            this.Controls.Add(pictureBox1);
            this.Controls.Add(this.label_Sekreter);
            this.Controls.Add(this.label_Doktor);
            this.Controls.Add(this.label_Hasta);
            this.Controls.Add(this.button_Hasta);
            this.Controls.Add(this.button_Nurse);
            this.Controls.Add(this.button_Doctor);
            this.Name = "GirisForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_Nurse;
        private System.Windows.Forms.Button button_Hasta;
        private System.Windows.Forms.Label label_Hasta;
        private System.Windows.Forms.Label label_Doktor;
        private System.Windows.Forms.Label label_Sekreter;
        private System.Windows.Forms.Button button_Doctor;
        private System.Windows.Forms.Label label1;
    }
}

