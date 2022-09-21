using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Locadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Filme> filmes = new List<Filme>();            
            filmes.Add(new Filme() { Nome = "Homem Aranha", Ano = 2002, Avaliacao = 7.4, Sinopse = "Quando o morde uma aranha, o inteligente, e tímido Peter Parker ganha habilidades que deberá usar para lutar contra o mal.", Genero = "Ação" });
            filmes.Add(new Filme() { Nome = "Batman", Ano = 2022, Avaliacao = 7.9, Sinopse = "Batman se aventura no submundo de Gotham City quando um assassino sádico deixa para trás um rastro de pistas enigmáticas.", Genero = "Ação" });
            filmes.Add(new Filme() { Nome = "Tropa de Elite", Ano = 2007, Avaliacao = 8.0, Sinopse = "Em 1997, o capitão Nascimento tem que encontrar seu substituto enquanto luta contra os narcotraficantes e criminais.", Genero = "Ação" });
            filmes.Add(new Filme() { Nome = "Sing", Ano = 2016, Avaliacao = 7.1, Sinopse = "Numa cidade de animais humanóides, o dono dum teatro organiza uma competiçao de canto para salvar seu teatro.", Genero = "Animação" });
            filmes.Add(new Filme("Matrix", 2003, 8.9, "filmezinho", "Ação"));
            //filmes.Add(new Filme() { });
            //
            foreach (var f in filmes)
            {
                this.dataGridView1.DataSource = f;
            }
        }   

        private void btnAluga_Click(object sender, EventArgs e)
        {
           
        }
    }
}
