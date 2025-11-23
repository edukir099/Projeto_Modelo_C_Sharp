using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Modelo_C_Sharp.DTO
{
    internal class DtoPedidoItem
    {
        
        public int? id_item { get; set; }
        public int id_pedido { get; set; }
        public int id_produto { get; set; }
        public int quantidade { get; set; }
        public decimal preco_unitario { get; set; }
        public decimal totalItem => quantidade * preco_unitario;
    }
}
