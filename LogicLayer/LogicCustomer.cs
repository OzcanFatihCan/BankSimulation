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
              Sifre != "" &&
              HesapNo.Length==7)
            {
                return DALCustomer.CustomerLogin(HesapNo, Sifre);
            }
            else
            {
                return null;
            }
        }

        public static int LLCustomerRegister(EntityCustomer ent)
        {
            if (ent.Ad!="" &&
                ent.Soyad!="" &&
                ent.Sifre!="" &&
                ent.Hesapno!="" &&
                ent.Tc!="" &&
                ent.Telefon!="" &&
                ent.Tc.Length==11 &&
                ent.Hesapno.Length==7)
            {
                return DALCustomer.CustomerRegister(ent);
            }
            else
            {
                return -1;
            }
        }
        public static List<EntityCustomer> LLAccountNumber()
        {
            return DALCustomer.AccountNumber();
        }
    }
}
