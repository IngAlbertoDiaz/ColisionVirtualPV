using System;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Drawing;
using System.IO;

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
            try
            {
                string ConStr = "";
                OpenFileDialog openfile1 = new OpenFileDialog();
                openfile1.Filter = "Excel Files |*.xls;*xlsx;";
                openfile1.Title = "Seleccione el archivo de Excel";
                if (openfile1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (openfile1.FileName.Equals("") == false)
                    {
                        string ruta = openfile1.FileName;
                        string extension = Path.GetExtension(openfile1.FileName).ToLower();

                        //Filtrar el formato de archivo de excel
                        if (extension.Trim() == ".xls")
                        {
                            ConStr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + ruta + ";Extended Properties=\"Excel 8.0;HDR=Yes;IMEX=2\"";
                        }
                        else if (extension.Trim() == ".xlsx")
                        {
                            ConStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + ruta + ";Extended Properties=\"Excel 12.0;HDR=Yes;IMEX=2\"";
                        }
                        textBox1.Enabled = false;
                        textBox1.Text = ruta;
                        //Se abre la conexion
                        OleDbConnection conn = new OleDbConnection(ConStr);
                        if (conn.State == ConnectionState.Closed)
                        {
                            conn.Open();
                        }
                        //Se selecciona el contenido de la primera tabla
                        DataTable dtSheets = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                        string ExcelQuery = "SELECT * FROM ["+ dtSheets.Rows[0]["TABLE_NAME"].ToString() +"]";

                        //Se llena el Datagrid
                        OleDbCommand cmd = new OleDbCommand(ExcelQuery, conn);
                        OleDbDataAdapter excelAdapter = new OleDbDataAdapter(cmd);
                        excelAdapter.Fill(dt);
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

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            gsInventario _gsi = new gsInventario();

            try
            {
                for (int i = 0; i < dgvData.Rows.Count; i++)
                {
                    _gsi.codigo = dgvData.Rows[i].Cells[0].Value.ToString();
                    _gsi.marca = dgvData.Rows[i].Cells[0].Value.ToString();
                    _gsi.tipo = dgvData.Rows[i].Cells[1].Value.ToString();
                    _gsi.medida = dgvData.Rows[i].Cells[2].Value.ToString();
                    _gsi.color = dgvData.Rows[i].Cells[3].Value.ToString();
                    _gsi.descripcion = dgvData.Rows[i].Cells[4].Value.ToString();
                    _gsi.cantidad = Convert.ToInt32(dgvData.Rows[i].Cells[6].Value);
                    _gsi.precio_unitario = dgvData.Rows[i].Cells[6].Value.ToString();

                    int resGuardar = invMet.Agregar(_gsi);
                    result = DialogResult.OK;
                }
            }
            catch (Exception)
            {
                result = DialogResult.Abort;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
