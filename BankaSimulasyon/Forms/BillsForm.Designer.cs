namespace BankaSimulasyon.Forms
{
    partial class BillsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillsForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CmbDogalgaz = new System.Windows.Forms.ComboBox();
            this.CmbTelefon = new System.Windows.Forms.ComboBox();
            this.CmbTv = new System.Windows.Forms.ComboBox();
            this.CmbElektrik = new System.Windows.Forms.ComboBox();
            this.CmbSu = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnOdeme = new System.Windows.Forms.Button();
            this.TxtFaturaTutar = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtAbone = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "TV FATURASI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "SU FATURASI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "ELEKTRİK FATURASI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 355);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "DOĞALGAZ FATURASI";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "TELEFON FATURASI";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.CmbDogalgaz);
            this.groupBox1.Controls.Add(this.CmbTelefon);
            this.groupBox1.Controls.Add(this.CmbTv);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.CmbElektrik);
            this.groupBox1.Controls.Add(this.CmbSu);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(261, 452);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seçenekler";
            // 
            // CmbDogalgaz
            // 
            this.CmbDogalgaz.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbDogalgaz.FormattingEnabled = true;
            this.CmbDogalgaz.Location = new System.Drawing.Point(34, 377);
            this.CmbDogalgaz.Name = "CmbDogalgaz";
            this.CmbDogalgaz.Size = new System.Drawing.Size(178, 27);
            this.CmbDogalgaz.TabIndex = 6;
            this.CmbDogalgaz.SelectedIndexChanged += new System.EventHandler(this.CmbDogalgaz_SelectedIndexChanged);
            // 
            // CmbTelefon
            // 
            this.CmbTelefon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbTelefon.FormattingEnabled = true;
            this.CmbTelefon.Location = new System.Drawing.Point(34, 292);
            this.CmbTelefon.Name = "CmbTelefon";
            this.CmbTelefon.Size = new System.Drawing.Size(178, 27);
            this.CmbTelefon.TabIndex = 5;
            this.CmbTelefon.SelectedIndexChanged += new System.EventHandler(this.CmbTelefon_SelectedIndexChanged);
            // 
            // CmbTv
            // 
            this.CmbTv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbTv.FormattingEnabled = true;
            this.CmbTv.Location = new System.Drawing.Point(34, 214);
            this.CmbTv.Name = "CmbTv";
            this.CmbTv.Size = new System.Drawing.Size(178, 27);
            this.CmbTv.TabIndex = 3;
            this.CmbTv.SelectedIndexChanged += new System.EventHandler(this.CmbTv_SelectedIndexChanged);
            // 
            // CmbElektrik
            // 
            this.CmbElektrik.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbElektrik.FormattingEnabled = true;
            this.CmbElektrik.Location = new System.Drawing.Point(34, 139);
            this.CmbElektrik.Name = "CmbElektrik";
            this.CmbElektrik.Size = new System.Drawing.Size(178, 27);
            this.CmbElektrik.TabIndex = 2;
            this.CmbElektrik.SelectedIndexChanged += new System.EventHandler(this.CmbElektrik_SelectedIndexChanged);
            // 
            // CmbSu
            // 
            this.CmbSu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbSu.FormattingEnabled = true;
            this.CmbSu.Location = new System.Drawing.Point(34, 61);
            this.CmbSu.Name = "CmbSu";
            this.CmbSu.Size = new System.Drawing.Size(178, 27);
            this.CmbSu.TabIndex = 0;
            this.CmbSu.SelectedIndexChanged += new System.EventHandler(this.CmbSu_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.BtnOdeme);
            this.groupBox2.Controls.Add(this.TxtFaturaTutar);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.TxtAbone);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(286, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(545, 262);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ödeme";
            // 
            // BtnOdeme
            // 
            this.BtnOdeme.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnOdeme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOdeme.Location = new System.Drawing.Point(276, 181);
            this.BtnOdeme.Name = "BtnOdeme";
            this.BtnOdeme.Size = new System.Drawing.Size(110, 40);
            this.BtnOdeme.TabIndex = 3;
            this.BtnOdeme.Text = "Ödeme Yap";
            this.BtnOdeme.UseVisualStyleBackColor = true;
            this.BtnOdeme.Click += new System.EventHandler(this.BtnOdeme_Click);
            // 
            // TxtFaturaTutar
            // 
            this.TxtFaturaTutar.Location = new System.Drawing.Point(209, 139);
            this.TxtFaturaTutar.Name = "TxtFaturaTutar";
            this.TxtFaturaTutar.Size = new System.Drawing.Size(249, 26);
            this.TxtFaturaTutar.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(57, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 19);
            this.label7.TabIndex = 3;
            this.label7.Text = "Ödenecek Tutar:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 19);
            this.label6.TabIndex = 2;
            this.label6.Text = "Abone Numarası:";
            // 
            // TxtAbone
            // 
            this.TxtAbone.Location = new System.Drawing.Point(209, 86);
            this.TxtAbone.Name = "TxtAbone";
            this.TxtAbone.Size = new System.Drawing.Size(249, 26);
            this.TxtAbone.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(286, 280);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(544, 183);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Geçmiş Ödemeler";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(538, 158);
            this.dataGridView1.TabIndex = 0;
            // 
            // BillsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(99)))), ((int)(((byte)(130)))));
            this.ClientSize = new System.Drawing.Size(849, 476);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "BillsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Faturalar";
            this.Load += new System.EventHandler(this.BillsForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox CmbDogalgaz;
        private System.Windows.Forms.ComboBox CmbTelefon;
        private System.Windows.Forms.ComboBox CmbTv;
        private System.Windows.Forms.ComboBox CmbElektrik;
        private System.Windows.Forms.ComboBox CmbSu;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnOdeme;
        private System.Windows.Forms.TextBox TxtFaturaTutar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtAbone;
    }
}