using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Projeto_Modelo_C_Sharp.DAO
{
    internal class MySQL_Conexao
    {
        public MySqlConnection String_Conexao()
        {
            return new MySqlConnection("user id=root;password=root;server=localhost:3307;database=bd_limpeza;SslMode=none");
        }
    }
}
