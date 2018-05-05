using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ColisionSoft
{
    class prodMet
    {
        //AGREGAR----------------------------------------------
        public static int Agregar(gsProductos gsp)
        {
            int exito = 0;
            int error = 0;
            try
            {
                DBCon con = new DBCon();

                exito = con.Conectar("INSERT INTO inventario(nombre ,peso ,unidad_medida ,bodega ,exhibicion ,precio ,proveedor) values('" + gsp.nombre + "','" + gsp.peso + "','" + gsp.unidad_medida + "','" + gsp.bodega + "','" + gsp.exhibicion + "','" + gsp.precio + "','" + gsp.proveedor + "')");

                return exito;
            }
            catch (Exception)
            {
                return error;
            }

        }
        //CONSULTAR----------------------------------------------
        public MySqlDataReader Consultar()
        {
            try
            {
                MySqlDataReader query;
                DBCon con = new DBCon();

                query = con.Consultar("SELECT inventario.id, inventario.nombre,inventario.peso,inventario.unidad_medida,inventario.bodega,inventario.exhibicion,inventario.precio, proveedores.abrev FROM inventario INNER JOIN proveedores ON inventario.proveedor = proveedores.id ");
                
                return query;
            }
            catch (Exception)
            {
                MySqlDataReader noRes = null;
                return noRes;
            }
            
        }

        public MySqlDataReader ConsultarProveedores()
        {
            try
            {
                MySqlDataReader query;
                DBCon con = new DBCon();
                
                query = con.Consultar("SELECT * FROM proveedores");

                return query;
            }
            catch (Exception)
            {
                MySqlDataReader noRes = null;
                return noRes;
            }
        }

        public MySqlDataReader ConsultarProvId(string proveedor)
        {
            try
            {
                MySqlDataReader query;
                DBCon con = new DBCon();

                query = con.Consultar("SELECT id FROM proveedores WHERE nombre_prov = '" + proveedor + "' OR abrev = '" + proveedor + "'");

                return query;
            }
            catch (Exception)
            {
                MySqlDataReader noRes = null;
                return noRes;
            }
        }

        //ACTUALIZAR--------------------------------------------
        public static int ActualizarProducto(gsProductos gsp)
        {
            int exito = 0;
            int error = 0;
            try
            {
                DBCon con = new DBCon();

                exito = con.Conectar("UPDATE inventario SET " 
                    + "nombre          = '" + gsp.nombre 
                    + "',peso          = '" + gsp.peso 
                    + "',unidad_medida = '" + gsp.unidad_medida 
                    + "',bodega        = '" + gsp.bodega 
                    + "',exhibicion    = '" + gsp.exhibicion 
                    + "',precio        = '" + gsp.precio 
                    + "',proveedor     = '" + gsp.proveedor 
                    + "' WHERE id      = '" + gsp.id + "'");

                return exito;
            }
            catch (Exception)
            {
                return error;
            }
            
        }

        //ELIMINAR----------------------------------------------
        public static int Eliminar(gsProductos gsp)
        {
            int exito = 0;
            int error = 0;
            try
            {
                DBCon con = new DBCon();

                exito = con.Conectar("DELETE FROM inventario WHERE id = '" + gsp.id + "'");

                return exito;
            }
            catch (Exception)
            {
                return error;
            }
        }
    }
}
