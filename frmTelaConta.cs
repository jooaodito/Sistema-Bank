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
    public partial class frmTelaConta : Form
    {
        public frmTelaConta()
        {
            InitializeComponent();
        }

        public frmTelaConta(string valor)
        {
            InitializeComponent();
            txtExibiConta.Text = valor;

            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        public void txtExibiNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void btnSaque_Click(object sender, EventArgs e )
        {
            string variavel = txtExibiConta.Text;
            frmTelaSaque val = new frmTelaSaque(variavel.ToString());
            val.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string variavel = txtExibiConta.Text;
            frmTelaTransferencia val = new frmTelaTransferencia(variavel.ToString());
            val.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string variavel = txtExibiConta.Text;
            frmTelaDeposito val = new frmTelaDeposito(variavel.ToString());
            val.Show();
        }

        private void btnExtrato_Click(object sender, EventArgs e)
        {
            string variavel = txtExibiConta.Text;
            frmTelaExcluir val = new frmTelaExcluir(variavel.ToString());
            val.Show();
        }
    }
}
