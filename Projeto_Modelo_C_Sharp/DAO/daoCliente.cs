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
    internal class daoCliente
    {
        MySqlConnection cn;
        public daoCliente()
        {
            MySQL_Conexao conexao = new MySQL_Conexao();
            cn = conexao.String_Conexao();
        }

        #region Método para adicionar novo cliente
        public object Inserir(DtoCliente Cliente)
        {
            try
            {
                string comando = "INSERT INTO cliente (nome, endereco, telefone) VALUES (@nome, @endereco, @telefone);";
                MySqlCommand cmd = new MySqlCommand(comando, cn);
                cmd.Parameters.AddWithValue("@nome", Cliente.nome);
                cmd.Parameters.AddWithValue("@endereco", Cliente.endereco);
                cmd.Parameters.AddWithValue("@telefone", Cliente.telefone);

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

        #region Método para consultar cliente
        public Dto_ColecaoCliente Select_Geral()
        {
            try
            {
                string comando = "SELECT * FROM cliente;";
                MySqlCommand cmd = new MySqlCommand(comando, cn);

                cn.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                da.Fill(dt);

                Dto_ColecaoCliente colecaoCliente = new Dto_ColecaoCliente();

                foreach (DataRow item in dt.Rows)
                {
                    DtoCategoria Categoria = new DtoCategoria();
                    Categoria.id_categoria = Convert.ToInt32(item["id_cliente"]);
                    Categoria.nome = item["nome"].ToString();
                    Categoria.nome = item["endereco"].ToString();
                    Categoria.nome = item["telefone"].ToString();
                    Categoria.nome = item["status"].ToString();
                    Categoria.nome = item["limite_credito"].ToString();
                }
                return colecaoCliente;
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

        #region Método para editar cliente
        public object Alterar(DtoCliente Cliente)
        {
            try
            {
                string comando = "UPDATE cliente SET nome = @nome, endereco = @endereco, telefone = @telefone WHERE (id_cliente = @id_cliente);";
                MySqlCommand cmd = new MySqlCommand(comando, cn);
                cmd.Parameters.AddWithValue("@nome", Cliente.nome);
                cmd.Parameters.AddWithValue("@endereco", Cliente.endereco);
                cmd.Parameters.AddWithValue("@telefone", Cliente.telefone);
                cmd.Parameters.AddWithValue("@id_cliente", Cliente.id_cliente);

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
