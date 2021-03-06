﻿using AgendaMais.Classes.Windows;
using AgendaMais.Telas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaMais
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frLogin());
            if (frLogin.Autenticacao)
                Application.Run(new frPrincipal());
            else
                System.Diagnostics.Process.GetCurrentProcess().Kill();

        }
    }
}
