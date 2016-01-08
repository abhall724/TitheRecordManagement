// -----------------------------------------------------------------------
// <copyright file="MainFormController.cs" company="Microsoft">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace TitheProgram.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using TitheProgram.lib;

    public class MainFormController
    {
        private FileHandler file;
        private BLL bll;
        private DataBaseLogicLayer dll;

        public MainFormController(FileHandler file, BLL bll)
        {
            this.file = file;
            this.bll = bll;
            this.dll = new DataBaseLogicLayer(string.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Jet OLEDB:Engine Type=5", file.CompleteFileString()));
        }

        public void Setup()
        {
            if (this.file.DirectoryExists())
            {
                if (!this.file.HasDatabaseFile())
                {
                    this.file.CreateDatabaseFile();
                    this.dll.SetupDatabase();
                }
            }
            else
            {
                this.file.CreateDirectoryAndDatabaseFile();
            }
        }

    }
}
