using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using SistemaCadastro;

namespace SistemaCadastro
{
    internal class ConectaBD
    {
        MySqlConnection conexao = new MySqlConnection("server=sql10.freemysqlhosting.net;user id=sql10665669; password=XvILgDrTgG; database=sql10665669");
        public string mensagem;

        public bool insereEspecie(Especie novaEspecie)
        {
            try
            {
                conexao.Open();
                MySqlCommand cmd = new MySqlCommand("sp_insereEspecie", conexao);
                cmd.CommandType = CommandType.StoredProcedure;
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
            MySqlCommand cmd = new MySqlCommand("sp_listaEspecie", conexao);
            CommandType type = CommandType.StoredProcedure;
            try
            {
                conexao.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable tabela = new DataTable();
                da.Fill(tabela);
                Console.WriteLine(tabela.ToString());
                Console.WriteLine("alberto");
                return tabela;
            }
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                return null;
            }
            finally
            {
                conexao.Close();
            }
        }
        public void listaCBEspecie()
        {
            ConectaBD con = new ConectaBD();
            DataTable tabelaDados = new DataTable();
            tabelaDados = con.listaEspecie();
          
        }

        public DataTable listaGridEspecie()
        {
            MySqlCommand cmd = new MySqlCommand("sp_listaEspecie", conexao);
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
                mensagem = "Erro:" + e.Message;
                return null;
            }
            finally
            {
                conexao.Close();
            }
        }
        public bool deletaEspecie(int removeEspecie)
        {
            MySqlCommand cmd = new MySqlCommand("sp_removeEspecie", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("idEspecie", removeEspecie);

            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
                return false;
               
            }
            catch (MySqlException erro)
            {
                mensagem = "erro:" + erro.Message;
                return false;
            }
            finally
            {
                conexao.Close();
            }
        }
        public bool alteraEspecie(Especie e,int idEspecie)
        {
            MySqlCommand cmd = new MySqlCommand("sp_alteraEspecie", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("nomeEspecie", e.Nome);
            cmd.Parameters.AddWithValue("preco", e.Preco);
            cmd.Parameters.AddWithValue("idEspecie", idEspecie);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
                return true;

            }
            catch (MySqlException erro)
            {
                mensagem = "erro:" + erro.Message;
                return false;
            }
            finally
            {
                conexao.Close();
            }
        }
        public bool verifica(string user, string pass)
        {
            string senhaHash = Biblioteca.makeHash(pass);
            MySqlCommand cmd = new MySqlCommand("sp_consultaLogin", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("usuario", user);
            cmd.Parameters.AddWithValue("senha", senhaHash);
            try
            {
                conexao.Open();//abrindo a conexão;
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();// tabela virtual
                da.Fill(ds); //passando os valores consultados para o DataSet
                if (ds.Tables[0].Rows.Count > 0) // verifica se houve retorno
                    return true;
                else
                    return false;

            }
            catch (MySqlException er)
            {
                mensagem = "Erro" + er.Message;
                return false;
            }
            finally
            {
                conexao.Close();
            }
        }

    }
}
