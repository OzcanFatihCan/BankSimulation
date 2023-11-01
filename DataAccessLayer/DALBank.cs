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
    public class DALBank
    {
        public static List<EntityTransactionsTransfer> MoneyTransferHistory(string hesapno)
        {
            try
            {
                List<EntityTransactionsTransfer> HistoryLog = new List<EntityTransactionsTransfer>();
                SqlCommand komut5 = new SqlCommand("SELECT AD,SOYAD,ALICI,TUTAR FROM HAREKETLER INNER JOIN MUSTERILER ON HAREKETLER.ALICI=MUSTERILER.HESAPNO WHERE GONDEREN=@P1 AND ISLEM='HAVALE'", SQLConn.conn);
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
                    ent.Tutar = double.Parse(dr4["TUTAR"].ToString());
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
                    "INSERT INTO FATURALAR (GONDERENNO,ALICINO,ABONENO,TUTAR)" +
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
                SqlCommand komut11 = new SqlCommand("SELECT AD,ALICI,TUTAR FROM HAREKETLER INNER JOIN MUSTERILER ON HAREKETLER.ALICI=MUSTERILER.HESAPNO WHERE GONDEREN=@P1 AND ISLEM='Fatura'", SQLConn.conn);
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
                    ent.Tutar = double.Parse(dr4["TUTAR"].ToString());
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

        public static int DepositTransaction(EntityTransfer ent)
        {
            try
            {
                SqlCommand komut12 = new SqlCommand(
                    "DECLARE @GonderenHesap char(7);" +
                    "DECLARE @AliciHesap char(7);" +
                    "DECLARE @YatirilacakTutar DECIMAL(18, 3);" +
                    "SET @GonderenHesap = @P1;" +
                    "SET @AliciHesap = @P2;" +
                    "SET @YatirilacakTutar = @P3;" +                 
                    "BEGIN " +
                    "BEGIN TRANSACTION;" +                   
                    "UPDATE HESAPLAR SET BAKIYE = BAKIYE + @YatirilacakTutar WHERE HESAPNO = @AliciHesap;" +
                    "INSERT INTO HAREKETLER (GONDEREN, ALICI, TUTAR, ISLEM) " +
                    "VALUES (@GonderenHesap, @AliciHesap, @YatirilacakTutar, 'Para Yatırma');" +
                    "COMMIT;" +
                    "PRINT 'Hesaba para geldi.'; " +
                    "END ",SQLConn.conn);

                if (komut12.Connection.State != ConnectionState.Open)
                {
                    komut12.Connection.Open();
                }

                komut12.Parameters.AddWithValue("@P1", ent.Gonderen);
                komut12.Parameters.AddWithValue("@P2", ent.Gonderen);
                komut12.Parameters.AddWithValue("@P3", ent.Tutar);

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
                SqlCommand komut13 = new SqlCommand(
                    "DECLARE @GonderenHesap char(7);" +
                    "DECLARE @AliciHesap char(7);" +
                    "DECLARE @CekilecekTutar DECIMAL(18, 3);" +
                    "SET @GonderenHesap = @P1;" +
                    "SET @AliciHesap = @P2;" +
                    "SET @CekilecekTutar = @P3;" +
                    "IF (SELECT BAKIYE FROM HESAPLAR WHERE HESAPNO = @GonderenHesap) >= @CekilecekTutar " +
                    "BEGIN " +
                    "BEGIN TRANSACTION;" +
                    "UPDATE HESAPLAR SET BAKIYE = BAKIYE - @CekilecekTutar WHERE HESAPNO = @GonderenHesap;" +                   
                    "INSERT INTO HAREKETLER (GONDEREN, ALICI, TUTAR, ISLEM) " +
                    "VALUES (@GonderenHesap, @AliciHesap, @CekilecekTutar, 'Para Çekme');" +
                    "COMMIT;" +
                    "PRINT 'Para çekim işlemi tamamlandı'; " +
                    "END " +
                    "ELSE " +
                    "BEGIN " +
                    "PRINT 'Yetersiz bakiye! Para çekim işlemi iptal edildi.'; " +
                    "END", SQLConn.conn);

                if (komut13.Connection.State != ConnectionState.Open)
                {
                    komut13.Connection.Open();
                }

                komut13.Parameters.AddWithValue("@P1", ent.Alici);
                komut13.Parameters.AddWithValue("@P2", ent.Alici);
                komut13.Parameters.AddWithValue("@P3", ent.Tutar);

                return komut13.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
