using Projeto_Modelo_C_Sharp.DAO;
using Projeto_Modelo_C_Sharp.DTO;
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
    public partial class Form_Consulta_Pedido: Form
    {
        public Form_Consulta_Pedido()
        {
            InitializeComponent();
            dgvPesquisa.AutoGenerateColumns = true;
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
                HeaderText = "Código do pedido",
                DataPropertyName = "id_pedido"
            });
            dgvPesquisa.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Nome do cliente",
                DataPropertyName = "nome_cliente"
            });
            dgvPesquisa.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Data do pedido",
                DataPropertyName = "data",
                DefaultCellStyle = { Format = "dd/MM/yyyy" }
            });
            dgvPesquisa.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Valor total do pedido",
                DataPropertyName = "total",
                DefaultCellStyle = { Format = "C2" }
            });

            dgvPesquisa.DataSource = colecaopedido;
        }
    }

}
