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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void btnSesion_Click(object sender, EventArgs e)
        {
            usuariosMet userAuth = new usuariosMet();

            var resultado = userAuth.AuthUser(txtUsuario.Text,txtPass.Text);

            if (resultado.HasRows)
            {
                while (resultado.Read())
                {
                    inicio inicio = new inicio();
                    inicio.privilegio = Convert.ToInt32(resultado[3]);
                    inicio.Show();
                    this.Hide();
                }
            }
            else
            {
                msgbox.Error("Algo no esta bien revisa tus datos");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
