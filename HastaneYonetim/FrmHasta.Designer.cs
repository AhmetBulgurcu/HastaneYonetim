namespace HastaneYonetim
{
    partial class FrmHasta
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
            this.label1 = new System.Windows.Forms.Label();
            this.label_TcKimlikNo = new System.Windows.Forms.Label();
            this.label_Sifre = new System.Windows.Forms.Label();
            this.textBox_Sifre = new System.Windows.Forms.TextBox();
            this.maskedTextBox_Tc = new System.Windows.Forms.MaskedTextBox();
            this.linkLabel_ÜyeOl = new System.Windows.Forms.LinkLabel();
            this.button_Giris = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Playball", 24F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(235, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hasta Giriş Paneli";
            // 
            // label_TcKimlikNo
            // 
            this.label_TcKimlikNo.AutoSize = true;
            this.label_TcKimlikNo.Font = new System.Drawing.Font("Playball", 24F, System.Drawing.FontStyle.Bold);
            this.label_TcKimlikNo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_TcKimlikNo.Location = new System.Drawing.Point(120, 125);
            this.label_TcKimlikNo.Name = "label_TcKimlikNo";
            this.label_TcKimlikNo.Size = new System.Drawing.Size(193, 40);
            this.label_TcKimlikNo.TabIndex = 1;
            this.label_TcKimlikNo.Text = "Tc Kimlik No:";
            // 
            // label_Sifre
            // 
            this.label_Sifre.AutoSize = true;
            this.label_Sifre.Font = new System.Drawing.Font("Playball", 24F, System.Drawing.FontStyle.Bold);
            this.label_Sifre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_Sifre.Location = new System.Drawing.Point(120, 180);
            this.label_Sifre.Name = "label_Sifre";
            this.label_Sifre.Size = new System.Drawing.Size(98, 40);
            this.label_Sifre.TabIndex = 2;
            this.label_Sifre.Text = "Şifre:";
            // 
            // textBox_Sifre
            // 
            this.textBox_Sifre.Font = new System.Drawing.Font("Playball", 24F, System.Drawing.FontStyle.Bold);
            this.textBox_Sifre.Location = new System.Drawing.Point(333, 177);
            this.textBox_Sifre.Name = "textBox_Sifre";
            this.textBox_Sifre.Size = new System.Drawing.Size(124, 47);
            this.textBox_Sifre.TabIndex = 3;
            this.toolTip1.SetToolTip(this.textBox_Sifre, "1453 Girersen Güvenlik Çağırılacak");
            // 
            // maskedTextBox_Tc
            // 
            this.maskedTextBox_Tc.Font = new System.Drawing.Font("Playball", 24F, System.Drawing.FontStyle.Bold);
            this.maskedTextBox_Tc.Location = new System.Drawing.Point(333, 118);
            this.maskedTextBox_Tc.Name = "maskedTextBox_Tc";
            this.maskedTextBox_Tc.Size = new System.Drawing.Size(124, 47);
            this.maskedTextBox_Tc.TabIndex = 4;
            this.toolTip1.SetToolTip(this.maskedTextBox_Tc, "Önce Türk Olman Lazım. \r\nTürkiyeliler İhbar Edilecektir.");
            // 
            // linkLabel_ÜyeOl
            // 
            this.linkLabel_ÜyeOl.AutoSize = true;
            this.linkLabel_ÜyeOl.Location = new System.Drawing.Point(472, 207);
            this.linkLabel_ÜyeOl.Name = "linkLabel_ÜyeOl";
            this.linkLabel_ÜyeOl.Size = new System.Drawing.Size(39, 13);
            this.linkLabel_ÜyeOl.TabIndex = 5;
            this.linkLabel_ÜyeOl.TabStop = true;
            this.linkLabel_ÜyeOl.Text = "Üye Ol";
            // 
            // button_Giris
            // 
            this.button_Giris.BackColor = System.Drawing.Color.MediumPurple;
            this.button_Giris.Font = new System.Drawing.Font("Playball", 24F, System.Drawing.FontStyle.Bold);
            this.button_Giris.ForeColor = System.Drawing.Color.Black;
            this.button_Giris.Location = new System.Drawing.Point(333, 246);
            this.button_Giris.Name = "button_Giris";
            this.button_Giris.Size = new System.Drawing.Size(124, 47);
            this.button_Giris.TabIndex = 6;
            this.button_Giris.Text = "Giriş";
            this.toolTip1.SetToolTip(this.button_Giris, "Bunu Sen İstedin\r\n\r\n");
            this.button_Giris.UseVisualStyleBackColor = false;
            this.button_Giris.Click += new System.EventHandler(this.button_Giris_Click);
            // 
            // FrmHasta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_Giris);
            this.Controls.Add(this.linkLabel_ÜyeOl);
            this.Controls.Add(this.maskedTextBox_Tc);
            this.Controls.Add(this.textBox_Sifre);
            this.Controls.Add(this.label_Sifre);
            this.Controls.Add(this.label_TcKimlikNo);
            this.Controls.Add(this.label1);
            this.Name = "FrmHasta";
            this.Text = "FrmHasta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_TcKimlikNo;
        private System.Windows.Forms.Label label_Sifre;
        private System.Windows.Forms.TextBox textBox_Sifre;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_Tc;
        private System.Windows.Forms.LinkLabel linkLabel_ÜyeOl;
        private System.Windows.Forms.Button button_Giris;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}