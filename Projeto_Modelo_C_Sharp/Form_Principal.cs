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

        private void trumaToolStripMenuItem_Click(object sender, EventArgs e)
        {

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
    
    }
}
