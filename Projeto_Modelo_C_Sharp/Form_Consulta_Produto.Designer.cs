namespace Projeto_Modelo_C_Sharp
{
    partial class Form_Consulta_Produto
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
            this.lblAviso1 = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.dgvPesquisa = new System.Windows.Forms.DataGridView();
            this.rdoOrdenarNome = new System.Windows.Forms.RadioButton();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.txtNomeUsuario = new System.Windows.Forms.TextBox();
            this.lblNomePedido = new System.Windows.Forms.Label();
            this.lblText = new System.Windows.Forms.Label();
            this.id_produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesquisa)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAviso1
            // 
            this.lblAviso1.AutoSize = true;
            this.lblAviso1.BackColor = System.Drawing.SystemColors.Control;
            this.lblAviso1.ForeColor = System.Drawing.Color.Red;
            this.lblAviso1.Location = new System.Drawing.Point(25, 365);
            this.lblAviso1.Name = "lblAviso1";
            this.lblAviso1.Size = new System.Drawing.Size(174, 13);
            this.lblAviso1.TabIndex = 37;
            this.lblAviso1.Text = "* Double click para editar o produto";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(399, 399);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(118, 49);
            this.btnVoltar.TabIndex = 36;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // dgvPesquisa
            // 
            this.dgvPesquisa.AllowUserToOrderColumns = true;
            this.dgvPesquisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPesquisa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_produto,
            this.nome,
            this.id_categoria,
            this.id_preco});
            this.dgvPesquisa.Location = new System.Drawing.Point(25, 127);
            this.dgvPesquisa.Name = "dgvPesquisa";
            this.dgvPesquisa.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dgvPesquisa.Size = new System.Drawing.Size(504, 235);
            this.dgvPesquisa.TabIndex = 35;
            // 
            // rdoOrdenarNome
            // 
            this.rdoOrdenarNome.AutoSize = true;
            this.rdoOrdenarNome.Location = new System.Drawing.Point(25, 93);
            this.rdoOrdenarNome.Name = "rdoOrdenarNome";
            this.rdoOrdenarNome.Size = new System.Drawing.Size(112, 17);
            this.rdoOrdenarNome.TabIndex = 33;
            this.rdoOrdenarNome.TabStop = true;
            this.rdoOrdenarNome.Text = "Ordenar por &Nome";
            this.rdoOrdenarNome.UseVisualStyleBackColor = true;
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Location = new System.Drawing.Point(434, 50);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(83, 43);
            this.btnFinalizar.TabIndex = 32;
            this.btnFinalizar.Text = "&Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            // 
            // txtNomeUsuario
            // 
            this.txtNomeUsuario.Location = new System.Drawing.Point(117, 50);
            this.txtNomeUsuario.Name = "txtNomeUsuario";
            this.txtNomeUsuario.Size = new System.Drawing.Size(99, 20);
            this.txtNomeUsuario.TabIndex = 31;
            // 
            // lblNomePedido
            // 
            this.lblNomePedido.AutoSize = true;
            this.lblNomePedido.Location = new System.Drawing.Point(22, 57);
            this.lblNomePedido.Name = "lblNomePedido";
            this.lblNomePedido.Size = new System.Drawing.Size(89, 13);
            this.lblNomePedido.TabIndex = 30;
            this.lblNomePedido.Text = "Nome do produto";
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText.Location = new System.Drawing.Point(188, 9);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(180, 24);
            this.lblText.TabIndex = 29;
            this.lblText.Text = "Consulta do produto";
            // 
            // id_produto
            // 
            this.id_produto.HeaderText = "Código do produto";
            this.id_produto.Name = "id_produto";
            this.id_produto.Width = 70;
            // 
            // nome
            // 
            this.nome.HeaderText = "Nome do produto";
            this.nome.Name = "nome";
            this.nome.Width = 200;
            // 
            // id_categoria
            // 
            this.id_categoria.HeaderText = "Categoria";
            this.id_categoria.Name = "id_categoria";
            // 
            // id_preco
            // 
            this.id_preco.HeaderText = "Valor da unidade";
            this.id_preco.Name = "id_preco";
            // 
            // Form_Consulta_Produto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 461);
            this.Controls.Add(this.lblAviso1);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.dgvPesquisa);
            this.Controls.Add(this.rdoOrdenarNome);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.txtNomeUsuario);
            this.Controls.Add(this.lblNomePedido);
            this.Controls.Add(this.lblText);
            this.Name = "Form_Consulta_Produto";
            this.Text = "Form_Consultar_Produto";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesquisa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAviso1;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.DataGridView dgvPesquisa;
        private System.Windows.Forms.RadioButton rdoOrdenarNome;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.TextBox txtNomeUsuario;
        private System.Windows.Forms.Label lblNomePedido;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_preco;
    }
}