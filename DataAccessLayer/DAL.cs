using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DAL
    {
        private SqlConnection conn = new SqlConnection();
        private SqlDataAdapter adapter = new SqlDataAdapter();
        private SqlCommandBuilder builder = new SqlCommandBuilder();

        public DAL(string sqlConnectionString)
        {
            conn.ConnectionString = sqlConnectionString;
            builder.DataAdapter = adapter;
        }

        public void Open()
        {
            conn.Open();
        }

        public void Close()
        {
            conn.Close();
        }

        public int InsertUpdateDelete(SqlCommand command)
        {
            int numRowSet;
            command.Connection = conn;

            if (conn.State == System.Data.ConnectionState.Closed)
            {
                Open();
                numRowSet = command.ExecuteNonQuery();
                Close();
            }
            else
            {
                numRowSet = command.ExecuteNonQuery();
            }
            return numRowSet;
        }

        public DataTable GetTable(SqlCommand command)
        {
            DataTable dt = new DataTable();
            command.Connection = conn;
            adapter.SelectCommand = command;
            adapter.Fill(dt);
            return dt;
        }

        public void UpdateTable(DataTable table)
        {
            adapter.Update(table);
        }
    }
}
