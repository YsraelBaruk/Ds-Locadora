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

            List<Filme> filme = new List<Filme>();
            filme.Add(new Filme() { Nome = "Homem Aranha", Ano = 2002, Avaliacao = 7, Sinopse = "Quando o morde uma aranha, o inteligente, e tímido Peter Parker ganha habilidades que deberá usar para lutar contra o mal.", Genero = "Ação" });
            filme.Add(new Filme() { Nome = "Batman", Ano = 2022, Avaliacao = 7, Sinopse = "Batman se aventura no submundo de Gotham City quando um assassino sádico deixa para trás um rastro de pistas enigmáticas.", Genero = "Ação" });
            filme.Add(new Filme() { Nome = "Tropa de Elite", Ano = 2007, Avaliacao = 8, Sinopse = "Em 1997, o capitão Nascimento tem que encontrar seu substituto enquanto luta contra os narcotraficantes e criminais.", Genero = "Ação" });
            filme.Add(new Filme() { Nome = "Sing", Ano = 2016, Avaliacao = 7, Sinopse = "Numa cidade de animais humanóides, o dono dum teatro organiza uma competiçao de canto para salvar seu teatro.", Genero = "Animação" });
            filme.Add(new Filme() { Nome = "Matrix", Ano = 1999, Avaliacao = 8, Sinopse = "Um hacker aprende com os misteriosos rebeldes sobre a verdadeira natureza de sua realidade e seu papel na guerra contra seus controladores.", Genero = "Ação" });

            foreach (var f in filme)
            {
                dataGridView1.Rows.Add(f.nome, f.ano, f.avaliacao, f.sinopse, f.genero);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        public void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAluga_Click(object sender, EventArgs e)
        {
            Filme movie = new Filme();
            int avaliacao;
            int ano;
            string data;

            //dataFilme.

            data = Convert.ToString(dataFilme);
            avaliacao = Convert.ToInt32(txtAvaliacao.Text);
            ano = Convert.ToInt32(txtAno.Text);

            MessageBox.Show($"{movie.Aluga(avaliacao, ano, data)}", "Filme Alugado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow flm = dataGridView1.Rows[e.RowIndex];
            txtNome.Text = flm.Cells[0].Value.ToString();
            txtAno.Text = flm.Cells[1].Value.ToString();
            txtAvaliacao.Text = flm.Cells[2].Value.ToString();
            txtSinopse.Text = flm.Cells[3].Value.ToString();
            txtGenero.Text = flm.Cells[4].Value.ToString();
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {
        }
    }
}
