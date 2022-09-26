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
        public double avaliacao;
        public string sinopse;
        public string genero;
        public string msgErro;

        public string Nome { get => nome; set => nome = value; }
        public int Ano { get => ano; set => ano = value; }
        public double Avaliacao { get => avaliacao; set => avaliacao = value; }
        public string Sinopse { get => sinopse; set => sinopse = value; }
        public string Genero { get => genero; set => genero = value; }
        //public string MsgErro { get => msgErro; set => msgErro = value; }

        public Filme(string nome, int ano, double avaliacao, string sinopse, string genero, string msgErro)
        {
            this.nome = nome;
            this.ano = ano;
            this.avaliacao = avaliacao;
            this.sinopse = sinopse;
            this.genero = genero;
            this.msgErro = msgErro;
        }

        public Filme(){}

        public bool Aluga(bool btn)
        {
<<<<<<< HEAD
            double valorLoc = (this.ano / 1000) + this.avaliacao;
            double multa = (this.ano / 1000) + (this.avaliacao*1.5);
            //double Data = ;
            if (this.avaliacao > 0)
=======
            if (!(this.nome))
            {
                return false;
            }
            else
>>>>>>> 409b5296c5f1fb3b318e2f340011a5c9bae681a5
            {
                 this.msgErro = $"Locadora: {valorLoc}; " +
                         $"Multa: ; {multa}" +
                         $"Data: Hoje + 7dias;";
                return true;
            }
<<<<<<< HEAD
            this.msgErro = "Erro!!, Dê um duplo clique em qualquer filme, Escolha um que você goste";
            return false;
=======
>>>>>>> 409b5296c5f1fb3b318e2f340011a5c9bae681a5
        }
    }
}
