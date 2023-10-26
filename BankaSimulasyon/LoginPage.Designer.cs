namespace BankaSimulasyon
{
    partial class LoginPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MskLoginHesap = new System.Windows.Forms.MaskedTextBox();
            this.TxtLoginSifre = new System.Windows.Forms.TextBox();
            this.BtnLoginGiris = new System.Windows.Forms.Button();
            this.LnkKayıtOl = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MskRgsTc = new System.Windows.Forms.MaskedTextBox();
            this.MskRgsTelefon = new System.Windows.Forms.MaskedTextBox();
            this.MskRgsHesap = new System.Windows.Forms.MaskedTextBox();
            this.TxtRgsAd = new System.Windows.Forms.TextBox();
            this.TxtRgsSoyad = new System.Windows.Forms.TextBox();
            this.TxtRgsSifre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.BtnKayitOl = new System.Windows.Forms.Button();
            this.LnkGirisYap = new System.Windows.Forms.LinkLabel();
            this.BtnHesapNo = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(498, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hesap No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(538, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre:";
            // 
            // MskLoginHesap
            // 
            this.MskLoginHesap.Location = new System.Drawing.Point(597, 140);
            this.MskLoginHesap.Mask = "0000000";
            this.MskLoginHesap.Name = "MskLoginHesap";
            this.MskLoginHesap.Size = new System.Drawing.Size(168, 26);
            this.MskLoginHesap.TabIndex = 2;
            this.MskLoginHesap.ValidatingType = typeof(int);
            // 
            // TxtLoginSifre
            // 
            this.TxtLoginSifre.Location = new System.Drawing.Point(597, 176);
            this.TxtLoginSifre.Name = "TxtLoginSifre";
            this.TxtLoginSifre.Size = new System.Drawing.Size(168, 26);
            this.TxtLoginSifre.TabIndex = 3;
            this.TxtLoginSifre.UseSystemPasswordChar = true;
            // 
            // BtnLoginGiris
            // 
            this.BtnLoginGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLoginGiris.Location = new System.Drawing.Point(597, 220);
            this.BtnLoginGiris.Name = "BtnLoginGiris";
            this.BtnLoginGiris.Size = new System.Drawing.Size(168, 40);
            this.BtnLoginGiris.TabIndex = 4;
            this.BtnLoginGiris.Text = "Giriş Yap";
            this.BtnLoginGiris.UseVisualStyleBackColor = true;
            this.BtnLoginGiris.Click += new System.EventHandler(this.BtnLoginGiris_Click);
            // 
            // LnkKayıtOl
            // 
            this.LnkKayıtOl.AutoSize = true;
            this.LnkKayıtOl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(90)))));
            this.LnkKayıtOl.DisabledLinkColor = System.Drawing.Color.White;
            this.LnkKayıtOl.LinkColor = System.Drawing.Color.White;
            this.LnkKayıtOl.Location = new System.Drawing.Point(639, 292);
            this.LnkKayıtOl.Name = "LnkKayıtOl";
            this.LnkKayıtOl.Size = new System.Drawing.Size(68, 19);
            this.LnkKayıtOl.TabIndex = 5;
            this.LnkKayıtOl.TabStop = true;
            this.LnkKayıtOl.Text = "Kayıt Ol";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(647, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // MskRgsTc
            // 
            this.MskRgsTc.Location = new System.Drawing.Point(128, 161);
            this.MskRgsTc.Mask = "00000000000";
            this.MskRgsTc.Name = "MskRgsTc";
            this.MskRgsTc.Size = new System.Drawing.Size(168, 26);
            this.MskRgsTc.TabIndex = 7;
            this.MskRgsTc.ValidatingType = typeof(int);
            // 
            // MskRgsTelefon
            // 
            this.MskRgsTelefon.Location = new System.Drawing.Point(128, 193);
            this.MskRgsTelefon.Mask = "(999) 000-0000";
            this.MskRgsTelefon.Name = "MskRgsTelefon";
            this.MskRgsTelefon.Size = new System.Drawing.Size(168, 26);
            this.MskRgsTelefon.TabIndex = 8;
            // 
            // MskRgsHesap
            // 
            this.MskRgsHesap.Enabled = false;
            this.MskRgsHesap.Location = new System.Drawing.Point(128, 225);
            this.MskRgsHesap.Mask = "0000000";
            this.MskRgsHesap.Name = "MskRgsHesap";
            this.MskRgsHesap.Size = new System.Drawing.Size(168, 26);
            this.MskRgsHesap.TabIndex = 9;
            this.MskRgsHesap.ValidatingType = typeof(int);
            // 
            // TxtRgsAd
            // 
            this.TxtRgsAd.Location = new System.Drawing.Point(128, 97);
            this.TxtRgsAd.Name = "TxtRgsAd";
            this.TxtRgsAd.Size = new System.Drawing.Size(168, 26);
            this.TxtRgsAd.TabIndex = 10;
            // 
            // TxtRgsSoyad
            // 
            this.TxtRgsSoyad.Location = new System.Drawing.Point(128, 129);
            this.TxtRgsSoyad.Name = "TxtRgsSoyad";
            this.TxtRgsSoyad.Size = new System.Drawing.Size(168, 26);
            this.TxtRgsSoyad.TabIndex = 11;
            // 
            // TxtRgsSifre
            // 
            this.TxtRgsSifre.Location = new System.Drawing.Point(128, 257);
            this.TxtRgsSifre.Name = "TxtRgsSifre";
            this.TxtRgsSifre.Size = new System.Drawing.Size(168, 26);
            this.TxtRgsSifre.TabIndex = 12;
            this.TxtRgsSifre.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 19);
            this.label3.TabIndex = 14;
            this.label3.Text = "Soyad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 19);
            this.label4.TabIndex = 13;
            this.label4.Text = "Ad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 19);
            this.label5.TabIndex = 15;
            this.label5.Text = "TC Kimlik:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 19);
            this.label6.TabIndex = 16;
            this.label6.Text = "Telefon:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 232);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 19);
            this.label7.TabIndex = 17;
            this.label7.Text = "Hesap No:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(68, 257);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 19);
            this.label8.TabIndex = 18;
            this.label8.Text = "Şifre:";
            // 
            // BtnKayitOl
            // 
            this.BtnKayitOl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnKayitOl.Location = new System.Drawing.Point(128, 289);
            this.BtnKayitOl.Name = "BtnKayitOl";
            this.BtnKayitOl.Size = new System.Drawing.Size(168, 40);
            this.BtnKayitOl.TabIndex = 19;
            this.BtnKayitOl.Text = "Kayıt Ol";
            this.BtnKayitOl.UseVisualStyleBackColor = true;
            this.BtnKayitOl.Click += new System.EventHandler(this.BtnKayitOl_Click);
            // 
            // LnkGirisYap
            // 
            this.LnkGirisYap.AutoSize = true;
            this.LnkGirisYap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(90)))));
            this.LnkGirisYap.DisabledLinkColor = System.Drawing.Color.White;
            this.LnkGirisYap.LinkColor = System.Drawing.Color.White;
            this.LnkGirisYap.Location = new System.Drawing.Point(174, 361);
            this.LnkGirisYap.Name = "LnkGirisYap";
            this.LnkGirisYap.Size = new System.Drawing.Size(76, 19);
            this.LnkGirisYap.TabIndex = 20;
            this.LnkGirisYap.TabStop = true;
            this.LnkGirisYap.Text = "Giriş Yap";
            // 
            // BtnHesapNo
            // 
            this.BtnHesapNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHesapNo.Location = new System.Drawing.Point(302, 225);
            this.BtnHesapNo.Name = "BtnHesapNo";
            this.BtnHesapNo.Size = new System.Drawing.Size(31, 26);
            this.BtnHesapNo.TabIndex = 21;
            this.BtnHesapNo.Text = "...";
            this.BtnHesapNo.UseVisualStyleBackColor = true;
            this.BtnHesapNo.Click += new System.EventHandler(this.BtnHesapNo_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(178, 29);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(60, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(90)))));
            this.ClientSize = new System.Drawing.Size(809, 389);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.BtnHesapNo);
            this.Controls.Add(this.LnkGirisYap);
            this.Controls.Add(this.BtnKayitOl);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtRgsSifre);
            this.Controls.Add(this.TxtRgsSoyad);
            this.Controls.Add(this.TxtRgsAd);
            this.Controls.Add(this.MskRgsHesap);
            this.Controls.Add(this.MskRgsTelefon);
            this.Controls.Add(this.MskRgsTc);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LnkKayıtOl);
            this.Controls.Add(this.BtnLoginGiris);
            this.Controls.Add(this.TxtLoginSifre);
            this.Controls.Add(this.MskLoginHesap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "LoginPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AuroraBank";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox MskLoginHesap;
        private System.Windows.Forms.TextBox TxtLoginSifre;
        private System.Windows.Forms.Button BtnLoginGiris;
        private System.Windows.Forms.LinkLabel LnkKayıtOl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MaskedTextBox MskRgsTc;
        private System.Windows.Forms.MaskedTextBox MskRgsTelefon;
        private System.Windows.Forms.MaskedTextBox MskRgsHesap;
        private System.Windows.Forms.TextBox TxtRgsAd;
        private System.Windows.Forms.TextBox TxtRgsSoyad;
        private System.Windows.Forms.TextBox TxtRgsSifre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BtnKayitOl;
        private System.Windows.Forms.LinkLabel LnkGirisYap;
        private System.Windows.Forms.Button BtnHesapNo;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

