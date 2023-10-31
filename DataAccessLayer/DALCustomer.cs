using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DALCustomer
    {
        public static List<EntityCustomer> CustomerLogin(string HesapNo,string Sifre) 
        {
            try
            {
                List<EntityCustomer> CustomerLog = new List<EntityCustomer>();
                SqlCommand komut = new SqlCommand("SELECT * FROM MUSTERILER WHERE HESAPNO=@P1 AND SIFRE=@P2", SQLConn.conn);
                if (komut.Connection.State != ConnectionState.Open)
                {
                    komut.Connection.Open();
                }
                komut.Parameters.AddWithValue("@p1", HesapNo);
                komut.Parameters.AddWithValue("@p2", Sifre);
                SqlDataReader dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    EntityCustomer e = new EntityCustomer();
                    e.Hesapno = dr["HESAPNO"].ToString();
                    e.Sifre = dr["SIFRE"].ToString();
                    CustomerLog.Add(e);
                }
                dr.Close();
                return CustomerLog;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static int CustomerRegister(EntityCustomer ent)
        {
            try
            {
                SqlCommand komut2 = new SqlCommand("INSERT INTO MUSTERILER (AD,SOYAD,TC,TELEFON,HESAPNO,SIFRE) VALUES (@P1,@P2,@P3,@P4,@P5,@P6)", SQLConn.conn);
                if (komut2.Connection.State != ConnectionState.Open)
                {
                    komut2.Connection.Open();
                }
                komut2.Parameters.AddWithValue("@P1", ent.Ad);
                komut2.Parameters.AddWithValue("@P2", ent.Soyad);
                komut2.Parameters.AddWithValue("@P3", ent.Tc);
                komut2.Parameters.AddWithValue("@P4", ent.Telefon);
                komut2.Parameters.AddWithValue("@P5", ent.Hesapno);
                komut2.Parameters.AddWithValue("@P6", ent.Sifre);

                return komut2.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public static List<EntityCustomer> AccountNumber()
        {
            try
            {
                List<EntityCustomer> AccountLog = new List<EntityCustomer>();
                SqlCommand komut3 = new SqlCommand("SELECT HESAPNO FROM MUSTERILER", SQLConn.conn);
                if (komut3.Connection.State != ConnectionState.Open)
                {
                    komut3.Connection.Open();
                }
                SqlDataReader dr2 = komut3.ExecuteReader();
                while (dr2.Read())
                {
                    EntityCustomer ent = new EntityCustomer();
                    ent.Hesapno = dr2["HESAPNO"].ToString();
                    AccountLog.Add(ent);
                }
                dr2.Close();
                return AccountLog;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static List<EntityCustomer> CustumerInfo(string hesapNo)
        {
            try
            {
                List<EntityCustomer> InfoLog = new List<EntityCustomer>();
                SqlCommand komut4 = new SqlCommand("SELECT * FROM MUSTERILER WHERE HESAPNO=@P1", SQLConn.conn);
                if (komut4.Connection.State != ConnectionState.Open)
                {
                    komut4.Connection.Open();
                }
                komut4.Parameters.AddWithValue("@P1", hesapNo);
                SqlDataReader dr3 = komut4.ExecuteReader();
                while (dr3.Read())
                {
                    EntityCustomer ent = new EntityCustomer();
                    ent.Ad = dr3["AD"].ToString();
                    ent.Soyad = dr3["SOYAD"].ToString();
                    ent.Hesapno = dr3["HESAPNO"].ToString();
                    ent.Tc = dr3["TC"].ToString();
                    ent.Telefon = dr3["TELEFON"].ToString();
                    InfoLog.Add(ent);
                }
                dr3.Close();
                return InfoLog;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static List<EntityTransactionsTransfer> MoneyTransferHistory(string hesapno)
        {
            try
            {
                List<EntityTransactionsTransfer> HistoryLog = new List<EntityTransactionsTransfer>();
                SqlCommand komut5 = new SqlCommand("SELECT AD,SOYAD,ALICI FROM HAREKETLER INNER JOIN MUSTERILER ON HAREKETLER.ALICI=MUSTERILER.HESAPNO WHERE GONDEREN=@P1 AND ISLEM='HAVALE'", SQLConn.conn);
                if (komut5.Connection.State != ConnectionState.Open)
                {
                    komut5.Connection.Open();
                }
                komut5.Parameters.AddWithValue("@P1", hesapno);
                SqlDataReader dr4 = komut5.ExecuteReader();
                while (dr4.Read())
                {
                    EntityTransactionsTransfer ent = new EntityTransactionsTransfer();
                    ent.Aliciisim = dr4["AD"] + " " + dr4["SOYAD"];
                    ent.Alici = dr4["ALICI"].ToString();
                    HistoryLog.Add(ent);
                }
                dr4.Close();
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
                SqlCommand komut6 = new SqlCommand(
                    "DECLARE @GonderenHesap char(7);" +
                    "DECLARE @AliciHesap char(7);" +
                    "DECLARE @TransferMiktari DECIMAL(18, 3);" +
                    "SET @GonderenHesap = @P1;" +
                    "SET @AliciHesap = @P2;" +
                    "SET @TransferMiktari = @P3;" +
                    "IF (SELECT BAKIYE FROM HESAPLAR WHERE HESAPNO = @GonderenHesap) >= @TransferMiktari " +
                    "BEGIN " +
                    "BEGIN TRANSACTION;" +
                    "UPDATE HESAPLAR SET BAKIYE = BAKIYE - @TransferMiktari WHERE HESAPNO = @GonderenHesap;" +
                    "UPDATE HESAPLAR SET BAKIYE = BAKIYE + @TransferMiktari WHERE HESAPNO = @AliciHesap;" +
                    "INSERT INTO HAREKETLER (GONDEREN, ALICI, TUTAR, ISLEM) " +
                    "VALUES (@GonderenHesap, @AliciHesap, @TransferMiktari, 'Havale');" +
                    "COMMIT;" +
                    "PRINT 'Para transferi başarıyla tamamlandı.'; " +
                    "END " +
                    "ELSE " +
                    "BEGIN " +
                    "PRINT 'Yetersiz bakiye! Para transferi iptal edildi.'; " +
                    "END", SQLConn.conn);

                if (komut6.Connection.State != ConnectionState.Open)
                {
                    komut6.Connection.Open();
                }

                komut6.Parameters.AddWithValue("@P1", ent.Gonderen);
                komut6.Parameters.AddWithValue("@P2", ent.Alici);
                komut6.Parameters.AddWithValue("@P3", ent.Tutar);

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
                return BalanceLog;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<EntityCustomer> TCNumber()
        {
            try
            {
                List<EntityCustomer> TcLog = new List<EntityCustomer>();
                SqlCommand komut8 = new SqlCommand("SELECT TC FROM MUSTERILER", SQLConn.conn);
                if (komut8.Connection.State != ConnectionState.Open)
                {
                    komut8.Connection.Open();
                }
                SqlDataReader dr5 = komut8.ExecuteReader();
                while (dr5.Read())
                {
                    EntityCustomer ent = new EntityCustomer();
                    ent.Tc = dr5["TC"].ToString();
                    TcLog.Add(ent);
                }
                dr5.Close();
                return TcLog;
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
                SqlCommand komut10 = new SqlCommand(
                    "DECLARE @GonderenHesap char(7);" +
                    "DECLARE @AliciHesap char(7);" +
                    "DECLARE @OdenecekTutar DECIMAL(18, 3);" +
                    "DECLARE @AboneNumarasi varchar(30);" +
                    "SET @GonderenHesap = @P1;" +
                    "SET @AliciHesap = @P2;" +
                    "SET @OdenecekTutar = @P3;" +
                    "SET @AboneNumarasi = @P4;" +
                    "IF (SELECT BAKIYE FROM HESAPLAR WHERE HESAPNO = @GonderenHesap) >= @OdenecekTutar " +
                    "BEGIN " +
                    "BEGIN TRANSACTION;" +
                    "UPDATE HESAPLAR SET BAKIYE = BAKIYE - @OdenecekTutar WHERE HESAPNO = @GonderenHesap;" +
                    "UPDATE HESAPLAR SET BAKIYE = BAKIYE + @OdenecekTutar WHERE HESAPNO = @AliciHesap;" +
                    "INSERT INTO FATURALAR (GONDERENNO,ALICINO,ABONENO,TUTAR)"+
                    "VALUES (@GonderenHesap,@AliciHesap,@AboneNumarasi,@OdenecekTutar)" +
                    "INSERT INTO HAREKETLER (GONDEREN, ALICI, TUTAR, ISLEM) " +
                    "VALUES (@GonderenHesap, @AliciHesap, @OdenecekTutar, 'Fatura');" +
                    "COMMIT;" +
                    "PRINT 'Fatura ödemesi başarıyla tamamlandı.'; " +
                    "END " +
                    "ELSE " +
                    "BEGIN " +
                    "PRINT 'Yetersiz bakiye! Fatura ödeme iptal edildi.'; " +
                    "END", SQLConn.conn);

                if (komut10.Connection.State != ConnectionState.Open)
                {
                    komut10.Connection.Open();
                }

                komut10.Parameters.AddWithValue("@P1", ent.GonderenNo);
                komut10.Parameters.AddWithValue("@P2", ent.AliciNo);
                komut10.Parameters.AddWithValue("@P3", ent.Tutar);
                komut10.Parameters.AddWithValue("@P4", ent.AboneNo);

                return komut10.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<EntityTransactionsTransfer> PayingBillsHistory(string hesapno)
        {
            try
            {
                List<EntityTransactionsTransfer> HistoryLog = new List<EntityTransactionsTransfer>();
                SqlCommand komut11 = new SqlCommand("SELECT AD,ALICI FROM HAREKETLER INNER JOIN MUSTERILER ON HAREKETLER.ALICI=MUSTERILER.HESAPNO WHERE GONDEREN=@P1 AND ISLEM='Fatura'", SQLConn.conn);
                if (komut11.Connection.State != ConnectionState.Open)
                {
                    komut11.Connection.Open();
                }
                komut11.Parameters.AddWithValue("@P1", hesapno);
                SqlDataReader dr4 = komut11.ExecuteReader();
                while (dr4.Read())
                {
                    EntityTransactionsTransfer ent = new EntityTransactionsTransfer();
                    ent.Aliciisim = dr4["AD"].ToString();
                    ent.Alici = dr4["ALICI"].ToString();
                    HistoryLog.Add(ent);
                }
                dr4.Close();
                return HistoryLog;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
