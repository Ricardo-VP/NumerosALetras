using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumerosALetras
{
    public partial class frmEmisionDeCheque : Form
    {
        public frmEmisionDeCheque()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //UTILS.Clases.NumerosLetras.TestUnidades();
            if (txtCantidad.Text.Length == 0)
            {
                MessageBox.Show("Ingresa el valor del cheque", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCantidad.Focus();
                return;
            }
            else if (txtOrdenDe.Text.Length == 0)
            {
                MessageBox.Show("Ingresa el nombre del remitente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtOrdenDe.Focus();
                return;
            }
            else if (txtDestinatario.Text.Length == 0)
            {
                MessageBox.Show("Ingresa el nombre del destinatario", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtDestinatario.Focus();
                return;
            }
            else { 
            int num = Int32.Parse(this.txtCantidad.Text);
            this.txtResultado.Text = UTILS.Clases.NumerosLetras.getMillones(num) + " dólares";
            txtFechaNow.Text = Convert.ToString(DateTime.Now.ToString("dd 'de' MMMM 'del' yyyy"));
            }

        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtOrdenDe_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo números enteros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
