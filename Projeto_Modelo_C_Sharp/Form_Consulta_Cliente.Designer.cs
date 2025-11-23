namespace Projeto_Modelo_C_Sharp
{
    partial class Form_Consulta_Cliente
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
            this.lblText = new System.Windows.Forms.Label();
            this.dgvPesquisa = new System.Windows.Forms.DataGridView();
            this.rdoOrdenarEmail = new System.Windows.Forms.RadioButton();
            this.rdoOrdenarNome = new System.Windows.Forms.RadioButton();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.txtNomeUsuario = new System.Windows.Forms.TextBox();
            this.lblNomeUsuario = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.limete_credito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesquisa)).BeginInit();
            this.SuspendLayout();
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText.Location = new System.Drawing.Point(241, 9);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(170, 24);
            this.lblText.TabIndex = 0;
            this.lblText.Text = "Consulta de cliente";
            // 
            // dgvPesquisa
            // 
            this.dgvPesquisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPesquisa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nome,
            this.endereco,
            this.telefone,
            this.status,
            this.limete_credito});
            this.dgvPesquisa.Location = new System.Drawing.Point(15, 123);
            this.dgvPesquisa.Name = "dgvPesquisa";
            this.dgvPesquisa.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dgvPesquisa.Size = new System.Drawing.Size(642, 235);
            this.dgvPesquisa.TabIndex = 12;
            // 
            // rdoOrdenarEmail
            // 
            this.rdoOrdenarEmail.AutoSize = true;
            this.rdoOrdenarEmail.Location = new System.Drawing.Point(216, 89);
            this.rdoOrdenarEmail.Name = "rdoOrdenarEmail";
            this.rdoOrdenarEmail.Size = new System.Drawing.Size(109, 17);
            this.rdoOrdenarEmail.TabIndex = 11;
            this.rdoOrdenarEmail.TabStop = true;
            this.rdoOrdenarEmail.Text = "Ordena por &E-mail";
            this.rdoOrdenarEmail.UseVisualStyleBackColor = true;
            // 
            // rdoOrdenarNome
            // 
            this.rdoOrdenarNome.AutoSize = true;
            this.rdoOrdenarNome.Location = new System.Drawing.Point(15, 89);
            this.rdoOrdenarNome.Name = "rdoOrdenarNome";
            this.rdoOrdenarNome.Size = new System.Drawing.Size(112, 17);
            this.rdoOrdenarNome.TabIndex = 10;
            this.rdoOrdenarNome.TabStop = true;
            this.rdoOrdenarNome.Text = "Ordenar por &Nome";
            this.rdoOrdenarNome.UseVisualStyleBackColor = true;
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Location = new System.Drawing.Point(574, 46);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(83, 43);
            this.btnFinalizar.TabIndex = 9;
            this.btnFinalizar.Text = "&Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            // 
            // txtNomeUsuario
            // 
            this.txtNomeUsuario.Location = new System.Drawing.Point(107, 46);
            this.txtNomeUsuario.Name = "txtNomeUsuario";
            this.txtNomeUsuario.Size = new System.Drawing.Size(375, 20);
            this.txtNomeUsuario.TabIndex = 8;
            // 
            // lblNomeUsuario
            // 
            this.lblNomeUsuario.AutoSize = true;
            this.lblNomeUsuario.Location = new System.Drawing.Point(12, 53);
            this.lblNomeUsuario.Name = "lblNomeUsuario";
            this.lblNomeUsuario.Size = new System.Drawing.Size(72, 13);
            this.lblNomeUsuario.TabIndex = 7;
            this.lblNomeUsuario.Text = "Nome usuário";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(530, 379);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(118, 49);
            this.btnVoltar.TabIndex = 19;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // nome
            // 
            this.nome.HeaderText = "Nome do cliente";
            this.nome.Name = "nome";
            this.nome.Width = 200;
            // 
            // endereco
            // 
            this.endereco.HeaderText = "Endereco";
            this.endereco.Name = "endereco";
            // 
            // telefone
            // 
            this.telefone.HeaderText = "Telefone";
            this.telefone.Name = "telefone";
            // 
            // status
            // 
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            // 
            // limete_credito
            // 
            this.limete_credito.HeaderText = "Limite de crédito";
            this.limete_credito.Name = "limete_credito";
            // 
            // Form_Consulta_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 440);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.dgvPesquisa);
            this.Controls.Add(this.rdoOrdenarEmail);
            this.Controls.Add(this.rdoOrdenarNome);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.txtNomeUsuario);
            this.Controls.Add(this.lblNomeUsuario);
            this.Controls.Add(this.lblText);
            this.Name = "Form_Consulta_Cliente";
            this.Text = "Form_Consulta_Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesquisa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.DataGridView dgvPesquisa;
        private System.Windows.Forms.RadioButton rdoOrdenarEmail;
        private System.Windows.Forms.RadioButton rdoOrdenarNome;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.TextBox txtNomeUsuario;
        private System.Windows.Forms.Label lblNomeUsuario;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn endereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn limete_credito;
    }
}