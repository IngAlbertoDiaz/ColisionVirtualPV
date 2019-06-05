using System;
using System.Drawing;
using System.Windows.Forms;

namespace ColisionSoft
{
    public partial class cobro : Form
    {
        public cobro()
        {
            InitializeComponent();
        }

        static cobro msgbox_cobro;
        static DialogResult result = DialogResult.No;

        public static DialogResult Cobrar()
        {
            msgbox_cobro = new cobro();
            result = DialogResult.No;
            msgbox_cobro.ShowDialog();
            return result;
        }

        private void cobro_Load(object sender, EventArgs e)
        {
            lblTotal.Text = "Total: $" + venta.total;
            result = DialogResult.No;
        }

        private void txtRecibir_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (txtRecibir.Text == "")
                    {
                        this.BackColor = Color.FromArgb(120, 0, 0);
                        timer1.Start();
                    }
                    else
                    {
                        string valor = lblTotal.Text;
                        string[] info = valor.Split('$');
                        double total = Convert.ToDouble(info[1]);
                        double recibido = Convert.ToDouble(txtRecibir.Text);
                        if (recibido < total)
                        {
                            msgbox.Error("El monto recibido es menor al costo total.");
                        }
                        else
                        {
                            double resultado = recibido - total;
                            lblCambio.Text = "Cambio: " + resultado.ToString();
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                msgbox.Error("Algo salio mal");
                MessageBox.Show(ex.ToString());
            }
            
        }
        private void txtRecibir_KeyPress(object sender, KeyPressEventArgs e)
        {
            char keypress = e.KeyChar;
            if (char.IsLetter(keypress))
            {
                this.BackColor = Color.FromArgb(120, 0, 0);
            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            result = DialogResult.OK;
            msgbox_cobro.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            result = DialogResult.Cancel;
            msgbox_cobro.Close();
        }

        private void btnCancelar_Enter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(120, 0, 0);
        }

        private void btnFinalizar_Enter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(0, 120, 0);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(0, 120, 0);
        }
    }
}
