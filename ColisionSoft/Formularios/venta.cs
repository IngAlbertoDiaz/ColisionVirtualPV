using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ColisionSoft
{
    public partial class venta : Form
    {
        public venta()
        {
            InitializeComponent();
        }

        DataTable dt = new DataTable();
        public static string total = "";

        private void venta_Load(object sender, EventArgs e)
        {
            txtProducto.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            lblCantidad.Text = "";
            txtProducto.Text = "";
            txtProducto.Focus();
            dgvVenta.Rows.Clear();
        }

        private void btnCobrar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = new DialogResult();
                cobro fcob = new cobro();
                DBConn db = new DBConn();
                total = lblCantidad.Text;
                dr = cobro.Cobrar();
                if (dr == DialogResult.OK)
                {
                    db.sqlConnection.ConnectionString = db.dbString;
                    db.sqlConnection.Open();

                    for (int i = 0; i < dgvVenta.Rows.Count; i++)
                    {
                        SqlDataAdapter query = new SqlDataAdapter("INSERT INTO ventas (nTicket,codigo_prod,precio) VALUES ("
                            + dgvVenta.Rows[i].Cells["ticket"].Value + ",'"
                            + dgvVenta.Rows[i].Cells["codigo"].Value + "',"
                            + dgvVenta.Rows[i].Cells["precio"].Value + ");", db.sqlConnection
                            );
                    }

                    Properties.Settings.Default.ticket++;
                    Properties.Settings.Default.Save();
                    lblCantidad.Text = "";
                    dgvVenta.Rows.Clear();
                    msgbox.Exito("Venta procesada con exito");
                }
                else
                {
                    msgbox.Error("Venta CANCELADA");
                    lblCantidad.Text = "";
                    dgvVenta.Rows.Clear();
                }
            }
            catch (Exception)
            {
                msgbox.Error("Error al procesar la venta");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarProducto(txtProducto.Text);
            txtProducto.Text = "";
            txtProducto.Focus();
        }

        private void txtProducto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AgregarProducto(txtProducto.Text);
            }
        }

        public void AgregarProducto(string codigo)
        {
            try
            {
                invMet metInventario = new invMet();
                DataTable dtResult = metInventario.ConsultarInventario("SELECT codigo, precio_unitario FROM inventario WHERE codigo = '" + txtProducto.Text + "'");
                float total = 0f;

                if (dtResult != null)
                {
                    if (dtResult.Rows.Count > 0)
                    {
                        dgvVenta.Rows.Insert(0, Properties.Settings.Default.ticket ,dtResult.Rows[0]["codigo"], dtResult.Rows[0]["precio_unitario"]);
                        for (int i = 0; i < dgvVenta.Rows.Count; i++)
                        {
                            total += float.Parse(dgvVenta.Rows[i].Cells[2].Value.ToString());
                        }
                        lblCantidad.Text = total.ToString();
                    }
                    else
                    {
                        msgbox.Error("No se encuentra el producto");
                    }
                }
                else
                {
                    msgbox.Error("Ocurrio un error al consultar la informacion");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                msgbox.Error("Algo salio mal");
            }
        }
    }
}