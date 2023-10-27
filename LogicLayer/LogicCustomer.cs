using DataAccessLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer
{
    public class LogicCustomer
    {
        public static List<EntityCustomer> LLCustomerLogin(string HesapNo, string Sifre)
        {
            if (HesapNo != "" &&
              Sifre != "")
            {
                return DALCustomer.CustomerLogin(HesapNo, Sifre);
            }
            else
            {
                return null;
            }
        }
    }
}
