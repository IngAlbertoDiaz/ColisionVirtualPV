using System;
using System.Data;
using System.Data.SqlClient;

namespace ColisionSoft
{
    class provMet
    {
        //CREATE

        public static int Agregar(gsProveedores _gsp)
        {
            DBCon DB = new DBCon();
            DB._CONN.ConnectionString = DB._DB;
            DB._CONN.Open();
            string query = "INSERT INTO proveedores (nombre,abreviatura)  VALUES ('"
                + _gsp.nombre+ "', '"
                + _gsp.abreviatura + "')";

            DB._CMD.CommandText = query;
            DB._CMD.Connection = DB._CONN;
            int res = DB._CMD.ExecuteNonQuery();
            DB._CONN.Close();

            return res;
        }

        //READ

        public DataTable ConsultarInventario()
        {
            DataTable resultado = new DataTable();
            DBCon DB = new DBCon();
            try
            {
                DB._CONN.ConnectionString = DB._DB;
                DB._CONN.Open();

                SqlDataAdapter sql = new SqlDataAdapter("SELECT * FROM proveedores", DB._CONN);
                sql.Fill(resultado);
                DB._CONN.Close();
                return resultado;
            }
            catch (Exception)
            {
                return resultado;
            }
        }

        //UPDATE

        public static int Actualizar(gsProveedores _gsp)
        {
            DBCon DB = new DBCon();
            DB._CONN.ConnectionString = DB._DB;
            DB._CONN.Open();
            string query = "UPDATE proveedores SET " +
                "nombre ='" + _gsp.nombre +
                "', abreviatura ='" + _gsp.abreviatura + 
                "' WHERE id = '" + _gsp.id + "'";
            DB._CMD.CommandText = query;
            DB._CMD.Connection = DB._CONN;
            int res = DB._CMD.ExecuteNonQuery();
            DB._CONN.Close();

            return res;
        }

        //DELETE
        public static int Eliminar(gsProveedores _gsp)
        {
            DBCon DB = new DBCon();
            DB._CONN.ConnectionString = DB._DB;
            DB._CONN.Open();
            string query = "DELETE FROM proveedores WHERE id = '" + _gsp.id + "'";
            DB._CMD.CommandText = query;
            DB._CMD.Connection = DB._CONN;
            int res = DB._CMD.ExecuteNonQuery();
            DB._CONN.Close();

            return res;
        }
    }
}
