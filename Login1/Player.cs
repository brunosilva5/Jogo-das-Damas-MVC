using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CheckersGame
{
    public abstract class Player
    {
        public List<Peca> ListaPecas { get; set; }
        public List<Peca> ListaPecasComidas { get; set; }

        public string Name { get; set; }
        public Image Photo { get; set; }
        public int NumGames { get; set; }
        public int NumWins { get; set; }
        public int NumDefeats { get; set; }
        public int NumLeave { get; set; }

        public Color Color { get; set; }
        public bool Turn { get; set; }

        public Player()
        {
            Turn = false;
            ListaPecas = new List<Peca>();
        }

    }
}
