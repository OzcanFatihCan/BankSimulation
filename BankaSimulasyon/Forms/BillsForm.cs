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
    public partial class BillsForm : Form
    {
        private string hesapNo;
        private string aliciNo;
        public BillsForm(string hesap)
        {
            InitializeComponent();
            this.hesapNo = hesap;
            dataGridView1.ForeColor = Color.Black;
        }

        private void BillsForm_Load(object sender, EventArgs e)
        {
            GetInvoiceType();
            PastInvoices();
        }

        void PastInvoices()
        {
            List<EntityTransactionsTransfer> HistoryLog = LogicBank.LLPayingBillsHistory(hesapNo);
            dataGridView1.DataSource = HistoryLog;
        }

        void GetInvoiceType()
        {
            List<EntityCustomer> BillsLog = LogicBank.LLBillingService();
            foreach (var item in BillsLog)
            {
                if (item.Soyad=="su hizmeti")
                {
                    CmbSu.Items.Add(item.Ad);
                }
                if (item.Soyad == "elektrik hizmeti")
                {
                    CmbElektrik.Items.Add(item.Ad);
                }
                if (item.Soyad == "tv hizmeti")
                {
                    CmbTv.Items.Add(item.Ad);
                }
                if (item.Soyad == "telefon hizmeti")
                {
                    CmbTelefon.Items.Add(item.Ad);
                }
                if (item.Soyad == "doğalgaz hizmeti")
                {
                    CmbDogalgaz.Items.Add(item.Ad);
                }
            }
        }

        private void AliciNoGet(EntityCustomer selectedBill)
        {
            if (selectedBill != null)
            {
                aliciNo = selectedBill.Hesapno;
            }
            else
            {
                aliciNo = string.Empty;
            }
        }

        private void CmbSu_SelectedIndexChanged(object sender, EventArgs e)
        {          
            if (CmbSu.SelectedItem!=null)
            {
                string chosen = CmbSu.SelectedItem.ToString();
                groupBox2.Text = "Su Faturası Ödeme";
                label6.Text = "Abone Numarası:";
                List<EntityCustomer> BillsLog = LogicBank.LLBillingService();
                EntityCustomer waterBill = BillsLog.FirstOrDefault(item => item.Ad == chosen);
                AliciNoGet(waterBill);
                CmbElektrik.SelectedIndex = -1;
                CmbTv.SelectedIndex = -1;
                CmbTelefon.SelectedIndex = -1;
                CmbDogalgaz.SelectedIndex = -1;
            }
        }

        private void CmbElektrik_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            if (CmbElektrik.SelectedItem != null)
            {
                string chosen = CmbElektrik.SelectedItem.ToString();
                groupBox2.Text = "Elektrik Faturası Ödeme";
                label6.Text = "Abone Numarası:";
                List<EntityCustomer> BillsLog = LogicBank.LLBillingService();
                EntityCustomer electricityBill = BillsLog.FirstOrDefault(item => item.Ad == chosen);
                AliciNoGet(electricityBill);
                CmbSu.SelectedIndex = -1;
                CmbTv.SelectedIndex = -1;
                CmbTelefon.SelectedIndex = -1;
                CmbDogalgaz.SelectedIndex = -1;
            }
        }

        private void CmbTv_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbTv.SelectedItem != null)
            {
                string chosen = CmbTv.SelectedItem.ToString();
                groupBox2.Text = "Tv Faturası Ödeme";
                label6.Text = "Abone Numarası:";
                List<EntityCustomer> BillsLog = LogicBank.LLBillingService();
                EntityCustomer tvBill = BillsLog.FirstOrDefault(item => item.Ad == chosen);
                AliciNoGet(tvBill);
                CmbSu.SelectedIndex = -1;
                CmbElektrik.SelectedIndex = -1;
                CmbTelefon.SelectedIndex = -1;
                CmbDogalgaz.SelectedIndex = -1;  
            }
        }

        private void CmbTelefon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbTelefon.SelectedItem != null)
            {
                string chosen = CmbTelefon.SelectedItem.ToString();
                groupBox2.Text = "Telefon Faturası Ödeme";
                label6.Text = "Telefon Numarası:";
                List<EntityCustomer> BillsLog = LogicBank.LLBillingService();
                EntityCustomer telephoneBill = BillsLog.FirstOrDefault(item => item.Ad == chosen);
                AliciNoGet(telephoneBill);
                CmbSu.SelectedIndex = -1;
                CmbElektrik.SelectedIndex = -1;
                CmbTv.SelectedIndex = -1;
                CmbDogalgaz.SelectedIndex = -1;  
            }
        }

        private void CmbDogalgaz_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbDogalgaz.SelectedItem != null)
            {
                string chosen = CmbDogalgaz.SelectedItem.ToString();
                groupBox2.Text = "Doğalgaz Faturası Ödeme";
                label6.Text = "Abone Numarası:";
                List<EntityCustomer> BillsLog = LogicBank.LLBillingService();
                EntityCustomer naturalgasBill = BillsLog.FirstOrDefault(item => item.Ad == chosen);
                AliciNoGet(naturalgasBill);
                CmbSu.SelectedIndex = -1;
                CmbElektrik.SelectedIndex = -1;
                CmbTv.SelectedIndex = -1;
                CmbTelefon.SelectedIndex = -1;               
            }
        }

        private void BtnOdeme_Click(object sender, EventArgs e)
        {
            EntityBill ent = new EntityBill();
            if (aliciNo!=null)
            {
                if (double.TryParse(TxtFaturaTutar.Text, out double tutar))
                {
                    ent.GonderenNo = hesapNo;
                    ent.AliciNo = aliciNo;
                    ent.Tutar = tutar;
                    ent.AboneNo = TxtAbone.Text;
                    int result = LogicBank.LLPayingBills(ent);
                    if (result > 0)
                    {
                        MessageBox.Show("Ödeme işlemi başarıyla tamamlandı!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        PastInvoices();
                        return;
                    }
                    if (result == 0)
                    {
                        MessageBox.Show("Ödeme işlemi sırasında bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            else
            {
                MessageBox.Show("Lütfen ödenecek fatura hizmetini seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
