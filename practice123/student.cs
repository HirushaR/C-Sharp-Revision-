using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace practice123
{
    class student:login
    {
        //this is used abstraction oop concept
        //log is abstact method in login class its ablasct class
        //we override the log method 
        public override int log(string nm, string pw)
        {

            using (var connection = DB.GetConnection())
            {
                string qry = "select * from alluser where admin = 0 and username= '"+nm+"' and password = '"+pw+"' ";
                SqlCommand cmd = new SqlCommand(qry, connection);

                connection.Open();
                SqlDataReader sr = cmd.ExecuteReader();
                if (sr.Read())
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
