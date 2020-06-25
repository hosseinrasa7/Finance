using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataActivity
{
    public class DataOperation
    {
        

        //private static SqlConnection  sqlConnection= new SqlConnection(Connection.ConnectionString);
        //public void ExecuteQuery(string query)
        //{
        //    using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
        //    {
        //        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
        //        sqlConnection.Open();

        //        SqlDataReader reader = sqlCommand.ExecuteReader();
        //        DataTable schemaTable = reader.GetSchemaTable();

        //        foreach (DataRow row in schemaTable.Rows)
        //        {
        //            foreach (DataColumn column in schemaTable.Columns)
        //            {
        //                Console.WriteLine(String.Format("{0} = {1}",
        //                   column.ColumnName, row[column]));
        //            }
        //        }
        //    }
        //}

        public List<string> GetDatabaseList(string con)
        {
            string command = "SELECT * FROM sys.databases";
            using (SqlCommand sqlCommand = new SqlCommand(command, new SqlConnection( con)))
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

               
                return (from DataRow row in dataTable.Rows select row["name"].ToString()).ToList();

            }
        }
    }
}
