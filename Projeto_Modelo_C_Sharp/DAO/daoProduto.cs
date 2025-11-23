using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
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
    }
}
