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
    public partial class frmTelaExcluir : Form
    {
        public frmTelaExcluir(string valor)
        {
            InitializeComponent();
            txtExcluir.Text = valor;
        }

        private void btnExcluir_Excluir_Click(object sender, EventArgs e)
        {
            DAL obj = new DAL();

            int n = Convert.ToInt32(txtExcluir.Text);

            if(obj.Excluir(n))
            {
                MessageBox.Show("Cadastro Excluido com Sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Erro ao Excluir!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
        }
    }
}
