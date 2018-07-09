using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace ColisionSoft
{
    class DBCon
    {
        public SqlConnection _CONN = new SqlConnection();
        public SqlCommand _CMD = new SqlCommand();
        public string _DB = @"Data Source=(LocalDB)\MSSQLLocalDB;
                              AttachDbFilename=|DataDirectory|\ColisionSoft.mdf;
                              Integrated Security=True";
    }
}
