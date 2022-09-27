using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora
{
    class Filme
    {
        public string nome;
        public int ano;
        public int avaliacao;
        public string sinopse;
        public string genero;

        public string Nome { get => nome; set => nome = value; }
        public int Ano { get => ano; set => ano = value; }
        public int Avaliacao { get => avaliacao; set => avaliacao = value; }
        public string Sinopse { get => sinopse; set => sinopse = value; }
        public string Genero { get => genero; set => genero = value; }

        public Filme(string nome, int ano, int avaliacao, string sinopse, string genero)
        {
            this.nome = nome;
            this.ano = ano;
            this.avaliacao = avaliacao;
            this.sinopse = sinopse;
            this.genero = genero;
        }

        public Filme() { }

        public string Aluga(int avaliacao, int ano)
        {
            string msgErro;

            this.avaliacao = avaliacao;
            this.ano = ano;
            if (avaliacao > 0 && ano > 1000)
            {
                int valorLoc = (this.ano / 100) + this.avaliacao;
                int multa = (this.ano / 100) + (this.avaliacao * 2);
                
                return msgErro = $"Locadora: R$ {valorLoc}.\n " +
                                 $"Multa: R$ {multa}.\n" +
                                 $"Data: Devolva depois de 7 dias.\n";
            }
            else
            {
                return msgErro = "Erro!!, Dê um duplo clique em qualquer filme, Escolha um que você goste";
            }
        }
    }
}