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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rdoOrdenarData = new System.Windows.Forms.RadioButton();
            this.rdoOrdenarNome = new System.Windows.Forms.RadioButton();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.txtNomeUsuario = new System.Windows.Forms.TextBox();
            this.lblNomePedido = new System.Windows.Forms.Label();
            this.lblText = new System.Windows.Forms.Label();
            this.lblAviso1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column4,
            this.Column3,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(12, 124);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dataGridView1.Size = new System.Drawing.Size(492, 235);
            this.dataGridView1.TabIndex = 26;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Código do pedido";
            this.Column1.Name = "Column1";
            this.Column1.Width = 70;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Nome do cliente";
            this.Column4.Name = "Column4";
            this.Column4.Width = 200;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Data do pedido";
            this.Column3.Name = "Column3";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Valor total do pedido";
            this.Column2.Name = "Column2";
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
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.rdoOrdenarData);
            this.Controls.Add(this.rdoOrdenarNome);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.txtNomeUsuario);
            this.Controls.Add(this.lblNomePedido);
            this.Controls.Add(this.lblText);
            this.Name = "Form_Consulta_Pedido";
            this.Text = "Form1_Consulta_Pedido";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton rdoOrdenarData;
        private System.Windows.Forms.RadioButton rdoOrdenarNome;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.TextBox txtNomeUsuario;
        private System.Windows.Forms.Label lblNomePedido;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Label lblAviso1;
    }
}