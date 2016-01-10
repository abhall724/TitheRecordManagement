// -----------------------------------------------------------------------
// <copyright file="ControllerFactory.cs" company="Microsoft">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace TitheProgram.lib
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using TitheProgram.Controllers;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class ControllerFactory
    {
        private BLL bll;
        private DataBaseLogicLayer dll;
        private FileHandler fileHandler;
        private MainFormController mainFormController;
        private AddMemberController addMemberController;
        private AddTitheRecordController addTitheRecordController;

        public ControllerFactory(FileHandler fileHandler)
        {
            this.fileHandler = fileHandler;

            this.dll = new DataBaseLogicLayer(string.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Jet OLEDB:Engine Type=5", this.fileHandler.CompleteFileString()));
            this.bll = new BLL(this.fileHandler, this.dll);
        }

        public MainFormController getMainFormController()
        {
            if (this.mainFormController == null)
            {
                this.mainFormController = new MainFormController(this.bll);
            }

            return this.mainFormController;
        }

        public AddMemberController getAddMemberController()
        {
            if (this.addMemberController == null)
            {
                this.addMemberController = new AddMemberController(this.bll);
            }

            return this.addMemberController;
        }

        public AddTitheRecordController getAddTitheRecordController()
        {
            if (this.addTitheRecordController == null)
            {
                this.addTitheRecordController = new AddTitheRecordController(this.bll);
            }

            return this.addTitheRecordController;
        }
    }
}
