using System;
using System.Windows.Forms;

namespace ColisionSoft
{
    public partial class granel : Form
    {

        private venta venta;
        public granel(venta venta)
        {
            InitializeComponent();
            this.venta = venta;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string prod = txtProducto.Text;
            double costo = Convert.ToDouble(txtCosto.Text);
            int nTicket = Convert.ToInt32(Properties.Settings.Default.ticket);

            venta.dgvVenta.Rows.Add(nTicket, prod, costo);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
