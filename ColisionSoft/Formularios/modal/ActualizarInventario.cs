using System;
using System.Windows.Forms;

namespace ColisionSoft
{
    public partial class ActualizarInventario : Form
    {
        public ActualizarInventario(string _id,string _nombre,string _peso,string _unidad_medida, string _precio,string _bodega,string _exhibicion, string _proveedor)
        {
            InitializeComponent();
            txtId.Text = _id;
            txtNombre.Text = _nombre;
            txtPeso.Text = _peso;
            cbUM.Text = _unidad_medida;
            txtPU.Text = _precio;
            txtBodega.Text = _bodega;
            txtExhibicion.Text = _exhibicion;
            txtProveedor.Text = _proveedor;
        }

        private void ActualizarInventario_Load(object sender, EventArgs e)
        {

            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                gsInventario _gsi = new gsInventario();

                _gsi.id = Convert.ToInt32(txtId.Text);
                _gsi.nombre = txtNombre.Text;
                _gsi.peso = float.Parse(txtPeso.Text);
                _gsi.unidad_medida = cbUM.Text;
                _gsi.precio = float.Parse(txtPU.Text);
                _gsi.bodega = float.Parse(txtBodega.Text);
                _gsi.exhibicion = float.Parse(txtExhibicion.Text);
                _gsi.proveedor = Convert.ToInt32(txtProveedor.Text);

                int _Actualizar = invMet.Actualizar(_gsi);

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

        
    }
}
