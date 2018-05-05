using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            ajustesUsuario FAU = new ajustesUsuario();
            Form FAUOpen = Application.OpenForms["ajustesUsuario"];
            
            if (FAUOpen == null)
            {
                CerrarFormulariosExtra();
                FAU.Show();
            }
            else
            {
                FAUOpen.BringToFront();
            }
        }

        private void btnAjustes_Click(object sender, EventArgs e)
        {
            ajustesGenerales FAG = new ajustesGenerales();
            Form FAGOpen = Application.OpenForms["ajustesGenerales"];

            if (FAGOpen == null)
            {
                CerrarFormulariosExtra();
                FAG.Show();
            }
            else
            {
                FAGOpen.BringToFront();
            }
        }

        private void btnAcerca_Click(object sender, EventArgs e)
        {
            acercade FA = new acercade();
            Form FAOpen = Application.OpenForms["acercade"];

            if (FAOpen == null)
            {
                CerrarFormulariosExtra();
                FA.Show();
            }
            else
            {
                FAOpen.BringToFront();
            }
        }
    }
}