using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login1
{
    public partial class ViewModoJogo : Form
    {
        public ViewModoJogo()
        {
            InitializeComponent();
        }

        private void buttonVSComputador_Click(object sender, EventArgs e)
        {
            Program.V_Jogo.ShowDialog();
            this.Visible = false;

        }

        private void buttonVSJogador_Click(object sender, EventArgs e)
        {
            Program.V_Jogo.ShowDialog();
            this.Visible = false;

        }

        private void buttonONLINE_Click(object sender, EventArgs e)
        {
            Program.V_Jogo.ShowDialog();
            this.Visible = false;
        }

        private void closeModeGame_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.V_Login.Visible = true;
        }
    }
}
