using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login1
{
    public class ControllerDamas
    {
        public ControllerDamas()
        {
            Program.V_Login.UserQuit += V_Login_UserQuit;
            Program.V_Login.UserWantSignup += V_Login_UserWantSignup;
            Program.V_Login.UserLogin += V_Login_UserLogin;
        }

        private void V_Login_UserLogin(string username, string password)
        {
            Program.M_Damas.Login(username, password);
        }

        private void V_Login_UserWantSignup()
        {
            Program.M_Damas.WantSignup();
        }

        private void V_Login_UserQuit()
        {
            Program.M_Damas.Quit();
        }

    }
}
