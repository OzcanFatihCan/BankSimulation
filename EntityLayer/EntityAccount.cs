using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityAccount
    {
        private string hesapNo;
        private double bakiye;

        public string HesapNo { get => hesapNo; set => hesapNo = value; }
        public double Bakiye { get => bakiye; set => bakiye = value; }
    }
}
