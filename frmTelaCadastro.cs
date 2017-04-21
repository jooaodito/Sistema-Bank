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

namespace SystemBank
{
    public partial class frmTelaCadastro : Form
    {
        public frmTelaCadastro()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCadastra_cad_Click(object sender, EventArgs e)
        {
        if(validar())
        {
            DAL obj = new DAL();

            ContaModelo conta = new ContaModelo();

            conta.numero = txtConta.Text;
            conta.agencia = txtAgencia.Text;
            conta.saldo = Convert.ToDecimal((txtSaldo.Text.Equals("") ? "0.00" : txtSaldo.Text));
            conta.tipo = cbConta.Text;
            conta.nome = txtNome.Text;
            conta.cpf = txtCpf.Text;

            if (obj.Insert(conta))
            {
                MessageBox.Show("Cadastrado com Sucesso!","Sucesso", MessageBoxButtons.OK,MessageBoxIcon.Information);
                    frmTelaBusca dt = new frmTelaBusca();
                    dt.dgDados_Enter(e, e);
            }
            else
            {
                MessageBox.Show("Erro ao Cadastrar!","Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            this.Close();
        }
        }

        private bool validar()
        {
            if (txtConta.Text == "")
            {
                MessageBox.Show("Digite o número da conta", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtAgencia.Text == "")
            {
                MessageBox.Show("Digite o número da agência", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtNome.Text == "")
            {
                MessageBox.Show("Digite o nome do cliente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtCpf.Text == "")
            {
                MessageBox.Show("Digite o CPF do cliente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (cbConta.Text == "")
            {
                MessageBox.Show("Selecione o tipo de conta", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtSaldo.Text == "")
            {
                MessageBox.Show("Digite o saldo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
    }
}
