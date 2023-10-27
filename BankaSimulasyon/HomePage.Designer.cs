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
            this.BtnTransfer = new System.Windows.Forms.Button();
            this.BtnFatura = new System.Windows.Forms.Button();
            this.BtnCekim = new System.Windows.Forms.Button();
            this.BtnHesap = new System.Windows.Forms.Button();
            this.PanelLogo = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PanelTitleBar = new System.Windows.Forms.Panel();
            this.LblTitle = new System.Windows.Forms.Label();
            this.PanelDesktopPanel = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.PanelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PanelTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(90)))));
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
            // BtnTransfer
            // 
            this.BtnTransfer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnTransfer.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnTransfer.FlatAppearance.BorderSize = 0;
            this.BtnTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTransfer.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnTransfer.Image = global::BankaSimulasyon.Properties.Resources.transferbeyaz;
            this.BtnTransfer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnTransfer.Location = new System.Drawing.Point(0, 370);
            this.BtnTransfer.Name = "BtnTransfer";
            this.BtnTransfer.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.BtnTransfer.Size = new System.Drawing.Size(225, 90);
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
            this.BtnFatura.Location = new System.Drawing.Point(0, 280);
            this.BtnFatura.Name = "BtnFatura";
            this.BtnFatura.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.BtnFatura.Size = new System.Drawing.Size(225, 90);
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
            this.BtnCekim.Location = new System.Drawing.Point(0, 190);
            this.BtnCekim.Name = "BtnCekim";
            this.BtnCekim.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.BtnCekim.Size = new System.Drawing.Size(225, 90);
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
            this.BtnHesap.Size = new System.Drawing.Size(225, 90);
            this.BtnHesap.TabIndex = 28;
            this.BtnHesap.Text = "  Hesap Dökümü";
            this.BtnHesap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnHesap.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnHesap.UseVisualStyleBackColor = true;
            this.BtnHesap.Click += new System.EventHandler(this.BtnHesap_Click);
            // 
            // PanelLogo
            // 
            this.PanelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.PanelLogo.Controls.Add(this.label5);
            this.PanelLogo.Controls.Add(this.pictureBox1);
            this.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelLogo.Location = new System.Drawing.Point(0, 0);
            this.PanelLogo.Name = "PanelLogo";
            this.PanelLogo.Size = new System.Drawing.Size(225, 100);
            this.PanelLogo.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Doubleplus", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(89, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 58);
            this.label5.TabIndex = 8;
            this.label5.Text = "AURORA\r\nBANK";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // PanelTitleBar
            // 
            this.PanelTitleBar.BackColor = System.Drawing.Color.SlateGray;
            this.PanelTitleBar.Controls.Add(this.LblTitle);
            this.PanelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTitleBar.Location = new System.Drawing.Point(225, 0);
            this.PanelTitleBar.Name = "PanelTitleBar";
            this.PanelTitleBar.Size = new System.Drawing.Size(859, 100);
            this.PanelTitleBar.TabIndex = 27;
            // 
            // LblTitle
            // 
            this.LblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblTitle.Location = new System.Drawing.Point(319, 35);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(216, 32);
            this.LblTitle.TabIndex = 9;
            this.LblTitle.Text = "Hesap Dökümü";
            this.LblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PanelDesktopPanel
            // 
            this.PanelDesktopPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelDesktopPanel.Location = new System.Drawing.Point(225, 100);
            this.PanelDesktopPanel.Name = "PanelDesktopPanel";
            this.PanelDesktopPanel.Size = new System.Drawing.Size(859, 511);
            this.PanelDesktopPanel.TabIndex = 28;
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PanelTitleBar.ResumeLayout(false);
            this.PanelTitleBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel PanelLogo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnHesap;
        private System.Windows.Forms.Button BtnTransfer;
        private System.Windows.Forms.Button BtnFatura;
        private System.Windows.Forms.Button BtnCekim;
        private System.Windows.Forms.Panel PanelTitleBar;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Panel PanelDesktopPanel;
    }
}