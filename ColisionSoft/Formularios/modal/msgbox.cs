using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace ColisionSoft
{
    public partial class msgbox : Form
    {
        public msgbox()
        {
            InitializeComponent();
        }

        static msgbox Per_MsgBox;
        static DialogResult result = DialogResult.No;

        public void FormError()
        {
            pictureBox1.Image = (Image)(Properties.Resources.error);
            this.BackColor = Color.FromArgb(120, 0, 0);
            SoundPlayer sError = new SoundPlayer(Properties.Resources.sonidoError);
            sError.Play();
            
        }
        public void FormExito()
        {
            pictureBox1.Image = (Image)(Properties.Resources.success);
            this.BackColor = Color.FromArgb(0, 120, 0);
            SoundPlayer sExito = new SoundPlayer(Properties.Resources.sonidoExito);
            sExito.Play();
        }

        public static DialogResult Exito(string mensaje)
        {
            Per_MsgBox = new msgbox();
            Per_MsgBox.lblMensaje.Text = mensaje;
            Per_MsgBox.lblMensaje.BackColor = Color.FromArgb(0, 120, 0);
            Per_MsgBox.FormExito();
            result = DialogResult.No;
            Per_MsgBox.ShowDialog();
            return result;
        }
        public static DialogResult Error(string mensaje)
        {
            Per_MsgBox = new msgbox();
            Per_MsgBox.lblMensaje.Text = mensaje;
            Per_MsgBox.lblMensaje.BackColor = Color.FromArgb(120,0,0);
            Per_MsgBox.FormError();
            result = DialogResult.No;
            Per_MsgBox.ShowDialog();
            return result;
        }

        private void msgbox_Load(object sender, EventArgs e)
        {
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            result = DialogResult.Yes;
            Per_MsgBox.Close();
        }
    }
}
