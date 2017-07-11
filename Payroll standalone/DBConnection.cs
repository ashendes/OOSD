using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll_standalone
{
    
    class DBConnection
    {
        private static Queue<MySqlConnection> connectionPool = new Queue<MySqlConnection>();

        public static void setupDBConnection()
        {
            for(int i=0; i<5; i++)
            {
                connectionPool.Enqueue(new MySqlConnection("datasource=localhost;port=3306;database=softwaredb;username=root;password="));
            }
        }

        public static MySqlConnection getDBConnection()
        {
            return connectionPool.Dequeue();
        }

        public static void releaseDBConnection(MySqlConnection dbConnection)
        {
            connectionPool.Enqueue(dbConnection);
        }
    }
}
