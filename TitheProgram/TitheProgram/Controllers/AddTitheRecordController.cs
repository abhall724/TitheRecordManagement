namespace TitheProgram.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using TitheProgram.lib;
    using TitheProgram.Models;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class AddTitheRecordController: ControllerBase
    {
        private AddTitheRecord view;

        public AddTitheRecordController(BLL bll):base(bll)
        {
        }

        public void SetView(AddTitheRecord view)
        {
            this.view = view;
        }

        public List<Member> GetMembers()
        {
            return this.bll.GetAllMembers();
        }

        public void AddTitheRecord(TitheRecord tithe)
        {
            if (this.bll.AddTitheRecord(tithe))
            {
                this.view.ShowMessage("Successfully added tithe record.");
            }
            else
            {
                this.view.ShowMessage("Error adding tithe record.");
            }
        }
    }
}
