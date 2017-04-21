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
    public partial class frmTelaBusca : Form
    {

        public frmTelaBusca()
        {
            InitializeComponent();
            DAL obj = new DAL();
            dgDados.DataSource = obj.ListarGrid();
            DataTable dt = obj.ListarGrid();

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            frmTelaCadastro frm = new frmTelaCadastro();
            frm.ShowDialog();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            DAL obj = new DAL();
            string sql;

            if (rdConta.Checked)
            {
                dgDados.DataSource = obj.PesquisaConta(txtPesquisa.Text);
            }
            else if (rdAgencia.Checked)
            {
                dgDados.DataSource = obj.PesquisaAgencia(txtPesquisa.Text);
            }
            else if(rdCpf.Checked)
            {
                dgDados.DataSource = obj.PesquisaCPF(txtPesquisa.Text);
            }
            else
            {
                dgDados.DataSource = obj.PesquisaNome("%"+txtPesquisa.Text+"%");
            }
        }

        public void dgDados_Enter(object sender, EventArgs e)
        {
            dgDados.Refresh();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            DAL obj = new DAL();
            dgDados.DataSource = obj.ListarGrid();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        public void dgDados_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void dgDados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmTelaConta obj = new frmTelaConta(dgDados.SelectedRows[0].Cells[0].Value.ToString());
            obj.Show();
        }
    }
}
