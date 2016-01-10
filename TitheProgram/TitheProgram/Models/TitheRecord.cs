using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TitheProgram.Models
{

    public class TitheRecord
    {
        public int id
        {
            get;
            set;
        }

        public string memberId
        {
            get;
            set;
        }

        public DateTime recordDate
        {
            get;
            set;
        }

        public string type
        {
            get;
            set;
        }

        public string checkNum
        {
            get;
            set;
        }
        public decimal amount
        {
            get;
            set;
        }

        public int pamyentType
        {
            get;
            set;
        }

        public enum titheType
        {
            missions,
            tithes,
            misc
        }
    }
}
