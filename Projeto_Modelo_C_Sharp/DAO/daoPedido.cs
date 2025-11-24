using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;
using Projeto_Modelo_C_Sharp.DTO;

namespace Projeto_Modelo_C_Sharp.DAO
{
    internal class daoPedido
    {
        MySqlConnection cn;
        public daoPedido()
        {
            MySQL_Conexao conexao = new MySQL_Conexao();
            cn = conexao.String_Conexao();
        }

        #region Método para adicionar novo pedido
        public int InserirPedido(DtoPedido pedido)
        {
            int idPedidoGerado = 0;

            using (MySqlConnection cn = new MySQL_Conexao().String_Conexao())
            {
                cn.Open();

                using (MySqlCommand cmd = new MySqlCommand("CriarPedido", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("p_idCliente", pedido.id_cliente);
                    cmd.Parameters.AddWithValue("p_data", pedido.data);

                    MySqlParameter outParam = new MySqlParameter("p_idPedido", MySqlDbType.Int32)
                    {
                        Direction = ParameterDirection.Output
                    };
                    cmd.Parameters.Add(outParam);

                    cmd.ExecuteNonQuery();

                    idPedidoGerado = Convert.ToInt32(outParam.Value);
                }
            }

            return idPedidoGerado;
        }
        #endregion

        #region Método para listar pedidos
        public List<DtoPedido> ListarPedidos()
        {
            List<DtoPedido> lista = new List<DtoPedido>();

            using (MySqlConnection cn = new MySQL_Conexao().String_Conexao())
            {
                cn.Open();

                string sql = @"
                    SELECT 
                        p.id_pedido,
                        p.data,
                        p.id_cliente,
                        c.nome AS nome_cliente,
                        p.total
                    FROM Pedido p
                    INNER JOIN Cliente c ON c.id_cliente = p.id_cliente
                    ORDER BY p.id_pedido DESC";

                using (MySqlCommand cmd = new MySqlCommand(sql, cn))
                using (MySqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        lista.Add(new DtoPedido()
                        {
                            id_pedido = dr.GetInt32("id_pedido"),
                            data = dr.GetDateTime("data"),
                            id_cliente = dr.GetInt32("id_cliente"),
                            nome_cliente = dr.GetString("nome_cliente"),
                            total = dr.GetDecimal("total")
                        });
                    }
                }
            }

            return lista;
        }
        #endregion

        #region Método para buscar pedido por ID (com itens)
        public DtoPedido BuscarPorID(int idPedido)
        {
            DtoPedido pedido = null;

            using (MySqlConnection cn = new MySQL_Conexao().String_Conexao())
            {
                cn.Open();

                // 1️⃣ Busca dados do pedido
                string sqlPedido = @"
                    SELECT p.id_pedido, p.id_cliente, p.data, p.total, c.nome AS nome_cliente
                    FROM Pedido p
                    INNER JOIN Cliente c ON c.id_cliente = p.id_cliente
                    WHERE p.id_pedido = @id_pedido";

                using (MySqlCommand cmd = new MySqlCommand(sqlPedido, cn))
                {
                    cmd.Parameters.AddWithValue("@id_pedido", idPedido);

                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            pedido = new DtoPedido
                            {
                                id_pedido = dr.GetInt32("id_pedido"),
                                id_cliente = dr.GetInt32("id_cliente"),
                                data = dr.GetDateTime("data"),
                                total = dr.GetDecimal("total"),
                                nome_cliente = dr.GetString("nome_cliente"),
                                itens = new List<DtoPedidoItem>()
                            };
                        }
                    }
                }

                if (pedido != null)
                {
                    // 2️⃣ Busca itens do pedido
                    string sqlItens = @"
                        SELECT i.id_item, i.id_produto, p.nome, i.quantidade, i.preco_unitario, i.totalItem
                        FROM ItemPedido i
                        INNER JOIN Produto p ON p.id_produto = i.id_produto
                        WHERE i.id_pedido = @id_pedido";

                    using (MySqlCommand cmd = new MySqlCommand(sqlItens, cn))
                    {
                        cmd.Parameters.AddWithValue("@id_pedido", idPedido);

                        using (MySqlDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                pedido.itens.Add(new DtoPedidoItem
                                {
                                    id_item = dr.GetInt32("id_item"),
                                    id_produto = dr.GetInt32("id_produto"),                                    
                                    quantidade = dr.GetInt32("quantidade"),
                                    preco_unitario = dr.GetDecimal("preco_unitario")                                    
                                });
                            }
                        }
                    }
                }
            }

            return pedido;
        }
        #endregion

        #region Método para editar pedido completo
        public bool EditarPedidoCompleto(DtoPedido pedido)
        {
            bool sucesso = false;

            using (MySqlConnection cn = new MySQL_Conexao().String_Conexao())
            {
                cn.Open();

                using (MySqlTransaction trans = cn.BeginTransaction())
                {
                    try
                    {
                        // Atualiza dados do pedido
                        string sqlPedido = @"
                            UPDATE Pedido
                            SET data = @data,
                                id_cliente = @id_cliente
                            WHERE id_pedido = @id_pedido";

                        using (MySqlCommand cmd = new MySqlCommand(sqlPedido, cn, trans))
                        {
                            cmd.Parameters.AddWithValue("@data", pedido.data);
                            cmd.Parameters.AddWithValue("@id_cliente", pedido.id_cliente);
                            cmd.Parameters.AddWithValue("@id_pedido", pedido.id_pedido);
                            cmd.ExecuteNonQuery();
                        }

                        // Atualiza ou insere itens
                        foreach (var item in pedido.itens)
                        {
                            if (item.id_item.HasValue) // Atualiza item existente
                            {
                                string sqlAtualizaItem = @"
                                    UPDATE ItemPedido
                                    SET id_produto = @id_produto,
                                        quantidade = @quantidade,
                                        totalItem = @quantidade * preco_unitario
                                    WHERE id_item = @id_item";

                                using (MySqlCommand cmd = new MySqlCommand(sqlAtualizaItem, cn, trans))
                                {
                                    cmd.Parameters.AddWithValue("@id_produto", item.id_produto);
                                    cmd.Parameters.AddWithValue("@quantidade", item.quantidade);
                                    cmd.Parameters.AddWithValue("@id_item", item.id_item.Value);
                                    cmd.ExecuteNonQuery();
                                }
                            }
                            else // Novo item
                            {
                                string sqlInsereItem = @"
                                    INSERT INTO ItemPedido (id_pedido, id_produto, quantidade, preco_unitario, totalItem)
                                    SELECT @id_pedido, id_produto, @quantidade, preco, preco*@quantidade
                                    FROM Produto
                                    WHERE id_produto = @id_produto";

                                using (MySqlCommand cmd = new MySqlCommand(sqlInsereItem, cn, trans))
                                {
                                    cmd.Parameters.AddWithValue("@id_pedido", pedido.id_pedido);
                                    cmd.Parameters.AddWithValue("@id_produto", item.id_produto);
                                    cmd.Parameters.AddWithValue("@quantidade", item.quantidade);
                                    cmd.ExecuteNonQuery();
                                }
                            }
                        }

                        // Recalcula total do pedido
                        string sqlAtualizaTotal = @"
                            UPDATE Pedido
                            SET total = (SELECT SUM(totalItem) FROM ItemPedido WHERE id_pedido = @id_pedido)
                            WHERE id_pedido = @id_pedido";

                        using (MySqlCommand cmd = new MySqlCommand(sqlAtualizaTotal, cn, trans))
                        {
                            cmd.Parameters.AddWithValue("@id_pedido", pedido.id_pedido);
                            cmd.ExecuteNonQuery();
                        }

                        trans.Commit();
                        sucesso = true;
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        throw new Exception("Erro ao editar pedido: " + ex.Message);
                    }
                }
            }

            return sucesso;
        }
        #endregion
    }
}
