using System;
using System.Windows.Forms;

namespace ColisionSoft
{
    public partial class InsertarProducto : Form
    {
        public InsertarProducto()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                gsInventario gsi = new gsInventario();

                gsi.codigo = txtCodigo.Text;
                gsi.marca = txtMarca.Text;
                gsi.tipo = txtTipo.Text;
                gsi.medida = txtMedida.Text;
                gsi.color = txtColor.Text;
                gsi.descripcion = txtDescripcion.Text;
                gsi.cantidad = Convert.ToInt32(txtCantidad.Text);


                int resGuardar = invMet.Agregar(gsi);

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

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
