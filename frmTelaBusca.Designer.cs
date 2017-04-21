namespace SystemBank
{
    partial class frmTelaBusca
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.lbBuscar = new System.Windows.Forms.Label();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.dgDados = new System.Windows.Forms.DataGridView();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.rdConta = new System.Windows.Forms.RadioButton();
            this.rdAgencia = new System.Windows.Forms.RadioButton();
            this.rdCpf = new System.Windows.Forms.RadioButton();
            this.rdNome = new System.Windows.Forms.RadioButton();
            this.btnSair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgDados)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(522, 37);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 0;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // lbBuscar
            // 
            this.lbBuscar.AutoSize = true;
            this.lbBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBuscar.Location = new System.Drawing.Point(44, 41);
            this.lbBuscar.Name = "lbBuscar";
            this.lbBuscar.Size = new System.Drawing.Size(80, 18);
            this.lbBuscar.TabIndex = 1;
            this.lbBuscar.Text = "Busca por:";
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(384, 40);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(132, 20);
            this.txtPesquisa.TabIndex = 2;
            // 
            // dgDados
            // 
            this.dgDados.AllowUserToAddRows = false;
            this.dgDados.AllowUserToDeleteRows = false;
            this.dgDados.BackgroundColor = System.Drawing.Color.White;
            this.dgDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDados.Location = new System.Drawing.Point(47, 74);
            this.dgDados.Name = "dgDados";
            this.dgDados.ReadOnly = true;
            this.dgDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgDados.Size = new System.Drawing.Size(644, 265);
            this.dgDados.TabIndex = 3;
            this.dgDados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDados_CellContentClick);
            this.dgDados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDados_CellDoubleClick);
            this.dgDados.Enter += new System.EventHandler(this.dgDados_Enter);
            this.dgDados.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgDados_MouseClick);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(697, 74);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(108, 23);
            this.btnCadastrar.TabIndex = 4;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(697, 103);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(108, 23);
            this.btnAtualizar.TabIndex = 6;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // rdConta
            // 
            this.rdConta.AutoSize = true;
            this.rdConta.Location = new System.Drawing.Point(130, 41);
            this.rdConta.Name = "rdConta";
            this.rdConta.Size = new System.Drawing.Size(68, 17);
            this.rdConta.TabIndex = 9;
            this.rdConta.TabStop = true;
            this.rdConta.Text = "Nº Conta";
            this.rdConta.UseVisualStyleBackColor = true;
            // 
            // rdAgencia
            // 
            this.rdAgencia.AutoSize = true;
            this.rdAgencia.Location = new System.Drawing.Point(204, 41);
            this.rdAgencia.Name = "rdAgencia";
            this.rdAgencia.Size = new System.Drawing.Size(64, 17);
            this.rdAgencia.TabIndex = 10;
            this.rdAgencia.TabStop = true;
            this.rdAgencia.Text = "Agencia";
            this.rdAgencia.UseVisualStyleBackColor = true;
            // 
            // rdCpf
            // 
            this.rdCpf.AutoSize = true;
            this.rdCpf.Location = new System.Drawing.Point(274, 41);
            this.rdCpf.Name = "rdCpf";
            this.rdCpf.Size = new System.Drawing.Size(45, 17);
            this.rdCpf.TabIndex = 11;
            this.rdCpf.TabStop = true;
            this.rdCpf.Text = "CPF";
            this.rdCpf.UseVisualStyleBackColor = true;
            // 
            // rdNome
            // 
            this.rdNome.AutoSize = true;
            this.rdNome.Location = new System.Drawing.Point(325, 40);
            this.rdNome.Name = "rdNome";
            this.rdNome.Size = new System.Drawing.Size(53, 17);
            this.rdNome.TabIndex = 12;
            this.rdNome.TabStop = true;
            this.rdNome.Text = "Nome";
            this.rdNome.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(697, 316);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(108, 23);
            this.btnSair.TabIndex = 13;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmTelaBusca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 362);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.rdNome);
            this.Controls.Add(this.rdCpf);
            this.Controls.Add(this.rdAgencia);
            this.Controls.Add(this.rdConta);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.dgDados);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.lbBuscar);
            this.Controls.Add(this.btnPesquisar);
            this.Name = "frmTelaBusca";
            this.Text = "Tela de Busca";
            ((System.ComponentModel.ISupportInitialize)(this.dgDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label lbBuscar;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.DataGridView dgDados;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.RadioButton rdConta;
        private System.Windows.Forms.RadioButton rdAgencia;
        private System.Windows.Forms.RadioButton rdCpf;
        private System.Windows.Forms.RadioButton rdNome;
        private System.Windows.Forms.Button btnSair;
    }
}

