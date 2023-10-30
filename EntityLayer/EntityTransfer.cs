using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityTransfer
    {
        private string gonderen;
        private string alici;
        private double tutar;

        public string Gonderen { get => gonderen; set => gonderen = value; }
        public string Alici { get => alici; set => alici = value; }
        public double Tutar { get => tutar; set => tutar = value; }
    }
}
