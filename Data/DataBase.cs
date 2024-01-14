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
        public static SqlParameter CreateSqlParameter(string parameterName, object value, System.Data.SqlDbType sqlDbType, int size = 0)
        {
            SqlParameter parameter = new SqlParameter(parameterName, sqlDbType);
            parameter.Value = value ?? DBNull.Value;

            if (size > 0)
            {
                parameter.Size = size;
            }

            return parameter;
        }
        private List<SqlParameter> GenerateSQLParameters(object model)
        {
            var paramList = new List<SqlParameter>();
            Type modelType = model.GetType();
            var properties = modelType.GetProperties();
            foreach (var property in properties)
            {
                if (property.GetValue(model) == null)
                {
                    paramList.Add(new SqlParameter(property.Name, DBNull.Value));
                }
                else
                {
                    paramList.Add(new SqlParameter(property.Name, property.GetValue(model)));
                }
            }
            return paramList;

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
