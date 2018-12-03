using System;
using System.Windows.Forms;

namespace ColisionSoft
{
    public partial class caja : Form
    {
        public caja()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            login fl = new login();
            fl.Show();
        }

        private void btnRecuperar_Click(object sender, EventArgs e)
        {
            txtCaja.Text = Properties.Settings.Default.caja_final.ToString();
        }

        private void btnNuevaCaja_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.caja_inicial = txtCaja.Text;
            Properties.Settings.Default.Save();
        }
    }
}
