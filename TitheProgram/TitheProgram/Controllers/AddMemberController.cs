// -----------------------------------------------------------------------
// <copyright file="AddMemberController.cs" company="Microsoft">
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
    using TitheProgram.Models;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class AddMemberController: ControllerBase
    {
        private AddMemberForm view;

        public AddMemberController(BLL bll):base(bll)
        {
        }

        public void SetView(AddMemberForm view)
        {
            this.view = view;
        }

        public void AddMember(Member member)
        {
            if (this.bll.AddMember(member))
            {
                this.view.ShowMessage("Successfully added member.");
            }
            else
            {
                this.view.ShowMessage("Error adding member.");
            }
        }
    }
}
