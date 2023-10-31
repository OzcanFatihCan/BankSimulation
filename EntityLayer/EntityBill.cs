using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityBill
    {
        private string gonderenNo;
        private string aliciNo;
        private string aboneNo;
        private double tutar;

        public string GonderenNo { get => gonderenNo; set => gonderenNo = value; }
        public string AliciNo { get => aliciNo; set => aliciNo = value; }
        public string AboneNo { get => aboneNo; set => aboneNo = value; }
        public double Tutar { get => tutar; set => tutar = value; }
    }
}
