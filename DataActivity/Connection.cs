using System;
using System.Configuration;
using System.Data.SqlClient;

namespace DataActivity
{
    public static class Connection
    {
        //public Connection()
        //{
        //    _ConnectionString = ConfigurationManager.ConnectionStrings["FinanceConnectionString"].ConnectionString;
        //}
        private static string _ConnectionString;
        public static string ConnectionString { get { return _ConnectionString; } set { _ConnectionString = value; } }

        public static bool ConnectionChecking()
        {
            SqlConnection sqlConnection;
            try
            {
                sqlConnection = new SqlConnection(Connection.ConnectionString);
            }
            catch
            {
                return false;
            }
            try
            {
                sqlConnection.Open();
            }
            catch
            {
                return false;

            }
            finally
            {
                if (sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    sqlConnection.Close();
                }
            }
            return true;
        }

    }
}
