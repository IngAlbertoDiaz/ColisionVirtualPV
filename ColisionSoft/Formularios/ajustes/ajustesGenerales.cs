using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using excel = Microsoft.Office.Interop.Excel;

namespace ColisionSoft
{
    public partial class ajustesGenerales : Form
    {
        public ajustesGenerales()
        {
            InitializeComponent();
        }

        private void btnGuardarAjustes_Click(object sender, EventArgs e)
        {
            //Cambia valores de la aplicacion
            Properties.Settings.Default.nombreNegocio = txtNombre.Text;
            //Guarda valores de la aplicacion
            Properties.Settings.Default.Save();
            msgbox.Exito("Debe reiniciar el programa para efectuar los cambios");
        }

        private void btnRT_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Estas seguro de realizar esta accion?","Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                Properties.Settings.Default.ticket = 1;
                Properties.Settings.Default.Save();
                lblTicket.Text = "N°:" + Properties.Settings.Default.ticket.ToString();
            }
            else
            {

            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInvTemplate_Click(object sender, EventArgs e)
        {
            string TemplateInv = "PlantillaInventario";
            GenerarExcel(TemplateInv);
        }

        private void btnProvTemplate_Click(object sender, EventArgs e)
        {
            string TemplateInv = "PlantillaProveedores";
            GenerarExcel(TemplateInv);
        }

        public void GenerarExcel(string nombre)
        {
            try
            {
                string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                excel.Application xlApp = new excel.Application();
                if (xlApp == null)
                {
                    return;
                }

                excel.Workbook _LibroExcel;
                excel.Worksheet _HojaExcel;
                object misValue = System.Reflection.Missing.Value;

                _LibroExcel = xlApp.Workbooks.Add(misValue);
                _HojaExcel = (excel.Worksheet)_LibroExcel.Worksheets.get_Item(1);

                if (nombre == "PlantillaInventario")
                {
                    _HojaExcel.Cells[1, 1] = "NOMBRE";
                    _HojaExcel.Cells[1, 2] = "APELLIDO";
                }
                else if (nombre == "PlantillaProveedores")
                {
                    _HojaExcel.Cells[1, 1] = "nombre";
                    _HojaExcel.Cells[1, 2] = "abrev";
                }
                

                _LibroExcel.SaveAs(ruta + "\\"+ nombre +".xlsx", excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                _LibroExcel.Close(true, misValue, misValue);
                xlApp.Quit();

                Marshal.ReleaseComObject(_HojaExcel);
                Marshal.ReleaseComObject(_LibroExcel);
                Marshal.ReleaseComObject(xlApp);

                msgbox.Exito("Encuentra el archivo plantilla en el escritorio");
            }
            catch (Exception)
            {
                msgbox.Error("Ocurrio un error");
            }
            
        }

        private void ajustesGenerales_Load(object sender, EventArgs e)
        {
            lblTicket.Text = "N°:" + Properties.Settings.Default.ticket.ToString();
        }
    }
}
