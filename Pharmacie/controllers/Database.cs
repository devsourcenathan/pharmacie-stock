using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
namespace Pharmacie.controllers
{
    class Database
    {
        private static OdbcConnection connection = null;

        public static OdbcConnection getConnection()
        {
            if(connection == null)
            {
                connection = new OdbcConnection("dsn=pharmacie");
                connection.Open();
            }

            return connection;
        }
    }
}
