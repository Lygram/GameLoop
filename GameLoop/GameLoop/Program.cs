﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameLoop
{
    static class Program
    {
        static FastLoop _fastloop = new FastLoop(GameLoop);
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
    static void GameLoop()
        {
            //Game code goes here.
            //GetInput
            //Process
            //Render
            System.Console.WriteLine("loop");
        }
    }
}
