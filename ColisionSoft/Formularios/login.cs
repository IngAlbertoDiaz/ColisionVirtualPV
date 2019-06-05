using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace ColisionSoft
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        //MOVER FORMULARIO SIN BORDE CON UN PANEL--------------------------------
        private bool LMB;
        private Point lastLocation;

        private void PFormulario_MouseMove(object sender, MouseEventArgs e)
        {
            if (LMB)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void PFormulario_MouseUp(object sender, MouseEventArgs e)
        {
            LMB = false;
        }

        private void PFormulario_MouseDown(object sender, MouseEventArgs e)
        {
            LMB = true;
            lastLocation = e.Location;
        }
        //-----------------------------------------------------------------------

        private void login_Load(object sender, EventArgs e)
        {
        }

        private void btnSesion_Click(object sender, EventArgs e)
        {
            IniciarSesion(txtUsuario.Text, txtPass.Text);
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                IniciarSesion(txtUsuario.Text, txtPass.Text);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void IniciarSesion(string pUsuario, string pPass)
        {
            try
            {
                usuariosMet userAuth = new usuariosMet();

                DataTable resultado = userAuth.login(pUsuario, pPass);

                if (resultado != null)
                {
                    if (resultado.Rows.Count > 0)
                    {
                        inicio inicio = new inicio();
                        inicio.privilegio = Convert.ToInt32(resultado.Rows[0][3]);
                        inicio.Show();
                        this.Hide();
                    }
                    else
                    {
                        msgbox.Error("Datos incorrectos");
                    }
                }
            }
            catch (Exception)
            {
                msgbox.Error("Error al leer los datos");
            }
        }

       
    }
}
