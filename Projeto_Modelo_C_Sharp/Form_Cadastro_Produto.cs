using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projeto_Modelo_C_Sharp.DAO;
using Projeto_Modelo_C_Sharp.DTO;

namespace Projeto_Modelo_C_Sharp
{
    public partial class Form_Cadastro_Produto: Form
    {
        private daoCategoria dao;
        public Form_Cadastro_Produto()
        {
            InitializeComponent();            
            dao = new daoCategoria();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Form_Adicionar_Categoria objadicionarcategoria = new Form_Adicionar_Categoria();
            objadicionarcategoria.ShowDialog();
        }        

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCategoria.DataSource == null)
                return;

            // Verifica se SelectedValue não é nulo e é um int
            if (cmbCategoria.SelectedValue != null && int.TryParse(cmbCategoria.SelectedValue.ToString(), out int idCategoriaSelecionada))
            {
                Console.WriteLine($"Categoria selecionada: {idCategoriaSelecionada}");
            }
        }

        private void Form_Cadastro_Produto_Load(object sender, EventArgs e)
        {
            daoCategoria dao = new daoCategoria();
            var categorias = dao.Select_Geral();

            // Define a fonte de dados do ComboBox
            cmbCategoria.DataSource = categorias;

            // Define qual propriedade mostrar no ComboBox
            cmbCategoria.DisplayMember = "nome";

            // Define qual propriedade será o valor real (id)
            cmbCategoria.ValueMember = "id_categoria";
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                DtoProduto dtoProduto = new DtoProduto();
                dtoProduto.nome = txtNome.Text;
                dtoProduto.preco = decimal.Parse(txtPreco.Text);
                int idCategoriaSelecionada = (int)cmbCategoria.SelectedValue;
                dtoProduto.id_categoria = idCategoriaSelecionada;
                

                daoProduto daoProduto = new daoProduto();
                object retornoproduto = daoProduto.Inserir(dtoProduto);                
                MessageBox.Show("Produto adcionado com sucesso");                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensagem Erro");
                throw;
            }
        }
    }
}

