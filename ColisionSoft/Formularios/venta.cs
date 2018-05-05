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

namespace ColisionSoft
{
    public partial class venta : Form
    {
        public venta()
        {
            InitializeComponent();
            AutoCompletarBusqueda();
        }

        DataTable dt = new DataTable();
        public static string total = "";

        public void AutoCompletarBusqueda()
        {
            try
            {
                txtProducto.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txtProducto.AutoCompleteSource = AutoCompleteSource.CustomSource;
                AutoCompleteStringCollection col = new AutoCompleteStringCollection();

                prodMet ProdMetod = new prodMet();

                var resultado = ProdMetod.Consultar();

                if (resultado != null)
                {
                    while (resultado.Read())
                    {
                        //Añadir filas con los resultados
                        string sNombre = resultado.GetString("nombre");
                        float sPrecio = resultado.GetInt32("precio");
                        col.Add(sNombre + "$" + sPrecio);
                    }
                }
                else
                {
                }

                txtProducto.AutoCompleteCustomSource = col;
            }
            catch (Exception)
            {
                msgbox.Error("NO SE CARGARON LOS PRODUCTOS");
            }
        }

        private void venta_Load(object sender, EventArgs e)
        {
        }

        private void txtProducto_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    string valor = txtProducto.Text;
                    string[] info = valor.Split('$');
                    int nTicket = Convert.ToInt32(Properties.Settings.Default.ticket);
                    dgvVenta.Rows.Add(nTicket, info[0], info[1]);
                    Array.Clear(info, 0, info.Length);
                    txtProducto.Text = "";

                    double suma = 0;

                    for (int i = 0; i < dgvVenta.Rows.Count; i++)
                    {
                        suma += Convert.ToDouble(dgvVenta.Rows[i].Cells[2].Value);
                    }
                    lblCantidad.Text = suma.ToString();
                }
            }
            catch (Exception)
            {
                msgbox.Error("OCURRIO UN PROBLEMA");
            }
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtProducto.Text = "";
            lblCantidad.Text = "";
            dgvVenta.Rows.Clear();
        }

        private void btnCobrar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = new DialogResult();
                cobro fcob = new cobro();
                DBCon cadena = new DBCon();
                MySqlConnection con = new MySqlConnection();
                MySqlCommand query = new MySqlCommand();
                total = lblCantidad.Text;
                dr = cobro.Cobrar();
                if (dr == DialogResult.OK)
                {
                    con.ConnectionString = cadena.CadenaConexion();
                    con.Open();
                    query.Connection = con;

                    for (int i = 0; i < dgvVenta.Rows.Count; i++)
                    {
                        query.CommandText = "INSERT INTO ventas (n_ticket,producto,precio) VALUES ("
                            + dgvVenta.Rows[i].Cells["ticket"].Value    + ",'"
                            + dgvVenta.Rows[i].Cells["producto"].Value  + "',"
                            + dgvVenta.Rows[i].Cells["precio"].Value    + ");";
                        query.ExecuteNonQuery();
                    }

                    Properties.Settings.Default.ticket++;
                    Properties.Settings.Default.Save();
                    txtProducto.Text = "";
                    lblCantidad.Text = "";
                    dgvVenta.Rows.Clear();
                    msgbox.Exito("Venta procesada con exito");
                }
                else
                {
                    msgbox.Error("Venta CANCELADA");
                    txtProducto.Text = "";
                    lblCantidad.Text = "";
                    dgvVenta.Rows.Clear();
                }
            }
            catch (Exception)
            {
                msgbox.Error("Error al procesar la venta");
            }
        }

        private void btnGranel_Click(object sender, EventArgs e)
        {
            granel Fgranel = new granel(this);
            Fgranel.Show();
        }
    }
}
