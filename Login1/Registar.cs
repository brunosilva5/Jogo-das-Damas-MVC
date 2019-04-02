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
    

    public partial class Registar : Form
    {
        List<string> cultureList = new List<string>();
        CultureInfo[] cultures = CultureInfo.GetCultures(CultureTypes.SpecificCultures);
        RegionInfo region;

        public Registar()
        {
            InitializeComponent();
        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuDatepicker1_onValueChanged(object sender, EventArgs e)
        {
            
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
                    //comboboxPaises.Items.Intersect(0, new ListItem(region.EnglishName);
                    //comboboxPaises.Items.(region.EnglishName);
                }
            }
        }

        private void comboboxPaises_onItemSelected(object sender, EventArgs e)
        {
            
        }
    }
}
