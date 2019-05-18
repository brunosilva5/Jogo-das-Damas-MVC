using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login1
{
    public delegate void MetodosSemParametros();
    public delegate void MetodosComDuasString(string s1, string s2);
    public delegate void MetodosComTresString(string s1, string s2, string s3);
    public delegate void MetodosComSeisString(string s1, string s2, string s3, string s4, string s5, string s6);
    public delegate void ListaJogadoresDelegate(List<PReal> lp);

}
