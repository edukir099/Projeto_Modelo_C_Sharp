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
using MySql.Data.MySqlClient;
using Projeto_Modelo_C_Sharp.DAO;
using Projeto_Modelo_C_Sharp.DTO;

namespace Projeto_Modelo_C_Sharp
{
    public partial class Form_Cadastro_Pedido: Form
    {
        private daoPedido daoPedido;
        private daoCliente daoCliente;
        private daoProduto daoProduto;
        public Form_Cadastro_Pedido()
        {
            InitializeComponent();
            daoPedido = new daoPedido();
            daoCliente = new daoCliente();
            daoProduto = new daoProduto();
        }

        

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxCliente.DataSource == null)
                return;

            // Verifica se SelectedValue não é nulo e é um int
            if (comboBoxCliente.SelectedValue != null && int.TryParse(comboBoxCliente.SelectedValue.ToString(), out int idClienteSelecionado))
            {
                Console.WriteLine($"Cliente selecionado: {idClienteSelecionado}");
            }
        }
        private void ConfigurarDgvProdutoSelecionado()
        {

            // Limpa colunas existentes
            dgvProdutoSelecionado.Columns.Clear();

            // Adiciona colunas com nomes corretos (Name) e títulos (HeaderText)
            dgvProdutoSelecionado.Columns.Add("colId", "ID");
            dgvProdutoSelecionado.Columns.Add("colNome", "Nome");
            dgvProdutoSelecionado.Columns.Add("colPreco", "Preço");
            dgvProdutoSelecionado.Columns.Add("colQtd", "Quantidade");
            dgvProdutosPedido.Columns.Clear();
            dgvProdutosPedido.Columns.Add("colIdProduto", "ID");
            dgvProdutosPedido.Columns["colIdProduto"].Visible = false; // id não precisa aparecer
            dgvProdutosPedido.Columns.Add("colNome", "Nome");
            dgvProdutosPedido.Columns.Add("colQtdPed", "Quantidade");
            dgvProdutosPedido.Columns.Add("colPreco", "Preço");
            dgvProdutosPedido.Columns.Add("colTotal", "Total");

            // Configura para não permitir adicionar linhas pelo usuário
            dgvProdutoSelecionado.AllowUserToAddRows = false;

            // Configura seleção inteira da linha
            dgvProdutoSelecionado.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }



        private void Form_Cadastro_Pedido_Load(object sender, EventArgs e)
        {
            ConfigurarDgvProdutoSelecionado();

            var clientes = daoCliente.Select_Geral();

            comboBoxCliente.SelectedIndexChanged -= comboBoxCliente_SelectedIndexChanged;

            comboBoxCliente.DataSource = clientes;
            comboBoxCliente.DisplayMember = "nome";
            comboBoxCliente.ValueMember = "id_cliente";
            comboBoxCliente.SelectedIndex = 0;

            comboBoxCliente.SelectedIndexChanged += comboBoxCliente_SelectedIndexChanged;

            // 2️⃣ Carregar categorias
            var categorias = new daoCategoria().Select_Geral();

            comboBoxCategoria.SelectedIndexChanged -= comboBoxCategoria_SelectedIndexChanged;

            comboBoxCategoria.DataSource = categorias;
            comboBoxCategoria.DisplayMember = "nome";
            comboBoxCategoria.ValueMember = "id_categoria";
            comboBoxCategoria.SelectedIndex = 0;

            comboBoxCategoria.SelectedIndexChanged += comboBoxCategoria_SelectedIndexChanged;

            // 3️⃣ Carregar produtos
            var produtos = new daoProduto().Select_Geral();

            comboBoxProduto.SelectedIndexChanged -= comboBoxProduto_SelectedIndexChanged;

            comboBoxProduto.DataSource = produtos;
            comboBoxProduto.DisplayMember = "nome";
            comboBoxProduto.ValueMember = "id_produto";
            if (comboBoxProduto.Items.Count > 0)
            {
                comboBoxProduto.SelectedIndex = 0;
            }
            comboBoxProduto.SelectedIndexChanged += comboBoxProduto_SelectedIndexChanged;

            // Limpar DataGridViews
            dgvProdutoSelecionado.Rows.Clear();
            dgvProdutosPedido.Rows.Clear();


        }

        private void comboBoxCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxCategoria.SelectedValue == null) return;

            if (int.TryParse(comboBoxCategoria.SelectedValue.ToString(), out int idCategoriaSelecionada))
            {
                daoProduto daoProduto = new daoProduto();
                var produtosFiltrados = daoProduto.SelecionarPorCategoria(idCategoriaSelecionada);

                comboBoxProduto.SelectedIndexChanged -= comboBoxProduto_SelectedIndexChanged;

                comboBoxProduto.DataSource = produtosFiltrados;
                comboBoxProduto.DisplayMember = "nome";
                comboBoxProduto.ValueMember = "id_produto";

                comboBoxProduto.SelectedIndexChanged += comboBoxProduto_SelectedIndexChanged;
            }
        }

        private void comboBoxProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxProduto.SelectedValue == null)
                return;

            int idProduto = (int)comboBoxProduto.SelectedValue;

            daoProduto dao = new daoProduto();
            DtoProduto produto = dao.BuscarPorID(idProduto);

            dgvProdutoSelecionado.Rows.Clear();

            dgvProdutoSelecionado.Rows.Add(
                produto.id_produto,
                produto.nome,
                produto.preco,
                1 // quantidade default
            );
        }

        private void dgvProdutoSelecionado_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            int idProduto = Convert.ToInt32(dgvProdutoSelecionado.Rows[e.RowIndex].Cells["colId"].Value);
            string nome = dgvProdutoSelecionado.Rows[e.RowIndex].Cells[1].Value.ToString();
            int quantidade = int.Parse(dgvProdutoSelecionado.Rows[e.RowIndex].Cells[3].Value.ToString());
            decimal preco = decimal.Parse(dgvProdutoSelecionado.Rows[e.RowIndex].Cells[2].Value.ToString());
            decimal total = preco * quantidade;

            dgvProdutosPedido.Rows.Add(
                idProduto,
                nome,
                quantidade,
                preco,
                total
            );

        }

        private void dgvProdutosPedido_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dgvProdutosPedido.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                // 1️⃣ Monta o objeto pedido
                DtoPedido pedido = new DtoPedido();
                pedido.id_cliente = (int)comboBoxCliente.SelectedValue;
                pedido.data = DateTime.Now;

                daoPedido dao = new daoPedido();

                // 2️⃣ Cria o pedido e recebe o ID gerado
                int idPedidoGerado = dao.InserirPedido(pedido);

                // 3️⃣ Para cada produto do DataGridView → Chama a procedure AdicionarItem
                using (MySqlConnection cn = new MySQL_Conexao().String_Conexao())
                {
                    cn.Open();

                    foreach (DataGridViewRow row in dgvProdutosPedido.Rows)
                    {
                        if (row.IsNewRow) continue;

                        int idProduto = Convert.ToInt32(row.Cells["colIdProduto"].Value);
                        int quantidade = Convert.ToInt32(row.Cells["colQtdPed"].Value);

                        using (MySqlCommand cmd = new MySqlCommand("AdicionarItem", cn))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.AddWithValue("p_idPedido", idPedidoGerado);
                            cmd.Parameters.AddWithValue("p_idProduto", idProduto);
                            cmd.Parameters.AddWithValue("p_quantidade", quantidade);

                            cmd.ExecuteNonQuery();
                        }
                    }
                }

                MessageBox.Show($"Pedido cadastrado com sucesso! ID: {idPedidoGerado}");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar pedido: " + ex.Message);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}
