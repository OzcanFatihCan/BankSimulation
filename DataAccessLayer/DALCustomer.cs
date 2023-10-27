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
    }
}
