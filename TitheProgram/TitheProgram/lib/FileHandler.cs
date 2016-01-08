// -----------------------------------------------------------------------
// <copyright file="FileHandler.cs" company="Microsoft">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace TitheProgram.lib
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.IO;
    using ADOX;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class FileHandler
    {
        private string directory = "C:\\TitheProgram";
        private string databaseFileName = "tithe.accdb";

        public FileHandler()
        {
            
        }

        public bool HasDatabaseFile()
        {
            if (this.DirectoryExists())
            {
                return File.Exists(this.CompleteFileString());
            }

            return false;
        }

        public string CompleteFileString()
        {
            return string.Format("{0}\\{1}", directory, databaseFileName);
        }

        public bool DirectoryExists()
        {
            return Directory.Exists(directory);
        }

        public bool CreateDatabaseFile()
        {
            if (this.DirectoryExists())
            {
                var cat = new ADOX.Catalog();

                cat.Create(string.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Jet OLEDB:Engine Type=5", this.CompleteFileString()));

                cat = null;
            }

            return false;
        }


        public void CreateDirectoryAndDatabaseFile()
        {
            Directory.CreateDirectory(this.directory);
            this.CreateDatabaseFile();
        }
    }
}
