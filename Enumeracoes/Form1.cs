using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enumeracoes
{
    public partial class Form1 : Form
    {
        Jogador jogador;
        public Form1()
        {
            InitializeComponent();
            jogador = new Jogador();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Cima_Click(object sender, EventArgs e)
        {
            jogador.Mover(Jogador.Movimentos.Cima);
        }

        private void btn_Direita_Click(object sender, EventArgs e)
        {
            jogador.Mover(Jogador.Movimentos.Direita);
        }

        private void btn_Baixo_Click(object sender, EventArgs e)
        {
            jogador.Mover(Jogador.Movimentos.Baixo);
        }

        private void btn_Esquerda_Click(object sender, EventArgs e)
        {
            jogador.Mover(Jogador.Movimentos.Esquerda);
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
