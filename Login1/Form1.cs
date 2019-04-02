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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void closelogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void signupbutton_Click(object sender, EventArgs e)
        {
            Registar registar = new Registar();
            registar.ShowDialog();
        }

        private void UsernameEnter(object sender, EventArgs e)
        {
            if (textboxUsername.Text == "Username")
            {
                textboxUsername.Text = "";
            }
        }

        private void UsernameLeave(object sender, EventArgs e)
        {
            if (textboxUsername.Text == "")
            {
                textboxUsername.Text = "Username";
            }
        }
    }
}
