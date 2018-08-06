using System;
using System.Windows.Forms;

namespace ColisionSoft
{
    public partial class cambiar_salir : Form
    {
        public cambiar_salir()
        {
            InitializeComponent();
        }

        private void btnGuardarUsuario_Click(object sender, EventArgs e)
        {
            login login = new login();
            login.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
