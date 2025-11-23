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
            dgvPesquisa.AutoGenerateColumns = false;
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
            dgvPesquisa.DataSource = colecaocliente;
        }
    }
}
