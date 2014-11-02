using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HillyBillyDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Data.SqlClient.SqlConnection sqlConn = new System.Data.SqlClient.SqlConnection("workstation id=rockybalboa.mssql.somee.com;packet size=4096;user id=qmr;pwd=qqqqqqqq;data source=rockybalboa.mssql.somee.com;persist security info=False;initial catalog=rockybalboa");
            sqlConn.Open();
            System.Data.SqlClient.SqlCommand sqlComm = new System.Data.SqlClient.SqlCommand("select* from tbl;", sqlConn);
            //Console.WriteLine(sqlConn.Database); // rockybalboa //
            //int i = sqlComm.ExecuteNonQuery();
            //Console.WriteLine(i);
            System.Data.SqlClient.SqlDataReader sqlDR = sqlComm.ExecuteReader();
            Console.WriteLine(sqlDR.FieldCount.ToString());
            Console.WriteLine(sqlDR.GetName(0));
            Console.WriteLine(sqlDR.GetName(1));
            Console.WriteLine(sqlDR.GetName(2));
            System.Data.DataTable dT = sqlDR.GetSchemaTable();
            //Console.WriteLine(sqlDR.GetInt16(1).ToString());
            //Console.WriteLine(sqlDR.GetString(0));
            //Console.WriteLine(sqlDR.GetString(1));
            //Console.WriteLine(sqlDR.GetString(2));
            sqlDR.Close();
            sqlConn.Close();
            return;
        }
    }
}
