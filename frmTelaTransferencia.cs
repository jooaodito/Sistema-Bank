using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemBank
{
    public partial class frmTelaTransferencia : Form
    {
        public frmTelaTransferencia(string valor)
        {
            InitializeComponent();
            txtConta.Text = valor;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTransferencia_Click(object sender, EventArgs e)
        {
            decimal valor = Convert.ToDecimal(txtValor.Text);
            int nconta = Convert.ToInt32(txtConta.Text);
            int destino = Convert.ToInt32(txtDestino.Text);
            DAL obj = new DAL();
            obj.Transferencia(nconta, destino, valor);
            this.Close();
        }

        private void txtDestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            DAL obj = new DAL();
        }

    }
}
