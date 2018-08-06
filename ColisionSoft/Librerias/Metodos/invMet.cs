using System;
using System.Data;
using System.Data.SqlClient;

namespace ColisionSoft
{
    class invMet
    {
        //CREATE

        public static int Agregar(gsInventario _gsi)
        {
            DBCon DB = new DBCon();
            DB._CONN.ConnectionString = DB._DB;
            DB._CONN.Open();
            string query = "INSERT INTO inventario (nombre,peso,unidad_medida,precio,bodega,exhibicion,proveedor)  VALUES ('"
                + _gsi.nombre+ "', '"
                + _gsi.peso + "', '"
                + _gsi.unidad_medida + "', '"
                + _gsi.precio + "', '"
                + _gsi.bodega +"', '"
                + _gsi.exhibicion +"', '"
                + _gsi.proveedor +"')";

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

                SqlDataAdapter sql = new SqlDataAdapter("SELECT * FROM inventario", DB._CONN);
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

        public static int Actualizar(gsInventario _gsi)
        {
            DBCon DB = new DBCon();
            DB._CONN.ConnectionString = DB._DB;
            DB._CONN.Open();
            string query = "UPDATE inventario SET "+
                "nombre ='" + _gsi.nombre +
                "', peso =" + _gsi.peso +
                ", unidad_medida ='" + _gsi.unidad_medida +
                "', precio =" + _gsi.precio +
                ", bodega =" + _gsi.bodega +
                ", exhibicion =" + _gsi.exhibicion +
                ", proveedor =" + _gsi.proveedor + 
                " WHERE id = " + _gsi.id +"";
            DB._CMD.CommandText = query;
            DB._CMD.Connection = DB._CONN;
            int res = DB._CMD.ExecuteNonQuery();
            DB._CONN.Close();

            return res;
        }

        //DELETE
        public static int Eliminar(gsInventario _gsi)
        {
            DBCon DB = new DBCon();
            DB._CONN.ConnectionString = DB._DB;
            DB._CONN.Open();
            string query = "DELETE FROM inventario WHERE id = '" + _gsi.id + "'";
            DB._CMD.CommandText = query;
            DB._CMD.Connection = DB._CONN;
            int res = DB._CMD.ExecuteNonQuery();
            DB._CONN.Close();

            return res;
        }

    }
}
