using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Modelo_C_Sharp.DTO
{
    internal class DtoProduto
    {
            public int id_produto { get; set; }
            public string nome { get; set; }
            public decimal preco { get; set; }
            public int id_categoria { get; set; }
        
    }
}
