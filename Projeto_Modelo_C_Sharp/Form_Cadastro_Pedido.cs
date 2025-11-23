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

namespace Projeto_Modelo_C_Sharp
{
    public partial class Form_Cadastro_Pedido: Form
    {
        private daoPedido daoPedido;
        private daoCliente daoCliente;
        public Form_Cadastro_Pedido()
        {
            InitializeComponent();
            daoPedido = new daoPedido();
            daoCliente = new daoCliente();
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

        private void Form_Cadastro_Pedido_Load(object sender, EventArgs e)
        {
            daoCliente dao = new daoCliente();
            var clientes = dao.Select_Geral();

            // Define a fonte de dados do ComboBox
            comboBoxCliente.DataSource = clientes;

            // Define qual propriedade mostrar no ComboBox
            comboBoxCliente.DisplayMember = "nome";

            // Define qual propriedade será o valor real (id)
            comboBoxCliente.ValueMember = "id_cliente";
        }
    }
}
