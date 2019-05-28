using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckersGame
{
    public class ControllerDamas
    {
        public ControllerDamas()
        {
            Program.V_Login.UserQuit += V_Login_UserQuit;
            Program.V_Login.UserLogin += V_Login_UserLogin;
            Program.V_Registar.UserRegistered += V_Registar_UserRegistered;
            Program.V_Registar.ComboBoxCountries += V_Registar_ComboBoxCountries;
        }

        private void V_Registar_ComboBoxCountries()
        {
            Program.M_Damas.UpdateComboBox();
        }

        private void V_Registar_UserRegistered(string s1, string s2, string s3, string s4, string s5, string s6)
        {
            Program.M_Damas.UserRegistered(s1, s2, s3, s4, s5, s6);
        }

        private void V_Login_UserLogin(string username, string password)
        {
            Program.M_Damas.Login(username, password);
        }

        private void V_Login_UserQuit()
        {
            Program.M_Damas.Quit();
        }

    }
}
