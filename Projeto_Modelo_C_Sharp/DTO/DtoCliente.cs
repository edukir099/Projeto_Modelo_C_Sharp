using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Modelo_C_Sharp.DTO
{
    internal class DtoCliente
    {
            public int id_cliente { get; set; }
            public string nome { get; set; }
            public string endereco { get; set; }
            public string telefone { get; set; }
            public string status { get; set; }
            public decimal limite_credito { get; set; }
        
    }
}
