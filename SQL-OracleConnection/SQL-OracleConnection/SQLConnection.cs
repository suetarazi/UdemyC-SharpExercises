using System;
using System.Collections.Generic;
using System.Text;

namespace SQL_OracleConnection
{
    public class SQLConnection : DbConnection
    {
        public void OpenConnection()
        {
            Console.WriteLine("Are you ready to open a SQL connection?");
        }

        public void CloseConnection()
        {
            Console.WriteLine("Connection now closing");
        }
    }
}
