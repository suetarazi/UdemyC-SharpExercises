using System;
using System.Collections.Generic;
using System.Text;

namespace SQL_OracleConnection
{
    class OracleConnection : DbConnection
    {
        public void OpenConnection()
        {
            Console.WriteLine("Opening an Oracle connection");
        }

        public void CloseConnection()
        {
            Console.WriteLine("Closing Oracle connection");
        }
    }
}
