using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora
{
    class Filme
    {
        private string nome;
        private int ano;
        private double avaliacao;
        private string sinopse;
        private string genero;

        public string Nome { get => nome; set => nome = value; }
        public int Ano { get => ano; set => ano = value; }
        public double Avaliacao { get => avaliacao; set => avaliacao = value; }
        public string Sinopse { get => sinopse; set => sinopse = value; }
        public string Genero { get => genero; set => genero = value; }

        public Filme(string nome, int ano, double avaliacao, string sinopse, string genero)
        {
            this.nome = nome;
            this.ano = ano;
            this.avaliacao = avaliacao;
            this.sinopse = sinopse;
            this.genero = genero;
        }

        public Filme(){}
    }
}
