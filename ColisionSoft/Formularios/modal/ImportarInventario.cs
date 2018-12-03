using System;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Drawing;

namespace ColisionSoft
{
    public partial class ImportarInventario : Form
    {
        public ImportarInventario()
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

        public DataTable dt = new DataTable();
        static DialogResult result = DialogResult.No;

        private void btnSelecExcel_Click(object sender, EventArgs e)
        {
            String ruta = "";
            try
            {
                OpenFileDialog openfile1 = new OpenFileDialog();
                openfile1.Filter = "Excel Files |*.xlsx";
                openfile1.Title = "Seleccione el archivo de Excel";
                if (openfile1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {

                    if (openfile1.FileName.Equals("") == false)
                    {
                        ruta = openfile1.FileName;
                        textBox1.Enabled = false;
                        textBox1.Text = ruta;

                        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;data source=" + ruta + ";Extended Properties='Excel 12.0 Xml;HDR=Yes'");
                        OleDbDataAdapter MyDataAdapter = new OleDbDataAdapter("SELECT * FROM [" + "Hoja1" + "$]", conn);
                        MyDataAdapter.Fill(dt);
                        dgvData.DataSource = dt;
                        label4.Visible = true;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al seleccionar el archivo.");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            gsInventario _gsi = new gsInventario();

            try
            {
                for (int i = 0; i < dgvData.Rows.Count; i++)
                {
                    _gsi.nombre = dgvData.Rows[i].Cells[0].Value.ToString();
                    _gsi.peso = float.Parse(dgvData.Rows[i].Cells[1].Value.ToString());
                    _gsi.unidad_medida = dgvData.Rows[i].Cells[2].Value.ToString();
                    _gsi.bodega = float.Parse(dgvData.Rows[i].Cells[3].Value.ToString());
                    _gsi.exhibicion = float.Parse(dgvData.Rows[i].Cells[4].Value.ToString());
                    _gsi.precio = float.Parse(dgvData.Rows[i].Cells[5].Value.ToString());
                    _gsi.proveedor = Convert.ToInt32(dgvData.Rows[i].Cells[6].Value);

                    int resGuardar = invMet.Agregar(_gsi);
                    result = DialogResult.OK;
                }
            }
            catch (Exception)
            {
                result = DialogResult.Abort;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
