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
using System.Globalization;
using System.IO;

namespace CheckersGame
{

    public partial class ViewRegistar : Form
    {
        public event MetodosComSeisString UserRegistered;
        public event MetodosSemParametros ComboBoxCountries;

        OpenFileDialog openPhoto;


        public ViewRegistar()
        {
            InitializeComponent();
            Program.M_Damas.msg += M_Damas_msg;
            Program.M_Damas.CountriesComboBox += M_Damas_CountriesComboBox;

            // configura o componente para escolher a fotografia
            openPhoto = new OpenFileDialog();
            openPhoto.CheckFileExists = true;
            openPhoto.CheckPathExists = true;
            openPhoto.Filter = "Imagens|*.jpg;*.png;*.bmp|Ficheiros JPG|*.jpg|Ficheiros PNG|*.png|Ficheiros BMP|*.bmp|Todos os Ficheiros|*.*";
        }

        private void M_Damas_CountriesComboBox(List<string> countries)
        {
            //add list à combobox
            comboBox1.Items.Add(countries);
            
            bunifuDropdown1.AddItem(Convert.ToString(countries));
        }

        private void ViewRegistar_Load(object sender, EventArgs e)
        {
            if (ComboBoxCountries != null)
            {
                ComboBoxCountries();
            }
        }

        //---------------------------------------------------------------------
        private void textBoxNameRegistar_Enter(object sender, EventArgs e)
        {
            if (textBoxNameRegistar.Text == "Name") textBoxNameRegistar.Text = "";
        }
        private void textBoxNameRegistar_Leave(object sender, EventArgs e)
        {
            if (textBoxNameRegistar.Text == "") textBoxNameRegistar.Text = "Name";
        }
        private void UsernameEnter(object sender, EventArgs e)
        {
            if (textboxUsernameRegistar.Text == "Username") textboxUsernameRegistar.Text = "";
        }
        private void UsernameLeave(object sender, EventArgs e)
        {
            if (textboxUsernameRegistar.Text == "") textboxUsernameRegistar.Text = "Username";
        }
        private void textBoxEmailRegistar_Enter(object sender, EventArgs e)
        {
            if (textBoxEmailRegistar.Text == "Email") textBoxEmailRegistar.Text = "";
        }
        private void textBoxEmailRegistar_Leave(object sender, EventArgs e)
        {
            if (textBoxEmailRegistar.Text == "") textBoxEmailRegistar.Text = "Email";
        }
        private void textboxPasswordRegistar_Enter(object sender, EventArgs e)
        {
            if (textboxPasswordRegistar.Text == "Password")
            {
                textboxPasswordRegistar.Text = "";
                textboxPasswordRegistar.isPassword = true;
            }
        }
        private void textboxPasswordRegistar_Leave(object sender, EventArgs e)
        {
            if (textboxPasswordRegistar.Text == "")
            {
                textboxPasswordRegistar.isPassword = false;
                textboxPasswordRegistar.Text = "Password";
            }
        }
        private void textboxConfirmarPassword_Enter(object sender, EventArgs e)
        {
            if (textboxConfirmarPassword.Text == "Confirm Password")
            {
                textboxConfirmarPassword.Text = "";
                textboxConfirmarPassword.isPassword = true;
            }
        }
        private void textboxConfirmarPassword_Leave(object sender, EventArgs e)
        {
            if (textboxConfirmarPassword.Text == "")
            {
                textboxConfirmarPassword.isPassword = false;
                textboxConfirmarPassword.Text = "Password";
            }
        }
        //--------------------------------------------------------------------






        private void backbutton_Click(object sender, EventArgs e)
        {
            Program.V_Login.Visible = true;
            this.Close();
        }

        private void buttonPhotoRegistar_Click(object sender, EventArgs e)
        {
            if (openPhoto.ShowDialog() == DialogResult.OK)
            { }
        }

        private void registarbutton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxNameRegistar.Text) ||
                string.IsNullOrWhiteSpace(textboxUsernameRegistar.Text) ||
                string.IsNullOrWhiteSpace(textboxPasswordRegistar.Text) ||
                string.IsNullOrWhiteSpace(openPhoto.FileName))
            {
                MessageBox.Show("Missing fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textboxPasswordRegistar.Text != textboxConfirmarPassword.Text)
            {
                MessageBox.Show("Password doesn't mach");
            }
            else
            {
                if (UserRegistered != null)
                    UserRegistered(textboxUsernameRegistar.Text, textBoxNameRegistar.Text, textboxPasswordRegistar.Text, openPhoto.FileName, textBoxEmailRegistar.Text, comboBox1.Text);
                this.DialogResult = DialogResult.Yes;
            }

        }

        private void M_Damas_msg(string msg)
        {
            MessageBox.Show(msg);
        }

    }
}