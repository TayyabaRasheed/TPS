using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace MiniProject
{
    class DbConnect
    {
        private static DbConnect instance;
        public String ConnectionString;
        private SqlConnection connection;


        public static DbConnect getInstance()
        {
            if (instance == null)
                instance = new DbConnect();
            return instance;
        }

        private DbConnect()
        {

        }

        public SqlConnection getConnection()
        {
            connection = new SqlConnection(ConnectionString);
            if (connection.State != System.Data.ConnectionState.Open)
                connection.Open();
            return connection;
        }

        public SqlDataReader getData(String commnadText)
        {
            connection = getConnection();
            SqlCommand cmd = new SqlCommand(commnadText, connection);
            SqlDataReader reader = cmd.ExecuteReader();
            return reader;
        }

        public int exectuteQuery(String commnadText)
        {
            connection = getConnection();
            SqlCommand cmd = new SqlCommand(commnadText, connection);
            int rows = cmd.ExecuteNonQuery();
            return rows;
        }

        public void closeConnection()
        {
            if (connection != null)
                connection.Close();
        }
    }
}
