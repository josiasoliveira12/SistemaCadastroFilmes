using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaCadastroFilmes
{
    internal class Filme
    {
        string nome;
        int ano;
        int duracao;
        int genero;

        public string Nome { get => nome; set => nome = value; }
        public int Ano { get => ano; set => ano = value; }
        public int Duracao { get => duracao; set => duracao = value; }
        public int Genero { get => genero; set => genero = value; }
    }
}
