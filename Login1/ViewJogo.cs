using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace CheckersGame
{
    public partial class ViewJogo : Form
    {
        public int final = 0;
        public string NomeVencedor;
        public PictureBox selecionado = new PictureBox();
        public PictureBox destino = new PictureBox();
        public string color;
        public string TagOrigem = "";
        Point PictureBoxOrigem = new Point();

        public Jogo J { get; }
        public List<PictureBox> PictureBoxList;
       
        public new event MetodosComDoisPontos Move;

        public ViewJogo()
        {
            InitializeComponent();
            Program.M_Tabuleiro.Movimento += M_Tabuleiro_Movimento1;
            Program.M_Tabuleiro.EliminaPecaView += M_Tabuleiro_EliminaPecaView;
            Program.M_Tabuleiro.PecaFicaDama += M_Tabuleiro_PecaFicaDama;
            Program.M_Tabuleiro.Vencedor += M_Tabuleiro_Vencedor;
            J = Program.M_Tabuleiro.J;

            PictureBoxList = new List<PictureBox>();
            PictureBoxList.Add(pictureBox2);  PictureBoxList.Add(pictureBox34);
            PictureBoxList.Add(pictureBox4);  PictureBoxList.Add(pictureBox36);
            PictureBoxList.Add(pictureBox6);  PictureBoxList.Add(pictureBox38);
            PictureBoxList.Add(pictureBox8);  PictureBoxList.Add(pictureBox40);
            PictureBoxList.Add(pictureBox9);  PictureBoxList.Add(pictureBox41);
            PictureBoxList.Add(pictureBox11); PictureBoxList.Add(pictureBox43);
            PictureBoxList.Add(pictureBox13); PictureBoxList.Add(pictureBox45);
            PictureBoxList.Add(pictureBox15); PictureBoxList.Add(pictureBox47);
            PictureBoxList.Add(pictureBox18); PictureBoxList.Add(pictureBox50);
            PictureBoxList.Add(pictureBox20); PictureBoxList.Add(pictureBox52);
            PictureBoxList.Add(pictureBox22); PictureBoxList.Add(pictureBox54);
            PictureBoxList.Add(pictureBox24); PictureBoxList.Add(pictureBox56);
            PictureBoxList.Add(pictureBox25); PictureBoxList.Add(pictureBox57);
            PictureBoxList.Add(pictureBox27); PictureBoxList.Add(pictureBox59);
            PictureBoxList.Add(pictureBox29); PictureBoxList.Add(pictureBox61);
            PictureBoxList.Add(pictureBox31); PictureBoxList.Add(pictureBox63);
        }

        private void M_Tabuleiro_Vencedor()
        {
            if (J.Players[0].Turn) NomeVencedor = J.Players[0].Name; 
            if (J.Players[1].Turn) NomeVencedor = J.Players[1].Name;
            labelWin.Text = NomeVencedor + " is the winner !";
            labelWin.Visible = true;
        }

        private void M_Tabuleiro_PecaFicaDama(Point movimento)
        {
            Point PecaDama = CoordenadasViewPictureBox(movimento);
            foreach(var p in PictureBoxList)
            {
                if (p.Location == PecaDama)
                {
                    if (p.Location.Y ==91)
                    {
                        p.Image = Image.FromFile("Photos\\claradama.png");
                    }
                    if (p.Location.Y == 441)
                    {
                        p.Image = Image.FromFile("Photos\\escuradama.png");
                    }
                }
            }
        }

        private void M_Tabuleiro_EliminaPecaView(int x, int y)
        {
            Point Peca = new Point();
            Peca.X = x;
            Peca.Y = y;
            Point PecaEliminar = CoordenadasViewPictureBox(Peca);

            foreach(var p in PictureBoxList)
            {
                if (p.Location == PecaEliminar)
                {
                    p.Tag = null;
                    p.Image = null;
                }
            }
        }

        private void M_Tabuleiro_Movimento1(Point movimento)
        {
            destino.Location = CoordenadasViewPictureBox(movimento);
            destino.Image = selecionado.Image;
            destino.Tag = selecionado.Tag;
            selecionado.Image = null;
            selecionado.Tag = null;
            selecionado = null;
        }

        private void TabClick(object sender, MouseEventArgs e)
        {
            //Point PictureBoxOrigem = new Point();
            if (final==1)
            {
                selecionado.BackColor = Color.Black;
                destino = ((PictureBox)sender);
                Point PictureBoxDestino = CoordenadasPictureBox(((PictureBox)sender).Location);
                if (Move!=null)
                {
                    Move(PictureBoxOrigem, PictureBoxDestino, TagOrigem);
                }
                final = 0;
            }
            else
            {
                if (J.Players[0].Turn) color = J.Players[0].Color.Name;   //Verifica a cor do jogador a jogar
                if (J.Players[1].Turn) color = J.Players[1].Color.Name;

                TagOrigem = (string)((PictureBox)sender).Tag;

                if (TagOrigem == color)                                   //Se a cor do jogador a jogar for igual à cor selecionada, faz
                {
                    PictureBoxOrigem = CoordenadasPictureBox(((PictureBox)sender).Location);
                    selecionado = ((PictureBox)sender);
                    Selecionado(selecionado);
                    final = 1;
                }
            }
        }

        public void Selecionado(PictureBox selecionado)
        {
            if (selecionado.Image != null)
            {
                selecionado.BackColor = Color.Gold;
            }
            else return;
        }

        public Point CoordenadasPictureBox(Point selecionada)
        {
            int x=-1;
            int y=-1;
            //Selecionar o ponto x da matriz
            if (selecionada.X == 162) x = 0;
            if (selecionada.X == 212) x = 1;
            if (selecionada.X == 262) x = 2;
            if (selecionada.X == 312) x = 3;
            if (selecionada.X == 362) x = 4;
            if (selecionada.X == 412) x = 5;
            if (selecionada.X == 462) x = 6;
            if (selecionada.X == 512) x = 7;

            //selecionar o ponto y da matriz
            if (selecionada.Y == 91) y = 0;
            if (selecionada.Y == 141) y = 1;
            if (selecionada.Y == 191) y = 2;
            if (selecionada.Y == 241) y = 3;
            if (selecionada.Y == 291) y = 4;
            if (selecionada.Y == 341) y = 5;
            if (selecionada.Y == 391) y = 6;
            if (selecionada.Y == 441) y = 7;

            return new Point(x, y);
        }
        public Point CoordenadasViewPictureBox(Point destino)
        {
            int x = destino.X;
            int y = destino.Y;

            if (destino.X == 0) x = 162;
            if (destino.X == 1) x = 212;
            if (destino.X == 2) x = 262;
            if (destino.X == 3) x = 312;
            if (destino.X == 4) x = 362;
            if (destino.X == 5) x = 412;
            if (destino.X == 6) x = 462;
            if (destino.X == 7) x = 512;

            if (destino.Y == 0) y = 91;
            if (destino.Y == 1) y = 141;
            if (destino.Y == 2) y = 191;
            if (destino.Y == 3) y = 241;
            if (destino.Y == 4) y = 291;
            if (destino.Y == 5) y = 341;
            if (destino.Y == 6) y = 391;
            if (destino.Y == 7) y = 441;

            return new Point(x, y);
        }











        //Button Settings
        private void buttonSettingsJogo_Click(object sender, EventArgs e)
        {
            //Using bunifu transition

            if (panelsettings.Width==220)
            {
                panelsettings.Visible = false;
                panelsettings.Width = 50;
                panelsettings.BackColor = Color.Transparent;
                buttonMyProfileMenu.Visible = false;
                buttonExitMenu.Visible = false;
                buttonAboutMenu.Visible = false;
                buttonRulesMenu.Visible = false;
                buttonLogoutMenu.Visible = false;
                buttonSettingsJogo.BackColor = Color.Transparent;
                PanelAnimator.ShowSync(panelsettings);

            }
            else
            {
                panelsettings.Visible = true;
                panelsettings.Width = 220;
                buttonMyProfileMenu.Visible = true;
                buttonExitMenu.Visible = true;
                buttonAboutMenu.Visible = true;
                buttonRulesMenu.Visible = true;
                buttonLogoutMenu.Visible = true;
                panelsettings.BackColor = Color.Silver;
                buttonSettingsJogo.BackColor = Color.Transparent;
                PanelAnimator2.ShowSync(panelsettings);
            }

        }
 

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //--------------------------------------------------------------------
        private void pictureBoxplayer1_Click(object sender, EventArgs e)
        {
            Program.V_Perfil.ShowDialog();
        }

        private void pictureBoxplayer2_Click(object sender, EventArgs e)
        {
            Program.V_Perfil.ShowDialog();
        }

        //-------------------------------------------------------------------

        private void buttonMyPerfilMenu_Click(object sender, EventArgs e)
        {
            Program.V_Perfil.ShowDialog();
            //Mostrar Editar perfil
        }

        private void buttonExitMenu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonAboutMenu_Click(object sender, EventArgs e)
        {
            panelsettings.Visible = false;
            panelsettings.Width = 50;
            panelsettings.BackColor = Color.Transparent;
            buttonMyProfileMenu.Visible = false;
            buttonExitMenu.Visible = false;
            buttonAboutMenu.Visible = false;
            buttonRulesMenu.Visible = false;
            buttonLogoutMenu.Visible = false;
            buttonSettingsJogo.BackColor = Color.Transparent;
            PanelAnimator.ShowSync(panelsettings);

            Program.V_About.ShowDialog();
        }


        private void buttonRulesMenu_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.fpdamas.pt/downloads/Regras_Damas_Cl%C3%A1ssicas_.pdf");
        }

        private void buttonLogoutMenu_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void ViewJogo_Load(object sender, EventArgs e)
        {
            if (J.Players[0].Color == Color.White)
            {
                labelplayerwhite.Text = J.Players[0].Name;
                pictureBoxplayer2.Image = J.Players[0].Photo;
                pictureBoxplayer2.SizeMode = PictureBoxSizeMode.StretchImage;

                labelplayerblack.Text = J.Players[1].Name;
                pictureBoxplayer1.Image = J.Players[1].Photo;
                pictureBoxplayer1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            if (J.Players[1].Color == Color.White)
            {
                labelplayerwhite.Text = J.Players[1].Name;
                pictureBoxplayer2.Image = J.Players[1].Photo;
                pictureBoxplayer2.SizeMode = PictureBoxSizeMode.Zoom;

                labelplayerblack.Text = J.Players[0].Name;
                pictureBoxplayer1.Image = J.Players[0].Photo;
                pictureBoxplayer1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        //--------------------------------------------------------------------
    }
}
