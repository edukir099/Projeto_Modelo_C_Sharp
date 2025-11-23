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
    public partial class Form_Adicionar_Categoria: Form
    {
        public Form_Adicionar_Categoria()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                DtoCategoria dtoCategoria = new DtoCategoria();
                dtoCategoria.nome = txtCategoria.Text;

                daoCategoria daocategoria = new daoCategoria();
                object retornocategoria = daocategoria.Inserir(dtoCategoria);
                int codigo = Convert.ToInt32(retornocategoria);
                MessageBox.Show("Categoria adicionada com sucesso");                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensagem Erro");
                throw;
            }
        }
    }
}

