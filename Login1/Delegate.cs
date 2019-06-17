using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CheckersGame
{
    public delegate void MetodosSemParametros();
    public delegate void MetodosComUmInteiro(int gamemode);
    public delegate void MetodosComDoisInteiros(int x, int y);
    public delegate void MetodosComDuasString(string s1, string s2);
    public delegate void MetodosComTresString(string s1, string s2, string s3);
    public delegate void MetodosComSeisString(string s1, string s2, string s3, string s4, string s5, string s6);
    public delegate void ListCountries(List<string> countries);

    public delegate void MensagemErro(string msg);

    public delegate void MetodosComUmPonto(Point movimento);
    public delegate void MetodosComDoisPontos(Point origem, Point destino, string cor);

}
