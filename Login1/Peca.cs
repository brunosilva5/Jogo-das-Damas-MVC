using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login1
{
    class Peca
    {
        bool _branca;
        string _posicao;

        public Peca(bool branca, string posicao)
        {
            Branca = branca;
            _posicao = posicao;
        }

        public string Posicao { get => _posicao; set => _posicao = value; }
        public bool Branca { get => _branca; set => _branca = value; }
    }
}
