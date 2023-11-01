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
    public partial class DpstWthdrwlPrcsForm : Form
    {
        private string hesapNo;
        public DpstWthdrwlPrcsForm(string hesap)
        {
            InitializeComponent();
            this.hesapNo = hesap;
        }

        private void DpstWthdrwlPrcsForm_Load(object sender, EventArgs e)
        {

        }

        private void RadioCek_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioCek.Checked)
            {
                RadioYatir.Checked = false;
            }
        }

        private void RadioYatir_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioYatir.Checked)
            {
                RadioCek.Checked = false;
            }
        }

        private void BtnIslem_Click(object sender, EventArgs e)
        {
            if (RadioCek.Checked)
            {
               EntityTransfer ent = new EntityTransfer();
                if (double.TryParse(TxtTutarHesap.Text, out double tutarCek))
                {
                    ent.Alici = hesapNo;
                    ent.Tutar = tutarCek;
                    int result=LogicBank.LLWithdrawalTransaction(ent);
                    if (result>0)
                    {
                        MessageBox.Show("Para çekme işlemi başarıyla gerçekeleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    if (result == 0)
                    {
                        MessageBox.Show("Para çekme sırasında bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (result == -2)
                    {
                        MessageBox.Show("Lütfen hesap numarasını kontrol ediniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (result == -3)
                    {                     
                        DialogResult resultMessage = MessageBox.Show("Hesabınızda yeterli bakiye bulunmamaktadır. Kredi kartından çekilsin mi?", "Para Çekme",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                        if (resultMessage==DialogResult.Yes)
                        {
                            return;
                        }
                        else
                        {
                            
                        }                      
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
            else if (RadioYatir.Checked)
            {
                EntityTransfer ent =new EntityTransfer();
                if (double.TryParse(TxtTutarHesap.Text,out double tutarYatir))
                {
                    ent.Gonderen = hesapNo;
                    ent.Tutar = tutarYatir;
                    int result=LogicBank.LLDepositTransaction(ent);
                    if (result>0)
                    {
                        MessageBox.Show("Para yatırma işlemi başarıyla gerçekeleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    if (result == 0)
                    {
                        MessageBox.Show("Para yatırma sırasında bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (result == -2)
                    {
                        MessageBox.Show("Minimum 5₺ Yatırılabilir. ", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Yapmak istediğiniz işlemi seçiniz.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
    }
}
