using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColisionSoft
{
    public partial class proveedores : Form
    {
        public proveedores()
        {
            InitializeComponent();
            CargarDGV();
        }

        public bool seleccionado;

        public void CargarDGV()
        {
            dgvProveedores.Rows.Clear();
            provMet pProvMetodos = new provMet();

            var resultado = pProvMetodos.Consultar();

            if (resultado != null)
            {
                while (resultado.Read())
                {
                    //Añadir filas con los resultados
                    this.dgvProveedores.Rows.Add(resultado["id"], resultado["nombre_prov"], resultado["abrev"]);
                }
            }
            else
            {
                msgbox.Error("NO SE PUEDEN CARGAR LOS PROVEEDORES");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            gsProveedores gsp = new gsProveedores();

            //Fila seleccionada
            DataGridViewRow delRow = dgvProveedores.CurrentRow;

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

            gsp.nombre_prov = txtNombre.Text.Trim();
            gsp.abrev = txtAbrev.Text.Trim();


            //Si fue seleccionado un producto actualiza si no agrega
            if (gsp.id > 0)
            {
                //Llamar metodo actualizar
                int actualizar = provMet.ActualizarProducto(gsp);
                //Si fue actualizado limpia campos y refrescar DGV si no ERROR
                if (actualizar > 0)
                {
                    lblEXITO.Visible = true;
                    lblEXITO.Text = "PROVEEDOR ACTUALIZADO CON EXITO";
                    timer1.Start();
                    txtNombre.Text = "";
                    txtAbrev.Text = "";
                    CargarDGV();
                    dgvProveedores.ClearSelection();
                }
                else
                {
                    msgbox.Error("ERROR AL ACTUALIZAR");
                }
            }
            else
            {
                //Llamar metodo agregar
                int resultado = provMet.Agregar(gsp);
                //Si fue agregado limpiar campos y refrescar DGV si no ERROR
                if (resultado > 0)
                {
                    lblEXITO.Visible = true;
                    lblEXITO.Text = "PROVEEDOR AGREGADO CON EXITO";
                    timer1.Start();
                    txtNombre.Text = "";
                    txtAbrev.Text = "";
                    CargarDGV();
                    dgvProveedores.ClearSelection();
                }
                else
                {
                    msgbox.Error("ERROR AL AGREGAR");
                }
            }
        }

        private void dgvProveedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvProveedores.CurrentRow;
            seleccionado = true;

            txtNombre.Text = Convert.ToString(row.Cells[1].Value);
            txtAbrev.Text = Convert.ToString(row.Cells[2].Value);
        }

        private void dgvProveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                //TODO - Button Clicked - Execute Code Here

                try
                {
                    DataGridViewRow delRow = dgvProveedores.CurrentRow;

                    gsProveedores gsp = new gsProveedores();

                    gsp.id = Convert.ToInt32(delRow.Cells[0].Value);

                    int resultado = provMet.Eliminar(gsp);
                    if (resultado > 0)
                    {
                        lblEXITO.Visible = true;
                        lblEXITO.Text = "PROVEEDOR ELIMINADO CON EXITO";
                        timer1.Start();
                        txtNombre.Text = "";
                        txtAbrev.Text = "";
                        CargarDGV();

                        dgvProveedores.ClearSelection();
                        txtNombre.Focus();
                    }
                    else
                    {
                        msgbox.Error("ERROR AL ELIMINAR PROVEEDOR");
                        txtNombre.Focus();
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
            txtNombre.Text = "";
            txtAbrev.Text = "";
            seleccionado = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblEXITO.Visible = false;
        }
    }
}
