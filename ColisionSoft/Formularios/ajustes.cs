using System;
using System.Windows.Forms;

namespace ColisionSoft
{
    public partial class ajustes : Form
    {
        public ajustes()
        {
            InitializeComponent();
        }

        public void CerrarFormulariosExtra()
        {
            //Permite solo un formulario de ajustes a la vez
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                if (Application.OpenForms[i].Name != "inicio")
                {
                    if (Application.OpenForms[i].Name != "ajustes")
                    {
                        if (Application.OpenForms[i].Name != "login")
                        {
                            Application.OpenForms[i].Close();
                        }
                    }
                }
            }
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            ajustesUsuario _FormAjustesUsuario = new ajustesUsuario();
            
            Form _FormOpen = Application.OpenForms["ajustesUsuario"];
            
            if (_FormOpen == null)
            {
                if (_FormAjustesUsuario.ShowDialog(this) == DialogResult.OK)
                {

                }
                CerrarFormulariosExtra();
            }
            else
            {
                _FormOpen.BringToFront();
            }
            
        }

        private void btnAjustes_Click(object sender, EventArgs e)
        {
            ajustesGenerales _FormAjustesGenerales = new ajustesGenerales();
            Form _FormOpen = Application.OpenForms["ajustesGenerales"];

            if (_FormOpen == null)
            {
                if (_FormAjustesGenerales.ShowDialog(this) == DialogResult.OK)
                {

                }
                CerrarFormulariosExtra();
            }
            else
            {
                _FormOpen.BringToFront();
            }
        }

        private void btnAcerca_Click(object sender, EventArgs e)
        {
            acercade _FormAcercaDe = new acercade();
            Form _FormOpen = Application.OpenForms["acercade"];

            if (_FormOpen == null)
            {
                if (_FormAcercaDe.ShowDialog(this) == DialogResult.OK)
                {

                }
                CerrarFormulariosExtra();
            }
            else
            {
                _FormOpen.BringToFront();
            }
        }
    }
}