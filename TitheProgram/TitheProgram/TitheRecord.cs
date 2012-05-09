using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TitheProgram
{

    class TitheRecord
    {
       private string myMemberID;
       private string myStrCash = null;
       private string myStrCheck = null;
       private string myStrCheckNumb = "NA";
       private decimal myDecAmount = 0.0M;

        public enum titheType
        {
            missions,
            tithes,
            misc
        }

        public TitheRecord(string in_memberID, string in_strCash, string in_strCheck, string in_strCheckNumb, decimal in_decAmount, titheType in_type)
        {
            myMemberID = in_memberID;
            myStrCash = in_strCash;
            myStrCheck = in_strCheck;
            myStrCheckNumb = in_strCheckNumb;
            myDecAmount = in_decAmount;

            titheType myType = in_type;
        }

    }
}
