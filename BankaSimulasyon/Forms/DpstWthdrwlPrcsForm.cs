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
    public partial class DpstWthdrwlPrcsForm : Form
    {
        private string hesapNo;
        public DpstWthdrwlPrcsForm(string hesap)
        {
            InitializeComponent();
            this.hesapNo = hesap;
        }

        private void DpstWthdrwlPrcsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
