﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBanSach
{
    static class Program
    {
        public static DBAcess da = new DBAcess();
        private static bool loggedIn = false;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
            //Application.Run(new FormThanhToan());
            //Application.Run(new Form1());
        }

        public static bool IsLoggedIn()
        {
            return loggedIn;
        }

        public static void LogIn()
        {
            loggedIn = true;
        }
    }
}
