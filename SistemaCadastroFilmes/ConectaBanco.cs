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



    }


}

