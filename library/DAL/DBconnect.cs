using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
namespace library.DAL
{
    class DBconnect
    {
        public static string connection = ConfigurationManager.ConnectionStrings["library.Properties.Settings.libraryConnectionString"].ConnectionString;
        public static SqlConnection conn = new SqlConnection(connection);
        public SqlCommand cmd = new SqlCommand();
        public DBconnect()
        {
            openconnection();
        }
        void openconnection()
        {
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
        }

    }
}
