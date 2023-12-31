﻿using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DALBank
    {
        public static List<EntityMovement> MoneyTransferHistory(string hesapno)
        {
            try
            {
                List<EntityMovement> HistoryLog = new List<EntityMovement>();
                SqlCommand komut5 = new SqlCommand("GetMoneyTransferHistory", SQLConn.conn);
                komut5.CommandType = CommandType.StoredProcedure;
                komut5.Parameters.AddWithValue("@HesapNo", hesapno);

                if (komut5.Connection.State != ConnectionState.Open)
                {
                    komut5.Connection.Open();
                }

                SqlDataReader dr4 = komut5.ExecuteReader();
                while (dr4.Read())
                {
                    EntityMovement ent = new EntityMovement();
                    ent.Aliciisim = dr4["AD"] + " " + dr4["SOYAD"];
                    ent.Alici = dr4["ALICI"].ToString();
                    ent.Tutar = double.Parse(dr4["TUTAR"].ToString());
                    HistoryLog.Add(ent);
                }
                dr4.Close();
                komut5.Connection.Close();
                return HistoryLog;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static int TransferMoney(EntityTransfer ent)
        {
            try
            {
                SqlCommand komut6 = new SqlCommand("TransferMoney", SQLConn.conn);
                komut6.CommandType = CommandType.StoredProcedure;

                if (komut6.Connection.State != ConnectionState.Open)
                {
                    komut6.Connection.Open();
                }
                komut6.Parameters.AddWithValue("@GonderenHesap", ent.Gonderen);
                komut6.Parameters.AddWithValue("@AliciHesap", ent.Alici);
                komut6.Parameters.AddWithValue("@TransferMiktari", ent.Tutar);
                
                return komut6.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<EntityAccount> BalanceCheck(string hesapNo)
        {
            try
            {
                List<EntityAccount> BalanceLog = new List<EntityAccount>();
                SqlCommand komut7 = new SqlCommand("SELECT BAKIYE FROM HESAPLAR WHERE HESAPNO=@P1", SQLConn.conn);
                if (komut7.Connection.State != ConnectionState.Open)
                {
                    komut7.Connection.Open();
                }
                komut7.Parameters.AddWithValue("@P1", hesapNo);
                SqlDataReader dr5 = komut7.ExecuteReader();
                while (dr5.Read())
                {
                    EntityAccount ent = new EntityAccount();
                    ent.Bakiye = double.Parse(dr5["BAKIYE"].ToString());
                    BalanceLog.Add(ent);
                }
                dr5.Close();
                komut7.Connection.Close();
                return BalanceLog;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<EntityCustomer> BillingService()
        {
            try
            {
                List<EntityCustomer> BillsLog = new List<EntityCustomer>();
                SqlCommand komut9 = new SqlCommand("SELECT AD, SOYAD, HESAPNO FROM MUSTERILER", SQLConn.conn);
                if (komut9.Connection.State != ConnectionState.Open)
                {
                    komut9.Connection.Open();
                }
                SqlDataReader dr6 = komut9.ExecuteReader();
                while (dr6.Read())
                {
                    EntityCustomer ent = new EntityCustomer();
                    ent.Ad = dr6["AD"].ToString();
                    ent.Soyad = dr6["SOYAD"].ToString();
                    ent.Hesapno = dr6["HESAPNO"].ToString();
                    BillsLog.Add(ent);
                }
                dr6.Close();
                komut9.Connection.Close();
                return BillsLog;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static int PayingBills(EntityBill ent)
        {
            try
            {
                SqlCommand komut10 = new SqlCommand("PayBills", SQLConn.conn);
                komut10.CommandType = CommandType.StoredProcedure;
                komut10.Parameters.AddWithValue("@GonderenHesap", ent.GonderenNo);
                komut10.Parameters.AddWithValue("@AliciHesap", ent.AliciNo);
                komut10.Parameters.AddWithValue("@OdenecekTutar", ent.Tutar);
                komut10.Parameters.AddWithValue("@AboneNumarasi", ent.AboneNo);

                if (komut10.Connection.State != ConnectionState.Open)
                {
                    komut10.Connection.Open();
                }

                return komut10.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<EntityMovement> PayingBillsHistory(string hesapno)
        {
            try
            {
                List<EntityMovement> HistoryLog = new List<EntityMovement>();
                SqlCommand komut11 = new SqlCommand("GetPayingBillsHistory", SQLConn.conn);
                komut11.CommandType = CommandType.StoredProcedure;
                komut11.Parameters.AddWithValue("@HesapNo", hesapno);

                if (komut11.Connection.State != ConnectionState.Open)
                {
                    komut11.Connection.Open();
                }

                SqlDataReader dr7 = komut11.ExecuteReader();
                while (dr7.Read())
                {
                    EntityMovement ent = new EntityMovement();
                    ent.Aliciisim = dr7["AD"].ToString();
                    ent.Alici = dr7["ALICI"].ToString();
                    ent.Tutar = double.Parse(dr7["TUTAR"].ToString());
                    HistoryLog.Add(ent);
                }
                dr7.Close();
                komut11.Connection.Close();
                return HistoryLog;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static int DepositTransaction(EntityTransfer ent)
        {
            try
            {
                SqlCommand komut12 = new SqlCommand("DepositTransaction", SQLConn.conn);
                komut12.CommandType = CommandType.StoredProcedure;
                komut12.Parameters.AddWithValue("@GonderenHesap", ent.Gonderen);
                komut12.Parameters.AddWithValue("@AliciHesap", ent.Gonderen);
                komut12.Parameters.AddWithValue("@YatirilacakTutar", ent.Tutar);

                if (komut12.Connection.State != ConnectionState.Open)
                {
                    komut12.Connection.Open();
                }

                return komut12.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static int WithdrawalTransaction(EntityTransfer ent)
        {
            try
            {
                SqlCommand komut13 = new SqlCommand("WithdrawalTransaction", SQLConn.conn);
                komut13.CommandType = CommandType.StoredProcedure;
                komut13.Parameters.AddWithValue("@GonderenHesap", ent.Alici);
                komut13.Parameters.AddWithValue("@AliciHesap", ent.Alici);
                komut13.Parameters.AddWithValue("@CekilecekTutar", ent.Tutar);

                if (komut13.Connection.State != ConnectionState.Open)
                {
                    komut13.Connection.Open();
                }

                return komut13.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static int CreditCardDebt(EntityTransfer ent)
        {
            try
            {
                SqlCommand komut14 = new SqlCommand("CreditCardDebtProcedure", SQLConn.conn);
                komut14.CommandType = CommandType.StoredProcedure;
                komut14.Parameters.AddWithValue("@GonderenHesap", ent.Alici);
                komut14.Parameters.AddWithValue("@AliciHesap", ent.Alici);
                komut14.Parameters.AddWithValue("@CekilecekTutar", ent.Tutar);
                if (komut14.Connection.State != ConnectionState.Open)
                {
                    komut14.Connection.Open();
                }
                return komut14.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<EntityDebt> CreditDebtFetch(string hesapNo)
        {
            try
            {
                List<EntityDebt> DebtLog = new List<EntityDebt>();
                SqlCommand komut15 = new SqlCommand("SELECT BORC FROM BORCLAR WHERE HESAPNO=@P1", SQLConn.conn);
                if (komut15.Connection.State != ConnectionState.Open)
                {
                    komut15.Connection.Open();
                }
                komut15.Parameters.AddWithValue("@P1", hesapNo);
                SqlDataReader dr8 = komut15.ExecuteReader();
                while (dr8.Read())
                {
                    EntityDebt ent = new EntityDebt();
                    ent.Borc = dr8["BORC"].ToString();
                    DebtLog.Add(ent);
                }
                dr8.Close();
                komut15.Connection.Close();
                return DebtLog;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static int PaymentCreditCardDebt(EntityTransfer ent)
        {
            try
            {
                SqlCommand komut16 = new SqlCommand("PaymentCreditCardDebt", SQLConn.conn);
                komut16.CommandType = CommandType.StoredProcedure;
                komut16.Parameters.AddWithValue("@GonderenHesap", ent.Gonderen);
                komut16.Parameters.AddWithValue("@OdenecekTutar", ent.Tutar);

                if (komut16.Connection.State != ConnectionState.Open)
                {
                    komut16.Connection.Open();
                }

                return komut16.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static List<EntityMovementDetailed> AccountStatementFetch(string hesapNo, string aramaMetni)
        {
            try
            {
                List<EntityMovementDetailed> AccountStatementLog = new List<EntityMovementDetailed>();
                SqlCommand komut17 = new SqlCommand("AccountStatementFetch", SQLConn.conn);
                komut17.CommandType = CommandType.StoredProcedure;
                komut17.Parameters.AddWithValue("@HesapNo", hesapNo);
                komut17.Parameters.AddWithValue("@AramaMetni", aramaMetni);
                if (komut17.Connection.State != ConnectionState.Open)
                {
                    komut17.Connection.Open();
                }
                SqlDataReader dr9 = komut17.ExecuteReader();
                while (dr9.Read())
                {
                    EntityMovementDetailed ent = new EntityMovementDetailed();
                    ent.Gonderen = dr9["Gönderen"].ToString();
                    ent.Alici = dr9["Alıcı"].ToString();
                    ent.Tutar = double.Parse(dr9["TUTAR"].ToString());
                    ent.Islem = dr9["ISLEM"].ToString();

                    AccountStatementLog.Add(ent);
                }
                dr9.Close();
                return AccountStatementLog;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}