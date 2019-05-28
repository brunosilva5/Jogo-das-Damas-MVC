using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckersGame
{
    public class Jogo
    {
        List<Peca> tabuleiro;
        public List<Player> Players { get; set; }

        public Jogo()
        {
            tabuleiro = new List<Peca>();
            Players = new List<Player>();

            Program.M_Damas.AddPlayer += M_Damas_AddPlayer;

            /*tabuleiro.Add(new Peca(true, "B1"));
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
            tabuleiro.Add(new Peca(false, "C4"));*/
        }

        private void M_Damas_AddPlayer(string s1, string s2, string s3, string s4, string s5, string s6)
        {
            PReal P = new PReal(s1,s2,s3,s4,s5,s6);
        }

        internal List<Peca> Tabuleiro { get => tabuleiro; set => tabuleiro = value; }

        public void AddPlayer(Player p)
        {
            if (Players.Count<2)
            {
                Players.Add(p);
            }
        }



    }
}
