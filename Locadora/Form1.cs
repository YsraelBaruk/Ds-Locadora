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

        public void Form1_Load(object sender, EventArgs e)
        {
            List<Filme> filme = new List<Filme>();
            filme.Add(new Filme() { Nome = "Homem Aranha", Ano = 2002, Avaliacao = 7, Sinopse = "Quando o morde uma aranha", Genero = "Ação" });
            filme.Add(new Filme() { Nome = "Batman", Ano = 2022, Avaliacao = 7, Sinopse = "Batman se aventura", Genero = "Ação" });
            filme.Add(new Filme() { Nome = "Tropa de Elite", Ano = 2007, Avaliacao = 8, Sinopse = "Em 1997", Genero = "Ação" });
            filme.Add(new Filme() { Nome = "Sing", Ano = 2016, Avaliacao = 7, Sinopse = "Numa ", Genero = "Animação" });
            filme.Add(new Filme() { Nome = "Matrix", Ano = 2003, Avaliacao = 8, Sinopse = "filmezinho", Genero = "Ação" });
            
            foreach (var f in filme)
            {
                //f.Nome = txtNome.Text;
                //txtAno.Text = Convert.ToString(f.Ano);
                ////f.ano = Convert.ToInt32(txtAno);
                //txtAvaliacao.Text = Convert.ToString(f.Avaliacao);
                //f.Sinopse = txtSinopse.Text;
                //f.Genero = txtGenero.Text;
                dataGridView1.Rows.Add(f.nome, f.ano, f.avaliacao, f.sinopse, f.genero);
            }                       
        }   

        private void btnAluga_Click(object sender, EventArgs e)
        {
           
        }

        public void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {            
            DataGridViewRow flm = dataGridView1.Rows[e.RowIndex];
            txtNome.Text = flm.Cells[0].Value.ToString();
            txtAno.Text = flm.Cells[1].Value.ToString();
            txtAvaliacao.Text = flm.Cells[2].Value.ToString();
            txtSinopse.Text = flm.Cells[3].Value.ToString();
            txtGenero.Text = flm.Cells[4].Value.ToString();

            //Listar();
        }



        private void addFilme_Click(object sender, EventArgs e)
        {
        }
    }
}
