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
            int num = Int32.Parse(this.txtCantidad.Text);
            this.txtResultado.Text = UTILS.Clases.NumerosLetras.getUnidades(num);
        }
    }
}
