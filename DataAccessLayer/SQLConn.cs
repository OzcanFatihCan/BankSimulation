using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class SQLConn
    {
       public static SqlConnection conn=new SqlConnection("Data Source=FatihBuzac\\SQLEXPRESS;Initial Catalog=DbBanka;Integrated Security=True");
    }
}
