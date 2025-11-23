using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Modelo_C_Sharp.DTO
{
    internal class DtoPedido
    {
        
            public int id_pedido { get; set; }
            public int id_cliente { get; set; }
            public string nome_cliente { get; set; }
            public System.DateTime data { get; set; }
            public decimal total { get; set; }
        public List<DtoPedidoItem> itens { get; set; }
        public DtoPedido()
        {
            itens = new List<DtoPedidoItem>();
        }

    }
}
