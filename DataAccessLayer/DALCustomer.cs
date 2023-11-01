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
    }
}
