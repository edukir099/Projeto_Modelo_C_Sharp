using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Projeto_Modelo_C_Sharp.DAO;
using Projeto_Modelo_C_Sharp.DTO;

namespace Projeto_Modelo_C_Sharp
{
    public partial class Form_Editar_Pedido : Form
    {
        private int idPedido;
        private daoPedido daoPedido;
        private daoCliente daoCliente;
        private daoProduto daoProduto;

        public Form_Editar_Pedido(int idPedido)
        {
            InitializeComponent();
            this.idPedido = idPedido;

            daoPedido = new daoPedido();
            daoCliente = new daoCliente();
            daoProduto = new daoProduto();
        }

        private void ConfigurarDgvProdutoSelecionado()
        {
            // Limpa colunas existentes
            dgvProdutoSelecionado.Columns.Clear();
            dgvProdutosPedido.Columns.Clear();

            // dgvProdutoSelecionado
            dgvProdutoSelecionado.Columns.Add("colId", "ID");
            dgvProdutoSelecionado.Columns.Add("colNome", "Nome");
            dgvProdutoSelecionado.Columns.Add("colPreco", "Preço");
            dgvProdutoSelecionado.Columns.Add("colQtd", "Quantidade");
            dgvProdutoSelecionado.AllowUserToAddRows = false;
            dgvProdutoSelecionado.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // dgvProdutosPedido
            dgvProdutosPedido.Columns.Add("colIdProduto", "ID");
            dgvProdutosPedido.Columns["colIdProduto"].Visible = false;
            dgvProdutosPedido.Columns.Add("colNome", "Nome");
            dgvProdutosPedido.Columns.Add("colQtdPed", "Quantidade");
            dgvProdutosPedido.Columns.Add("colPreco", "Preço");
            dgvProdutosPedido.Columns.Add("colTotal", "Total");
            dgvProdutosPedido.AllowUserToAddRows = false;
            dgvProdutosPedido.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void Form_Editar_Pedido_Load(object sender, EventArgs e)
        {
            ConfigurarDgvProdutoSelecionado();

            // Carregar clientes
            var clientes = daoCliente.Select_Geral();
            cmbCliente.DataSource = clientes;
            cmbCliente.DisplayMember = "nome";
            cmbCliente.ValueMember = "id_cliente";

            // Carregar categorias
            var categorias = new daoCategoria().Select_Geral();
            cmbCategoria.DataSource = categorias;
            cmbCategoria.DisplayMember = "nome";
            cmbCategoria.ValueMember = "id_categoria";

            // Carregar produtos
            var produtos = daoProduto.Select_Geral();
            cmbProduto.DataSource = produtos;
            cmbProduto.DisplayMember = "nome";
            cmbProduto.ValueMember = "id_produto";

            // Carregar pedido existente
            CarregarPedido();
        }

        private void CarregarPedido()
        {
            var pedido = daoPedido.BuscarPorID(idPedido);
            if (pedido != null)
            {
                cmbCliente.SelectedValue = pedido.id_cliente;

                dgvProdutosPedido.Rows.Clear();
                foreach (var item in pedido.itens)
                {
                    dgvProdutosPedido.Rows.Add(
                        item.id_produto,                        
                        item.quantidade,
                        item.preco_unitario,
                        item.totalItem
                    );
                }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection cn = new MySQL_Conexao().String_Conexao())
                {
                    cn.Open();

                    // Atualiza pedido
                    using (MySqlCommand cmd = new MySqlCommand(
                        "UPDATE Pedido SET id_cliente=@idCliente, data=@data WHERE id_pedido=@idPedido", cn))
                    {
                        cmd.Parameters.AddWithValue("@idCliente", cmbCliente.SelectedValue);
                        cmd.Parameters.AddWithValue("@data", DateTime.Now);
                        cmd.Parameters.AddWithValue("@idPedido", idPedido);
                        cmd.ExecuteNonQuery();
                    }

                    // Remove itens antigos
                    using (MySqlCommand cmd = new MySqlCommand(
                        "DELETE FROM ItemPedido WHERE id_pedido=@idPedido", cn))
                    {
                        cmd.Parameters.AddWithValue("@idPedido", idPedido);
                        cmd.ExecuteNonQuery();
                    }

                    // Adiciona itens novos via procedure
                    foreach (DataGridViewRow row in dgvProdutosPedido.Rows)
                    {
                        if (row.IsNewRow) continue;

                        using (MySqlCommand cmd = new MySqlCommand("AdicionarItem", cn))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("p_idPedido", idPedido);
                            cmd.Parameters.AddWithValue("p_idProduto", row.Cells["colIdProduto"].Value);
                            cmd.Parameters.AddWithValue("p_quantidade", row.Cells["colQtdPed"].Value);
                            cmd.ExecuteNonQuery();
                        }
                    }
                }

                MessageBox.Show("Pedido atualizado com sucesso!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar pedido: " + ex.Message);
            }
        }
        public Form_Editar_Pedido(string codigo, string nome, string categoria, string total)
        {
            InitializeComponent();

            cmbCliente.Text = nome;
            txtTotal.Text = total;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
