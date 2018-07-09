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
    public partial class ajustesUsuario : Form
    {
        public ajustesUsuario()
        {
            InitializeComponent();
        }

        public bool seleccionado = false;

        public void CargarDGV()
        {
            //dgvUsuarios.Rows.Clear();

            usuariosMet _Usuarios = new usuariosMet();

            DataTable resultado = _Usuarios.ConsultarUsuarios();

            if (resultado != null)
            {
                if (resultado.Rows.Count > 0)
                {
                    dgvUsuarios.DataSource = resultado;
                }
            }
        }

        private void ajustesUsuario_Load(object sender, EventArgs e)
        {
            CargarDGV();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            gsUsuarios _gsu = new gsUsuarios();
            usuariosMet _usMet = new usuariosMet();

            try
            {
                _gsu.usuario = txtUsuario.Text;
                _gsu.pass = txtPass.Text;

                if (cbPrivilegios.Text == "ADMIN")
                {
                    _gsu.privilegios = 1;
                }
                else
                {
                    _gsu.privilegios = 0;
                }

                int resultado = usuariosMet.Agregar(_gsu);

                if (resultado > 0)
                {
                    CargarDGV();
                }
                else
                {
                    msgbox.Error("Ocurrio un error al agregar, intenta de nuevo");
                }
            }
            catch (Exception)
            {
                msgbox.Error("Hubo un error con tu solicitud");
            }
            
        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow delRow = dgvUsuarios.CurrentRow;

                    gsUsuarios _gsu = new gsUsuarios();
                    usuariosMet usuarios = new usuariosMet();

                    DataTable resultado = usuarios.ConsultarAdmins();

                    if (resultado != null)
                    {
                        if (resultado.Rows.Count > 0)
                        {
                            
                        }
                    }
                    else
                    {
                        msgbox.Error("Datos incorrectos");
                    }

                }
                catch (Exception)
                {
                    msgbox.Error("Ocurrio un problema al eliminar");
                }
            }
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = dgvUsuarios.CurrentRow;

                seleccionado = true;

                txtUsuario.Text = Convert.ToString(row.Cells[1].Value);
                int priv = Convert.ToInt32(row.Cells[2].Value);
                if (priv == 1)
                {
                    cbPrivilegios.Text = "ADMIN";
                }
                else
                {
                    cbPrivilegios.Text = "USUARIO";
                }
            }
            catch (Exception)
            {
                msgbox.Error("No pudo obtenerse la informacion");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            seleccionado = false;
            txtUsuario.Text = "";
            txtPass.Text = "";
            txtConfPass.Text = "";
            cbPrivilegios.Text = "";
            dgvUsuarios.ClearSelection();
        }
    }
}
