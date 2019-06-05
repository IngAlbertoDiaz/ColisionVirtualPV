using System;
using System.Data;
using System.Data.SqlClient;

namespace ColisionSoft
{
    class invMet
    {
        
        //CREATE

        public static int Agregar(gsInventario gsi)
        {
            DBConn db = new DBConn();
            db.sqlConnection.ConnectionString = db.dbString;
            db.sqlConnection.Open();
            string query = "INSERT INTO inventario (codigo,marca,tipo,medida,color,descripcion,cantidad,precio_unitario)  VALUES ('"
                + gsi.codigo + "', '"
                + gsi.marca + "', '"
                + gsi.tipo + "', '"
                + gsi.medida + "', '"
                + gsi.color + "', '"
                + gsi.descripcion + "', '"
                + gsi.cantidad + "', '"
                + gsi.precio_unitario +"')";
            db.sqlCommand.CommandText = query;
            db.sqlCommand.Connection = db.sqlConnection;
            int res = db.sqlCommand.ExecuteNonQuery();
            db.sqlConnection.Close();

            return res;
        }

        //READ

        public DataTable ConsultarInventario(string pConsulta)
        {
            DBConn db = new DBConn();
            DataTable resultado = new DataTable();
            db.sqlConnection.ConnectionString = db.dbString;
            db.sqlConnection.Open();
            string query = null;
            if (pConsulta == null)
            {
                query = "SELECT * FROM inventario";
            }
            else
            {
                query = pConsulta;
            }
            SqlDataAdapter sql = new SqlDataAdapter(query, db.sqlConnection);
            sql.Fill(resultado);
            db.sqlConnection.Close();
            return resultado;
        }

        //UPDATE

        public static int Actualizar(gsInventario gsi)
        {
            DBConn db = new DBConn();
            db.sqlConnection.ConnectionString = db.dbString;
            db.sqlConnection.Open();
            string query = "UPDATE inventario SET"+
                " codigo ='" + gsi.codigo +
                "', marca ='" + gsi.marca +
                "', tipo ='" + gsi.tipo +
                "', medida ='" + gsi.medida +
                "', color = '" + gsi.color +
                "', descripcion = '" + gsi.descripcion +
                "' WHERE id = " + gsi.id +"";
            db.sqlCommand.CommandText = query;
            db.sqlCommand.Connection = db.sqlConnection;
            int res = db.sqlCommand.ExecuteNonQuery();
            db.sqlConnection.Close();

            return res;
        }

        //DELETE
        public static int Eliminar(gsInventario gsi)
        {
            DBConn db = new DBConn();
            db.sqlConnection.ConnectionString = db.dbString;
            db.sqlConnection.Open();
            string query = "DELETE FROM inventario WHERE id = '" + gsi.id + "'";
            db.sqlCommand.CommandText = query;
            db.sqlCommand.Connection = db.sqlConnection;
            int res = db.sqlCommand.ExecuteNonQuery();
            db.sqlConnection.Close();

            return res;
        }

    }
}
