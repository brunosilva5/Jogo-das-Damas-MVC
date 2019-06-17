using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckersGame
{
    public class ControllerTabuleiro
    {
        public ControllerTabuleiro()
        {
            Program.V_Jogo.Move += V_Jogo_Move;
            Program.V_ModoJogo.DefineGameMode += V_ModoJogo_DefineGameMode;
        }

        private void V_ModoJogo_DefineGameMode(int gamemode)
        {
            Program.M_Tabuleiro.DefineGameMode(gamemode);
        }

        private void V_Jogo_Move(System.Drawing.Point origem, System.Drawing.Point destino, string cor)
        {
            Program.M_Tabuleiro.Move(origem, destino, cor);
        }
    }
}
