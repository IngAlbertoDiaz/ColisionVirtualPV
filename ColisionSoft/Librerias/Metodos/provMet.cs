using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ColisionSoft
{
    class provMet
    {
        //CREAR
        public static int Agregar(gsProveedores gsp)
        {
            int exito = 0;
            int error = 0;
            try
            {
                DBCon con = new DBCon();

                exito = con.Conectar("INSERT INTO proveedores(nombre_prov ,abrev) values('" + gsp.nombre_prov + "','" + gsp.abrev + "')");

                return exito;
            }
            catch (Exception)
            {
                return error;
            }
        }

        //CONSULTAR
        public MySqlDataReader Consultar()
        {
            try
            {
                DBCon con = new DBCon();
                MySqlConnection Conexion = new MySqlConnection();
                Conexion.ConnectionString = con.CadenaConexion();
                Conexion.Open();

                MySqlCommand query = new MySqlCommand();
                query.Connection = Conexion;

                query.CommandText = "SELECT * FROM proveedores";

                MySqlDataReader resultado = query.ExecuteReader();

                return resultado;
            }
            catch (Exception)
            {
                MySqlDataReader resultado = null;
                return resultado;
            }
            
        }

        //ACTUALIZAR--------------------------------------------
        public static int ActualizarProducto(gsProveedores gsp)
        {
            int retorno = 0;
            DBCon con = new DBCon();
            MySqlConnection Conexion = new MySqlConnection();
            Conexion.ConnectionString = con.CadenaConexion();
            Conexion.Open();

            MySqlCommand query = new MySqlCommand();
            query.Connection = Conexion;
            query.CommandText = (string.Format(
                "UPDATE proveedores SET nombre_prov = '{0}',abrev = '{1}' WHERE id = '{2}'",
            gsp.nombre_prov, gsp.abrev, gsp.id));

            retorno = query.ExecuteNonQuery();
            return retorno;
        }

        //ELIMINAR----------------------------------------------
        public static int Eliminar(gsProveedores gsp)
        {
            int retorno = 0;
            DBCon con = new DBCon();
            MySqlConnection Conexion = new MySqlConnection();
            Conexion.ConnectionString = con.CadenaConexion();
            Conexion.Open();

            MySqlCommand query = new MySqlCommand();
            query.Connection = Conexion;
            query.CommandText = (string.Format(
                "DELETE FROM proveedores WHERE id = '" + gsp.id + "'"));

            retorno = query.ExecuteNonQuery();
            return retorno;
        }

    }
}
