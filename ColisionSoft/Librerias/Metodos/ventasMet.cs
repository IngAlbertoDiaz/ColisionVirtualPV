using System;
using System.Data.SqlClient;
using System.Data;

namespace ColisionSoft
{
    class ventasMet
    {
        //CREATE

        public int Create(string query)
        {
            DBConn db = new DBConn();
            db.sqlConnection.ConnectionString = db.dbString;
            db.sqlConnection.Open();
            db.sqlCommand.CommandText = query;
            db.sqlCommand.Connection = db.sqlConnection;
            int rInsert = db.sqlCommand.ExecuteNonQuery();
            db.sqlConnection.Close();

            return rInsert;
        }

        //READ

        //UPDATE

        //DELETE

    }
}
