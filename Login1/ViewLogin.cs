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
    public partial class ViewLogin : Form
    {
        public event MetodosSemParametros UserQuit;
        public event MetodosComDuasString UserLogin;


        public ViewLogin()
        {
            InitializeComponent();
            Program.M_Damas.LoginSuccessful += M_Damas_LoginSuccessful;
        }

        private void signupbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.V_Registar.Show(); //Showdialog não funciona corretamente 
        }
        private void loginbutton_Click(object sender, EventArgs e)
        {
            if (UserLogin != null) UserLogin(textboxUsername.Text, textboxPassword.Text);

        }
        private void M_Damas_LoginSuccessful()
        {
            this.Hide();
            Program.V_Menu.ShowDialog();
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
            if (UserQuit != null) UserQuit();
        }

    }
}
