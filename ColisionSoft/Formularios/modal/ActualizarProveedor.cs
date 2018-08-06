using System;
using System.Windows.Forms;

namespace ColisionSoft
{
    public partial class ActualizarProveedor : Form
    {
        public ActualizarProveedor(string _id, string _nombre, string _abreviatura)
        {
            InitializeComponent();
            txtId.Text = _id;
            txtNombre.Text = _nombre;
            txtAbreviatura.Text = _abreviatura;
        }

        private void btnGuardar_Click(object sender, System.EventArgs e)
        {
            try
            {
                gsProveedores _gsp = new gsProveedores();

                _gsp.id = Convert.ToInt32(txtId.Text);
                _gsp.nombre = txtNombre.Text;
                _gsp.abreviatura = txtAbreviatura.Text;

                int _Actualizar = provMet.Actualizar(_gsp);

                if (_Actualizar > 0)
                {
                    msgbox.Exito("Datos actualizados");
                    this.Close();
                }

            }
            catch (Exception)
            {
                msgbox.Error("Error al actualizar");
            }
        }

        private void btnCancelar_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
