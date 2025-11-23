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
    public partial class Form_Principal : Form
    {
        public Form_Principal()
        {
            InitializeComponent();
        }

        private void Form_Principal_Load(object sender, EventArgs e)
        {
            DateTime data_hora_sistema = DateTime.Now;

            // Data atual
            txt_data.Text = data_hora_sistema.ToString("dd'/'MM'/'yyyy");

            // Hora atual           
            // Hora no formato H:Min:Seg
            txt_hora.Text = data_hora_sistema.ToString("HH':'mm':'ss");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime data_hora_sistema = DateTime.Now;

            // Data atual
            txt_data.Text = data_hora_sistema.ToString("dd'/'MM'/'yyyy");

            // Hora atual           
            // Hora no formato H:Min:Seg
            txt_hora.Text = data_hora_sistema.ToString("HH':'mm':'ss");
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Código para abrir a calculadora do Windows
            System.Diagnostics.Process.Start("C:/Windows/System32/calc.exe");
        }

        private void trocaDeUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente trocar de usuário?",
            "Sistema Modelo em C#....",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==  DialogResult.Yes)
            {
                Form_Login f_login = new Form_Login();
                f_login.Show();
                this.Dispose();
            }
        }

        private void sairDoSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair do sistema?",
            "Sistema Modelo em C#....",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            { Application.Exit(); }
        }

        private void clientecadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Cadastro_Cliente objfrmcadastrocliente = new Form_Cadastro_Cliente();
            objfrmcadastrocliente.MdiParent = this;
            objfrmcadastrocliente.Show();
        }

        private void produtocadTooStripMenuItem10_Click(object sender, EventArgs e)
        {
            Form_Cadastro_Produto objfrmcadastroproduto = new Form_Cadastro_Produto();
            objfrmcadastroproduto.MdiParent = this;
            objfrmcadastroproduto.Show();
        }

        private void pedidocadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Cadastro_Pedido objfrmcadastropedido = new Form_Cadastro_Pedido();
            objfrmcadastropedido.MdiParent = this;
            objfrmcadastropedido.Show();
        }

        private void clienteconToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            Form_Consulta_Cliente objfrmconsultacliente = new Form_Consulta_Cliente();
            objfrmconsultacliente.MdiParent = this;
            objfrmconsultacliente.Show();
        }

        private void produtoconToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            Form_Consulta_Produto objfrmconsultaproduto = new Form_Consulta_Produto();
            objfrmconsultaproduto.MdiParent = this;
            objfrmconsultaproduto.Show();
        }

        private void pedidoconToolStripMenuItem8_Click(object sender, EventArgs e)
        {
            Form_Consulta_Pedido objfrmconsultapedido = new Form_Consulta_Pedido();
            objfrmconsultapedido.MdiParent = this;
            objfrmconsultapedido.Show();
        }

        private void relatoriovenToolStripMenuItem29_Click(object sender, EventArgs e)
        {
            Form_Relatorio objfrmrelatorio = new Form_Relatorio();
            objfrmrelatorio.MdiParent = this;
            objfrmrelatorio.Show();
        }
    }
}
