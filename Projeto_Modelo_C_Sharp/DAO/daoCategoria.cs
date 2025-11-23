using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using Projeto_Modelo_C_Sharp.DTO;
using static Projeto_Modelo_C_Sharp.DTO.DtoCategoria;

namespace Projeto_Modelo_C_Sharp.DAO
{
    internal class daoCategoria
    {
        MySqlConnection cn;
        public daoCategoria()
        {
            MySQL_Conexao conexao = new MySQL_Conexao();
            cn = conexao.String_Conexao();
        }

        #region Método para adicionar nova categoria
        public object Inserir(DtoCategoria Categoria)
        {
            try
            {
                string comando = "INSERT INTO categoria (nome) VALUES (@nome);";
                MySqlCommand cmd = new MySqlCommand(comando, cn);
                cmd.Parameters.AddWithValue("@nome", Categoria.nome);                

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

        #region Método para consultar categoria
        public Dto_ColecaoCategoria Select_Geral()
        {
            try
            {
                string comando = "SELECT * FROM categoria;";
                MySqlCommand cmd = new MySqlCommand(comando, cn);                

                cn.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                da.Fill(dt);

                Dto_ColecaoCategoria colecaoCategoria = new Dto_ColecaoCategoria();

                foreach (DataRow item in dt.Rows)
                {
                    DtoCategoria Categoria = new DtoCategoria();
                    Categoria.id_categoria = Convert.ToInt32(item["id_categoria"]);
                    Categoria.nome = item["nome"].ToString();

                    colecaoCategoria.Add(Categoria);
                }
                return colecaoCategoria;
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
