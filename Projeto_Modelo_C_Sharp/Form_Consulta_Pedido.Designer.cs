namespace Projeto_Modelo_C_Sharp
{
    partial class Form_Consulta_Pedido
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
            this.dgvPesquisa = new System.Windows.Forms.DataGridView();
            this.id_pedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rdoOrdenarData = new System.Windows.Forms.RadioButton();
            this.rdoOrdenarNome = new System.Windows.Forms.RadioButton();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.txtNomeUsuario = new System.Windows.Forms.TextBox();
            this.lblNomePedido = new System.Windows.Forms.Label();
            this.lblText = new System.Windows.Forms.Label();
            this.lblAviso1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesquisa)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(386, 396);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(118, 49);
            this.btnVoltar.TabIndex = 27;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // dgvPesquisa
            // 
            this.dgvPesquisa.AllowUserToOrderColumns = true;
            this.dgvPesquisa.AllowUserToResizeColumns = false;
            this.dgvPesquisa.AllowUserToResizeRows = false;
            this.dgvPesquisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPesquisa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_pedido,
            this.nome_cliente,
            this.data,
            this.total});
            this.dgvPesquisa.Location = new System.Drawing.Point(12, 124);
            this.dgvPesquisa.Name = "dgvPesquisa";
            this.dgvPesquisa.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvPesquisa.Size = new System.Drawing.Size(492, 235);
            this.dgvPesquisa.TabIndex = 26;
            // 
            // id_pedido
            // 
            this.id_pedido.HeaderText = "Código do pedido";
            this.id_pedido.Name = "id_pedido";
            this.id_pedido.Width = 70;
            // 
            // nome_cliente
            // 
            this.nome_cliente.HeaderText = "Nome do cliente";
            this.nome_cliente.Name = "nome_cliente";
            this.nome_cliente.Width = 200;
            // 
            // data
            // 
            this.data.HeaderText = "Data do pedido";
            this.data.Name = "data";
            // 
            // total
            // 
            this.total.HeaderText = "Valor total do pedido";
            this.total.Name = "total";
            // 
            // rdoOrdenarData
            // 
            this.rdoOrdenarData.AutoSize = true;
            this.rdoOrdenarData.Location = new System.Drawing.Point(213, 90);
            this.rdoOrdenarData.Name = "rdoOrdenarData";
            this.rdoOrdenarData.Size = new System.Drawing.Size(104, 17);
            this.rdoOrdenarData.TabIndex = 25;
            this.rdoOrdenarData.TabStop = true;
            this.rdoOrdenarData.Text = "Ordena por Data";
            this.rdoOrdenarData.UseVisualStyleBackColor = true;
            // 
            // rdoOrdenarNome
            // 
            this.rdoOrdenarNome.AutoSize = true;
            this.rdoOrdenarNome.Location = new System.Drawing.Point(12, 90);
            this.rdoOrdenarNome.Name = "rdoOrdenarNome";
            this.rdoOrdenarNome.Size = new System.Drawing.Size(112, 17);
            this.rdoOrdenarNome.TabIndex = 24;
            this.rdoOrdenarNome.TabStop = true;
            this.rdoOrdenarNome.Text = "Ordenar por &Nome";
            this.rdoOrdenarNome.UseVisualStyleBackColor = true;
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Location = new System.Drawing.Point(421, 47);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(83, 43);
            this.btnFinalizar.TabIndex = 23;
            this.btnFinalizar.Text = "&Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            // 
            // txtNomeUsuario
            // 
            this.txtNomeUsuario.Location = new System.Drawing.Point(104, 47);
            this.txtNomeUsuario.Name = "txtNomeUsuario";
            this.txtNomeUsuario.Size = new System.Drawing.Size(99, 20);
            this.txtNomeUsuario.TabIndex = 22;
            // 
            // lblNomePedido
            // 
            this.lblNomePedido.AutoSize = true;
            this.lblNomePedido.Location = new System.Drawing.Point(9, 54);
            this.lblNomePedido.Name = "lblNomePedido";
            this.lblNomePedido.Size = new System.Drawing.Size(90, 13);
            this.lblNomePedido.TabIndex = 21;
            this.lblNomePedido.Text = "Código do pedido";
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText.Location = new System.Drawing.Point(174, 9);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(174, 24);
            this.lblText.TabIndex = 20;
            this.lblText.Text = "Consulta do pedido";
            // 
            // lblAviso1
            // 
            this.lblAviso1.AutoSize = true;
            this.lblAviso1.BackColor = System.Drawing.SystemColors.Control;
            this.lblAviso1.ForeColor = System.Drawing.Color.Red;
            this.lblAviso1.Location = new System.Drawing.Point(12, 362);
            this.lblAviso1.Name = "lblAviso1";
            this.lblAviso1.Size = new System.Drawing.Size(170, 13);
            this.lblAviso1.TabIndex = 28;
            this.lblAviso1.Text = "* Double click para editar o pedido";
            // 
            // Form_Consulta_Pedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 460);
            this.Controls.Add(this.lblAviso1);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.dgvPesquisa);
            this.Controls.Add(this.rdoOrdenarData);
            this.Controls.Add(this.rdoOrdenarNome);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.txtNomeUsuario);
            this.Controls.Add(this.lblNomePedido);
            this.Controls.Add(this.lblText);
            this.Name = "Form_Consulta_Pedido";
            this.Text = "Form1_Consulta_Pedido";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesquisa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.DataGridView dgvPesquisa;
        private System.Windows.Forms.RadioButton rdoOrdenarData;
        private System.Windows.Forms.RadioButton rdoOrdenarNome;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.TextBox txtNomeUsuario;
        private System.Windows.Forms.Label lblNomePedido;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Label lblAviso1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_pedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn data;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
    }
}