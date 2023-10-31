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
        public BillsForm(string hesap)
        {
            InitializeComponent();
            this.hesapNo = hesap;
           
        }

        private void BillsForm_Load(object sender, EventArgs e)
        {
            GetInvoiceType();
        }

        void GetInvoiceType()
        {
            List<EntityCustomer> BillsLog = LogicCustomer.LLBillingService();
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
       
    }
}
