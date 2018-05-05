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
            dgvUsuarios.Rows.Clear();
            usuariosMet consultar = new usuariosMet();

            var resultado = consultar.ConsultarUsuarios();

            if (resultado != null)
            {
                while (resultado.Read())
                {
                    //Añadir filas con los resultados
                    this.dgvUsuarios.Rows.Add(resultado["id"], resultado["usuario"], resultado["privilegios"]);
                }
            }
            else
            {
                msgbox.Error("Error al mostrar usuarios");
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
            usuariosMet authUser = new usuariosMet();

            //Fila seleccionada
            DataGridViewRow delRow = dgvUsuarios.CurrentRow;

            //Si una fila ha sido seleccionada pasar id del producto
            try
            {
                if (seleccionado == false)
                {
                    delRow = null;
                    _gsu.id = 0;
                }
                else
                {
                    _gsu.id = Convert.ToInt32(delRow.Cells[0].Value);
                }

            }
            catch (Exception)
            {
                _gsu.id = 0;
            }

            var usuarioExiste = authUser.AuthUser(txtUsuario.Text, null);

            _gsu.usuario = txtUsuario.Text.Trim();
            _gsu.pass = txtPass.Text.Trim();

            if (cbPrivilegios.Text == "ADMIN")
            {
                _gsu.privilegios = 1;
            }
            else
            {
                _gsu.privilegios = 0;
            }

            if (txtUsuario.Text == "")
            {
                msgbox.Error("Ingresa un nombre de usuario");
            }
            else if (txtPass.Text == "")
            {
                msgbox.Error("Ingresa una contraseña");
            }
            else if (txtConfPass.Text == "")
            {
                msgbox.Error("Confirma la contraseña");
            }
            else if (cbPrivilegios.Text == "")
            {
                msgbox.Error("Selecciona los privilegios");
            }
            else
            {
                if (txtConfPass.Text != txtPass.Text)
                {
                    msgbox.Error("Las contraseñas no coinciden");
                }
                else
                {
                    if (_gsu.id > 0)
                    {
                        int actualizar = usuariosMet.Actualizar(_gsu);
                        if (actualizar > 0)
                        {
                            txtUsuario.Text = "";
                            txtPass.Text = "";
                            txtConfPass.Text = "";
                            cbPrivilegios.Text = "";
                            CargarDGV();
                        }
                        else
                        {
                            msgbox.Error("Error al actualizar el usuario");
                        }
                    }
                    else
                    {
                        if (usuarioExiste.HasRows)
                        {
                            msgbox.Error("Este nombre de usuario ya existe");
                            txtUsuario.Focus();
                        }
                        else
                        {
                            int agregar = usuariosMet.Agregar(_gsu);
                            if (agregar > 0)
                            {
                                txtUsuario.Text = "";
                                txtPass.Text = "";
                                txtConfPass.Text = "";
                                cbPrivilegios.Text = "";
                                CargarDGV();
                            }
                            else
                            {
                                msgbox.Error("Error al agregar el usuario");
                            }
                        }
                    }
                }
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

                    var ADMINS = usuarios.ConsultarAdmins();

                    

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
