﻿using System;
    using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GarbageMonitoring
{
    static class Program
    {
        public static string com = "COM5";
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
