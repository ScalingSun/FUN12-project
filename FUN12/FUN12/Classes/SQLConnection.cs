using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace FUN12
{
    class SQLConnection
    {
        public SqlConnection conn;
        const string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Tim\source\repos\FUN12\FUN12\FUN12.mdf;Integrated Security=True";
        public SQLConnection()
        {
            conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();
        }

    }
}
