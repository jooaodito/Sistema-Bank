using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SystemBank
{
    public partial class frmTelaSaque : Form
    {
        public frmTelaSaque()
        {
            InitializeComponent();

        }
        public frmTelaSaque(string valor)
        {
            InitializeComponent();
            txtConta.Text = valor;

        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void btnSacar_Click(object sender, EventArgs e)
        {
            

            decimal saldo = Convert.ToDecimal(txtSaque.Text);
            int nconta = Convert.ToInt32(txtConta.Text);
            DAL obj = new DAL();
            obj.Alterar(nconta, saldo);
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtSaque_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtConta_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
