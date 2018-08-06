using System;
using System.Data;
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

        public void Eliminar()
        {
            DataGridViewRow row = dgvUsuarios.CurrentRow;
            gsUsuarios _gsu = new gsUsuarios();
            _gsu.id = Convert.ToInt32(row.Cells[1].Value);
            int resEliminar = usuariosMet.Eliminar(_gsu);

            if (resEliminar > 0)
            {
                msgbox.Exito("Usuario eliminado");
                CargarDGV();
            }
        }

        private void ajustesUsuario_Load(object sender, EventArgs e)
        {
            CargarDGV();
            dgvUsuarios.ClearSelection();
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
                    _gsu.id = Convert.ToInt32(delRow.Cells[1].Value);
                    DataTable resAdmins = usuarios.ConsultarAdmins();

                    if (delRow.Cells[4].Value.ToString() == "1")
                    {
                        if (resAdmins.Rows.Count == 1)
                        {
                            msgbox.Error("Debe haber al menos un administrador");
                        }
                        else
                        {
                            Eliminar();
                        }
                    }
                    else
                    {
                        Eliminar();
                    }
                    
                }
                catch (Exception)
                {
                    msgbox.Error("Ocurrio un problema al eliminar");
                }
            }
        }
    }
}
