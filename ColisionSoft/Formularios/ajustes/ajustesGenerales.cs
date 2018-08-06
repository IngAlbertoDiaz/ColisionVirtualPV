using System;
using System.Windows.Forms;

namespace ColisionSoft
{
    public partial class ajustesGenerales : Form
    {
        public ajustesGenerales()
        {
            InitializeComponent();
        }

        private void btnGuardarAjustes_Click(object sender, EventArgs e)
        {
            //Cambia valores de la aplicacion
            Properties.Settings.Default.nombreNegocio = txtNombre.Text;
            //Guarda valores de la aplicacion
            Properties.Settings.Default.Save();
            msgbox.Exito("Debe reiniciar el programa para efectuar los cambios");
        }

        private void btnRT_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.ticket = 1;
            Properties.Settings.Default.Save();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
