using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
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
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex==index)
            {
               index= random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender!=null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor= color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font= new System.Drawing.Font("Arial", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
                    PanelTitleBar.BackColor = color;
                    PanelLogo.BackColor = ThemeColor.ChangeColorBrightness(color,-0.3);
                }
            }
           
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType()==typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(42, 54, 90);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font= new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.PanelDesktopPanel.Controls.Add(childForm);
            this.PanelDesktopPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            LblTitle.Text = childForm.Text;
        }
      
        public HomePage()
        {
            InitializeComponent();
            random = new Random();
        }
        public string hesap;

        void bilgiGetir()
        {
            /*
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
            Baglanti.Close();*/
        }
        private void HomePage_Load(object sender, EventArgs e)
        {   /*                        
            LblHesap.Text = hesap;
            bilgiGetir();*/
        }

        private void BtnGonder_Click(object sender, EventArgs e)
        {
            /*
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
            */

        }

        private void BtnHesap_Click(object sender, EventArgs e)
        {            
            OpenChildForm(new Forms.AccountStatementForm(), sender);
        }

        private void BtnCekim_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.DpstWthdrwlPrcsForm(), sender);
        }

        private void BtnFatura_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.BillsForm(), sender);
        }

        private void BtnTransfer_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.TransferForm(), sender);
        }
    }
}
