using System;

namespace Polymorph
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection sqlConnection = new SqlConnection("AZFBISRAD01");
            Execute(sqlConnection, "SELECT * FROM SQL");
            

            OracleConnection oracleConnection = new OracleConnection("AZFBIDA02");
            Execute(oracleConnection, "SELECT * FROM Oracle");
        }

        public static void Execute(DbConnection conn, string query)
        {
            conn.Open();
            DbCommand sqldb = new DbCommand(conn,query);
            conn.Close();
        }
    }
}
