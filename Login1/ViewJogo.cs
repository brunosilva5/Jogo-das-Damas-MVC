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

namespace Login1
{
    public partial class ViewJogo : Form
    {
        /*PictureBox[,] matriz = new PictureBox[8, 8];
        Jogo j = new Jogo();*/

        PictureBox selecionado = null;
        private int final = 0;

        public ViewJogo()
        {
            InitializeComponent();

            /*matriz[0, 0] = pictureBox1;
            matriz[0, 1] = pictureBox2;
            matriz[0, 2] = pictureBox3;
            matriz[0, 3] = pictureBox4;
            matriz[0, 4] = pictureBox5;
            matriz[0, 5] = pictureBox6;
            matriz[0, 6] = pictureBox7;
            matriz[0, 7] = pictureBox8;
            matriz[1, 0] = pictureBox9;
            matriz[1, 1] = pictureBox10;
            matriz[1, 2] = pictureBox11;
            matriz[1, 3] = pictureBox12;
            matriz[1, 4] = pictureBox13;
            matriz[1, 5] = pictureBox14;
            matriz[1, 6] = pictureBox15;
            matriz[1, 7] = pictureBox16;
            matriz[2, 0] = pictureBox17;
            matriz[2, 1] = pictureBox18;
            matriz[2, 2] = pictureBox19;
            matriz[2, 3] = pictureBox20;
            matriz[2, 4] = pictureBox21;
            matriz[2, 5] = pictureBox22;
            matriz[2, 6] = pictureBox23;
            matriz[2, 7] = pictureBox24;
            matriz[3, 0] = pictureBox25;
            matriz[3, 1] = pictureBox26;
            matriz[3, 2] = pictureBox27;
            matriz[3, 3] = pictureBox28;
            matriz[3, 4] = pictureBox29;
            matriz[3, 5] = pictureBox30;
            matriz[3, 6] = pictureBox31;
            matriz[3, 7] = pictureBox32;
            matriz[4, 0] = pictureBox33;
            matriz[4, 1] = pictureBox34;
            matriz[4, 2] = pictureBox35;
            matriz[4, 3] = pictureBox36;
            matriz[4, 4] = pictureBox37;
            matriz[4, 5] = pictureBox38;
            matriz[4, 6] = pictureBox39;
            matriz[4, 7] = pictureBox40;
            matriz[5, 0] = pictureBox41;
            matriz[5, 1] = pictureBox42;
            matriz[5, 2] = pictureBox43;
            matriz[5, 3] = pictureBox44;
            matriz[5, 4] = pictureBox45;
            matriz[5, 5] = pictureBox46;
            matriz[5, 6] = pictureBox47;
            matriz[5, 7] = pictureBox48;
            matriz[6, 0] = pictureBox50;
            matriz[6, 1] = pictureBox51;
            matriz[6, 2] = pictureBox52;
            matriz[6, 3] = pictureBox53;
            matriz[6, 4] = pictureBox54;
            matriz[6, 5] = pictureBox55;
            matriz[6, 6] = pictureBox56;
            matriz[6, 7] = pictureBox57;
            matriz[7, 0] = pictureBox58;
            matriz[7, 1] = pictureBox59;
            matriz[7, 2] = pictureBox60;
            matriz[7, 3] = pictureBox61;
            matriz[7, 4] = pictureBox62;
            matriz[7, 5] = pictureBox63;
            matriz[7, 6] = pictureBox64;
            matriz[7, 7] = pictureBox64;

            DesenhaPecas(j.Tabuleiro);*/

        }

        private void TabClick(object sender, MouseEventArgs e)
        {
            if (final==1)Movimento((PictureBox)sender);
            else Selecao(sender);

        }

        public void Selecao(object obj)
        {
            try
            {
                selecionado.BackColor = Color.Black;
            }
            catch { }

            selecionado = (PictureBox)obj;
            selecionado.BackColor = Color.Gold;
            final = 1;
        }

        private void Movimento(PictureBox destino)
        {
            if (selecionado == null)
            {
                return;
            }
            destino.BackgroundImage = selecionado.BackgroundImage;

            selecionado.BackgroundImage = null;
            selecionado.BackColor = Color.Black;
            selecionado = null;
            final = 0;
            
        }


        /*private void DesenhaPecas(List<Peca> tabuleiro)
        {
            foreach (Peca p in tabuleiro)
            {
                MostraPecaTabuleiro(p);
            }
        }

        private void MapeiaTabuleiro(bool brancas)
        {
            char letra;
            int numero;

            if (brancas)
            {
                numero = 1;
            }
            else
            {
                numero = 8;
            }
            for (int i = 0; i < 8; i++)
            {
                if (brancas)
                {
                    letra = 'A';
                }
                else
                {
                    letra = 'H';
                }
                for (int j = 0; j < 8; j++)
                {
                    matriz[i, j].Name = letra + numero.ToString();
                    if (brancas)
                    {
                        letra++;
                    }
                    else
                    {
                        letra--;
                    }
                }
                if (brancas)
                {
                    numero++;
                }
                else
                {
                    numero--;
                }
            }
            if (brancas)
            {
                labelC1.Text = "A";
                labelC2.Text = "B";
                labelC3.Text = "C";
                labelC4.Text = "D";
                labelC5.Text = "E";
                labelC6.Text = "F";
                labelC7.Text = "G";
                labelC8.Text = "H";
                labelL1.Text = "1";
                labelL2.Text = "2";
                labelL3.Text = "3";
                labelL4.Text = "4";
                labelL5.Text = "5";
                labelL6.Text = "6";
                labelL7.Text = "7";
                labelL8.Text = "8";
            }
            else
            {
                labelC1.Text = "H";
                labelC2.Text = "G";
                labelC3.Text = "F";
                labelC4.Text = "E";               
                labelC5.Text = "D";
                labelC6.Text = "C";
                labelC7.Text = "B";
                labelC8.Text = "A";
                labelL1.Text = "8";
                labelL2.Text = "7";
                labelL3.Text = "6";
                labelL4.Text = "5";
                labelL5.Text = "4";
                labelL6.Text = "3";
                labelL7.Text = "2";
                labelL8.Text = "1";
            }
        }*/


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
                panelsettings.BackColor = Color.Silver;
                buttonSettingsJogo.BackColor = Color.Transparent;
                PanelAnimator2.ShowSync(panelsettings);
            }

        }
 

        /*private void MostraPecaTabuleiro(Peca peca)
        {
            PictureBox pp = this.Controls.Find(peca.Posicao, false)[0] as PictureBox;

            if (peca.Branca)
                pp.Image = Image.FromFile("Imagens//clara.png");
            else
                pp.Image = Image.FromFile("Imagens//escura.png");
        }*/

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
            buttonSettingsJogo.BackColor = Color.Transparent;
            PanelAnimator.ShowSync(panelsettings);

            Program.V_About.ShowDialog();
        }


        private void buttonRulesMenu_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.fpdamas.pt/downloads/Regras_Damas_Cl%C3%A1ssicas_.pdf");
        }

        //--------------------------------------------------------------------
    }
}
