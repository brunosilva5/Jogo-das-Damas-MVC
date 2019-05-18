using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Login1
{
    public class Player
    {
        //public List<Peca> ListaPecas { get; set; }
        //public List<Peca> ListaPecasComidas { get; set; }

        public string Name { get; set; }
        public Image Photo { get; set; }
        public int NumGames { get; set; }
        public int NumWins { get; set; }
        public int NumDefeats { get; set; }
        public int NumLeave { get; set; }

        public Color Color { get; set; }

        public Player()
        {
            //ListaPecas = new List<Peca>();
            //ListaPecasComidas = new List<Peca>();
        }
    }
}
