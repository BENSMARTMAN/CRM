using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM
{
    public static class DatabaseHelper
    {
        public static SqlConnection GetDatabaseConnection()
        {
            var connectionString = "Server=127.0.0.1;Database=CRM;User Id=SYSADM;Password=SYSADM";
            // 可以根據需要設置不同的連線字串

            var connection = new SqlConnection(connectionString);
            connection.Open();
            return connection;
        }
    }
}
