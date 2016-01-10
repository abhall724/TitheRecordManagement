// -----------------------------------------------------------------------
// <copyright file="ControllerBase.cs" company="Microsoft">
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
    using TitheProgram.Interfaces;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public abstract class ControllerBase
    {
        protected BLL bll;

        public ControllerBase(BLL bll)
        {
            this.bll = bll;
        }
    }
}
