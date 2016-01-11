
namespace TitheProgram.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using TitheProgram.lib;

    public class MainFormController:ControllerBase
    {
        private MainForm view;

        public MainFormController(BLL bll):base(bll)
        {
        }

        public void SetView(MainForm view)
        {
            this.view = view;
            this.SetMemberCount();
        }

        public void SetMemberCount()
        {
            this.view.SetTotalMembers(this.bll.GetTotalMemberCount());
            this.view.SetTotalDonations(this.bll.GetTotalYearlyDonations());
        }
    }
}
