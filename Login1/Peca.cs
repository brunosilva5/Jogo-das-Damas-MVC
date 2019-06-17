using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CheckersGame
{
    public class Peca
    {
        public Peca(Color cor, Point posicao, bool dama)
        {
            Cor = cor;
            Posicao = posicao;
            Dama = dama;
        }

        public Point Posicao { get; set; }
        public Color Cor { get; private set; }
        public bool Dama { get; set; }
    }
}
