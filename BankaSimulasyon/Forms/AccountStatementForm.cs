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
        void AccountStatementFetch()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            List<EntityMovementDetailed> HistoryLog = LogicBank.LLAccountStatementFetch(hesapNo);
            dataGridView1.Columns.Add("Gonderen", "Gönderen");
            dataGridView1.Columns.Add("Alıcı", "Alıcı");
            dataGridView1.Columns.Add("Tutar", "Tutar");
            dataGridView1.Columns.Add("Islem", "İşlem");
            foreach (var item in HistoryLog)
            {
                string tutar = ""; 
                if (adsoyad==item.Gonderen &&
                    adsoyad!=item.Alici)
                {
                    tutar= "- "+item.Tutar+" ₺";
                }
                if (adsoyad ==item.Gonderen &&
                    adsoyad ==item.Alici)
                {
                    tutar = "- " + item.Tutar + " ₺";
                }
                if (adsoyad == item.Alici &&
                    adsoyad !=item.Gonderen)
                {
                    tutar = "+ " + item.Tutar + " ₺";
                }
                dataGridView1.Rows.Add(item.Gonderen,item.Alici,tutar,item.Islem);
            }
        }

        private void AccountStatementForm_Load(object sender, EventArgs e)
        {
            InfoFetch();
            AccountStatementFetch();
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

        private void BtnKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
      
    } 
}
