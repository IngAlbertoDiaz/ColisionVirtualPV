using System.Data.SqlClient;

namespace ColisionSoft
{
    class DBConn
    {
        public SqlConnection sqlConnection = new SqlConnection();
        public SqlCommand sqlCommand = new SqlCommand();
        public string dbString = @"Data Source=(LocalDB)\MSSQLLocalDB;
                              AttachDbFilename=|DataDirectory|\ColisionSoft.mdf;
                              Integrated Security=True";
    }
}
