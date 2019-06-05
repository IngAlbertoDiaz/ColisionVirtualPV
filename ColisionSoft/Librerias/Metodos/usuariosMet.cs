using System;
using System.Data.SqlClient;
using System.Data;

namespace ColisionSoft
{
    class usuariosMet
    {

        //CREATE

        public static int Agregar(gsUsuarios gsu)
        {
            DBConn db = new DBConn();
            db.sqlConnection.ConnectionString = db.dbString;
            db.sqlConnection.Open();
            string query = "INSERT INTO usuarios (usuario, pass, privilegios)  VALUES ('" + gsu.usuario + "','" + gsu.pass + "', '" + gsu.privilegios + "')";
            db.sqlCommand.CommandText = query;
            db.sqlCommand.Connection = db.sqlConnection;
            int res = db.sqlCommand.ExecuteNonQuery();
            db.sqlConnection.Close();

            return res;
        }

        //READ

        public DataTable login(string pUsuario, string pPass)
        {
            DBConn db = new DBConn();
            DataTable resultado = new DataTable();
            db.sqlConnection.ConnectionString = db.dbString;
            db.sqlConnection.Open();

            SqlDataAdapter sql = new SqlDataAdapter("SELECT * FROM usuarios WHERE usuario = '" + pUsuario + "' AND pass = '" + pPass + "' ", db.sqlConnection);
            sql.Fill(resultado);
            db.sqlConnection.Close();
            return resultado;
        }

        public DataTable ConsultarUsuarios()
        {
            DBConn db = new DBConn();
            DataTable resultado = new DataTable();
            db.sqlConnection.ConnectionString = db.dbString;
            db.sqlConnection.Open();

            SqlDataAdapter sql = new SqlDataAdapter("SELECT * FROM usuarios", db.sqlConnection);
            sql.Fill(resultado);
            db.sqlConnection.Close();
            return resultado;
        }

        public DataTable ConsultarAdmins()
        {
            DBConn db = new DBConn();
            DataTable resultado = new DataTable();
            db.sqlConnection.ConnectionString = db.dbString;
            db.sqlConnection.Open();
            SqlDataAdapter sql = new SqlDataAdapter("SELECT * FROM usuarios WHERE privilegios = 1", db.sqlConnection);
            sql.Fill(resultado);
            db.sqlConnection.Close();
            return resultado;
        }

        //UPDATE

        //Para cambiar datos de un usuario se elimina y se vuelve a ingresar
        //Ya que son 3 datos solamente

        //DELETE

        public static int Eliminar(gsUsuarios gsu)
        {
            DBConn db = new DBConn();
            db.sqlConnection.ConnectionString = db.dbString;
            db.sqlConnection.Open();
            string query = "DELETE FROM usuarios WHERE id = '" + gsu.id + "'";
            db.sqlCommand.CommandText = query;
            db.sqlCommand.Connection = db.sqlConnection;
            int res = db.sqlCommand.ExecuteNonQuery();
            db.sqlConnection.Close();

            return res;
        }

    }
}
