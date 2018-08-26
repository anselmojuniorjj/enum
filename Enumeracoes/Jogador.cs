using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumeracoes
{
    class Jogador
    {
        public enum Movimentos { Cima, Direita, Baixo, Esquerda}

        public void Mover(Movimentos movimento)
        {
            Console.WriteLine("O jogador moveu-se para " + movimento);
        }
    }
}
