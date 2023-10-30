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

        }
    }
}
