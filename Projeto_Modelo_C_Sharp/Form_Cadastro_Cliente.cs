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
using Projeto_Modelo_C_Sharp.DAO;
using Projeto_Modelo_C_Sharp.DTO;

namespace Projeto_Modelo_C_Sharp
{
    public partial class Form_Cadastro_Cliente: Form
    {
        public Form_Cadastro_Cliente()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                DtoCliente dtoCliente = new DtoCliente();
                dtoCliente.nome = txtNome.Text;
                dtoCliente.endereco = txtEndereco.Text;
                dtoCliente.telefone = txtTelefone.Text;                

                daoCliente daoCliente = new daoCliente();
                object retornocliente = daoCliente.Inserir(dtoCliente);
                int codigo = Convert.ToInt32(retornocliente);
                MessageBox.Show("Cliente cadastrado com sucesso");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensagem Erro");
                throw;
            }
        }
    }
    }

