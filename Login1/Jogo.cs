using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login1
{
    class Jogo
    {
        List<Peca> tabuleiro;

        public Jogo()
        {
            tabuleiro = new List<Peca>();

            tabuleiro.Add(new Peca(true, "B1"));
            tabuleiro.Add(new Peca(true, "D1"));
            tabuleiro.Add(new Peca(true, "F1"));
            tabuleiro.Add(new Peca(true, "H1"));
            tabuleiro.Add(new Peca(true, "A2"));
            tabuleiro.Add(new Peca(true, "C2"));
            tabuleiro.Add(new Peca(true, "E2"));
            tabuleiro.Add(new Peca(true, "G2"));
            tabuleiro.Add(new Peca(true, "B3"));
            tabuleiro.Add(new Peca(true, "D3"));
            tabuleiro.Add(new Peca(true, "F3"));
            tabuleiro.Add(new Peca(true, "H3"));

            tabuleiro.Add(new Peca(false, "D8"));
            tabuleiro.Add(new Peca(false, "A4"));
            tabuleiro.Add(new Peca(false, "C4"));
        }

        internal List<Peca> Tabuleiro { get => tabuleiro; set => tabuleiro = value; }
    }
}
