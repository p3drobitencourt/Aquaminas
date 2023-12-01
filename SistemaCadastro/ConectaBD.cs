using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using SistemaCadastro;
namespace SistemaCadastroEspecie
{
    internal class ConectaBD
    {
        MySqlConnection conexao = new MySqlConnection("server=sql10.freemysqlhosting.net;user id=sql10665669; password=XvILgDrTgG; database_sql10665669");
        public string mensagem;

        public bool insereEspecie(Especie novaEspecie)
        {   try
            {
                conexao.Open();
                MySqlCommand cmd = new MySqlCommand("sp_insereEspecie", conexao);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("id", novaEspecie.Id);
                cmd.Parameters.AddWithValue("nome", novaEspecie.Nome);
                cmd.Parameters.AddWithValue("preco", novaEspecie.Preco);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (MySqlException erro)
            {
                mensagem = erro.Message;
                return false;
            }
        }

    public DataTable listaEspecie()
        {
            MySqlCommand cmd = new MySqlCommand("sp_listaEspecie",conexao);
            CommandType type = CommandType.StoredProcedure;
            try
            {
                conexao.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable tabela = new DataTable();
                da.Fill(tabela);
                return tabela;
            }
            catch (MySqlException e)
            {
                mensagem = "Erro:"+ e.Message;
                return null;
            }
            finally
            {
                conexao.Close();
            }
        }

        public bool deleteEspecie(int  novaEspecie)
        {
            MySqlCommand cmd = new MySqlCommand("sp_removeEspecie", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
           // cmd.Parameters.AddWithValue("idEspecie", idRemoveEspecie);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch(MySqlException e)
            {
                mensagem = "Erro" +e.Message;
                return false;
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
