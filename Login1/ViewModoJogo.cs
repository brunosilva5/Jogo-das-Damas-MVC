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

        private void ViewPanelModoJogo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void closelogin_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonVSComputador_Click(object sender, EventArgs e)
        {
            ViewJogo jogar = new ViewJogo();
            jogar.ShowDialog();
        }

        private void buttonVSJogador_Click(object sender, EventArgs e)
        {
            ViewJogo jogar = new ViewJogo();
            jogar.ShowDialog();
        }

        private void buttonONLINE_Click(object sender, EventArgs e)
        {
            ViewJogo jogar = new ViewJogo();
            jogar.ShowDialog();
        }
    }
}
