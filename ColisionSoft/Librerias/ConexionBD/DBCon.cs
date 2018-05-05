using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ColisionSoft
{
    class DBCon
    {
        static string server = "localhost";
        static string user = "root";
        static string pass = "";
        static string db = "colisionsoft";

        public string CadenaConexion()
        {
            try
            {
                return "server=" + server + ";user=" + user + ";pwd=" + pass + ";database=" + db + ";";
            }
            catch (Exception)
            {

                throw;
            }
        }

        //Devuelve confirmacion
        public int Conectar(string consulta)
        {
            int exito = 0;
            int error = 0;
            try
            {
                MySqlConnection conexion = new MySqlConnection();
                MySqlCommand query = new MySqlCommand();

                conexion.ConnectionString = this.CadenaConexion();
                conexion.Open();
                query.Connection = conexion;
                query.CommandText = consulta;

                exito = query.ExecuteNonQuery();
                return exito;
            }
            catch (Exception)
            {
                return error;
            }
        }

        //Devuelve arreglo de datos
        public MySqlDataReader Consultar(string consulta)
        {
            try
            {
                MySqlConnection Conexion = new MySqlConnection();
                Conexion.ConnectionString = this.CadenaConexion();
                Conexion.Open();

                MySqlCommand query = new MySqlCommand();
                query.Connection = Conexion;

                query.CommandText = consulta;

                MySqlDataReader resultado = query.ExecuteReader();

                return resultado;
            }
            catch (Exception)
            {
                MySqlDataReader noRes = null;
                return noRes;
            }
        }
    }
}
