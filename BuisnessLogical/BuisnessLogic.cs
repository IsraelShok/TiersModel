using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BuisnessLogical
{
    public class BuisnessLogic
    {
        public static DAL dl = new DAL("Data Source=SRRAAHOSQL1;Initial Catalog=HOST;Persist Security Info=True;User ID=sa;Password=ho");

        public static DataTable GetStores()
        {
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand();
            command.CommandText = "select * from Stores where iStoreId = 1";
            table = dl.GetTable(command);
            return table;
        }

        public static DataTable GetItemInfo()
        {
            DataTable table = new DataTable();

            table = dl.GetTable(new System.Data.SqlClient.SqlCommand("select * from ItemInfo"));
            return table;
        }
    }
}
