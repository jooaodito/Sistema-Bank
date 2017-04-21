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
    public partial class frmTelaDeposito : Form
    {
        public frmTelaDeposito(string valor)
        {
            InitializeComponent();
            txtConta.Text = valor;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnSacar_Click(object sender, EventArgs e)
        {
            decimal saldo = Convert.ToDecimal(txtSaque.Text);
            int nconta = Convert.ToInt32(txtConta.Text);
            DAL obj = new DAL();
            obj.Depositar(nconta, saldo);
            this.Close();
        }
    }
}
