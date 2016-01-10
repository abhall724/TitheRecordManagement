using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TitheProgram.Controllers;
using TitheProgram.lib;

namespace TitheProgram
{
    static class Program
    {
       public static ControllerFactory controllerFactory;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            FileHandler fileHandler = new FileHandler();
            
            controllerFactory = new ControllerFactory(fileHandler);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new MainForm());
        }
    }
}
