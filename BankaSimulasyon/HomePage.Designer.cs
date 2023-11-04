namespace BankaSimulasyon
{
    partial class HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.PanelLogo = new System.Windows.Forms.Panel();
            this.HomeLabel = new System.Windows.Forms.Label();
            this.PanelTitleBar = new System.Windows.Forms.Panel();
            this.LblTitle = new System.Windows.Forms.Label();
            this.PanelDesktopPanel = new System.Windows.Forms.Panel();
            this.PanelInfoBar = new System.Windows.Forms.Panel();
            this.LblAdSoyad = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.LblTelefon = new System.Windows.Forms.Label();
            this.LblTcNo = new System.Windows.Forms.Label();
            this.LblHesapNo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BtnAllClose = new System.Windows.Forms.Button();
            this.BtnAyarlar = new System.Windows.Forms.Button();
            this.BtnTransfer = new System.Windows.Forms.Button();
            this.BtnFatura = new System.Windows.Forms.Button();
            this.BtnCekim = new System.Windows.Forms.Button();
            this.BtnHesap = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.PanelLogo.SuspendLayout();
            this.PanelTitleBar.SuspendLayout();
            this.PanelDesktopPanel.SuspendLayout();
            this.PanelInfoBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(90)))));
            this.panelMenu.Controls.Add(this.BtnAyarlar);
            this.panelMenu.Controls.Add(this.BtnTransfer);
            this.panelMenu.Controls.Add(this.BtnFatura);
            this.panelMenu.Controls.Add(this.BtnCekim);
            this.panelMenu.Controls.Add(this.BtnHesap);
            this.panelMenu.Controls.Add(this.PanelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(225, 611);
            this.panelMenu.TabIndex = 0;
            // 
            // PanelLogo
            // 
            this.PanelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.PanelLogo.Controls.Add(this.HomeLabel);
            this.PanelLogo.Controls.Add(this.pictureBox1);
            this.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelLogo.Location = new System.Drawing.Point(0, 0);
            this.PanelLogo.Name = "PanelLogo";
            this.PanelLogo.Size = new System.Drawing.Size(225, 100);
            this.PanelLogo.TabIndex = 27;
            // 
            // HomeLabel
            // 
            this.HomeLabel.AutoSize = true;
            this.HomeLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HomeLabel.Font = new System.Drawing.Font("Doubleplus", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.HomeLabel.Location = new System.Drawing.Point(89, 21);
            this.HomeLabel.Name = "HomeLabel";
            this.HomeLabel.Size = new System.Drawing.Size(108, 58);
            this.HomeLabel.TabIndex = 8;
            this.HomeLabel.Text = "AURORA\r\nBANK";
            this.HomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.HomeLabel.Click += new System.EventHandler(this.HomeLabel_Click);
            // 
            // PanelTitleBar
            // 
            this.PanelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(90)))));
            this.PanelTitleBar.Controls.Add(this.BtnAllClose);
            this.PanelTitleBar.Controls.Add(this.LblTitle);
            this.PanelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTitleBar.Location = new System.Drawing.Point(225, 0);
            this.PanelTitleBar.Name = "PanelTitleBar";
            this.PanelTitleBar.Size = new System.Drawing.Size(859, 100);
            this.PanelTitleBar.TabIndex = 27;
            this.PanelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelTitleBar_MouseDown);
            // 
            // LblTitle
            // 
            this.LblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblTitle.Location = new System.Drawing.Point(331, 35);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(170, 32);
            this.LblTitle.TabIndex = 9;
            this.LblTitle.Text = "Hoşgeldiniz";
            this.LblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PanelDesktopPanel
            // 
            this.PanelDesktopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(101)))), ((int)(((byte)(132)))));
            this.PanelDesktopPanel.Controls.Add(this.PanelInfoBar);
            this.PanelDesktopPanel.Controls.Add(this.label1);
            this.PanelDesktopPanel.Controls.Add(this.pictureBox2);
            this.PanelDesktopPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelDesktopPanel.Location = new System.Drawing.Point(225, 100);
            this.PanelDesktopPanel.Name = "PanelDesktopPanel";
            this.PanelDesktopPanel.Size = new System.Drawing.Size(859, 511);
            this.PanelDesktopPanel.TabIndex = 28;
            // 
            // PanelInfoBar
            // 
            this.PanelInfoBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(90)))));
            this.PanelInfoBar.Controls.Add(this.LblAdSoyad);
            this.PanelInfoBar.Controls.Add(this.label7);
            this.PanelInfoBar.Controls.Add(this.LblTelefon);
            this.PanelInfoBar.Controls.Add(this.LblTcNo);
            this.PanelInfoBar.Controls.Add(this.LblHesapNo);
            this.PanelInfoBar.Controls.Add(this.label4);
            this.PanelInfoBar.Controls.Add(this.label3);
            this.PanelInfoBar.Controls.Add(this.label2);
            this.PanelInfoBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelInfoBar.Location = new System.Drawing.Point(0, 486);
            this.PanelInfoBar.Name = "PanelInfoBar";
            this.PanelInfoBar.Size = new System.Drawing.Size(859, 25);
            this.PanelInfoBar.TabIndex = 32;
            // 
            // LblAdSoyad
            // 
            this.LblAdSoyad.AutoSize = true;
            this.LblAdSoyad.Location = new System.Drawing.Point(89, 4);
            this.LblAdSoyad.Name = "LblAdSoyad";
            this.LblAdSoyad.Size = new System.Drawing.Size(73, 19);
            this.LblAdSoyad.TabIndex = 7;
            this.LblAdSoyad.Text = "Null Null";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 19);
            this.label7.TabIndex = 6;
            this.label7.Text = "Ad Soyad:";
            // 
            // LblTelefon
            // 
            this.LblTelefon.AutoSize = true;
            this.LblTelefon.Location = new System.Drawing.Point(720, 4);
            this.LblTelefon.Name = "LblTelefon";
            this.LblTelefon.Size = new System.Drawing.Size(72, 19);
            this.LblTelefon.TabIndex = 5;
            this.LblTelefon.Text = "0000000";
            // 
            // LblTcNo
            // 
            this.LblTcNo.AutoSize = true;
            this.LblTcNo.Location = new System.Drawing.Point(519, 4);
            this.LblTcNo.Name = "LblTcNo";
            this.LblTcNo.Size = new System.Drawing.Size(72, 19);
            this.LblTcNo.TabIndex = 4;
            this.LblTcNo.Text = "0000000";
            // 
            // LblHesapNo
            // 
            this.LblHesapNo.AutoSize = true;
            this.LblHesapNo.Location = new System.Drawing.Point(364, 4);
            this.LblHesapNo.Name = "LblHesapNo";
            this.LblHesapNo.Size = new System.Drawing.Size(72, 19);
            this.LblHesapNo.TabIndex = 3;
            this.LblHesapNo.Text = "0000000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(652, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Telefon:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(460, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "TC No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(278, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Hesap No:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(291, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 37);
            this.label1.TabIndex = 10;
            this.label1.Text = "AURORA BANK";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::BankaSimulasyon.Properties.Resources.Logo;
            this.pictureBox2.Location = new System.Drawing.Point(377, 160);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(78, 74);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // BtnAllClose
            // 
            this.BtnAllClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAllClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAllClose.FlatAppearance.BorderSize = 0;
            this.BtnAllClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAllClose.Image = global::BankaSimulasyon.Properties.Resources.kapatbeyaz;
            this.BtnAllClose.Location = new System.Drawing.Point(831, 3);
            this.BtnAllClose.Name = "BtnAllClose";
            this.BtnAllClose.Size = new System.Drawing.Size(23, 23);
            this.BtnAllClose.TabIndex = 11;
            this.BtnAllClose.UseVisualStyleBackColor = true;
            this.BtnAllClose.Click += new System.EventHandler(this.BtnAllClose_Click);
            // 
            // BtnAyarlar
            // 
            this.BtnAyarlar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAyarlar.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnAyarlar.FlatAppearance.BorderSize = 0;
            this.BtnAyarlar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAyarlar.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnAyarlar.Image = global::BankaSimulasyon.Properties.Resources.ayarlar;
            this.BtnAyarlar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAyarlar.Location = new System.Drawing.Point(0, 488);
            this.BtnAyarlar.Name = "BtnAyarlar";
            this.BtnAyarlar.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.BtnAyarlar.Size = new System.Drawing.Size(225, 97);
            this.BtnAyarlar.TabIndex = 32;
            this.BtnAyarlar.Text = "  Hesap Ayarları";
            this.BtnAyarlar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAyarlar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAyarlar.UseVisualStyleBackColor = true;
            this.BtnAyarlar.Click += new System.EventHandler(this.BtnAyarlar_Click);
            // 
            // BtnTransfer
            // 
            this.BtnTransfer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnTransfer.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnTransfer.FlatAppearance.BorderSize = 0;
            this.BtnTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTransfer.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnTransfer.Image = global::BankaSimulasyon.Properties.Resources.transferbeyaz;
            this.BtnTransfer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnTransfer.Location = new System.Drawing.Point(0, 391);
            this.BtnTransfer.Name = "BtnTransfer";
            this.BtnTransfer.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.BtnTransfer.Size = new System.Drawing.Size(225, 97);
            this.BtnTransfer.TabIndex = 31;
            this.BtnTransfer.Text = "  Para Transferi";
            this.BtnTransfer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnTransfer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnTransfer.UseVisualStyleBackColor = true;
            this.BtnTransfer.Click += new System.EventHandler(this.BtnTransfer_Click);
            // 
            // BtnFatura
            // 
            this.BtnFatura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnFatura.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnFatura.FlatAppearance.BorderSize = 0;
            this.BtnFatura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFatura.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnFatura.Image = global::BankaSimulasyon.Properties.Resources.faturabeyaz;
            this.BtnFatura.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnFatura.Location = new System.Drawing.Point(0, 294);
            this.BtnFatura.Name = "BtnFatura";
            this.BtnFatura.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.BtnFatura.Size = new System.Drawing.Size(225, 97);
            this.BtnFatura.TabIndex = 30;
            this.BtnFatura.Text = "  Faturalar";
            this.BtnFatura.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnFatura.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnFatura.UseVisualStyleBackColor = true;
            this.BtnFatura.Click += new System.EventHandler(this.BtnFatura_Click);
            // 
            // BtnCekim
            // 
            this.BtnCekim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCekim.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnCekim.FlatAppearance.BorderSize = 0;
            this.BtnCekim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCekim.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnCekim.Image = global::BankaSimulasyon.Properties.Resources.paracekmebeyaz;
            this.BtnCekim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCekim.Location = new System.Drawing.Point(0, 197);
            this.BtnCekim.Name = "BtnCekim";
            this.BtnCekim.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.BtnCekim.Size = new System.Drawing.Size(225, 97);
            this.BtnCekim.TabIndex = 29;
            this.BtnCekim.Text = "  Para \r\nÇekme-Yatırma";
            this.BtnCekim.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCekim.UseVisualStyleBackColor = true;
            this.BtnCekim.Click += new System.EventHandler(this.BtnCekim_Click);
            // 
            // BtnHesap
            // 
            this.BtnHesap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnHesap.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnHesap.FlatAppearance.BorderSize = 0;
            this.BtnHesap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHesap.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnHesap.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnHesap.Image = global::BankaSimulasyon.Properties.Resources.hesappbeyaz;
            this.BtnHesap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnHesap.Location = new System.Drawing.Point(0, 100);
            this.BtnHesap.Name = "BtnHesap";
            this.BtnHesap.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.BtnHesap.Size = new System.Drawing.Size(225, 97);
            this.BtnHesap.TabIndex = 28;
            this.BtnHesap.Text = "  Hesap Dökümü";
            this.BtnHesap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnHesap.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnHesap.UseVisualStyleBackColor = true;
            this.BtnHesap.Click += new System.EventHandler(this.BtnHesap_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1084, 611);
            this.Controls.Add(this.PanelDesktopPanel);
            this.Controls.Add(this.PanelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anasayfa";
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.panelMenu.ResumeLayout(false);
            this.PanelLogo.ResumeLayout(false);
            this.PanelLogo.PerformLayout();
            this.PanelTitleBar.ResumeLayout(false);
            this.PanelTitleBar.PerformLayout();
            this.PanelDesktopPanel.ResumeLayout(false);
            this.PanelDesktopPanel.PerformLayout();
            this.PanelInfoBar.ResumeLayout(false);
            this.PanelInfoBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel PanelLogo;
        private System.Windows.Forms.Label HomeLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnHesap;
        private System.Windows.Forms.Button BtnTransfer;
        private System.Windows.Forms.Button BtnFatura;
        private System.Windows.Forms.Button BtnCekim;
        private System.Windows.Forms.Panel PanelTitleBar;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Panel PanelDesktopPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button BtnAllClose;
        private System.Windows.Forms.Panel PanelInfoBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblTelefon;
        private System.Windows.Forms.Label LblTcNo;
        private System.Windows.Forms.Label LblHesapNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblAdSoyad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnAyarlar;
    }
}