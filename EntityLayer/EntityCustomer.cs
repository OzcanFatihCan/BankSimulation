using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityCustomer
    {
        private string ad;
        private string soyad;
        private string tc;
        private string telefon;
        private string hesapno;
        private string sifre;

        public string Ad { get => ad; set => ad = value; }
        public string Soyad { get => soyad; set => soyad = value; }
        public string Tc { get => tc; set => tc = value; }
        public string Telefon { get => telefon; set => telefon = value; }
        public string Hesapno { get => hesapno; set => hesapno = value; }
        public string Sifre { get => sifre; set => sifre = value; }
    }
}
