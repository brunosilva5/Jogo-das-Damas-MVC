using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckersGame
{
    public partial class ViewPerfil : Form
    {
        Jogo J { get; }
        PReal P;
        public ViewPerfil()
        {
            InitializeComponent();
            J = Program.M_Tabuleiro.J;
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            Program.V_Menu.Visible = true;
            this.Hide();
        }

        private void buttonUpdatePhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();  //criar uma file dialog
            dlg.Filter = "Imagens |*.jpg|Todos os Ficheiros|*.*";   //filtrar
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                pictureBoxProfile.ImageLocation = dlg.FileName;
                pictureBoxProfile.BackgroundImage = null;
            }
        }

        private void ViewPerfil_Load(object sender, EventArgs e)
        {
            textBoxProfileName.Text = J.Players[0].Name;
            textBoxProfileUserame.Text = (J.Players[0] as PReal).Username;
            textBoxProfileCountry.Text = (J.Players[0] as PReal).Country;
            textBoxProfileEmail.Text = (J.Players[0] as PReal).Email;
            textBoxNumGames.Text = J.Players[0].NumGames.ToString();
            textBoxNumWins.Text = J.Players[0].NumWins.ToString();
            textBoxNumDefeats.Text = J.Players[0].NumDefeats.ToString();
            textBoxNumLeave.Text = J.Players[0].NumLeave.ToString();
            pictureBoxProfile.Image = (J.Players[0] as PReal).Photo;

        }
    }
}
