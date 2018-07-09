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
            
        }

        private void inventario_Load(object sender, EventArgs e)
        {
            CargarDGV();
            dgvInventario.ClearSelection();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
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
