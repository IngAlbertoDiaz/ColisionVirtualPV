using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ColisionSoft
{
    class usuariosMet
    {
        //AGREGAR----------------------------------------------
        public static int Agregar(gsUsuarios _gsu)
        {
            int exito = 0;
            int error = 0;
            try
            {
                DBCon con = new DBCon();

                exito = con.Conectar("INSERT INTO usuarios(usuario ,pass ,privilegios) values('" + _gsu.usuario + "','" + _gsu.pass + "'," + _gsu.privilegios + ")");

                return exito;
            }
            catch (Exception)
            {
                return error;
            }

        }

        //CONSULTAR----------------------------------------------
        public MySqlDataReader AuthUser(string _usuario, string _pass)
        {
            try
            {
                MySqlDataReader query;
                DBCon con = new DBCon();

                if (_pass == null)
                {
                    query = con.Consultar("SELECT * FROM usuarios WHERE usuario = '" + _usuario + "'");
                }
                else
                {
                    query = con.Consultar("SELECT * FROM usuarios WHERE usuario = '" + _usuario + "' AND pass = '" + _pass + "'");
                }

                return query;
            }
            catch (Exception)
            {
                MySqlDataReader noRes = null;
                return noRes;
            }
        }

        public MySqlDataReader ConsultarUsuarios()
        {
            try
            {
                MySqlDataReader query;
                DBCon con = new DBCon();

                query = con.Consultar("SELECT * FROM usuarios");

                return query;
            }
            catch (Exception)
            {
                MySqlDataReader noRes = null;
                return noRes;
            }
        }

        public MySqlDataReader ConsultarAdmins()
        {
            try
            {
                MySqlDataReader query;
                DBCon con = new DBCon();
                //Cuenta el numero de usuarios con privilegios de administrador
                query = con.Consultar("SELECT * FROM usuarios WHERE privilegios = 1");

                return query;
            }
            catch (Exception)
            {
                MySqlDataReader noRes = null;
                return noRes;
            }
        }


        //ACTUALIZAR---------------------------------------------
        public static int Actualizar(gsUsuarios _gsu)
        {
            int exito = 0;
            int error = 0;
            try
            {
                DBCon con = new DBCon();
                
                exito = con.Conectar("UPDATE usuarios SET "
                    + "usuario          = '" + _gsu.usuario
                    + "',pass          = '" + _gsu.pass
                    + "',privilegios = '" + _gsu.privilegios
                    + "' WHERE id = " + _gsu.id + "");

                return exito;
            }
            catch (Exception)
            {
                return error;
            }

        }
        //ELIMINAR----------------------------------------------
        public static int Eliminar(gsUsuarios _gsu)
        {
            int exito = 0;
            int error = 0;
            try
            {
                DBCon con = new DBCon();

                exito = con.Conectar("DELETE FROM usuarios WHERE id = '" + _gsu.id + "'");

                return exito;
            }
            catch (Exception)
            {
                return error;
            }
        }

    }
}
