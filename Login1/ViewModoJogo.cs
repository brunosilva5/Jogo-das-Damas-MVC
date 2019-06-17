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
    public partial class ViewModoJogo : Form
    {
        public event MetodosComUmInteiro DefineGameMode;

        public ViewModoJogo()
        {
            InitializeComponent();
        }

        private void buttonVSComputador_Click(object sender, EventArgs e)
        {
            if (DefineGameMode != null) DefineGameMode(0);
            Program.V_Jogo.ShowDialog();
            this.Hide();
        }

        private void buttonVSJogador_Click(object sender, EventArgs e)
        {
            if (DefineGameMode != null) DefineGameMode(1);
            Program.V_Jogo.ShowDialog();
            this.Hide();
        }

        private void buttonONLINE_Click(object sender, EventArgs e)
        {
            if (DefineGameMode != null) DefineGameMode(2);
            Program.V_Jogo.ShowDialog();
            this.Hide();
        }

        private void closeModeGame_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.V_Login.ShowDialog();
        }
    }
}
