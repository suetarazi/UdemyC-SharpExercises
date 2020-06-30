using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace SQL_OracleConnection
{
    class DbConnection
    {
        public string ConnectionString {get; set;}
        public TimeSpan TimeOut { get; set; }

        public void DatabaseConnection()
        {
            DbConnection connection = new DbConnection();

            if (connection.IsValid)
            {

            }

        }

        public abstract OpenConnection()
        {

        }

        public abstract CloseConnection()
        {

        }
    }
}
