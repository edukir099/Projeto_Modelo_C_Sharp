using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Modelo_C_Sharp
{
    internal class Validar_Login
    {
        public bool verificar_usuario(string user, string senha)
        {
            bool sit_usuario = false;

            // Atualiza as variáveis para caixa alta
            user = user.ToUpper();
            senha = senha.ToUpper();

            if(user.Equals("ADM") && senha.Equals("123"))
            { sit_usuario = true; }

            if (user.Equals("GERENTE") && senha.Equals("500"))
            { sit_usuario = true; }

            if (user.Equals("FUNCIONÁRIO") && senha.Equals("ETEC"))
            { sit_usuario = true; }

            return sit_usuario;
        }
           
    }
}
