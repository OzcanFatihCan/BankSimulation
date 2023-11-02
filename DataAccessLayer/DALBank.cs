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
        public static List<EntityMovement> MoneyTransferHistory(string hesapno)
        {
            try
            {
                List<EntityMovement> HistoryLog = new List<EntityMovement>();
                SqlCommand komut5 = new SqlCommand("SELECT AD,SOYAD,ALICI,TUTAR FROM HAREKETLER INNER JOIN MUSTERILER ON HAREKETLER.ALICI=MUSTERILER.HESAPNO WHERE GONDEREN=@P1 AND ISLEM='HAVALE'", SQLConn.conn);
                if (komut5.Connection.State != ConnectionState.Open)
                {
                    komut5.Connection.Open();
                }
                komut5.Parameters.AddWithValue("@P1", hesapno);
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
                    "DECLARE @TransferMiktari DECIMAL(18, 2);" +
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
                    "DECLARE @OdenecekTutar DECIMAL(18, 2);" +
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

        public static List<EntityMovement> PayingBillsHistory(string hesapno)
        {
            try
            {
                List<EntityMovement> HistoryLog = new List<EntityMovement>();
                SqlCommand komut11 = new SqlCommand("SELECT AD,ALICI,TUTAR FROM HAREKETLER INNER JOIN MUSTERILER ON HAREKETLER.ALICI=MUSTERILER.HESAPNO WHERE GONDEREN=@P1 AND ISLEM='Fatura'", SQLConn.conn);
                if (komut11.Connection.State != ConnectionState.Open)
                {
                    komut11.Connection.Open();
                }
                komut11.Parameters.AddWithValue("@P1", hesapno);
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
                    "DECLARE @YatirilacakTutar DECIMAL(18, 2);" +
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
                    "DECLARE @CekilecekTutar DECIMAL(18, 2);" +
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

        public static int CreditCardDebt(EntityTransfer ent)
        { 
            try
            {
                SqlCommand komut14 = new SqlCommand(
                    "DECLARE @GonderenHesap char(7);" +
                    "DECLARE @AliciHesap char(7);" +
                    "DECLARE @CekilecekTutar DECIMAL(18, 2);" +
                    "DECLARE @KrediTutar DECIMAL(18,2);" +
                    "DECLARE @HesapBakiye DECIMAL(18,2);" +
                    "SET @GonderenHesap = @P1;" +
                    "SET @AliciHesap = @P2;" +
                    "SET @CekilecekTutar = @P3;" +
                    "BEGIN " +
                    "SELECT @HesapBakiye= BAKIYE FROM HESAPLAR WHERE HESAPNO=@AliciHesap;" +
                    "SELECT @KrediTutar= @CekilecekTutar-@HesapBakiye;" +
                    "BEGIN TRANSACTION;" +
                    "INSERT INTO HAREKETLER (GONDEREN, ALICI, TUTAR, ISLEM)" +
                    "VALUES (@GonderenHesap, @AliciHesap, @HesapBakiye, 'Para Çekme');" +
                    "UPDATE HESAPLAR SET BAKIYE = BAKIYE - @HesapBakiye WHERE HESAPNO = @AliciHesap;" +
                    "UPDATE BORCLAR SET BORC=BORC+@KrediTutar WHERE HESAPNO=@AliciHesap;" +
                    "INSERT INTO HAREKETLER (GONDEREN, ALICI, TUTAR, ISLEM) " +
                    "VALUES ('5060073', @AliciHesap, @KrediTutar, 'Kredi Çekme');" +
                    "COMMIT;" +
                    "PRINT 'Para çekim işlemi tamamlandı'; " +
                    "END ", SQLConn.conn) ;

                if (komut14.Connection.State != ConnectionState.Open)
                {
                    komut14.Connection.Open();
                }

                komut14.Parameters.AddWithValue("@P1", ent.Alici);
                komut14.Parameters.AddWithValue("@P2", ent.Alici);
                komut14.Parameters.AddWithValue("@P3", ent.Tutar);

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
                SqlCommand komut16 = new SqlCommand(
                   "DECLARE @GonderenHesap char(7);" +                 
                   "DECLARE @OdenecekTutar DECIMAL(18, 2);" +
                   "SET @GonderenHesap = @P1;" +                
                   "SET @OdenecekTutar = @P2;" +
                   "IF (SELECT BAKIYE FROM HESAPLAR WHERE HESAPNO = @GonderenHesap) >= @OdenecekTutar " +
                   "BEGIN " +
                   "BEGIN TRANSACTION;" +
                   "UPDATE HESAPLAR SET BAKIYE = BAKIYE - @OdenecekTutar WHERE HESAPNO = @GonderenHesap;" +
                   "UPDATE BORCLAR SET BORC = BORC - @OdenecekTutar WHERE HESAPNO=@GonderenHesap;"+
                   "INSERT INTO HAREKETLER (GONDEREN, ALICI, TUTAR, ISLEM) " +
                   "VALUES (@GonderenHesap, '5060073',@OdenecekTutar, 'Kredi Ödeme');" +
                   "COMMIT;" +
                   "PRINT 'Kredi ödemesi başarıyla tamamlandı.'; " +
                   "END " +
                   "ELSE " +
                   "BEGIN " +
                   "PRINT 'Yetersiz bakiye! Kredi ödeme iptal edildi.'; " +
                   "END", SQLConn.conn);

                if (komut16.Connection.State != ConnectionState.Open)
                {
                    komut16.Connection.Open();
                }
                komut16.Parameters.AddWithValue("@P1", ent.Gonderen);
                komut16.Parameters.AddWithValue("@P2", ent.Tutar);

                return komut16.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<EntityMovementDetailed> AccountStatementFetch(string hesapNo)
        {
            try
            {
                List<EntityMovementDetailed> AccountStatementLog = new List<EntityMovementDetailed>();
                SqlCommand komut17 = new SqlCommand(
                    "SELECT GonderenMusteri.AD + ' ' + GonderenMusteri.SOYAD AS 'Gönderen', " +
                    "AlıcıMusteri.AD + ' ' + AlıcıMusteri.SOYAD AS 'Alıcı', " +
                    "Hareketler.TUTAR, " +
                    "Hareketler.ISLEM " +
                    "FROM HAREKETLER " +
                    "INNER JOIN MUSTERILER AS GonderenMusteri ON Hareketler.GONDEREN = GonderenMusteri.HESAPNO " +
                    "INNER JOIN MUSTERILER AS AlıcıMusteri ON Hareketler.ALICI = AlıcıMusteri.HESAPNO " +
                    "WHERE HAREKETLER.GONDEREN = @P1 OR HAREKETLER.ALICI = @P2", SQLConn.conn);
                if (komut17.Connection.State != ConnectionState.Open)
                {
                    komut17.Connection.Open();
                }
                komut17.Parameters.AddWithValue("@P1", hesapNo);
                komut17.Parameters.AddWithValue("@P2", hesapNo);
                SqlDataReader dr9 = komut17.ExecuteReader();
                while (dr9.Read())
                {
                    EntityMovementDetailed ent = new EntityMovementDetailed();
                    ent.Gonderen = dr9["Gönderen"].ToString();
                    ent.Alici = dr9["Alıcı"].ToString();
                    ent.Tutar = double.Parse(dr9["Tutar"].ToString());
                    ent.Islem = dr9["Islem"].ToString();
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