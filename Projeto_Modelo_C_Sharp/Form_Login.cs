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
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Limpar campos
            txt_usuario.Clear();
            txt_senha.Clear();

            txt_usuario.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Validar_Login val_login =  new Validar_Login();

            bool sit_validacao_user =
                val_login.verificar_usuario(txt_usuario.Text, txt_senha.Text);

            if (sit_validacao_user == true)
            { 
                Form_Principal fp = new Form_Principal();
                fp.Show();
                fp.txt_usuario_logado.Text = txt_usuario.Text.ToUpper();

                this.Hide();

            }
            else 
            { 
                MessageBox.Show("Falha na validação do usuário", "Atenção!!!",
                MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Limpar campos
                txt_usuario.Clear();
                txt_senha.Clear();
                txt_usuario.Focus();
            }
        }
    }
}
