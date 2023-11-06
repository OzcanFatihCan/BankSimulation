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
    public partial class AccountStatementForm : Form
    {
        private string hesapNo;
        string adsoyad;
        public AccountStatementForm(string hesap)
        {
            InitializeComponent();
            //LoadTheme();
            this.hesapNo = hesap;
            dataGridView1.ForeColor = Color.Black;
        }
        void InfoFetch()
        {
            List<EntityCustomer> CustomerInfo = LogicCustomer.LLCustomerInfo(hesapNo);
            foreach (var item in CustomerInfo)
            {
                adsoyad = item.Ad + " " + item.Soyad;
                LblAdSoyad.Text = adsoyad;
                LblMusteriNo.Text = item.Hesapno;
            }
            List<EntityAccount> BalanceInfo = LogicBank.LLBalanceCheck(hesapNo);
            foreach (var item in BalanceInfo)
            {
                LblBakiye.Text = item.Bakiye + " ₺";
            }
        }

        private BindingList<EntityMovementDetailed> movementLogBindingList;
        void AccountStatementFetch()
        {
            
            string hes = hesapNo;
            string aramaMetni = textBox1.Text;
            List<EntityMovementDetailed> historyLog = LogicBank.LLAccountStatementFetch(hes,aramaMetni);

            dataGridView1.Rows.Clear();

            if (historyLog != null)
            {
                foreach (var hareket in historyLog)
                {
                    string tutar = "";

                    if (adsoyad == hareket.Gonderen &&
                        adsoyad != hareket.Alici)
                    {
                        tutar = "- " + hareket.Tutar + " ₺";
                    }
                    if (adsoyad == hareket.Gonderen &&
                        adsoyad == hareket  .Alici &&
                        "Para Çekme" == hareket.Islem)
                    {
                        tutar = "- " + hareket.Tutar + " ₺";
                    }
                    if (adsoyad == hareket.Alici &&
                        "Para Yatırma" == hareket.Islem)
                    {
                        tutar = "+ " + hareket.Tutar + " ₺";
                    }
                    if (adsoyad == hareket.Alici &&
                        adsoyad != hareket.Gonderen)
                    {
                        tutar = "+ " + hareket.Tutar + " ₺";
                    }

                    dataGridView1.Rows.Add(hareket.Gonderen, hareket.Alici, tutar, hareket.Islem);
                }
            }
        }

        private void AccountStatementForm_Load(object sender, EventArgs e)
        {
            InfoFetch();
            AccountStatementFetch();
          
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            AccountStatementFetch();
        }
  

        private void BtnKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
   
        private void LoadTheme()
        {
            //butonların da rengini değiştirmek istersek
            /*
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }*/

            // label1.ForeColor = ThemeColor.SecondaryColor;
            // label2.ForeColor = ThemeColor.PrimaryColor;
        }
    } 
}
