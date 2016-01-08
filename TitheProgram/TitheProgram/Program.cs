using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TitheProgram.Controllers;

namespace TitheProgram
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm(new MainFormController(new lib.FileHandler(), new lib.BLL())));
            //"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Jet OLEDB:Engine Type=5"
        }
    }
}
