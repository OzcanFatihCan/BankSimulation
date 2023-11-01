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
            List<EntityCustomer> AccountNumber = LogicCustomer.LLAccountNumber();
            List<EntityCustomer> TcNumber = LogicCustomer.LLTcNumber();
            bool hesapExists = AccountNumber.Any(customer => customer.Hesapno == ent.Hesapno);
            bool tcExists = TcNumber.Any(customer => customer.Tc == ent.Tc);
            if (ent.Ad!="" &&
                ent.Soyad!="" &&
                ent.Sifre!="" &&
                ent.Hesapno!="" &&
                ent.Tc!="" &&
                ent.Telefon!="" &&
                ent.Tc.Length==11 &&
                ent.Hesapno.Length==7)
            {
                if (!hesapExists)
                {
                    if (!tcExists)
                    {
                        return DALCustomer.CustomerRegister(ent);
                    }
                    else
                    {
                        return -3;
                    }
                }
                else
                {
                    return -2;
                }
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

        public static List<EntityCustomer> LLTcNumber()
        {
            return DALCustomer.TCNumber();
        }
        public static List<EntityCustomer> LLCustomerInfo(string hesapNo)
        {
            if (hesapNo!="" &&
                hesapNo.Length==7)
            {
                return DALCustomer.CustumerInfo(hesapNo);
            }
            else
            {
                return null; 
            }
        }
    }
}
