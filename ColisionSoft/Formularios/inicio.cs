using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.ServiceProcess;


namespace ColisionSoft
{
    public partial class inicio : Form
    {
        public inicio()
        {
            InitializeComponent();
            Configuraciones();
            timer1.Enabled = true;
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

        //ADMIN - USUARIO COMUN
        public int privilegio;

        public void Configuraciones()
        {
            //Llamar al inicio para establecer nombre del negocio
            lblNombre.Text = Properties.Settings.Default.nombreNegocio;
        }

        public void CerrarFormulariosExtra()
        {
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                if (Application.OpenForms[i].Name != "inicio")
                {
                    if (Application.OpenForms[i].Name != "login")
                    {
                        Application.OpenForms[i].Close();
                    }
                }
            }
        }

        public void FormVenta()
        {
            PVentanas.Controls.Clear();
            //Inicializa el formulario de ventas y lo agrega a un panel
            venta ven = new venta();
            ven.TopLevel = false;
            PVentanas.Controls.Add(ven);
            ven.Show();
        }

        public void FormInventario()
        {
            //Mueve la barra lateral izquierda hacia el boton de inventario
            Pindicador.Height = btnInventario.Height;
            Pindicador.Top = btnInventario.Top;
            //Limpia los controles del panel
            PVentanas.Controls.Clear();
            //Inicializa el formulario de ventas y lo agrega a un panel
            inventario inv = new inventario();
            //Cierra cualquier formulario extra abierto
            CerrarFormulariosExtra();
            inv.TopLevel = false;
            PVentanas.Controls.Add(inv);
            inv.Show();
        }

        public void FormProveedores()
        {
            Pindicador.Height = btnProveedores.Height;
            Pindicador.Top = btnProveedores.Top;
            PVentanas.Controls.Clear();
            proveedores prov = new proveedores();
            CerrarFormulariosExtra();
            prov.TopLevel = false;
            PVentanas.Controls.Add(prov);
            prov.Show();
        }

        public void FormAjustes()
        {
            Pindicador.Height = btnAjustes.Height;
            Pindicador.Top = btnAjustes.Top;
            PVentanas.Controls.Clear();
            ajustes FormAju = new ajustes();
            CerrarFormulariosExtra();
            FormAju.TopLevel = false;
            PVentanas.Controls.Add(FormAju);
            FormAju.Show();
        }

        private void inicio_Load(object sender, EventArgs e)
        {
            FormVenta();
            //Centra el nombre del negocio
            int x = (PFormulario.Size.Width - lblNombre.Size.Width) / 2;
            lblNombre.Location = new Point(x, lblNombre.Location.Y);
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            try
            {
                if (privilegio == 1)
                {
                    FormInventario();
                }
                else
                {
                    
                }
            }
            catch (Exception)
            {
                msgbox.Error("Algo salio mal");
            }
            
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            try
            {
                if (privilegio == 1)
                {
                    FormProveedores();
                }
                else
                {
                }
            }
            catch (Exception)
            {
                msgbox.Error("Algo salio mal");
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            cambiar_salir cs = new cambiar_salir();
            cs.Show();
            this.Close();
        }

        private void btnVenta_Click(object sender, EventArgs e)
        {
            try
            {
                FormVenta();
            }
            catch (Exception)
            {
                msgbox.Error("Algo salio mal");
            }
            
        }

        private void btnAjustes_Click(object sender, EventArgs e)
        {
            try
            {
                if (privilegio == 1)
                {
                    FormAjustes();
                }
                else
                {
                }
            }
            catch (Exception)
            {
                msgbox.Error("Algo salio mal");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString();
        }
    }
}
