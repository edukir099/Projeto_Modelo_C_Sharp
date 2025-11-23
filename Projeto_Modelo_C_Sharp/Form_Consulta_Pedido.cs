using Projeto_Modelo_C_Sharp.DAO;
using Projeto_Modelo_C_Sharp.DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Projeto_Modelo_C_Sharp
{
    public partial class Form_Consulta_Pedido : Form
    {
        public Form_Consulta_Pedido()
        {
            InitializeComponent();
            dgvPesquisa.AutoGenerateColumns = false; // desativa auto generate
            CarregarGrid();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CarregarGrid()
        {
            daoPedido daopedido = new daoPedido();
            List<DtoPedido> colecaopedido = daopedido.ListarPedidos();

            dgvPesquisa.Columns.Clear();
            dgvPesquisa.AutoGenerateColumns = false;

            dgvPesquisa.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "colIdPedido",
                HeaderText = "Código do pedido",
                DataPropertyName = "id_pedido"
            });
            dgvPesquisa.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "colNomeCliente",
                HeaderText = "Nome do cliente",
                DataPropertyName = "nome_cliente"
            });
            dgvPesquisa.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "colDataPedido",
                HeaderText = "Data do pedido",
                DataPropertyName = "data",
                DefaultCellStyle = { Format = "dd/MM/yyyy" }
            });
            dgvPesquisa.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "colTotalPedido",
                HeaderText = "Valor total do pedido",
                DataPropertyName = "total",
                DefaultCellStyle = { Format = "C2" }
            });

            dgvPesquisa.DataSource = colecaopedido;
        }

        private void dgvPesquisa_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            int idPedido = Convert.ToInt32(dgvPesquisa.Rows[e.RowIndex].Cells["colIdPedido"].Value);

            // Abrir o formulário de edição e passar o ID
            Form_Editar_Pedido formEditar = new Form_Editar_Pedido(idPedido);
            formEditar.ShowDialog();

            // Atualiza a lista de pedidos após fechar o formulário
            CarregarGrid();
        }
    }
}
