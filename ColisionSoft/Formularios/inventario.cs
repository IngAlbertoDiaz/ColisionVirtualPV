using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ColisionSoft
{
    public partial class inventario : Form
    {
        public inventario()
        {
            InitializeComponent();
            AutoCompletarBusqueda();
        }

        public bool seleccionado;
        
        public void AutoCompletarBusqueda()
        {
            txtProveedor.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtProveedor.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection col = new AutoCompleteStringCollection();

            prodMet varProdMet = new prodMet();

            var resultado = varProdMet.ConsultarProveedores();

            if (resultado != null)
            {
                while (resultado.Read())
                {
                    //Añadir filas con los resultados
                    string sNombre = resultado.GetString("nombre_prov");
                    col.Add(sNombre);
                }
            }
            else
            {
            }

            txtProveedor.AutoCompleteCustomSource = col;
        }

        public void CargarDGV()
        {
            dgvInventario.Rows.Clear();
            prodMet varProdMet= new prodMet();

            var resultado = varProdMet.Consultar();

            if (resultado != null)
            {
                while (resultado.Read())
                {
                    //Añadir filas con los resultados
                    this.dgvInventario.Rows.Add(resultado["id"], resultado["nombre"], resultado["peso"], resultado["unidad_medida"], resultado["bodega"], resultado["exhibicion"], resultado["precio"], resultado["abrev"]);
                }
            }
            else
            {
                msgbox.Error("Ingrese productos o revise la conexion");
            }
        }

        private void inventario_Load(object sender, EventArgs e)
        {
            CargarDGV();
            dgvInventario.ClearSelection();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            gsProductos gsp = new gsProductos();

            //Fila seleccionada
            DataGridViewRow delRow = dgvInventario.CurrentRow;

            //Si una fila ha sido seleccionada pasar id del producto
            try
            {
                if (seleccionado == false)
                {
                    delRow = null;
                    gsp.id = 0;
                }
                else
                {
                    if (delRow.Index > 0)
                    {
                        gsp.id = Convert.ToInt32(delRow.Cells[0].Value);
                    }
                }
                
            }
            catch (Exception)
            {
                gsp.id = 0;
            }

            try
            {
                prodMet provCons = new prodMet();

                gsp.nombre = txtNombre.Text.Trim();
                gsp.peso = float.Parse(txtPeso.Text.Trim());
                gsp.unidad_medida = txtUM.Text.Trim();
                gsp.bodega = Convert.ToInt32(txtBodega.Text.Trim());
                gsp.exhibicion = Convert.ToInt32(txtExhibicion.Text.Trim());
                gsp.precio = float.Parse(txtPU.Text.Trim());
                string proveedor = txtProveedor.Text.Trim();
                
                var provId = provCons.ConsultarProvId(proveedor);
                if (provId.HasRows)
                {
                    while (provId.Read())
                    {
                        gsp.proveedor = Convert.ToInt32(provId[0]);
                    }

                }

                //Si fue seleccionado un producto actualiza si no agrega
                if (gsp.id > 0)
                {
                    //Llamar metodo actualizar
                    int actualizar = prodMet.ActualizarProducto(gsp);
                    //Si fue actualizado limpia campos y refrescar DGV si no ERROR
                    if (actualizar > 0)
                    {
                        lblEXITO.Visible = true;
                        lblEXITO.Text = "PRODUCTO ACTUALIZADO CON EXITO";
                        timer1.Start();
                        txtNombre.Text = "";
                        txtPeso.Text = "";
                        txtUM.Text = "";
                        txtBodega.Text = "";
                        txtExhibicion.Text = "";
                        txtPU.Text = "";
                        txtProveedor.Text = "";
                        CargarDGV();
                        dgvInventario.ClearSelection();
                    }
                    else
                    {
                        msgbox.Error("ERROR AL ACTUALIZAR EL PRODUCTO");
                    }
                }
                else
                {
                    //Llamar metodo agregar
                    int resultado = prodMet.Agregar(gsp);
                    //Si fue agregado limpiar campos y refrescar DGV si no ERROR
                    if (resultado > 0)
                    {
                        lblEXITO.Visible = true;
                        lblEXITO.Text = "PRODUCTO AGREGADO CON EXITO";
                        timer1.Start();
                        txtNombre.Text = "";
                        txtPeso.Text = "";
                        txtUM.Text = "";
                        txtBodega.Text = "";
                        txtExhibicion.Text = "";
                        txtPU.Text = "";
                        txtProveedor.Text = "";
                        CargarDGV();
                        dgvInventario.ClearSelection();
                    }
                    else
                    {
                        msgbox.Error("ERROR AL AGREGAR EL PRODUCTO");
                    }
                }
            }
            catch (Exception)
            {
                msgbox.Error("Verifique la informacion");
            }
            
        }

        private void dgvInventario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = dgvInventario.CurrentRow;

                seleccionado = true;

                txtNombre.Text = Convert.ToString(row.Cells[1].Value);
                txtPeso.Text = Convert.ToString(row.Cells[2].Value);
                txtUM.Text = Convert.ToString(row.Cells[3].Value);
                txtBodega.Text = Convert.ToString(row.Cells[4].Value);
                txtExhibicion.Text = Convert.ToString(row.Cells[5].Value);
                txtPU.Text = Convert.ToString(row.Cells[6].Value);
                txtProveedor.Text = Convert.ToString(row.Cells[7].Value);
            }
            catch (Exception)
            {
                msgbox.Error("No pudo obtenerse la informacion");
            }
            
        }

        private void dgvInventario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                //TODO - Button Clicked - Execute Code Here

                try
                {
                    DataGridViewRow delRow = dgvInventario.CurrentRow;

                    gsProductos gsp = new gsProductos();

                    gsp.id = Convert.ToInt32(delRow.Cells[0].Value);

                    int resultado = prodMet.Eliminar(gsp);
                    if (resultado > 0)
                    {
                        lblEXITO.Visible = true;
                        lblEXITO.Text = "PRODUCTO ELIMINADO CON EXITO";
                        timer1.Start();
                        txtNombre.Text = "";
                        txtPeso.Text = "";
                        txtUM.Text = "";
                        txtBodega.Text = "";
                        txtExhibicion.Text = "";
                        txtPU.Text = "";
                        txtProveedor.Text = "";
                        CargarDGV();
                        dgvInventario.ClearSelection();
                    }
                    else
                    {
                        msgbox.Error("ERROR AL ELIMINAR EL PRODUCTO");
                    }

                }
                catch (Exception)
                {
                    msgbox.Error("Ocurrio un problema al eliminar");
                }

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            seleccionado = false;
            txtNombre.Text = "";
            txtPeso.Text = "";
            txtUM.Text = "";
            txtBodega.Text = "";
            txtExhibicion.Text = "";
            txtPU.Text = "";
            txtProveedor.Text = "";
            dgvInventario.ClearSelection();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblEXITO.Visible = false;
        }
    }
}
