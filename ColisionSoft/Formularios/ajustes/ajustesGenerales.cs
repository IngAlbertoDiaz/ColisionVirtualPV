﻿using System;
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

        private void ajustesGenerales_Load(object sender, EventArgs e)
        {
            lblTicket.Text = "N°:" + Properties.Settings.Default.ticket.ToString();
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
            GenerarExcel("PlantillaInventario");
        }


        public void GenerarExcel(string pNombre)
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

                //Llena las cabeceras
                if (pNombre == "PlantillaInventario")
                {
                    _HojaExcel.Cells[1, 1] = "codigo";
                    _HojaExcel.Cells[1, 2] = "marca";
                    _HojaExcel.Cells[1, 3] = "tipo";
                    _HojaExcel.Cells[1, 4] = "medida";
                    _HojaExcel.Cells[1, 5] = "color";
                    _HojaExcel.Cells[1, 6] = "descripcion";
                    _HojaExcel.Cells[1, 7] = "cantidad";
                    _HojaExcel.Cells[1, 8] = "precio_unitario";
                }

                //Genera archivo XLSX
                _LibroExcel.SaveAs(ruta + "\\"+ pNombre +".xlsx", excel.XlFileFormat.xlOpenXMLWorkbook, misValue, misValue, misValue, misValue, excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
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
    }
}
