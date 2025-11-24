using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projeto_Modelo_C_Sharp.DAO;
using Projeto_Modelo_C_Sharp.DTO;

namespace Projeto_Modelo_C_Sharp
{
    public partial class Form_Consulta_Produto: Form
    {
        public Form_Consulta_Produto()
        {
            InitializeComponent();
            dgvPesquisa.AutoGenerateColumns = true;
            CarregarGrid();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvPesquisa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Evita erro se clicar no cabeçalho
            if (e.RowIndex < 0) return;

            // Pega a linha clicada
            DataGridViewRow linha = dgvPesquisa.Rows[e.RowIndex];

            // Obtém os valores das células
            string codigo = linha.Cells["id_produto"].Value.ToString();
            string nome = linha.Cells["nome"].Value.ToString();
            string categoria = linha.Cells["id_categoria"].Value.ToString();
            string valor = linha.Cells["preco"].Value.ToString();

            // Abre a tela de edição passando os dados
            Form_Editar_Produto frmEditar = new Form_Editar_Produto(
                codigo, nome, categoria, valor
            );

            frmEditar.ShowDialog();
        }

        private void CarregarGrid()
        {
            daoProduto daoproduto = new daoProduto();
            Dto_ColecaoProduto colecaoproduto = daoproduto.Select_Geral();

            dgvPesquisa.AutoGenerateColumns = false;
            dgvPesquisa.Columns.Clear();

            dgvPesquisa.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Código do pedido",
                DataPropertyName = "id_produto",
                Name = "id_produto"
            });
            dgvPesquisa.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Nome do Produto",
                DataPropertyName = "nome",
                Name = "nome"
            });
            dgvPesquisa.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Categoria",
                DataPropertyName = "id_categoria",
                Name = "id_categoria"
            });
            dgvPesquisa.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Valor da unidade",
                DataPropertyName = "preco",
                Name = "preco"
            });

            dgvPesquisa.DataSource = colecaoproduto;
        }
    }
}
