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


namespace Login1
{

    public partial class ViewRegistar : Form
    {
        public event MetodosComSeisString UserRegistered;

        List<string> cultureList = new List<string>();
        CultureInfo[] cultures = CultureInfo.GetCultures(CultureTypes.SpecificCultures);
        RegionInfo region;

        OpenFileDialog openPhoto;

        public string Name { get { return textBoxNameRegistar.Text; } }
        public string Username { get { return textboxUsernameRegistar.Text; } }
        public string Password { get { return textboxPasswordRegistar.Text; } }
        public string Photo { get { return openPhoto.FileName; } }
        public string Email { get { return textBoxEmailRegistar.Text; } }
        public string Country { get { return comboBox1.Text; } }


        public ViewRegistar()
        {
            InitializeComponent();

            // configura o componente para escolher a fotografia
            openPhoto = new OpenFileDialog();
            openPhoto.CheckFileExists = true;
            openPhoto.CheckPathExists = true;
            openPhoto.Filter = "Imagens|*.jpg;*.png;*.bmp|Ficheiros JPG|*.jpg|Ficheiros PNG|*.png|Ficheiros BMP|*.bmp|Todos os Ficheiros|*.*";
        }


        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {
            foreach (CultureInfo culture in cultures)
            {
                region = new RegionInfo(culture.LCID);

                if (!(cultureList.Contains(region.EnglishName)))
                {
                    cultureList.Add(region.EnglishName);

                    comboBox1.Items.Add(region.EnglishName);
                }
            }
        }


        //---------------------------------------------------------------------
        private void UsernameEnter(object sender, EventArgs e)
        {
            if (textboxUsernameRegistar.Text == "Username")
            {
                textboxUsernameRegistar.Text = "";
            }
        }
        private void UsernameLeave(object sender, EventArgs e)
        {
            if (textboxUsernameRegistar.Text == "")
            {
                textboxUsernameRegistar.Text = "Username";
            }
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
            {

            }
        }

        private void registarbutton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxNameRegistar.Text) ||
                string.IsNullOrWhiteSpace(textboxUsernameRegistar.Text) ||
                string.IsNullOrWhiteSpace(textboxPasswordRegistar.Text) ||
                string.IsNullOrWhiteSpace(openPhoto.FileName))
            {
                MessageBox.Show("Falta preencher campos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (UserRegistered != null)
                    UserRegistered(textboxUsernameRegistar.Text, textBoxNameRegistar.Text, textboxPasswordRegistar.Text, openPhoto.FileName, textBoxEmailRegistar.Text, comboBox1.Text);
                this.DialogResult = DialogResult.Yes;
                Close();
            }

        }
    }
}