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
            try
            {
                flowLayoutPanel1.Controls.Clear();
                SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='|DataDirectory|ColisionSoft.mdf';Integrated Security=True");

                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM inventario", cn);

                DataTable dt = new DataTable();
                da.Fill(dt);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Button btn = new Button();
                    btn.Name = "btn" + dt.Rows[i][0];
                    btn.Text = dt.Rows[i][1].ToString();
                    btn.Font = new Font("ORATOR STD", 14f, FontStyle.Bold);
                    btn.ForeColor = Color.White;
                    // btn.UseCompatibleTextRendering = true;
                    btn.BackColor = Color.FromArgb(0, 120, 0);
                    btn.FlatAppearance.BorderSize = 0;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.Height = 55;
                    btn.Width = 145;
                    btn.Click += button1_Click;
                    flowLayoutPanel1.Controls.Add(btn);
                }
            }
            catch (Exception)
            {
                msgbox.Error("UPS! Algo salio mal, intenta de nuevo");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Button button = sender as Button;
                float sum = 0;
                SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='|DataDirectory|ColisionSoft.mdf';Integrated Security=True");
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM inventario WHERE  nombre = '" + button.Text + "'", cn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvVenta.Rows.Add(Properties.Settings.Default.ticket, dt.Rows[0][1], dt.Rows[0][4]);
                for (int i = 0; i < dgvVenta.Rows.Count; i++)
                {
                    sum += float.Parse(dgvVenta.Rows[i].Cells[2].Value.ToString());
                }
                lblCantidad.Text = sum.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Algo salio mal, intenta de nuevo");
            }
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            lblCantidad.Text = "";
            dgvVenta.Rows.Clear();
        }

        private void btnCobrar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = new DialogResult();
                cobro fcob = new cobro();
                DBCon db = new DBCon();
                total = lblCantidad.Text;
                dr = cobro.Cobrar();
                if (dr == DialogResult.OK)
                {
                    db._CONN.ConnectionString = db._DB;
                    db._CONN.Open();

                    for (int i = 0; i < dgvVenta.Rows.Count; i++)
                    {
                        SqlDataAdapter query = new SqlDataAdapter("INSERT INTO ventas (n_ticket,producto,precio) VALUES ("
                            + dgvVenta.Rows[i].Cells["ticket"].Value + ",'"
                            + dgvVenta.Rows[i].Cells["producto"].Value + "',"
                            + dgvVenta.Rows[i].Cells["precio"].Value + ");", db._CONN
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

        private void btnGranel_Click(object sender, EventArgs e)
        {
            granel Fgranel = new granel(this);
            Fgranel.Show();
        }

        
        
    }
}