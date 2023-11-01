using DataAccessLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer
{
    public class LogicBank
    {
        public static List<EntityTransactionsTransfer> LLMoneyTransferHistory(string HesapNo)
        {
            if (HesapNo != "")
            {
                return DALBank.MoneyTransferHistory(HesapNo);

            }
            else
            {
                return null;
            }
        }
        public static int LLTransferMoney(EntityTransfer ent)
        {
            double bakiye = 0.0;
            List<EntityAccount> balance = LogicBank.LLBalanceCheck(ent.Gonderen);
            foreach (var item in balance)
            {
                bakiye = item.Bakiye;
            }
            if (ent.Gonderen != "" &&
                ent.Alici != "" &&
                !string.IsNullOrEmpty(ent.Tutar.ToString()))
            {
                if (ent.Gonderen.Length == 7 &&
                    ent.Alici.Length == 7)
                {
                    if (ent.Tutar < bakiye)
                    {
                        return DALBank.TransferMoney(ent);
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

        public static List<EntityAccount> LLBalanceCheck(string hesapNo)
        {
            if (hesapNo != "")
            {
                return DALBank.BalanceCheck(hesapNo);
            }
            else
            {
                return null;
            }
        }

        public static List<EntityCustomer> LLBillingService()
        {
            return DALBank.BillingService();
        }

        public static int LLPayingBills(EntityBill ent)
        {
            double bakiye = 0.0;
            List<EntityAccount> balance = LogicBank.LLBalanceCheck(ent.GonderenNo);
            foreach (var item in balance)
            {
                bakiye = item.Bakiye;
            }
            if (ent.GonderenNo != "" &&
                ent.AliciNo != "" &&
                ent.AboneNo != "" &&
                !string.IsNullOrEmpty(ent.Tutar.ToString()))
            {
                if (ent.GonderenNo.Length == 7 &&
                    ent.AliciNo.Length == 7)
                {
                    if (ent.Tutar < bakiye)
                    {
                        return DALBank.PayingBills(ent);
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

        public static List<EntityTransactionsTransfer> LLPayingBillsHistory(string HesapNo)
        {
            if (HesapNo != "")
            {
                return DALBank.PayingBillsHistory(HesapNo);
            }
            else
            {
                return null;
            }
        }
    }
}
