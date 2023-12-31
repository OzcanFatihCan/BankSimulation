﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using EntityLayer;
using LogicLayer;

namespace BankaSimulasyon
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pctOrta.Left += 20;
            if (pctOrta.Left == 400)
            {
                timer1.Stop();               
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            pctOrta.Left -= 20;
            if (pctOrta.Left == 0)
            {
                timer2.Stop();
            }
        }

        private void LnkKayıtOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            timer1.Start();
        }

        private void LnkGirisYap_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            timer2.Start();
        }

        private void BtnLoginGiris_Click(object sender, EventArgs e)
        {
            List<EntityCustomer> CustomerLogin = LogicCustomer.LLCustomerLogin(TxtLoginHesap.Text, TxtLoginSifre.Text);
            if (CustomerLogin != null && CustomerLogin.Count > 0)
            {
                HomePage frm = new HomePage();
                frm.hesap = TxtLoginHesap.Text;
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı kullanıcı girişi yaptınız. Bilgilerinizi kontrol ediniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }         
        }

        private void BtnHesapNo_Click(object sender, EventArgs e)
        {
            List<EntityCustomer> AccountNumber = LogicCustomer.LLAccountNumber();
            Random rnd = new Random();
            int yeniSayi = 0;
            List<int> mevcutSayilar = AccountNumber.Select(customer => int.Parse(customer.Hesapno)).ToList();
            while (true)
            {
                yeniSayi = rnd.Next(1000000, 10000000);

                if (!mevcutSayilar.Contains(yeniSayi))
                {
                    TxtRgsHesap.Text = yeniSayi.ToString();
                    break;
                }
            }
        }

        private void BtnKayitOl_Click(object sender, EventArgs e)
        {
            EntityCustomer ent = new EntityCustomer();
            ent.Ad = TxtRgsAd.Text;
            ent.Soyad = TxtRgsSoyad.Text;
            ent.Sifre = TxtRgsSifre.Text;
            ent.Tc = TxtRgsTc.Text;
            ent.Hesapno = TxtRgsHesap.Text;
            ent.Telefon = MskRgsTelefon.Text;
            int result=LogicCustomer.LLCustomerRegister(ent);
            if (result > 0)
            {
                MessageBox.Show("Kayıt başarıyla gerçekleştirildi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (result == 0)
            {
                MessageBox.Show("Kayıt sırasında hata oluştu", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(result == -2)
            {
                MessageBox.Show("Lütfen başka bir hesap numarası alınız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(result == -3)
            {
                MessageBox.Show("Girdiğiniz TC numarasına ait bir hesap zaten mevcut.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Hatalı veri girişi yapıldı. Lütfen kontrol ediniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }          
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }
    }
}
