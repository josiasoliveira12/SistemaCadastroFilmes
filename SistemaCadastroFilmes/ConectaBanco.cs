using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;

namespace SistemaCadastroFilmes
{
    internal class ConectaBanco
    {
        // Dados da conexão com o banco
        public const string SERVER = "localhost";
        public const int PORT = 3306;
        public const string DATABASE = "banco_filmes";
        public const string USER = "root";
        public static readonly string PASSWORD =
            Environment.GetEnvironmentVariable("MYSQL_PASSWORD") ?? "";

        MySqlConnection conexao = new MySqlConnection(
            $"server={SERVER};" +
            $"port={PORT};" +
            $"database={DATABASE};" +
            $"user id={USER};" +
            $"password={PASSWORD};");

        public string mensagem;

        // Método para inserir filme
        public bool insereFilme(Filme novoFilme)
        {
            try
            {
                conexao.Open();

                MySqlCommand cmd =
                    new MySqlCommand("sp_insereFilme", conexao);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("titulo", novoFilme.Nome);
                cmd.Parameters.AddWithValue("ano", novoFilme.Ano);
                cmd.Parameters.AddWithValue("duracao", novoFilme.Duracao);
                cmd.Parameters.AddWithValue("genero", novoFilme.Genero);

                cmd.ExecuteNonQuery();

                return true;
            }
            catch (MySqlException erro)
            {
                mensagem = erro.Message;
                return false;
            }
            finally
            {
                if (conexao.State == ConnectionState.Open)
                    conexao.Close();
            }
        }

        public DataTable listaGeneros()
        {
            // comentario
            MySqlCommand cmd = new MySqlCommand("sp_listaGeneros", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                conexao.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable tabela = new DataTable();
                da.Fill(tabela);
                return tabela;
            }// fim try
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                return null;
            }
            finally
            {
                conexao.Close();
            }

        }// fim lista_generos 

        // Metodo no conecta Banco

        public DataTable listaFilmes()
        {
            MySqlCommand cmd = new MySqlCommand("sp_listaFilmes", conexao);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                conexao.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable tabela = new DataTable();
                da.Fill(tabela);
                return tabela;
            }// fim try
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                return null;
            }
            finally
            {
                conexao.Close();
            }

        }// fim lista_filmes

        public bool deletaFilme(int idRemoveFilme)
        {
            MySqlCommand cmd = new MySqlCommand("sp_removeFilme", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("p_idFilme", idRemoveFilme);

            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                return false;
            }
            finally
            {
                conexao.Close();
            }
        }

        public bool alteraFilme(Filme f, int idFilme)
        {
            MySqlCommand cmd = new MySqlCommand("sp_alteraFilme", conexao);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("p_idFilme", idFilme);
            cmd.Parameters.AddWithValue("p_titulo", f.Nome);
            cmd.Parameters.AddWithValue("p_ano", f.Ano);
            cmd.Parameters.AddWithValue("p_duracao", f.Duracao);
            cmd.Parameters.AddWithValue("p_genero", f.Genero);

            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                return false;
            }
            finally
            {
                conexao.Close();
            }
        }// fim alteraFilme

        public bool insereGenero(string nomeGenero)
        {
            try
            {
                conexao.Open();

                MySqlCommand cmd =
                    new MySqlCommand("sp_insereGenero", conexao);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("nomeGenero", nomeGenero);
                cmd.ExecuteNonQuery();

                return true;
            }
            catch (MySqlException erro)
            {
                mensagem = erro.Message;
                return false;
            }
            
        }

        public bool verifica(string user, string pass)
        {
            string senhaHash = Biblioteca.makeHash(pass);

            MySqlCommand cmd = new MySqlCommand("consultaLogin", conexao);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("usuario", user);
            cmd.Parameters.AddWithValue("senha", senhaHash);

            try
            {
                conexao.Open(); // abrindo a conexão

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                da.Fill(ds); // passando os valores consultados para o DataSet

                if (ds.Tables[0].Rows.Count > 0)
                    return true;
                else
                    return false;
            }
            catch (MySqlException er)
            {
                mensagem = "Erro:" + er.Message;
                return false;
            }
            finally
            {
                conexao.Close();
            }
        }

    }


}

