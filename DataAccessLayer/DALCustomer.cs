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
    }
}
