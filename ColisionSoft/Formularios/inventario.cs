using System;
using System.Data;
using System.Windows.Forms;

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

            invMet varProdMet = new invMet();
            /*
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
            */
            txtProveedor.AutoCompleteCustomSource = col;
        }

        public void CargarDGV()
        {
            dgvInventario.Rows.Clear();

            invMet _inv = new invMet();

            DataTable resultado = _inv.ConsultarInventario();

            if (resultado != null)
            {
                if (resultado.Rows.Count > 0)
                {
                    dgvInventario.DataSource = resultado;
                }
            }
        }

        private void inventario_Load(object sender, EventArgs e)
        {
            CargarDGV();
            dgvInventario.ClearSelection();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                gsInventario _gsi = new gsInventario();
                
                _gsi.nombre = txtNombre.Text;
                _gsi.peso = float.Parse(txtPeso.Text);
                _gsi.unidad_medida = cbUM.Text;
                _gsi.precio = float.Parse(txtPU.Text);
                _gsi.bodega = float.Parse(txtBodega.Text);
                _gsi.exhibicion = float.Parse(txtExhibicion.Text);
                _gsi.proveedor = Convert.ToInt32(txtProveedor.Text);

                int resGuardar = invMet.Agregar(_gsi);

                if (resGuardar > 0)
                {
                    msgbox.Exito("Producto agregado");
                }

            }
            catch (Exception)
            {
                msgbox.Error("Error al agregar");
            }
        }

        private void dgvInventario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow _fila = dgvInventario.CurrentRow;
                gsInventario _gsi = new gsInventario();

                if (e.ColumnIndex == 0 && e.RowIndex >= 0)
                {
                    msgbox.Exito("ELIMINAR");
                    _gsi.id = Convert.ToInt32(_fila.Cells[2].Value);

                    int resultado = invMet.Eliminar(_gsi);

                    if (resultado > 0)
                    {
                        msgbox.Exito("Producto eliminado");
                    }
                }
                else if (e.ColumnIndex == 1 && e.RowIndex >= 0)
                {
                    ActualizarInventario _ActInv = new ActualizarInventario(
                            _fila.Cells[2].Value.ToString(),
                            _fila.Cells[3].Value.ToString(),
                            _fila.Cells[4].Value.ToString(),
                            _fila.Cells[5].Value.ToString(),
                            _fila.Cells[6].Value.ToString(),
                            _fila.Cells[7].Value.ToString(),
                            _fila.Cells[8].Value.ToString(),
                            _fila.Cells[9].Value.ToString()
                        );
                    _ActInv.Show();
                }
            }
            catch (Exception)
            {
                msgbox.Error("Algo salio mal");
            }
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            seleccionado = false;
            txtNombre.Text = "";
            txtPeso.Text = "";
            cbUM.Text = "";
            txtBodega.Text = "";
            txtExhibicion.Text = "";
            txtPU.Text = ""; 
            txtProveedor.Text = "";
            dgvInventario.ClearSelection();
        }
    }
}
