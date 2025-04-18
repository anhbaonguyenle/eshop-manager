using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_ShopManager
{
    class DBHelper
    {
        private static DBHelper _instance;
        private string connectionString;

        private DBHelper()
        {
            connectionString = @"Data Source=BAOANH;Initial Catalog=eShop;Integrated Security=True;TrustServerCertificate=True";
        }

        public static DBHelper Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DBHelper();
                }
                return _instance;
            }
        }

        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }


}
