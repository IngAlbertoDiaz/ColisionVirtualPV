using System;
using System.Data;
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
            //dgvProveedores.Rows.Clear();

            provMet _prov = new provMet();

            DataTable resultado = _prov.ConsultarInventario();

            if (resultado != null)
            {
                if (resultado.Rows.Count > 0)
                {
                    dgvProveedores.DataSource = resultado;
                }
            }
        }

        private void proveedores_Load(object sender, EventArgs e)
        {
            CargarDGV();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                gsProveedores _gsp = new gsProveedores();

                _gsp.nombre = txtNombre.Text;
                _gsp.abreviatura = txtAbrev.Text;

                int resGuardar = provMet.Agregar(_gsp);

                if (resGuardar > 0)
                {
                    msgbox.Exito("Proveedor agregado");
                    CargarDGV();
                }

            }
            catch (Exception)
            {
                msgbox.Error("Error al agregar");
            }
        }

        private void dgvProveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow _fila = dgvProveedores.CurrentRow;
                gsProveedores _gsp = new gsProveedores();

                if (e.ColumnIndex == 0 && e.RowIndex >= 0)
                {
                    _gsp.id = Convert.ToInt32(_fila.Cells[2].Value);

                    int resultado = provMet.Eliminar(_gsp);

                    if (resultado > 0)
                    {
                        msgbox.Exito("Producto eliminado");
                        CargarDGV();
                    }
                }
                else if (e.ColumnIndex == 1 && e.RowIndex >= 0)
                {
                    ActualizarProveedor _ActProv = new ActualizarProveedor(
                            _fila.Cells[2].Value.ToString(),
                            _fila.Cells[3].Value.ToString(),
                            _fila.Cells[4].Value.ToString()
                        );
                    _ActProv.Show();
                }
            }
            catch (Exception)
            {
                msgbox.Error("Algo salio mal");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtAbrev.Text = "";
            seleccionado = false;
        }
        
    }
}
