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

        public static List<EntityCustomer> CustumerInfo(string hesapNo)
        {
            List<EntityCustomer> InfoLog = new List<EntityCustomer>();
            SqlCommand komut4 = new SqlCommand("SELECT * FROM MUSTERILER WHERE HESAPNO=@P1", SQLConn.conn);
            if (komut4.Connection.State != ConnectionState.Open)
            {
                komut4.Connection.Open();
            }
            komut4.Parameters.AddWithValue("@P1", hesapNo);
            SqlDataReader dr3=komut4.ExecuteReader();      
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

        public static List<EntityTransactionsTransfer> MoneyTransferHistory(string hesapno)
        {
            List<EntityTransactionsTransfer> HistoryLog= new List<EntityTransactionsTransfer>();
            SqlCommand komut5 = new SqlCommand("SELECT AD,SOYAD,ALICI FROM HAREKETLER INNER JOIN MUSTERILER ON HAREKETLER.ALICI=MUSTERILER.HESAPNO WHERE GONDEREN=@P1", SQLConn.conn);
            if (komut5.Connection.State != ConnectionState.Open)
            {
                komut5.Connection.Open();
            }
            komut5.Parameters.AddWithValue("@P1",hesapno);
            SqlDataReader dr4=komut5.ExecuteReader();
            while (dr4.Read())
            {
                EntityTransactionsTransfer ent=new EntityTransactionsTransfer();
                ent.Aliciisim = dr4["AD"] + " " + dr4["SOYAD"];
                ent.Alici = dr4["ALICI"].ToString();
                HistoryLog.Add(ent);
            }
            dr4.Close();
            return HistoryLog;
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
    }
}
