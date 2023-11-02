using EntityLayer;
using LogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankaSimulasyon.Forms
{
    public partial class TransferForm : Form
    {
        public string hesapNo;
        public TransferForm(string hesap)
        {
            InitializeComponent();
            this.hesapNo = hesap;
            dataGridView1.ForeColor = Color.Black;
        }

        private void TransferForm_Load(object sender, EventArgs e)
        {
            RegisterPayee();
        }

        void RegisterPayee()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            List<EntityMovement> HistoryLog = LogicBank.LLMoneyTransferHistory(hesapNo);
            dataGridView1.Columns.Add("AliciHesapNo", "Alıcı Hesap No");
            dataGridView1.Columns.Add("Alici", "Alıcı");          
            dataGridView1.Columns.Add("Tutar", "Tutar");
            foreach (var item in HistoryLog)
            {
                dataGridView1.Rows.Add(item.Alici,item.Aliciisim,item.Tutar + " ₺");
            }
        }
       
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["AliciHesapNo"].Index)
            {
                object value = dataGridView1.Rows[e.RowIndex].Cells["AliciHesapNo"].Value;
                if (value != null)
                {
                    string alici = value.ToString();
                    TxtRgsHesapNo.Text = alici;
                }
                else
                {
                    TxtRgsHesapNo.Text = "Hesap numarası seçiniz.";
                }
            }

        }
        
        private void BtnRgsHavale_Click(object sender, EventArgs e)
        {
            EntityTransfer ent = new EntityTransfer();
            if (double.TryParse(TxtRgsTutar.Text,out double tutarrgs))
            {
                ent.Gonderen = hesapNo;
                ent.Alici = TxtRgsHesapNo.Text;
                ent.Tutar = tutarrgs;
                int result = LogicBank.LLTransferMoney(ent);
                if (result > 0)
                {
                    MessageBox.Show("Para transferi başarıyla tamamlandı!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RegisterPayee();
                    return;
                }
                if (result==0)
                {
                    MessageBox.Show("Para transferi sırasında bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (result==-2)
                {
                    MessageBox.Show("Lütfen hesap numarasını kontrol ediniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (result == -3)
                {
                    MessageBox.Show("Hesabınızda yeterli bakiye bulunmamaktadır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    MessageBox.Show("Hücreleri boş bırakmayınız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir tutar giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            TxtHesapNo.Text= "";
            TxtTutar.Text = "";
        }

        private void BtnGonder_Click(object sender, EventArgs e)
        {
            EntityTransfer ent = new EntityTransfer();
            if (double.TryParse(TxtTutar.Text, out double tutar))
            {
                ent.Gonderen = hesapNo;
                ent.Alici = TxtHesapNo.Text;
                ent.Tutar = tutar;
                int result = LogicBank.LLTransferMoney(ent);
                if (result > 0)
                {
                    MessageBox.Show("Para transferi başarıyla tamamlandı!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RegisterPayee();
                    return;
                }
                if (result == 0)
                {
                    MessageBox.Show("Para transferi sırasında bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (result == -2)
                {
                    MessageBox.Show("Lütfen hesap numarasını kontrol ediniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (result == -3)
                {
                    MessageBox.Show("Hesabınızda yeterli bakiye bulunmamaktadır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    MessageBox.Show("Hücreleri boş bırakmayınız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir tutar giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
