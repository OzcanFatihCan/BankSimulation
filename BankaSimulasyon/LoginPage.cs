using System;
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
        SqlConnection Baglanti=new SqlConnection("Data Source=FatihBuzac\\SQLEXPRESS;Initial Catalog=DbBanka;Integrated Security=True");
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
            List<EntityCustomer> CustomerLogin = LogicCustomer.LLCustomerLogin(MskLoginHesap.Text, TxtLoginSifre.Text);
            if (CustomerLogin != null && CustomerLogin.Count > 0)
            {
                HomePage frm = new HomePage();
                frm.hesap = MskLoginHesap.Text;
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
            Random rnd = new Random();
            int sayi = rnd.Next(1000000, 10000000);
            MskRgsHesap.Text = sayi.ToString();
        }

        private void BtnKayitOl_Click(object sender, EventArgs e)
        {
            Baglanti.Open();
            SqlCommand komut = new SqlCommand("INSERT INTO MUSTERILER (AD,SOYAD,TC,TELEFON,HESAPNO,SIFRE) VALUES (@P1,@P2,@P3,@P4,@P5,@P6)", Baglanti);
            komut.Parameters.AddWithValue("@P1", TxtRgsAd.Text);
            komut.Parameters.AddWithValue("@P2", TxtRgsSoyad.Text);
            komut.Parameters.AddWithValue("@P3", MskRgsTc.Text);
            komut.Parameters.AddWithValue("@P4", MskRgsTelefon.Text);
            komut.Parameters.AddWithValue("@P5", MskRgsHesap.Text);
            komut.Parameters.AddWithValue("@P6", TxtRgsSifre.Text);
            komut.ExecuteNonQuery();
            Baglanti.Close();
            MessageBox.Show("Müşteri Bilgileri sisteme kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
