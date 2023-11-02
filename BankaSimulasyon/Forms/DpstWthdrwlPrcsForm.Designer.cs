namespace BankaSimulasyon.Forms
{
    partial class DpstWthdrwlPrcsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DpstWthdrwlPrcsForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnIslem = new System.Windows.Forms.Button();
            this.TxtTutarHesap = new System.Windows.Forms.TextBox();
            this.RadioYatir = new System.Windows.Forms.RadioButton();
            this.RadioCek = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LblBorc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.TxtTutarKredi = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.BtnIslem);
            this.groupBox1.Controls.Add(this.TxtTutarHesap);
            this.groupBox1.Controls.Add(this.RadioYatir);
            this.groupBox1.Controls.Add(this.RadioCek);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 450);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Para Çekme - Yatırma İşlemleri";
            // 
            // BtnIslem
            // 
            this.BtnIslem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnIslem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIslem.Location = new System.Drawing.Point(136, 301);
            this.BtnIslem.Name = "BtnIslem";
            this.BtnIslem.Size = new System.Drawing.Size(110, 40);
            this.BtnIslem.TabIndex = 4;
            this.BtnIslem.Text = "Tamamla";
            this.BtnIslem.UseVisualStyleBackColor = true;
            this.BtnIslem.Click += new System.EventHandler(this.BtnIslem_Click);
            // 
            // TxtTutarHesap
            // 
            this.TxtTutarHesap.Location = new System.Drawing.Point(86, 215);
            this.TxtTutarHesap.Name = "TxtTutarHesap";
            this.TxtTutarHesap.Size = new System.Drawing.Size(218, 26);
            this.TxtTutarHesap.TabIndex = 2;
            // 
            // RadioYatir
            // 
            this.RadioYatir.AutoSize = true;
            this.RadioYatir.Location = new System.Drawing.Point(205, 135);
            this.RadioYatir.Name = "RadioYatir";
            this.RadioYatir.Size = new System.Drawing.Size(99, 23);
            this.RadioYatir.TabIndex = 1;
            this.RadioYatir.TabStop = true;
            this.RadioYatir.Text = "Para Yatır";
            this.RadioYatir.UseVisualStyleBackColor = true;
            this.RadioYatir.CheckedChanged += new System.EventHandler(this.RadioYatir_CheckedChanged);
            // 
            // RadioCek
            // 
            this.RadioCek.AutoSize = true;
            this.RadioCek.Location = new System.Drawing.Point(86, 135);
            this.RadioCek.Name = "RadioCek";
            this.RadioCek.Size = new System.Drawing.Size(96, 23);
            this.RadioCek.TabIndex = 0;
            this.RadioCek.TabStop = true;
            this.RadioCek.Text = "Para Çek";
            this.RadioCek.UseVisualStyleBackColor = true;
            this.RadioCek.CheckedChanged += new System.EventHandler(this.RadioCek_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.LblBorc);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.TxtTutarKredi);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(435, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(400, 450);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kredi Kartı Borç Ödeme";
            // 
            // LblBorc
            // 
            this.LblBorc.AutoSize = true;
            this.LblBorc.Location = new System.Drawing.Point(203, 98);
            this.LblBorc.Name = "LblBorc";
            this.LblBorc.Size = new System.Drawing.Size(54, 19);
            this.LblBorc.TabIndex = 8;
            this.LblBorc.Text = "0.00 ₺";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Güncel Borç:";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(150, 301);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 40);
            this.button1.TabIndex = 6;
            this.button1.Text = "Tamamla";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // TxtTutarKredi
            // 
            this.TxtTutarKredi.Location = new System.Drawing.Point(96, 215);
            this.TxtTutarKredi.Name = "TxtTutarKredi";
            this.TxtTutarKredi.Size = new System.Drawing.Size(218, 26);
            this.TxtTutarKredi.TabIndex = 5;
            // 
            // DpstWthdrwlPrcsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(115)))), ((int)(((byte)(158)))));
            this.ClientSize = new System.Drawing.Size(849, 476);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "DpstWthdrwlPrcsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Para Yatırma Çekme";
            this.Load += new System.EventHandler(this.DpstWthdrwlPrcsForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton RadioYatir;
        private System.Windows.Forms.RadioButton RadioCek;
        private System.Windows.Forms.TextBox TxtTutarHesap;
        private System.Windows.Forms.Button BtnIslem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TxtTutarKredi;
        private System.Windows.Forms.Label LblBorc;
        private System.Windows.Forms.Label label1;
    }
}