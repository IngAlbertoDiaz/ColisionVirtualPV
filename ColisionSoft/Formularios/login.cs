﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

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
            try
            {
                usuariosMet userAuth = new usuariosMet();

                DataTable resultado = userAuth.login(txtUsuario.Text, txtPass.Text);

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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_Load(object sender, EventArgs e)
        {
        }
    }
}
