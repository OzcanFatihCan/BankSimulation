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
            List<EntityTransactionsTransfer> HistoryLog = LogicBank.LLMoneyTransferHistory(hesapNo);
            dataGridView1.DataSource= HistoryLog;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int columnIndex = e.ColumnIndex;
                if (columnIndex >= 0)
                {
                    TxtRgsHesapNo.Text = dataGridView1.Rows[e.RowIndex].Cells[columnIndex].Value.ToString();
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
