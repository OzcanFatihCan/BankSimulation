namespace BankaSimulasyon.Forms
{
    partial class TransferForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransferForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnGonder = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtTutar = new System.Windows.Forms.TextBox();
            this.MskHesapNo = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.LblTel = new System.Windows.Forms.Label();
            this.LblTc = new System.Windows.Forms.Label();
            this.LblHesap = new System.Windows.Forms.Label();
            this.LblAdSoyad = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnGonder);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.TxtTutar);
            this.groupBox1.Controls.Add(this.MskHesapNo);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(345, 246);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Size = new System.Drawing.Size(537, 310);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Havale";
            // 
            // BtnGonder
            // 
            this.BtnGonder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGonder.ForeColor = System.Drawing.Color.White;
            this.BtnGonder.Location = new System.Drawing.Point(197, 178);
            this.BtnGonder.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.BtnGonder.Name = "BtnGonder";
            this.BtnGonder.Size = new System.Drawing.Size(280, 56);
            this.BtnGonder.TabIndex = 6;
            this.BtnGonder.Text = "Gönder";
            this.BtnGonder.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(97, 115);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 19);
            this.label10.TabIndex = 5;
            this.label10.Text = "Tutar:";
            // 
            // TxtTutar
            // 
            this.TxtTutar.Location = new System.Drawing.Point(197, 111);
            this.TxtTutar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.TxtTutar.Name = "TxtTutar";
            this.TxtTutar.Size = new System.Drawing.Size(277, 26);
            this.TxtTutar.TabIndex = 4;
            // 
            // MskHesapNo
            // 
            this.MskHesapNo.Location = new System.Drawing.Point(197, 45);
            this.MskHesapNo.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MskHesapNo.Mask = "0000000";
            this.MskHesapNo.Name = "MskHesapNo";
            this.MskHesapNo.Size = new System.Drawing.Size(277, 26);
            this.MskHesapNo.TabIndex = 3;
            this.MskHesapNo.ValidatingType = typeof(int);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(37, 50);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 19);
            this.label9.TabIndex = 2;
            this.label9.Text = "Hesap No:";
            // 
            // LblTel
            // 
            this.LblTel.AutoSize = true;
            this.LblTel.ForeColor = System.Drawing.Color.Black;
            this.LblTel.Location = new System.Drawing.Point(595, 208);
            this.LblTel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblTel.Name = "LblTel";
            this.LblTel.Size = new System.Drawing.Size(39, 19);
            this.LblTel.TabIndex = 53;
            this.LblTel.Text = "Null";
            // 
            // LblTc
            // 
            this.LblTc.AutoSize = true;
            this.LblTc.ForeColor = System.Drawing.Color.Black;
            this.LblTc.Location = new System.Drawing.Point(595, 149);
            this.LblTc.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblTc.Name = "LblTc";
            this.LblTc.Size = new System.Drawing.Size(39, 19);
            this.LblTc.TabIndex = 52;
            this.LblTc.Text = "Null";
            // 
            // LblHesap
            // 
            this.LblHesap.AutoSize = true;
            this.LblHesap.ForeColor = System.Drawing.Color.Black;
            this.LblHesap.Location = new System.Drawing.Point(595, 83);
            this.LblHesap.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblHesap.Name = "LblHesap";
            this.LblHesap.Size = new System.Drawing.Size(39, 19);
            this.LblHesap.TabIndex = 51;
            this.LblHesap.Text = "Null";
            // 
            // LblAdSoyad
            // 
            this.LblAdSoyad.AutoSize = true;
            this.LblAdSoyad.ForeColor = System.Drawing.Color.Black;
            this.LblAdSoyad.Location = new System.Drawing.Point(595, 13);
            this.LblAdSoyad.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblAdSoyad.Name = "LblAdSoyad";
            this.LblAdSoyad.Size = new System.Drawing.Size(39, 19);
            this.LblAdSoyad.TabIndex = 50;
            this.LblAdSoyad.Text = "Null";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(467, 208);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 19);
            this.label4.TabIndex = 49;
            this.label4.Text = "Telefon:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(438, 149);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 19);
            this.label3.TabIndex = 48;
            this.label3.Text = "TC Kimlik:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(435, 83);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 19);
            this.label2.TabIndex = 47;
            this.label2.Text = "Hesap No:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(437, 13);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 19);
            this.label5.TabIndex = 46;
            this.label5.Text = "Ad Soyad:";
            // 
            // TransferForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1014, 602);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LblTel);
            this.Controls.Add(this.LblTc);
            this.Controls.Add(this.LblHesap);
            this.Controls.Add(this.LblAdSoyad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "TransferForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transferler";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnGonder;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtTutar;
        private System.Windows.Forms.MaskedTextBox MskHesapNo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label LblTel;
        private System.Windows.Forms.Label LblTc;
        private System.Windows.Forms.Label LblHesap;
        private System.Windows.Forms.Label LblAdSoyad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
    }
}