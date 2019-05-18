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
    public partial class ViewPerfil : Form
    {
        public ViewPerfil()
        {
            InitializeComponent();
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonUpdatePhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();  //criar uma file dialog
            dlg.Filter = "Imagens |*.jpg|Todos os Ficheiros|*.*";   //filtrar
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                pictureBoxPerfil.ImageLocation = dlg.FileName;
                pictureBoxPerfil.BackgroundImage = null;
            }
        }
    }
}
