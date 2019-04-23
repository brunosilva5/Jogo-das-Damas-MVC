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
        List<string> cultureList = new List<string>();
        CultureInfo[] cultures = CultureInfo.GetCultures(CultureTypes.SpecificCultures);
        RegionInfo region;

        public ViewRegistar()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
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
            if (textboxConfirmarPassword.Text == "Password")
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
            this.Close();
        }

    }
}
