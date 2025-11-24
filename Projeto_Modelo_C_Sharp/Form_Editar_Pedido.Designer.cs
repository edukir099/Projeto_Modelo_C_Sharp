namespace Projeto_Modelo_C_Sharp
{
    partial class Form_Editar_Pedido
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
            this.lblAviso2 = new System.Windows.Forms.Label();
            this.lblCodigo_produto = new System.Windows.Forms.Label();
            this.lblNome_produto = new System.Windows.Forms.Label();
            this.lblAviso1 = new System.Windows.Forms.Label();
            this.dgvProdutoSelecionado = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProdutosPedido = new System.Windows.Forms.DataGridView();
            this.Nome_produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor_unidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblReferencia = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.lblText = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.comboBoxCliente = new System.Windows.Forms.ComboBox();
            this.comboBoxCategoria = new System.Windows.Forms.ComboBox();
            this.comboBoxProduto = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutoSelecionado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutosPedido)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAviso2
            // 
            this.lblAviso2.AutoSize = true;
            this.lblAviso2.ForeColor = System.Drawing.Color.Red;
            this.lblAviso2.Location = new System.Drawing.Point(23, 535);
            this.lblAviso2.Name = "lblAviso2";
            this.lblAviso2.Size = new System.Drawing.Size(173, 13);
            this.lblAviso2.TabIndex = 45;
            this.lblAviso2.Text = "* Double click para remover pedido";
            // 
            // lblCodigo_produto
            // 
            this.lblCodigo_produto.AutoSize = true;
            this.lblCodigo_produto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo_produto.Location = new System.Drawing.Point(60, 160);
            this.lblCodigo_produto.Name = "lblCodigo_produto";
            this.lblCodigo_produto.Size = new System.Drawing.Size(154, 20);
            this.lblCodigo_produto.TabIndex = 44;
            this.lblCodigo_produto.Text = "Produto selecionado";
            // 
            // lblNome_produto
            // 
            this.lblNome_produto.AutoSize = true;
            this.lblNome_produto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome_produto.Location = new System.Drawing.Point(69, 359);
            this.lblNome_produto.Name = "lblNome_produto";
            this.lblNome_produto.Size = new System.Drawing.Size(147, 20);
            this.lblNome_produto.TabIndex = 43;
            this.lblNome_produto.Text = "Produtos do pedido";
            // 
            // lblAviso1
            // 
            this.lblAviso1.AutoSize = true;
            this.lblAviso1.BackColor = System.Drawing.SystemColors.Control;
            this.lblAviso1.ForeColor = System.Drawing.Color.Red;
            this.lblAviso1.Location = new System.Drawing.Point(23, 305);
            this.lblAviso1.Name = "lblAviso1";
            this.lblAviso1.Size = new System.Drawing.Size(193, 13);
            this.lblAviso1.TabIndex = 42;
            this.lblAviso1.Text = "* Double click para adicionar ao pedido";
            // 
            // dgvProdutoSelecionado
            // 
            this.dgvProdutoSelecionado.AllowUserToAddRows = false;
            this.dgvProdutoSelecionado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutoSelecionado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dgvProdutoSelecionado.Location = new System.Drawing.Point(26, 183);
            this.dgvProdutoSelecionado.Name = "dgvProdutoSelecionado";
            this.dgvProdutoSelecionado.Size = new System.Drawing.Size(535, 119);
            this.dgvProdutoSelecionado.TabIndex = 41;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "Codigo de produto";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome do produto";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Valor da unidade";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Quantidade";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dgvProdutosPedido
            // 
            this.dgvProdutosPedido.AllowUserToAddRows = false;
            this.dgvProdutosPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutosPedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome_produto,
            this.Quantidade,
            this.Valor_unidade,
            this.Valor_total});
            this.dgvProdutosPedido.Location = new System.Drawing.Point(26, 382);
            this.dgvProdutosPedido.Name = "dgvProdutosPedido";
            this.dgvProdutosPedido.Size = new System.Drawing.Size(535, 150);
            this.dgvProdutosPedido.TabIndex = 40;
            // 
            // Nome_produto
            // 
            this.Nome_produto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nome_produto.HeaderText = "Nome produto";
            this.Nome_produto.Name = "Nome_produto";
            // 
            // Quantidade
            // 
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.Name = "Quantidade";
            // 
            // Valor_unidade
            // 
            this.Valor_unidade.HeaderText = "Valor da unidade";
            this.Valor_unidade.Name = "Valor_unidade";
            // 
            // Valor_total
            // 
            this.Valor_total.HeaderText = "Valor total";
            this.Valor_total.Name = "Valor_total";
            // 
            // lblReferencia
            // 
            this.lblReferencia.AutoSize = true;
            this.lblReferencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReferencia.Location = new System.Drawing.Point(429, 103);
            this.lblReferencia.Name = "lblReferencia";
            this.lblReferencia.Size = new System.Drawing.Size(75, 13);
            this.lblReferencia.TabIndex = 39;
            this.lblReferencia.Text = "Nome Produto";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(230, 103);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(52, 13);
            this.lblMarca.TabIndex = 36;
            this.lblMarca.Text = "Categoria";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(26, 119);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(152, 20);
            this.textBox1.TabIndex = 35;
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorTotal.Location = new System.Drawing.Point(23, 103);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(104, 13);
            this.lblValorTotal.TabIndex = 34;
            this.lblValorTotal.Text = "Valor total do pedido";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(300, 584);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(118, 49);
            this.btnVoltar.TabIndex = 33;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(443, 584);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(118, 49);
            this.btnCadastrar.TabIndex = 32;
            this.btnCadastrar.Text = "Salvar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText.Location = new System.Drawing.Point(228, 9);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(122, 24);
            this.lblText.TabIndex = 31;
            this.lblText.Text = "Editar pedido";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(23, 51);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(39, 13);
            this.lblCliente.TabIndex = 46;
            this.lblCliente.Text = "Cliente";
            // 
            // comboBoxCliente
            // 
            this.comboBoxCliente.FormattingEnabled = true;
            this.comboBoxCliente.Location = new System.Drawing.Point(26, 67);
            this.comboBoxCliente.Name = "comboBoxCliente";
            this.comboBoxCliente.Size = new System.Drawing.Size(138, 21);
            this.comboBoxCliente.TabIndex = 47;
            // 
            // comboBoxCategoria
            // 
            this.comboBoxCategoria.FormattingEnabled = true;
            this.comboBoxCategoria.Location = new System.Drawing.Point(232, 119);
            this.comboBoxCategoria.Name = "comboBoxCategoria";
            this.comboBoxCategoria.Size = new System.Drawing.Size(138, 21);
            this.comboBoxCategoria.TabIndex = 48;
            // 
            // comboBoxProduto
            // 
            this.comboBoxProduto.FormattingEnabled = true;
            this.comboBoxProduto.Location = new System.Drawing.Point(432, 119);
            this.comboBoxProduto.Name = "comboBoxProduto";
            this.comboBoxProduto.Size = new System.Drawing.Size(138, 21);
            this.comboBoxProduto.TabIndex = 49;
            // 
            // Form_Editar_Pedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 644);
            this.Controls.Add(this.comboBoxProduto);
            this.Controls.Add(this.comboBoxCategoria);
            this.Controls.Add(this.comboBoxCliente);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.lblAviso2);
            this.Controls.Add(this.lblCodigo_produto);
            this.Controls.Add(this.lblNome_produto);
            this.Controls.Add(this.lblAviso1);
            this.Controls.Add(this.dgvProdutoSelecionado);
            this.Controls.Add(this.dgvProdutosPedido);
            this.Controls.Add(this.lblReferencia);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblValorTotal);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.lblText);
            this.Name = "Form_Editar_Pedido";
            this.Text = "Form_Editar_Pedido";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutoSelecionado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutosPedido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAviso2;
        private System.Windows.Forms.Label lblCodigo_produto;
        private System.Windows.Forms.Label lblNome_produto;
        private System.Windows.Forms.Label lblAviso1;
        private System.Windows.Forms.DataGridView dgvProdutoSelecionado;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridView dgvProdutosPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome_produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor_unidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor_total;
        private System.Windows.Forms.Label lblReferencia;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.ComboBox comboBoxCliente;
        private System.Windows.Forms.ComboBox comboBoxCategoria;
        private System.Windows.Forms.ComboBox comboBoxProduto;
    }
}