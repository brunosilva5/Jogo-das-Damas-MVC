﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckersGame
{
    static class Program
    {
        public static ViewLogin V_Login { get; private set; }
        public static ViewRegistar V_Registar { get; private set; }
        public static ViewMenu V_Menu { get; private set; }
        public static ViewModoJogo V_ModoJogo { get; private set; }
        public static ViewJogo V_Jogo { get; private set; }
        public static ViewPerfil V_Perfil { get; private set; }
        public static ViewAbout V_About { get; private set; }

        public static ControllerDamas C_Damas { get; private set; }
        public static ControllerTabuleiro C_Tabuleiro { get; private set; }

        public static ModelDamas M_Damas { get; private set; }
        public static ModelTabuleiro M_Tabuleiro { get; private set; }


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            M_Damas = new ModelDamas();

            M_Tabuleiro = new ModelTabuleiro();

            V_Login = new ViewLogin();
            V_Registar = new ViewRegistar();
            V_Menu = new ViewMenu();
            V_ModoJogo = new ViewModoJogo();
            V_Jogo = new ViewJogo();
            V_Perfil = new ViewPerfil();
            V_About = new ViewAbout();

            C_Damas = new ControllerDamas();
            C_Tabuleiro = new ControllerTabuleiro();

            Application.Run(V_Login);
        }
    }
}
