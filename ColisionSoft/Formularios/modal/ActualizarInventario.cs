using System;
using System.Windows.Forms;

namespace ColisionSoft
{
    public partial class ActualizarInventario : Form
    {
        public ActualizarInventario(string pId, string pCodigo, string pMarca, string pTipo, string pMedida, 
            string pColor, string pDescripcion, string pPrecio, int pCantidad)
        {
            InitializeComponent();
            txtId.Text = pId;
            txtCodigo.Text = pCodigo;
            txtMarca.Text = pMarca;
            txtTipo.Text = pTipo;
            txtMedida.Text = pMedida;
            txtPU.Text = pPrecio;
            txtDescripcion.Text = pDescripcion;
            txtColor.Text = pColor;
            txtCantidad.Text = pCantidad.ToString();
        }

        private void ActualizarInventario_Load(object sender, EventArgs e)
        {
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                gsInventario gsi = new gsInventario();

                gsi.id = Convert.ToInt32(txtId.Text);
                gsi.codigo = txtCodigo.Text;
                gsi.marca = txtMarca.Text;
                gsi.tipo = txtTipo.Text;
                gsi.medida = txtMedida.Text;
                gsi.color = txtPU.Text;
                gsi.descripcion = txtDescripcion.Text;
                gsi.cantidad = Convert.ToInt32(txtColor.Text);

                int _Actualizar = invMet.Actualizar(gsi);

                if (_Actualizar > 0)
                {
                    msgbox.Exito("Datos actualizados");
                }
            }
            catch (Exception)
            {
                msgbox.Error("Error al actualizar");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
