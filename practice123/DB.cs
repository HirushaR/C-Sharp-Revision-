using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace practice123
{
    class DB
    {
        public static SqlConnection GetConnection()
        {
            // this is database class
            string conn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\hiru\works\C#\practice123\new1.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection mycon = new SqlConnection(conn);
            return mycon;
        }
      
    }
}
