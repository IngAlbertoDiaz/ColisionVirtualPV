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
            //txtProveedor.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            //txtProveedor.AutoCompleteSource = AutoCompleteSource.CustomSource;
            //AutoCompleteStringCollection col = new AutoCompleteStringCollection();

            //invMet varProdMet = new invMet();
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
            //txtProveedor.AutoCompleteCustomSource = col;
        }

        public void CargarDGV()
        {
            //dgvInventario.Rows.Clear();

            invMet _inv = new invMet();

            DataTable resultado = _inv.ConsultarInventario(null);

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
        
        private void dgvInventario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow _fila = dgvInventario.CurrentRow;
                gsInventario gsi = new gsInventario();

                if (e.ColumnIndex == 0 && e.RowIndex >= 0)
                {
                    gsi.id = Convert.ToInt32(_fila.Cells[2].Value);

                    int resultado = invMet.Eliminar(gsi);

                    if (resultado > 0)
                    {
                        msgbox.Exito("Producto eliminado");
                        CargarDGV();
                    }
                }
                else if (e.ColumnIndex == 1 && e.RowIndex >= 0)
                {
                    ActualizarInventario fActInv = new ActualizarInventario(
                            _fila.Cells[2].Value.ToString(),
                            _fila.Cells[3].Value.ToString(),
                            _fila.Cells[4].Value.ToString(),
                            _fila.Cells[5].Value.ToString(),
                            _fila.Cells[6].Value.ToString(),
                            _fila.Cells[7].Value.ToString(),
                            _fila.Cells[8].Value.ToString(),
                            _fila.Cells[9].Value.ToString(),
                            Convert.ToInt32(_fila.Cells[10].Value)
                        );
                    fActInv.Show();
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
            
            dgvInventario.ClearSelection();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            ImportarInventario _importExcel = new ImportarInventario();
            if (_importExcel.ShowDialog() == DialogResult.OK)
            {
                msgbox.Exito("Datos importados con exito");
            }
            else
            {
            }
        }
    }
}
