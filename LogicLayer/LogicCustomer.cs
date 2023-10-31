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

        public static List<EntityTransactionsTransfer> LLMoneyTransferHistory(string HesapNo)
        {
            if (HesapNo!="")
            {
                return DALCustomer.MoneyTransferHistory(HesapNo);

            }
            else
            {
                return null;
            }
        }
        public static int LLTransferMoney(EntityTransfer ent)
        {
            double bakiye=0.0;
            List<EntityAccount> balance = LogicCustomer.LLBalanceCheck(ent.Gonderen);
            foreach (var item in balance)
            {
                bakiye = item.Bakiye;
            }
            if (ent.Gonderen!=""&&
                ent.Alici!=""&&
                !string.IsNullOrEmpty(ent.Tutar.ToString()))
            {
                if (ent.Gonderen.Length==7 &&
                    ent.Alici.Length==7)
                {
                    if (ent.Tutar<bakiye)
                    {
                        return DALCustomer.TransferMoney(ent);
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

        public static  List<EntityAccount> LLBalanceCheck(string hesapNo)
        {
            if (hesapNo!="")
            {
                return DALCustomer.BalanceCheck(hesapNo);
            }
            else
            {
                return null;
            }
        }
    }
}
