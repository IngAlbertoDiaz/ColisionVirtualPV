using System;
using System.Data.SqlClient;
using System.Data;

namespace ColisionSoft
{
    class usuariosMet
    {
        //CREATE

        public static int Agregar(gsUsuarios _gsu)
        {
            DBCon DB = new DBCon();
            DB._CONN.ConnectionString = DB._DB;
            DB._CONN.Open();
            string query = "INSERT INTO usuarios (usuario, pass, privilegios)  VALUES ('" + _gsu.usuario + "','" + _gsu.pass + "', '" + _gsu.privilegios + "')";
            DB._CMD.CommandText = query;
            DB._CMD.Connection = DB._CONN;
            int res = DB._CMD.ExecuteNonQuery();
            DB._CONN.Close();

            return res;
        }

        //READ

        public DataTable login(string _usuario, string _pass)
        {
            DataTable resultado = new DataTable();
            DBCon DB = new DBCon();
            try
            {
                DB._CONN.ConnectionString = DB._DB;
                DB._CONN.Open();

                SqlDataAdapter sql = new SqlDataAdapter("SELECT * FROM usuarios WHERE usuario = '" + _usuario + "' AND pass = '" + _pass + "' ", DB._CONN);
                sql.Fill(resultado);
                DB._CONN.Close();
                return resultado;
            }
            catch (Exception)
            {
                return resultado;
            }
        }

        public DataTable ConsultarUsuarios()
        {
            DataTable resultado = new DataTable();
            DBCon DB = new DBCon();
            try
            {
                DB._CONN.ConnectionString = DB._DB;
                DB._CONN.Open();

                SqlDataAdapter sql = new SqlDataAdapter("SELECT * FROM usuarios", DB._CONN);
                sql.Fill(resultado);
                DB._CONN.Close();
                return resultado;
            }
            catch (Exception)
            {
                return resultado;
            }
        }

        public DataTable ConsultarAdmins()
        {
            DataTable resultado = new DataTable();
            DBCon DB = new DBCon();
            try
            {
                DB._CONN.ConnectionString = DB._DB;
                DB._CONN.Open();
                SqlDataAdapter sql = new SqlDataAdapter("SELECT * FROM usuarios WHERE privilegios = 1", DB._CONN);
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

        //Para cambiar datos de un usuario se elimina y se vuelve a ingresar
        //Ya que son 3 datos solamente

        //DELETE

        public static int Eliminar(gsUsuarios _gsu)
        {
            DBCon DB = new DBCon();
            DB._CONN.ConnectionString = DB._DB;
            DB._CONN.Open();
            string query = "DELETE FROM usuarios WHERE id = '" + _gsu.id + "'";
            DB._CMD.CommandText = query;
            DB._CMD.Connection = DB._CONN;
            int res = DB._CMD.ExecuteNonQuery();
            DB._CONN.Close();

            return res;
        }

    }
}
