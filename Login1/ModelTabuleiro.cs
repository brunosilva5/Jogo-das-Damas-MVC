using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

using System.Data.SqlClient;

namespace CheckersGame
{
    public class ModelTabuleiro
    {
        public const int INVALID = -1;
        public const int VAZIO = 0;
        public const int BLACK = 2;
        public const int WHITE = 1;

        public Jogo J { get; private set; }
        public event MetodosComUmPonto Movimento;
        public event MetodosComDoisInteiros EliminaPecaView;
        public event MetodosComUmPonto PecaFicaDama;
        public event MetodosSemParametros Vencedor;

        public int aux = 0;

        public ModelTabuleiro()
        {
            J = new Jogo();
        }

        public void Move(Point origem, Point destino,string cor)
        {
            // Se a peça selecionada for Dama!
            if (J.CheckDamaSelect(origem))
            {
                if ((origem.X) - 1 == (destino.X) && (origem.Y) - 1 == (destino.Y) || (origem.X) + 1 == (destino.X) && (origem.Y) - 1 == (destino.Y) ||
                    (origem.X) + 1 == (destino.X) && (origem.Y) + 1 == (destino.Y) || (origem.X) - 1 == (destino.X) && (origem.Y) + 1 == (destino.Y))
                {
                    if(Mover(origem, destino))J.ChangeTurn();
                }
                if (cor == "White")
                {
                    if ((origem.X) - 2 == (destino.X) && (origem.Y) - 2 == (destino.Y) && J.matriz[origem.X - 1, origem.Y - 1] == BLACK //Comer peça preta cima lado esquerdo
                    || (origem.X) + 2 == (destino.X) && (origem.Y) - 2 == (destino.Y) && J.matriz[origem.X + 1, origem.Y - 1] == BLACK  //Comer peça preta cima lado direito
                    || (origem.X) + 2 == (destino.X) && (origem.Y) + 2 == (destino.Y) && J.matriz[origem.X + 1, origem.Y + 1] == BLACK  //Comer peça preta baixo lado direito
                    || (origem.X) - 2 == (destino.X) && (origem.Y) + 2 == (destino.Y) && J.matriz[origem.X - 1, origem.Y + 1] == BLACK) //Comer peça preta baixo lado esquerdo
                    {
                        if(MoverComer(origem, destino))J.ChangeTurn();       // Move a peça na matriz, faz update da lista de peças e lança evento para mover tabuleiro
                    }
                }
                if (cor == "Black")                        //Executa o mesmo codigo de cima, só que para a Dama preta
                {
                    if ((origem.X) - 2 == (destino.X) && (origem.Y) - 2 == (destino.Y) && J.matriz[origem.X - 1, origem.Y - 1] == WHITE //Comer peça branca cima lado esquerdo
                    || (origem.X) + 2 == (destino.X) && (origem.Y) - 2 == (destino.Y) && J.matriz[origem.X + 1, origem.Y - 1] == WHITE  //Comer peça branca cima lado direito
                    || (origem.X) + 2 == (destino.X) && (origem.Y) + 2 == (destino.Y) && J.matriz[origem.X + 1, origem.Y + 1] == WHITE  //Comer peça branca baixo lado direito
                    || (origem.X) - 2 == (destino.X) && (origem.Y) + 2 == (destino.Y) && J.matriz[origem.X - 1, origem.Y + 1] == WHITE) //Comer peça branca baixo lado esquerdo
                    {
                        if(MoverComer(origem, destino)) J.ChangeTurn();       // Move a peça na matriz, faz update da lista de peças e lança evento para mover tabuleiro
                    }
                }
                return;
            }


            // Se a peça selecionada for uma peça "normal"
            if (cor == "White")                            // Se a peça selecionada for uma peça branca
            {
                if ((origem.X)-1==(destino.X)&&(origem.Y)-1==(destino.Y)||(origem.X)+1==(destino.X)&&(origem.Y)-1==(destino.Y))// Movimento peça diagonal
                {
                    if(Mover(origem, destino))J.ChangeTurn();// Move a peça na matriz e lança evento para mover tabuleiro, caso retorne true a vez é alterada
                    if (J.CheckDama(destino))              // Verifica se ficou dama, retorna true se afirmativo
                    {
                        if (PecaFicaDama != null) PecaFicaDama(destino);
                    }
                }
                if ((origem.X) - 2 == (destino.X) && (origem.Y) - 2 == (destino.Y) && J.matriz[origem.X-1, origem.Y-1]== BLACK //Comer peça preta lado esquerdo
                    || (origem.X) + 2 == (destino.X) && (origem.Y) - 2 == (destino.Y) && J.matriz[origem.X + 1, origem.Y - 1] == BLACK)//Comer peça preta lado direito
                {
                    if(MoverComer(origem, destino))J.ChangeTurn();            // Move a peça na matriz e lança evento para mover tabuleiro

                    if (J.CheckDama(destino))              // Verifica se ficou dama, retorna true se afirmativo
                    {
                        if (PecaFicaDama != null) PecaFicaDama(destino);
                    }
                }
            }
            else                                           // Se a peça selecionada for uma peça branca
            {
                if ((origem.X) + 1 == (destino.X) && (origem.Y) + 1 == (destino.Y) || (origem.X) - 1 == (destino.X) && (origem.Y) + 1 == (destino.Y))// Movimento peça diagonal
                {
                    if(Mover(origem, destino))J.ChangeTurn(); 
                    if (J.CheckDama(destino))              // Verifica se ficou dama, retorna true se afirmativo
                    {
                        if (PecaFicaDama != null) PecaFicaDama(destino);
                    }
                }
                if ((origem.X) + 2 == (destino.X) && (origem.Y) + 2 == (destino.Y) && J.matriz[origem.X + 1, origem.Y + 1] == WHITE
                    || (origem.X) - 2 == (destino.X) && (origem.Y) + 2 == (destino.Y) && J.matriz[origem.X - 1, origem.Y + 1] == WHITE)//Comer peça
                {
                    if(MoverComer(origem, destino))J.ChangeTurn();

                    if (J.CheckDama(destino))              // Verifica se ficou dama, retorna true se afirmativo
                    {
                        if (PecaFicaDama != null) PecaFicaDama(destino);
                    }
                }
            }
        }

        public bool Mover(Point origem, Point destino)
        {
            if (J.matriz[destino.X, destino.Y] == VAZIO)
            {
                if (Movimento != null)
                {
                    Movimento(destino);
                }
                aux = J.matriz[origem.X, origem.Y];
                J.matriz[origem.X, origem.Y] = VAZIO;
                J.matriz[destino.X, destino.Y] = aux;
                J.UpdatePiecesList(origem, destino);   // Faz update da lista de pecas do jogador que jogou
                return true;
            }
            return false;
        }
        public bool MoverComer(Point origem, Point destino)
        {
            if (J.matriz[destino.X, destino.Y] == VAZIO) // Verifica se a casa destino está vazia
            {
                if (Movimento != null)
                {
                    Movimento(destino);                  // Excuta movimento na view
                }
                aux = J.matriz[origem.X, origem.Y];
                J.matriz[origem.X, origem.Y] = VAZIO;
                J.matriz[destino.X, destino.Y] = aux;
                J.UpdatePiecesList(origem, destino);     // Faz update da lista de pecas do jogador que jogou
                // Comer
                J.matriz[((origem.X + destino.X) / 2), ((origem.Y + destino.Y) / 2)] = VAZIO;     // Altera valor da matriz na posição da peça comida
                J.RemovePieceList(((origem.X + destino.X) / 2), ((origem.Y + destino.Y) / 2));    // Remove peca na lista de peças do jogador
                if (EliminaPecaView != null) EliminaPecaView(((origem.X + destino.X) / 2), ((origem.Y + destino.Y) / 2));
                CheckGameWin();                          // Como houve uma peça comida, verifica se alguém ganhou

                return true;
            }
            return false;
        }

        public void CheckGameWin()
        {
            if (J.CheckWin())
            {
                //Apresenta Vencedor
                if (Vencedor != null) Vencedor();
                //Atualizad dados jogador
                if (J.Players[0].Turn)
                {
                    J.Players[0].NumGames = J.Players[0].NumGames +1;
                    J.Players[0].NumWins = J.Players[0].NumWins + 1;
                    J.Players[1].NumGames = J.Players[1].NumGames + 1;
                    J.Players[1].NumDefeats = J.Players[1].NumDefeats + 1;
                }
                if (J.Players[1].Turn)
                {
                    J.Players[1].NumGames = J.Players[1].NumGames + 1;
                    J.Players[1].NumWins = J.Players[1].NumWins + 1;
                    J.Players[0].NumGames = J.Players[0].NumGames + 1;
                    J.Players[0].NumDefeats = J.Players[0].NumDefeats + 1;
                }
                //Atualiza BD
                UpdateDatabase(0);                            // Update database jogador 0
                if (J.Game_Mode == Jogo.GAMEMODE.MULTIPLAYER) // Caso haja 2 players atualiza o segundo na bd
                {
                    //UpdateDatabase(1);                      // Update database jogador 1
                }

                return;//não será necessário o return
            }
        }







        public void UpdateDatabase(int Turn)
        {
            //para poder reutilizar a base de dados, caso contrário, ele está sempre a substituir
            var folder = AppDomain.CurrentDomain.BaseDirectory.Replace("\\bin\\Debug", "");

            //construir a ligação ao servidor SQL Server local com o caminho do ficheiro
            string sqlConnection = "Server=(localdb)\\MSSQLLocalDB;AttachDbFilename=" + folder + "Utilizadores.mdf" +
                                     ";Trusted_Connection=True;";

            //inicializar a ligação ao servidor
            SqlConnection server = new SqlConnection(sqlConnection);

            //abrir a ligação
            server.Open();

            string cmdText = String.Format("UPDATE Users SET NumGames = '" + J.Players[Turn].NumGames.ToString() + "', NumWins = '" + J.Players[Turn].NumWins.ToString() + "', NumDefeats = '" + J.Players[Turn].NumDefeats.ToString() + "' WHERE username = '" + (J.Players[Turn] as PReal).Username + "'");
            //construir o comando SQL com a ligação ao servidor
            SqlCommand command = new SqlCommand(cmdText, server);
            command.ExecuteNonQuery();

            server.Close();
        }

        public void DefineGameMode(int gamemode)
        {
            J.DefineGameMode(gamemode);
        }
    }
}
