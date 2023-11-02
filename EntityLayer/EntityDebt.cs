using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityDebt
    {
        private string hesapNo;
        private string borc;

        public string HesapNo { get => hesapNo; set => hesapNo = value; }
        public string Borc { get => borc; set => borc = value; }
    }
}
