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
    public partial class AccountSettingsForm : Form
    {
        public string hesapNo;

        public AccountSettingsForm(string hesap)
        {
            InitializeComponent();
            this.hesapNo = hesap;
            InfoFetch();
        }

        void InfoFetch()
        {
            List<EntityCustomer> CustomerInfo = LogicCustomer.LLCustomerInfo(hesapNo);
            foreach (var item in CustomerInfo)
            {            
                TxtAd.Text=item.Ad.ToString();
                TxtSoyad.Text=item.Soyad.ToString();               
                MskTel.Text = item.Telefon.ToString();
                TxtSifre.Text=item.Sifre.ToString();
            }
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            EntityCustomer ent = new EntityCustomer();
            ent.Hesapno = hesapNo;
            ent.Ad = TxtAd.Text;
            ent.Soyad = TxtSoyad.Text;
            ent.Sifre = TxtSifre.Text;
            ent.Telefon = MskTel.Text;
            bool result=LogicCustomer.LLCustomerUpdate(ent);
            if (result)
            {
                MessageBox.Show("Güncelleme işlemi başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lütfen bilgileri boş bırakmayınız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSifAcKapa_Click(object sender, EventArgs e)
        {
            if (TxtSifre.UseSystemPasswordChar)
            {
                TxtSifre.UseSystemPasswordChar = false;
                BtnSifAcKapa.Image = Properties.Resources.Sifrekapat;
            }
            else
            {
                TxtSifre.UseSystemPasswordChar = true;
                BtnSifAcKapa.Image = Properties.Resources.Sifreac;
            }
        }

        private void AccountSettingsForm_Load(object sender, EventArgs e)
        {
            BtnSifAcKapa.Image = Properties.Resources.Sifreac;
            TxtSifre.UseSystemPasswordChar=true;
        }
    }
}
