using Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    /// <summary>
    /// ADO işlemlerinde kullanılan class  
    /// </summary>
    public class ADODataAccess
    {

        private static readonly string connectionString = "Data Source=DESKTOP-4FUOTSR;Initial Catalog=Test;Integrated Security=True";
        /// <summary>
        /// SqlServer Select sorguları için kullanılacak metot
        /// </summary>
        /// <param name="sqlQuery"></param>
        /// <returns></returns>
        public static DataTable SelectQuery(string sqlQuery, Dictionary<string, object> dictionary = null,
            Enums.CommandType commandType = Enums.CommandType.StoredProcedure)
        {
            DataTable dataTable = new DataTable();

            SqlConnection sqlConnection = new SqlConnection(connectionString);

            sqlConnection.Open();

            SqlCommand sqlCommand = new SqlCommand(sqlQuery, sqlConnection);

            //commandType = Enums.CommandType.StoredProcedure;

            if (commandType == Enums.CommandType.StoredProcedure)
            {
                sqlCommand.CommandType = CommandType.StoredProcedure;
            }

            if (dictionary != null)
            {
                foreach (var item in dictionary)
                {
                    sqlCommand.Parameters.AddWithValue(item.Key, item.Value);
                }
            }

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

            sqlDataAdapter.Fill(dataTable);

            sqlConnection.Close();

            return dataTable;
        }

        /// <summary>
        /// SqlServer Insert Delete Update sorguları için kullanılacak metot
        /// </summary>
        /// <param name="sqlQuery"></param>
        /// <returns></returns>
        public static int InsertDeleteUpdateQuery(string sqlQuery, Dictionary<string, object> dictionary = null,
            Enums.CommandType commandType = Enums.CommandType.StoredProcedure)
        {
            int result;

            SqlConnection sqlConnection = new SqlConnection(connectionString);

            sqlConnection.Open();

            SqlCommand sqlCommand = new SqlCommand(sqlQuery, sqlConnection);

            sqlCommand.CommandType = CommandType.StoredProcedure;

            if (dictionary != null)
            {
                foreach (var item in dictionary)
                {
                    sqlCommand.Parameters.AddWithValue(item.Key, item.Value);
                }
            }

            result = sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();

            return result;
        }

    }


}
