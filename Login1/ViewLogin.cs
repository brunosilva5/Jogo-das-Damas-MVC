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
    public partial class ViewLogin : Form
    {
        public ViewLogin()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }


        private void signupbutton_Click(object sender, EventArgs e)
        {
            ViewRegistar registar = new ViewRegistar();
            registar.ShowDialog();
        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            ViewJogo jogar = new ViewJogo();
            jogar.ShowDialog();
        }


        //-----------------------------------------------------------
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

        private void textboxPassword_Enter(object sender, EventArgs e)
        {
            if (textboxPassword.Text == "Password")
            {
                textboxPassword.Text = "";
                textboxPassword.isPassword = true;
            }
        }

        private void textboxPassword_Leave(object sender, EventArgs e)
        {
            if (textboxPassword.Text == "")
            {
                textboxPassword.isPassword = false;
                textboxPassword.Text = "Password";
            }
        }
        //-----------------------------------------------------------





        private void closelogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
