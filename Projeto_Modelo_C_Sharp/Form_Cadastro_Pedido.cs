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
        private daoPedido dao;
        public Form_Cadastro_Pedido()
        {
            InitializeComponent();
            dao = new daoPedido();
        }

        

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblValorTotal_Click(object sender, EventArgs e)
        {

        }

        private void lblCategoria_Click(object sender, EventArgs e)
        {

        }

        private void lblNome_Click(object sender, EventArgs e)
        {

        }
    }
}
