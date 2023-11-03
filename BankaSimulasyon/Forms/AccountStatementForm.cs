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

            List<EntityMovementDetailed> HistoryLogText = LogicBank.LLAccountStatementFetch(hesapNo);
            movementLogBindingList = new BindingList<EntityMovementDetailed>(HistoryLogText);
            dataGridView1.DataSource = movementLogBindingList;
            ApplyCellFormatting();
            /*
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            List<EntityMovementDetailed> HistoryLog = LogicBank.LLAccountStatementFetch(hesapNo);
            dataGridView1.AutoGenerateColumns = false;
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
                    adsoyad ==item.Alici &&
                    "Para Çekme"==item.Islem)
                {
                    tutar = "- " + item.Tutar + " ₺";
                }
                if (adsoyad == item.Alici &&
                    "Para Yatırma" == item.Islem)
                {
                    tutar = "+ " + item.Tutar + " ₺";
                }
                if (adsoyad == item.Alici &&
                    adsoyad !=item.Gonderen)
                {
                    tutar = "+ " + item.Tutar + " ₺";
                }
                dataGridView1.Rows.Add(item.Gonderen,item.Alici,tutar,item.Islem);
            }*/
        }

        private void AccountStatementForm_Load(object sender, EventArgs e)
        {
            InfoFetch();
            AccountStatementFetch();
            ApplyCellFormatting();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {/*
            string searchText = textBox1.Text.Trim();
            if (searchText == "")
            {
                dataGridView1.Columns.Clear();
                AccountStatementFetch();
            }
            else
            {
                dataGridView1.Columns.Clear(); // Önceki sütunları temizle
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.Columns.Add("Gonderen", "Gönderen");
                dataGridView1.Columns.Add("Alıcı", "Alıcı");
                dataGridView1.Columns.Add("Tutar", "Tutar");
                dataGridView1.Columns.Add("Islem", "İşlem");
                List<EntityMovementDetailed> movementLog = LogicBank.LLSearchForMovement(searchText, hesapNo);
                dataGridView1.DataSource = movementLog;
            }*/
            string searchText = textBox1.Text.Trim();
            if (searchText == "")
            {            
                dataGridView1.DataSource = movementLogBindingList;               
            }
            else
            {
                
                var filteredList = movementLogBindingList.Where(item =>
                    item.Gonderen.Contains(searchText) ||
                    item.Alici.Contains(searchText) ||
                    item.Islem.Contains(searchText)
                ).ToList();/*
                List<EntityMovementDetailed> filteredList = LogicBank.LLSearchForMovement(textBox1.Text,hesapNo);*/
                dataGridView1.DataSource = new BindingList<EntityMovementDetailed>(filteredList);
            }
            ApplyCellFormatting();
        }

        private void ApplyCellFormatting()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
               
                if (row.Cells["Tutar"].Value != null && row.Cells["Islem"].Value != null)
                {
                    string tutar = row.Cells["Tutar"].Value.ToString();
                    string islem = row.Cells["Islem"].Value.ToString();

                    if (adsoyad == row.Cells["Gonderen"].Value.ToString() &&
                        adsoyad != row.Cells["Alici"].Value.ToString())
                    {
                        row.Cells["Tutar"].Style.BackColor = Color.Red;
                        row.Cells["Tutar"].Style.ForeColor = Color.White;
                    }
                    else if (adsoyad == row.Cells["Gonderen"].Value.ToString() &&
                        adsoyad == row.Cells["Alici"].Value.ToString() &&
                        "Para Çekme" == islem)
                    {
                        row.Cells["Tutar"].Style.BackColor = Color.Red;
                        row.Cells["Tutar"].Style.ForeColor = Color.White;

                    }
                    else if (adsoyad == row.Cells["Alici"].Value.ToString() &&
                        "Para Yatırma" == islem)
                    {
                        row.Cells["Tutar"].Style.BackColor = Color.Green;
                        row.Cells["Tutar"].Style.ForeColor = Color.White;

                    }
                    else if (adsoyad == row.Cells["Alici"].Value.ToString() &&
                        adsoyad != row.Cells["Gonderen"].Value.ToString())
                    {
                        row.Cells["Tutar"].Style.BackColor = Color.Green;
                        row.Cells["Tutar"].Style.ForeColor = Color.White;

                    }
                    else
                    {
                        row.Cells["Tutar"].Style.BackColor = Color.Empty;
                    }
                }
            }
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
