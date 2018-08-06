using System;
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
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
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
