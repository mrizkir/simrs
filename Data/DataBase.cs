using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;

namespace simrs.Data
{
    internal class DataBase
    {
        /**
         * Object SqlConnection
         */
        private SqlConnection connection;
        /**
         * Koneksi ke DBMS
         * 
        */
        public void Connect()
        {
            string connectionString = GetConnectionString();

            using (this.connection = new SqlConnection())
            {
                this.connection.ConnectionString = connectionString;
                this.connection.Open();
            }
        }
        static private string GetConnectionString()
        {

            string dbHost = ConfigurationManager.AppSettings.Get("db_host");
            string db_user = ConfigurationManager.AppSettings.Get("db_user");
            string db_password = ConfigurationManager.AppSettings.Get("db_password");
            string db_name = ConfigurationManager.AppSettings.Get("db_name");

            string dsn = $"Data Source={dbHost};Initial Catalog={db_name};user id={db_user};Password={db_password}";

            return dsn;
        }
    }
}
