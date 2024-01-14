using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace simrs.Data
{
    internal class DataBase
    {
        /**
         * Object SqlConnection
         */
        private SqlConnection connection;
        /**
         * Object data adapter
         */
        private SqlDataAdapter adapter;

        /**
         * Object data sql command
         */
        SqlCommand command;

        static private string GetConnectionString()
        {

            string dbHost = ConfigurationManager.AppSettings.Get("db_host");
            string db_user = ConfigurationManager.AppSettings.Get("db_user");
            string db_password = ConfigurationManager.AppSettings.Get("db_password");
            string db_name = ConfigurationManager.AppSettings.Get("db_name");

            string dsn = $"Data Source={dbHost};Initial Catalog={db_name};user id={db_user};Password={db_password}";

            return dsn;
        }

        /**
         * Koneksi ke DBMS
         * 
        */
        public void Connect()
        {
            string connectionString = GetConnectionString();
            this.connection = new SqlConnection();

            this.connection.ConnectionString = connectionString;
            this.connection.Open();
        }
        public void Close()
        {
            this.connection.Close();    
        }
        /**
         * digunakan untuk mendapatkan data dari table
         * @param sql perintah sql
         */
        public DataSet GetDataSet(string sql)
        {
            this.adapter = new SqlDataAdapter(sql, this.connection);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);

            return dataSet;
        }
        public Dictionary<string, string> GetSingleRecord(string sql)
        {
            Dictionary<string, string> singleRecord = new Dictionary<string, string>();

            using (this.command = new SqlCommand(sql, this.connection))
            {
                using (SqlDataReader reader = this.command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            singleRecord.Add(reader.GetName(i), reader[i].ToString());
                        }
                    }
                }
            }
            return singleRecord;
        }
        public void InsertRecord(string sql)
        {
            this.command = new SqlCommand(sql, this.connection);
            this.command.ExecuteNonQuery(); 
        }
        
        public void DeleteRecord(string sql)
        {
            this.command = new SqlCommand(sql, this.connection);
            this.command.ExecuteNonQuery(); 
        }

        public void ExecuteStoredProcedure(string procedureName)
        {
            this.command = new SqlCommand(procedureName, this.connection);
            this.command.CommandType = CommandType.StoredProcedure;
            this.command.ExecuteNonQuery();
        }
        public void ExecuteStoredProcedure(string procedureName, List<SqlParameter> parameters)
        {
            this.command = new SqlCommand(procedureName, this.connection);
            this.command.CommandType = CommandType.StoredProcedure;

            foreach (var param in parameters)
            {
                this.command.Parameters.Add(param);
            }

            this.command.ExecuteNonQuery();
        }
        public bool checkRecordIsExist(string sql)
        {
            bool exist = false;

            this.command = new SqlCommand(sql, this.connection);
            this.command.ExecuteNonQuery();

            int jumlahRecord = (int)this.command.ExecuteScalar();
            if (jumlahRecord > 0)
            { 
                exist = true; 
            }
            return exist;
        }
    }

}
