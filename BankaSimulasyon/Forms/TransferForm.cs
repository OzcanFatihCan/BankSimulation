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
    public partial class TransferForm : Form
    {
        public string hesapNo;
        public TransferForm(string hesap)
        {
            InitializeComponent();
            this.hesapNo = hesap;
        }
       
        private void TransferForm_Load(object sender, EventArgs e)
        {
            RegisterPayee();
        }

        void RegisterPayee()
        {
            List<EntityTransactionsTransfer> HistoryLog = LogicCustomer.LLMoneyTransferHistory(hesapNo);
            // DataGridView'deki sütunları kullanarak verileri aktar
            for (int i = 0; i < HistoryLog.Count; i++)
            {
                // Sıradaki veriyi al
                EntityTransactionsTransfer data = HistoryLog[i];

                // DataGridView'deki ilgili sütunlara veriyi yerleştir
                dataGridView1.Rows[i].Cells["Column1"].Value = data.Aliciisim;
                dataGridView1.Rows[i].Cells["Column2"].Value = data.Alici;
            }
           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtRgsHesapNo.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }
    }
}
