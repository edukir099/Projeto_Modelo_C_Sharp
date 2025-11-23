namespace Projeto_Modelo_C_Sharp
{
    partial class Form_Cadastro_Produto
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
            this.lblText1 = new System.Windows.Forms.Label();
            this.lblText3 = new System.Windows.Forms.Label();
            this.lblText4 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblText5 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText.Location = new System.Drawing.Point(94, 9);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(181, 24);
            this.lblText.TabIndex = 0;
            this.lblText.Text = "Cadastro de produto";
            // 
            // lblText1
            // 
            this.lblText1.AutoSize = true;
            this.lblText1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText1.Location = new System.Drawing.Point(34, 70);
            this.lblText1.Name = "lblText1";
            this.lblText1.Size = new System.Drawing.Size(89, 13);
            this.lblText1.TabIndex = 1;
            this.lblText1.Text = "Nome do produto";
            // 
            // lblText3
            // 
            this.lblText3.AutoSize = true;
            this.lblText3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText3.Location = new System.Drawing.Point(34, 132);
            this.lblText3.Name = "lblText3";
            this.lblText3.Size = new System.Drawing.Size(89, 13);
            this.lblText3.TabIndex = 2;
            this.lblText3.Text = "Preço do produto";
            // 
            // lblText4
            // 
            this.lblText4.AutoSize = true;
            this.lblText4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText4.Location = new System.Drawing.Point(33, 198);
            this.lblText4.Name = "lblText4";
            this.lblText4.Size = new System.Drawing.Size(106, 13);
            this.lblText4.TabIndex = 3;
            this.lblText4.Text = "Categoria do produto";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(215, 276);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(118, 49);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // lblText5
            // 
            this.lblText5.AutoSize = true;
            this.lblText5.Location = new System.Drawing.Point(35, 264);
            this.lblText5.Name = "lblText5";
            this.lblText5.Size = new System.Drawing.Size(0, 13);
            this.lblText5.TabIndex = 5;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(36, 86);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(296, 20);
            this.txtNome.TabIndex = 6;
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(36, 148);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(296, 20);
            this.txtPreco.TabIndex = 7;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(37, 276);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(118, 49);
            this.btnVoltar.TabIndex = 9;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(38, 214);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(202, 21);
            this.cmbCategoria.TabIndex = 10;
            // 
            // Form_Cadastro_Produto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 337);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblText5);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lblText4);
            this.Controls.Add(this.lblText3);
            this.Controls.Add(this.lblText1);
            this.Controls.Add(this.lblText);
            this.Name = "Form_Cadastro_Produto";
            this.Text = "Form_Produto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Label lblText1;
        private System.Windows.Forms.Label lblText3;
        private System.Windows.Forms.Label lblText4;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblText5;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.ComboBox cmbCategoria;
    }
}