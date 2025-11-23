using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using Projeto_Modelo_C_Sharp.DTO;

namespace Projeto_Modelo_C_Sharp.DAO
{
    internal class daoProduto
    {
        MySqlConnection cn;
        public daoProduto()
        {
            MySQL_Conexao conexao = new MySQL_Conexao();
            cn = conexao.String_Conexao();
        }

        #region Método para adicionar novo produto
        public object Inserir(DtoProduto Produto)
        {
            try
            {
                string comando = "INSERT INTO produto (nome, preco, id_categoria) VALUES (@nome, @preco, @id_categoria);";
                MySqlCommand cmd = new MySqlCommand(comando, cn);
                cmd.Parameters.AddWithValue("@nome", Produto.nome);
                cmd.Parameters.AddWithValue("@preco", Produto.preco);
                cmd.Parameters.AddWithValue("@id_categoria", Produto.id_categoria);

                cn.Open();
                object retorno = cmd.ExecuteNonQuery();
                return retorno;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cn.Close();
            }
        }
        #endregion

        #region Método para consultar produto
        public Dto_ColecaoProduto Select_Geral()
        {
            try
            {
                string comando = "SELECT * FROM produto;";
                MySqlCommand cmd = new MySqlCommand(comando, cn);

                cn.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                da.Fill(dt);

                Dto_ColecaoProduto colecaoProduto = new Dto_ColecaoProduto();

                foreach (DataRow item in dt.Rows)
                {
                    DtoProduto Produto = new DtoProduto();
                    Produto.id_produto = Convert.ToInt32(item["id_produto"]);
                    Produto.nome = item["nome"].ToString();
                    Produto.preco = Convert.ToDecimal(item["preco"]);
                    Produto.id_categoria = Convert.ToInt32(item["id_categoria"]);
                    colecaoProduto.Add(Produto);
                }
                return colecaoProduto;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                cn.Close();
            }
        }
        #endregion

        #region Método para editar produto
        public object Alterar(DtoProduto Produto)
        {
            try
            {
                string comando = "UPDATE produto SET nome = @nome, preco = @preco, id_categoria = @id_categoria WHERE (id_produto = id_produto);";
                MySqlCommand cmd = new MySqlCommand(comando, cn);
                cmd.Parameters.AddWithValue("@nome", Produto.nome);
                cmd.Parameters.AddWithValue("@preco", Produto.preco);
                cmd.Parameters.AddWithValue("@id_categoria", Produto.id_categoria);
                cmd.Parameters.AddWithValue("@id_produto", Produto.id_produto);

                cn.Open();
                object retorno = cmd.ExecuteNonQuery();

                return retorno;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                cn.Close();
            }
        }
        #endregion

        #region Método de busca especifico de produto
        public DtoProduto BuscarPorID(int idProduto)
        {
            try
            {
                string comando = "SELECT * FROM produto WHERE id_produto = @id_produto;";
                MySqlCommand cmd = new MySqlCommand(comando, cn);
                cmd.Parameters.AddWithValue("@id_produto", idProduto);

                cn.Open();

                MySqlDataReader dr = cmd.ExecuteReader();

                DtoProduto produto = null;

                if (dr.Read())
                {
                    produto = new DtoProduto();
                    produto.id_produto = Convert.ToInt32(dr["id_produto"]);
                    produto.nome = dr["nome"].ToString();
                    produto.preco = Convert.ToDecimal(dr["preco"]);
                    produto.id_categoria = Convert.ToInt32(dr["id_categoria"]);
                }
                

                return produto;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cn.Close();
            }
        }

        public List<DtoProduto> SelecionarPorCategoria(int idCategoria)
        {
            List<DtoProduto> lista = new List<DtoProduto>();

            try
            {
                string comando = "SELECT * FROM Produto WHERE id_categoria = @id_categoria;";
                MySqlCommand cmd = new MySqlCommand(comando, cn);
                cmd.Parameters.AddWithValue("@id_categoria", idCategoria);

                cn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    DtoProduto produto = new DtoProduto
                    {
                        id_produto = Convert.ToInt32(dr["id_produto"]),
                        nome = dr["nome"].ToString(),
                        preco = Convert.ToDecimal(dr["preco"]),
                        id_categoria = Convert.ToInt32(dr["id_categoria"])
                    };
                    lista.Add(produto);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cn.Close();
            }

            return lista;
        }

        #endregion
    }
}
