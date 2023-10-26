using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankaSimulasyon
{
    public partial class HomePage : Form
    {
        SqlConnection Baglanti = new SqlConnection("Data Source=FatihBuzac\\SQLEXPRESS;Initial Catalog=DbBanka;Integrated Security=True");
        public HomePage()
        {
            InitializeComponent();
        }
        public string hesap;

        void bilgiGetir()
        {
            Baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM MUSTERILER WHERE HESAPNO=@P1",Baglanti);
            komut.Parameters.AddWithValue("@P1",hesap);
            SqlDataReader dr=komut.ExecuteReader();
            while (dr.Read())
            {
                LblAdSoyad.Text = dr["AD"] + " " + dr["SOYAD"];
                LblTc.Text = dr["TC"].ToString();
                LblTel.Text = dr["TELEFON"].ToString();
            }
            Baglanti.Close();
        }
        private void HomePage_Load(object sender, EventArgs e)
        {
            LblHesap.Text = hesap;
            bilgiGetir();
        }

        private void BtnGonder_Click(object sender, EventArgs e)
        {
            //gönderilen hesabın para atışı
            Baglanti.Open();
            SqlCommand komut = new SqlCommand("UPDATE HESAPLAR SET BAKIYE=BAKIYE+@P1 WHERE HESAPNO=@P2", Baglanti);
            komut.Parameters.AddWithValue("@P1", decimal.Parse(TxtTutar.Text));
            komut.Parameters.AddWithValue("@P2",MskHesapNo.Text);
            komut.ExecuteNonQuery();
            Baglanti.Close();
           

            //gönderen hesabın para azalışı
            Baglanti.Open();
            SqlCommand komut2 = new SqlCommand("UPDATE HESAPLAR SET BAKIYE=BAKIYE-@K1 WHERE HESAPNO=@K2", Baglanti);
            komut2.Parameters.AddWithValue("@K1", decimal.Parse(TxtTutar.Text));
            komut2.Parameters.AddWithValue("@K2", hesap);
            komut2.ExecuteNonQuery();
            Baglanti.Close();
            MessageBox.Show("Havale işlemi gerçekleşti");

            //HAREKET


        }
    }
}
