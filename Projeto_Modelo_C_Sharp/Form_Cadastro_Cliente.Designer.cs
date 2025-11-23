namespace Projeto_Modelo_C_Sharp
{
    partial class Form_Cadastro_Cliente
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
            this.lblNome_Cliente = new System.Windows.Forms.Label();
            this.lblEndereco_Cliente = new System.Windows.Forms.Label();
            this.lblCelular_Cliente = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText.Location = new System.Drawing.Point(102, 9);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(171, 24);
            this.lblText.TabIndex = 0;
            this.lblText.Text = "Cadastro de cliente";
            // 
            // lblNome_Cliente
            // 
            this.lblNome_Cliente.AutoSize = true;
            this.lblNome_Cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome_Cliente.Location = new System.Drawing.Point(37, 74);
            this.lblNome_Cliente.Name = "lblNome_Cliente";
            this.lblNome_Cliente.Size = new System.Drawing.Size(84, 13);
            this.lblNome_Cliente.TabIndex = 1;
            this.lblNome_Cliente.Text = "Nome do cliente";
            // 
            // lblEndereco_Cliente
            // 
            this.lblEndereco_Cliente.AutoSize = true;
            this.lblEndereco_Cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndereco_Cliente.Location = new System.Drawing.Point(36, 138);
            this.lblEndereco_Cliente.Name = "lblEndereco_Cliente";
            this.lblEndereco_Cliente.Size = new System.Drawing.Size(102, 13);
            this.lblEndereco_Cliente.TabIndex = 2;
            this.lblEndereco_Cliente.Text = "Endereço de cliente";
            // 
            // lblCelular_Cliente
            // 
            this.lblCelular_Cliente.AutoSize = true;
            this.lblCelular_Cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCelular_Cliente.Location = new System.Drawing.Point(36, 200);
            this.lblCelular_Cliente.Name = "lblCelular_Cliente";
            this.lblCelular_Cliente.Size = new System.Drawing.Size(88, 13);
            this.lblCelular_Cliente.TabIndex = 3;
            this.lblCelular_Cliente.Text = "Celular do cliente";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(40, 90);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(283, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(39, 154);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(283, 20);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(39, 216);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(283, 20);
            this.textBox3.TabIndex = 6;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(223, 275);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(100, 51);
            this.btnSalvar.TabIndex = 7;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(40, 277);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(100, 49);
            this.btnVoltar.TabIndex = 19;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            // 
            // Form_Cadastro_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 344);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblCelular_Cliente);
            this.Controls.Add(this.lblEndereco_Cliente);
            this.Controls.Add(this.lblNome_Cliente);
            this.Controls.Add(this.lblText);
            this.Name = "Form_Cadastro_Cliente";
            this.Text = "Form_Cadastro_Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Label lblNome_Cliente;
        private System.Windows.Forms.Label lblEndereco_Cliente;
        private System.Windows.Forms.Label lblCelular_Cliente;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnVoltar;
    }
}