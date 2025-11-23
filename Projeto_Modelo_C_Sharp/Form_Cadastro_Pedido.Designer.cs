namespace Projeto_Modelo_C_Sharp
{
    partial class Form_Cadastro_Pedido
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
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.lblText = new System.Windows.Forms.Label();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.dgvProdutosPedido = new System.Windows.Forms.DataGridView();
            this.dgvProdutoSelecionado = new System.Windows.Forms.DataGridView();
            this.lblAviso1 = new System.Windows.Forms.Label();
            this.lblNome_produto = new System.Windows.Forms.Label();
            this.lblCodigo_produto = new System.Windows.Forms.Label();
            this.lblAviso2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxCliente = new System.Windows.Forms.ComboBox();
            this.comboBoxCategoria = new System.Windows.Forms.ComboBox();
            this.comboBoxProduto = new System.Windows.Forms.ComboBox();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQtd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomePed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQtdPed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValorPed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotalPed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutosPedido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutoSelecionado)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(298, 545);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(118, 49);
            this.btnVoltar.TabIndex = 18;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(441, 545);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(118, 49);
            this.btnCadastrar.TabIndex = 14;
            this.btnCadastrar.Text = "Salvar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText.Location = new System.Drawing.Point(204, 9);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(175, 24);
            this.lblText.TabIndex = 10;
            this.lblText.Text = "Cadastro de pedido";
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorTotal.Location = new System.Drawing.Point(21, 64);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(155, 20);
            this.lblValorTotal.TabIndex = 19;
            this.lblValorTotal.Text = "Valor total do pedido";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(24, 87);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(152, 20);
            this.txtTotal.TabIndex = 20;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(227, 64);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(78, 20);
            this.lblCategoria.TabIndex = 21;
            this.lblCategoria.Text = "Categoria";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(427, 64);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(111, 20);
            this.lblNome.TabIndex = 24;
            this.lblNome.Text = "Nome Produto";
            // 
            // dgvProdutosPedido
            // 
            this.dgvProdutosPedido.AllowUserToAddRows = false;
            this.dgvProdutosPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutosPedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNomePed,
            this.colQtdPed,
            this.colValorPed,
            this.colTotalPed});
            this.dgvProdutosPedido.Location = new System.Drawing.Point(24, 343);
            this.dgvProdutosPedido.MultiSelect = false;
            this.dgvProdutosPedido.Name = "dgvProdutosPedido";
            this.dgvProdutosPedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProdutosPedido.Size = new System.Drawing.Size(535, 150);
            this.dgvProdutosPedido.TabIndex = 25;
            this.dgvProdutosPedido.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdutosPedido_CellContentDoubleClick);
            // 
            // dgvProdutoSelecionado
            // 
            this.dgvProdutoSelecionado.AllowUserToAddRows = false;
            this.dgvProdutoSelecionado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutoSelecionado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colNome,
            this.colValor,
            this.colQtd});
            this.dgvProdutoSelecionado.Location = new System.Drawing.Point(24, 144);
            this.dgvProdutoSelecionado.MultiSelect = false;
            this.dgvProdutoSelecionado.Name = "dgvProdutoSelecionado";
            this.dgvProdutoSelecionado.ReadOnly = true;
            this.dgvProdutoSelecionado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProdutoSelecionado.Size = new System.Drawing.Size(535, 119);
            this.dgvProdutoSelecionado.TabIndex = 26;
            this.dgvProdutoSelecionado.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdutoSelecionado_CellContentDoubleClick);
            // 
            // lblAviso1
            // 
            this.lblAviso1.AutoSize = true;
            this.lblAviso1.BackColor = System.Drawing.SystemColors.Control;
            this.lblAviso1.ForeColor = System.Drawing.Color.Red;
            this.lblAviso1.Location = new System.Drawing.Point(21, 266);
            this.lblAviso1.Name = "lblAviso1";
            this.lblAviso1.Size = new System.Drawing.Size(193, 13);
            this.lblAviso1.TabIndex = 27;
            this.lblAviso1.Text = "* Double click para adicionar ao pedido";
            // 
            // lblNome_produto
            // 
            this.lblNome_produto.AutoSize = true;
            this.lblNome_produto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome_produto.Location = new System.Drawing.Point(67, 320);
            this.lblNome_produto.Name = "lblNome_produto";
            this.lblNome_produto.Size = new System.Drawing.Size(147, 20);
            this.lblNome_produto.TabIndex = 28;
            this.lblNome_produto.Text = "Produtos do pedido";
            // 
            // lblCodigo_produto
            // 
            this.lblCodigo_produto.AutoSize = true;
            this.lblCodigo_produto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo_produto.Location = new System.Drawing.Point(58, 121);
            this.lblCodigo_produto.Name = "lblCodigo_produto";
            this.lblCodigo_produto.Size = new System.Drawing.Size(154, 20);
            this.lblCodigo_produto.TabIndex = 29;
            this.lblCodigo_produto.Text = "Produto selecionado";
            // 
            // lblAviso2
            // 
            this.lblAviso2.AutoSize = true;
            this.lblAviso2.ForeColor = System.Drawing.Color.Red;
            this.lblAviso2.Location = new System.Drawing.Point(21, 496);
            this.lblAviso2.Name = "lblAviso2";
            this.lblAviso2.Size = new System.Drawing.Size(173, 13);
            this.lblAviso2.TabIndex = 30;
            this.lblAviso2.Text = "* Double click para remover pedido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "Cliente";
            // 
            // comboBoxCliente
            // 
            this.comboBoxCliente.FormattingEnabled = true;
            this.comboBoxCliente.Location = new System.Drawing.Point(25, 36);
            this.comboBoxCliente.Name = "comboBoxCliente";
            this.comboBoxCliente.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCliente.TabIndex = 32;
            this.comboBoxCliente.SelectedIndexChanged += new System.EventHandler(this.comboBoxCliente_SelectedIndexChanged);
            // 
            // comboBoxCategoria
            // 
            this.comboBoxCategoria.FormattingEnabled = true;
            this.comboBoxCategoria.Location = new System.Drawing.Point(231, 87);
            this.comboBoxCategoria.Name = "comboBoxCategoria";
            this.comboBoxCategoria.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCategoria.TabIndex = 33;
            this.comboBoxCategoria.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategoria_SelectedIndexChanged);
            // 
            // comboBoxProduto
            // 
            this.comboBoxProduto.FormattingEnabled = true;
            this.comboBoxProduto.Location = new System.Drawing.Point(431, 87);
            this.comboBoxProduto.Name = "comboBoxProduto";
            this.comboBoxProduto.Size = new System.Drawing.Size(121, 21);
            this.comboBoxProduto.TabIndex = 34;
            this.comboBoxProduto.SelectedIndexChanged += new System.EventHandler(this.comboBoxProduto_SelectedIndexChanged);
            // 
            // colId
            // 
            this.colId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colId.DataPropertyName = "colId";
            this.colId.HeaderText = "Codigo de produto";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            // 
            // colNome
            // 
            this.colNome.DataPropertyName = "colNome";
            this.colNome.HeaderText = "Nome do produto";
            this.colNome.Name = "colNome";
            this.colNome.ReadOnly = true;
            // 
            // colValor
            // 
            this.colValor.DataPropertyName = "colValor";
            this.colValor.HeaderText = "Valor da unidade";
            this.colValor.Name = "colValor";
            this.colValor.ReadOnly = true;
            // 
            // colQtd
            // 
            this.colQtd.DataPropertyName = "colQtd";
            this.colQtd.HeaderText = "Quantidade";
            this.colQtd.Name = "colQtd";
            this.colQtd.ReadOnly = true;
            // 
            // colNomePed
            // 
            this.colNomePed.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNomePed.DataPropertyName = "colNomePed";
            this.colNomePed.HeaderText = "Nome produto";
            this.colNomePed.Name = "colNomePed";
            // 
            // colQtdPed
            // 
            this.colQtdPed.DataPropertyName = "colQtdPed";
            this.colQtdPed.HeaderText = "Quantidade";
            this.colQtdPed.Name = "colQtdPed";
            // 
            // colValorPed
            // 
            this.colValorPed.DataPropertyName = "colValorPed";
            this.colValorPed.HeaderText = "Valor da unidade";
            this.colValorPed.Name = "colValorPed";
            // 
            // colTotalPed
            // 
            this.colTotalPed.DataPropertyName = "colTotalPed";
            this.colTotalPed.HeaderText = "Valor total";
            this.colTotalPed.Name = "colTotalPed";
            // 
            // Form_Cadastro_Pedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 606);
            this.Controls.Add(this.comboBoxProduto);
            this.Controls.Add(this.comboBoxCategoria);
            this.Controls.Add(this.comboBoxCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAviso2);
            this.Controls.Add(this.lblCodigo_produto);
            this.Controls.Add(this.lblNome_produto);
            this.Controls.Add(this.lblAviso1);
            this.Controls.Add(this.dgvProdutoSelecionado);
            this.Controls.Add(this.dgvProdutosPedido);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblValorTotal);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.lblText);
            this.Name = "Form_Cadastro_Pedido";
            this.Text = "Form_Pedido";
            this.Load += new System.EventHandler(this.Form_Cadastro_Pedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutosPedido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutoSelecionado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.DataGridView dgvProdutosPedido;
        private System.Windows.Forms.DataGridView dgvProdutoSelecionado;
        private System.Windows.Forms.Label lblAviso1;
        private System.Windows.Forms.Label lblNome_produto;
        private System.Windows.Forms.Label lblCodigo_produto;
        private System.Windows.Forms.Label lblAviso2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxCliente;
        private System.Windows.Forms.ComboBox comboBoxCategoria;
        private System.Windows.Forms.ComboBox comboBoxProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomePed;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQtdPed;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValorPed;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotalPed;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQtd;
    }
}