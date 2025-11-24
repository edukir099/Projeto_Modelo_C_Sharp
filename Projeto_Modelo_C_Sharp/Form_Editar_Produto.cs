using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Modelo_C_Sharp
{
    public partial class Form_Editar_Produto : Form
    {
        public Form_Editar_Produto()
        {
            InitializeComponent();
        }

        public Form_Editar_Produto(string codigo, string nome, string categoria, string valor)
        {
            InitializeComponent();

            txtCodigo.Text = codigo;
            txtNome.Text = nome;
            txtCategoria.Text = categoria;
            txtPreco.Text = valor;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // Aqui você faz o UPDATE no banco de dados

            MessageBox.Show("Produto atualizado com sucesso!");
            this.Close();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}