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
    public partial class Form_Consulta_Cliente: Form
    {
        public Form_Consulta_Cliente()
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
            daoCliente daocliente = new daoCliente();
            Dto_ColecaoCliente colecaocliente = daocliente.Select_Geral();

            dgvPesquisa.AutoGenerateColumns = false;
            dgvPesquisa.Columns.Clear();

            dgvPesquisa.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Nome do cliente",
                DataPropertyName = "nome",
                Name = "nome"
            });
            dgvPesquisa.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Endereço",
                DataPropertyName = "endereco",
                Name = "endereco"
            });
            dgvPesquisa.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Telefone",
                DataPropertyName = "telefone",
                Name = "telefone"
            });
            dgvPesquisa.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Status",
                DataPropertyName = "status",
                Name = "status"
            });
            dgvPesquisa.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Limite de crédito",
                DataPropertyName = "limite_credito",
                Name = "limite_credito"
            });

            dgvPesquisa.DataSource = colecaocliente;
        }


    }
}
