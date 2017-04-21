namespace SystemBank
{
    partial class frmTelaExcluir
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExcluir_Excluir = new System.Windows.Forms.Button();
            this.txtExcluir = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnExcluir_Excluir);
            this.groupBox1.Controls.Add(this.txtExcluir);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 92);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Excluir Conta";
            // 
            // btnExcluir_Excluir
            // 
            this.btnExcluir_Excluir.Location = new System.Drawing.Point(184, 50);
            this.btnExcluir_Excluir.Name = "btnExcluir_Excluir";
            this.btnExcluir_Excluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir_Excluir.TabIndex = 2;
            this.btnExcluir_Excluir.Text = "Excluir";
            this.btnExcluir_Excluir.UseVisualStyleBackColor = true;
            this.btnExcluir_Excluir.Click += new System.EventHandler(this.btnExcluir_Excluir_Click);
            // 
            // txtExcluir
            // 
            this.txtExcluir.Enabled = false;
            this.txtExcluir.Location = new System.Drawing.Point(9, 50);
            this.txtExcluir.Name = "txtExcluir";
            this.txtExcluir.Size = new System.Drawing.Size(69, 20);
            this.txtExcluir.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Deseja excluir a conta de Nº  ";
            // 
            // frmTelaExcluir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 116);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmTelaExcluir";
            this.Text = "Tela de Excluir";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnExcluir_Excluir;
        private System.Windows.Forms.TextBox txtExcluir;
        private System.Windows.Forms.Label label1;
    }
}