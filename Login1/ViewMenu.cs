using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckersGame
{
    public partial class ViewMenu : Form
    {
        public ViewMenu()
        {
            InitializeComponent();
        }

        private void buttonMenuPlay_Click(object sender, EventArgs e)
        {
            Program.V_ModoJogo.ShowDialog();
            this.Visible = false;
        }

        private void buttonMenuProfile_Click(object sender, EventArgs e)
        {
            Program.V_Perfil.Show();
            Program.V_Menu.Visible = false;
        }

        private void buttonMenuRules_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.fpdamas.pt/downloads/Regras_Damas_Cl%C3%A1ssicas_.pdf");
        }

        private void buttonMenuLogOut_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void closelogin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
