using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CheckersGame
{
    public class Jogo
    {
        //Definir nomes para o estado de cada ponto da matriz
        public const int INVALID = -1;
        public const int VAZIO = 0;
        public const int BLACK = 2;
        public const int WHITE = 1;
        public enum GAMEMODE { PC, MULTIPLAYER, ONLINE };
        public GAMEMODE Game_Mode;

        public List<Player> Players { get; set; }
        public List<Peca> ListaPecas { get; set; }

        public int[,] matriz = new int[8, 8];

        public int turn;
        
        public Jogo()
        {
            Players = new List<Player>();
            ListaPecas = new List<Peca>();

            // SUBSITUIR ESTES EVENTOS POR METODOS
            //Program.M_Damas.AddPlayer += M_Damas_AddPlayer;
            //Program.M_Tabuleiro.ModoJogo += M_Tabuleiro_ModoJogo;

            matriz[0, 0] = BLACK;
            matriz[1, 0] = INVALID;
            matriz[2, 0] = BLACK;
            matriz[3, 0] = INVALID;
            matriz[4, 0] = BLACK;
            matriz[5, 0] = INVALID;
            matriz[6, 0] = BLACK;
            matriz[7, 0] = INVALID;
            matriz[0, 1] = INVALID;
            matriz[1, 1] = BLACK;
            matriz[2, 1] = INVALID;
            matriz[3, 1] = BLACK;
            matriz[4, 1] = INVALID;
            matriz[5, 1] = BLACK;
            matriz[6, 1] = INVALID;
            matriz[7, 1] = BLACK;
            matriz[0, 2] = BLACK;
            matriz[1, 2] = INVALID;
            matriz[2, 2] = BLACK;
            matriz[3, 2] = INVALID;
            matriz[4, 2] = BLACK;
            matriz[5, 2] = INVALID;
            matriz[6, 2] = BLACK;
            matriz[7, 2] = INVALID;
            matriz[0, 3] = INVALID;
            matriz[1, 3] = VAZIO;
            matriz[2, 3] = INVALID;
            matriz[3, 3] = VAZIO;
            matriz[4, 3] = INVALID;
            matriz[5, 3] = VAZIO;
            matriz[6, 3] = INVALID;
            matriz[7, 3] = VAZIO;
            matriz[0, 4] = VAZIO;
            matriz[1, 4] = INVALID;
            matriz[2, 4] = VAZIO;
            matriz[3, 4] = INVALID;
            matriz[4, 4] = VAZIO;
            matriz[5, 4] = INVALID;
            matriz[6, 4] = VAZIO;
            matriz[7, 4] = INVALID;
            matriz[0, 5] = INVALID;
            matriz[1, 5] = WHITE;
            matriz[2, 5] = INVALID;
            matriz[3, 5] = WHITE;
            matriz[4, 5] = INVALID;
            matriz[5, 5] = WHITE;
            matriz[6, 5] = INVALID;
            matriz[7, 5] = WHITE;
            matriz[0, 6] = WHITE;
            matriz[1, 6] = INVALID;
            matriz[2, 6] = WHITE;
            matriz[3, 6] = INVALID;
            matriz[4, 6] = WHITE;
            matriz[5, 6] = INVALID;
            matriz[6, 6] = WHITE;
            matriz[7, 6] = INVALID;
            matriz[0, 7] = INVALID;
            matriz[1, 7] = WHITE;
            matriz[2, 7] = INVALID;
            matriz[3, 7] = WHITE;
            matriz[4, 7] = INVALID;
            matriz[5, 7] = WHITE;
            matriz[6, 7] = INVALID;
            matriz[7, 7] = WHITE;
        }

        // VE BEM
        // vou fazer para o modo jog, da menos trabalho
        public void DefineGameMode(int val)
        {
            Game_Mode = (GAMEMODE)val;

            if (Game_Mode == GAMEMODE.PC)
            {

            }
            if (Game_Mode == GAMEMODE.MULTIPLAYER)
            {

                Program.M_Tabuleiro.J.AddPlayer(new GuessPlayer("GuessPlayer", "guessplayer", "guessplayer", "PT", "guess@guess.com", "User.png"));

                Random rnd = new Random();
                int numrnd = rnd.Next(1, 3);

                if (numrnd == 1)
                {
                    Players[0].ListaPecas.Add(new Peca(Color.White, new Point(1, 5), false));
                    Players[0].ListaPecas.Add(new Peca(Color.White, new Point(3, 5), false));
                    Players[0].ListaPecas.Add(new Peca(Color.White, new Point(5, 5), false));
                    Players[0].ListaPecas.Add(new Peca(Color.White, new Point(7, 5), false));
                    Players[0].ListaPecas.Add(new Peca(Color.White, new Point(0, 6), false));
                    Players[0].ListaPecas.Add(new Peca(Color.White, new Point(2, 6), false));
                    Players[0].ListaPecas.Add(new Peca(Color.White, new Point(4, 6), false));
                    Players[0].ListaPecas.Add(new Peca(Color.White, new Point(6, 6), false));
                    Players[0].ListaPecas.Add(new Peca(Color.White, new Point(1, 7), false));
                    Players[0].ListaPecas.Add(new Peca(Color.White, new Point(3, 7), false));
                    Players[0].ListaPecas.Add(new Peca(Color.White, new Point(5, 7), false));
                    Players[0].ListaPecas.Add(new Peca(Color.White, new Point(7, 7), false));

                    Players[1].ListaPecas.Add(new Peca(Color.Black, new Point(0, 0), false));
                    Players[1].ListaPecas.Add(new Peca(Color.Black, new Point(2, 0), false));
                    Players[1].ListaPecas.Add(new Peca(Color.Black, new Point(4, 0), false));
                    Players[1].ListaPecas.Add(new Peca(Color.Black, new Point(6, 0), false));
                    Players[1].ListaPecas.Add(new Peca(Color.Black, new Point(1, 1), false));
                    Players[1].ListaPecas.Add(new Peca(Color.Black, new Point(3, 1), false));
                    Players[1].ListaPecas.Add(new Peca(Color.Black, new Point(5, 1), false));
                    Players[1].ListaPecas.Add(new Peca(Color.Black, new Point(7, 1), false));
                    Players[1].ListaPecas.Add(new Peca(Color.Black, new Point(0, 2), false));
                    Players[1].ListaPecas.Add(new Peca(Color.Black, new Point(2, 2), false));
                    Players[1].ListaPecas.Add(new Peca(Color.Black, new Point(4, 2), false));
                    Players[1].ListaPecas.Add(new Peca(Color.Black, new Point(6, 2), false));

                    Players[0].Color = Color.White;
                    Players[1].Color = Color.Black;
                    Players[0].Turn = true;
                }
                else
                {
                    Players[1].ListaPecas.Add(new Peca(Color.White, new Point(1, 5), false));
                    Players[1].ListaPecas.Add(new Peca(Color.White, new Point(3, 5), false));
                    Players[1].ListaPecas.Add(new Peca(Color.White, new Point(5, 5), false));
                    Players[1].ListaPecas.Add(new Peca(Color.White, new Point(7, 5), false));
                    Players[1].ListaPecas.Add(new Peca(Color.White, new Point(0, 6), false));
                    Players[1].ListaPecas.Add(new Peca(Color.White, new Point(2, 6), false));
                    Players[1].ListaPecas.Add(new Peca(Color.White, new Point(4, 6), false));
                    Players[1].ListaPecas.Add(new Peca(Color.White, new Point(6, 6), false));
                    Players[1].ListaPecas.Add(new Peca(Color.White, new Point(1, 7), false));
                    Players[1].ListaPecas.Add(new Peca(Color.White, new Point(3, 7), false));
                    Players[1].ListaPecas.Add(new Peca(Color.White, new Point(5, 7), false));
                    Players[1].ListaPecas.Add(new Peca(Color.White, new Point(7, 7), false));

                    Players[0].ListaPecas.Add(new Peca(Color.Black, new Point(0, 0), false));
                    Players[0].ListaPecas.Add(new Peca(Color.Black, new Point(2, 0), false));
                    Players[0].ListaPecas.Add(new Peca(Color.Black, new Point(4, 0), false));
                    Players[0].ListaPecas.Add(new Peca(Color.Black, new Point(6, 0), false));
                    Players[0].ListaPecas.Add(new Peca(Color.Black, new Point(1, 1), false));
                    Players[0].ListaPecas.Add(new Peca(Color.Black, new Point(3, 1), false));
                    Players[0].ListaPecas.Add(new Peca(Color.Black, new Point(5, 1), false));
                    Players[0].ListaPecas.Add(new Peca(Color.Black, new Point(7, 1), false));
                    Players[0].ListaPecas.Add(new Peca(Color.Black, new Point(0, 2), false));
                    Players[0].ListaPecas.Add(new Peca(Color.Black, new Point(2, 2), false));
                    Players[0].ListaPecas.Add(new Peca(Color.Black, new Point(4, 2), false));
                    Players[0].ListaPecas.Add(new Peca(Color.Black, new Point(6, 2), false));

                    Players[0].Color = Color.Black;
                    Players[1].Color = Color.White;
                    Players[1].Turn = true;
                }
            }
        }

        public bool CheckDamaSelect(Point origem) //Este metodo serve para verificar se a peça selecionada é uma Dama
        {
            if (Players[0].Turn == true) turn = 0;
            if (Players[1].Turn == true) turn = 1;
            foreach (var p in Players[turn].ListaPecas)
            {
                if (p.Posicao == origem && p.Dama == true)
                {
                    return true;
                }
            }
            return false;
        }

        public bool CheckDama(Point destino)
        {
            if (Players[0].Turn == true) turn = 1;
            if (Players[1].Turn == true) turn = 0;
            foreach (var p in Players[turn].ListaPecas)
            {
                if (p.Cor == Color.White)
                {
                    if (p.Posicao == destino && destino.Y == 0)
                    {
                        p.Dama = true;
                        return true;
                    }
                }
                if (p.Cor == Color.Black)
                {
                    if (p.Posicao == destino && destino.Y == 7)
                    {
                        p.Dama = true;
                        return true;
                    }
                }
            }
            return false;
        }

        public void ChangeTurn()
        {
            if (Players[0].Turn == true)
            {
                Players[0].Turn = false;
                Players[1].Turn = true;
            }
            else
            {
                Players[1].Turn = false;
                Players[0].Turn = true;
            }
        }

        public void UpdatePiecesList(Point origem, Point destino)
        {
            if (Players[0].Turn == true) turn = 0;
            if (Players[1].Turn == true) turn = 1;

            foreach (var p in Players[turn].ListaPecas)
            {
                if (p.Posicao == origem)
                {
                    p.Posicao = destino;
                }
            }
        }

        public void RemovePieceList(int x, int y)
        {
            if (Players[0].Turn == true) turn = 1;
            if (Players[1].Turn == true) turn = 0;

            foreach (var p in Players[turn].ListaPecas)
            {
                if (p.Posicao.X == x && p.Posicao.Y == y)
                {
                    Players[turn].ListaPecas.Remove(p);
                    return;
                }
            }
        }

        public bool CheckWin()
        {
            if (Players[0].Turn == true) turn = 1;
            if (Players[1].Turn == true) turn = 0;

            if (Players[turn].ListaPecas.Count == 0)
            {
                return true;
            }
            return false;
        }

        public void AddPlayer(string s1, string s2, string s3, string s4, string s5, string s6, string s7, string s8, string s9, string s10)
        {
            if (Players.Count == 0)
            {
                PReal P = new PReal(s1, s2, s3, s4, s5, s6, s7, s8, s9, s10);
                AddPlayer(P);
            }
            else
            {
                GuessPlayer P2 = new GuessPlayer(s1, s2, s3, s4, s5, s6);
                AddPlayer(P2);
            }
        }

        public void AddPlayer(Player p)
        {
            if (Players.Count<2)
            {
                Players.Add(p);
            }
        }

    }
}
