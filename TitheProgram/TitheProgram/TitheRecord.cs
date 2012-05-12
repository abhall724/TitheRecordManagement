using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TitheProgram
{

    class TitheRecord
    {
       private string myMemberID;
       private bool myBoolCash;
       private bool myBoolCheck;
       private string myStrCheckNumb;
       private decimal myDecAmount;
        //private titheDataSetTableAdapters adapter = new titheDataSetTableAdapters.TitheRecordTableAdapter;


        public enum titheType
        {
            missions,
            tithes,
            misc
        }
        //Not using constructors yet...maybe in rewrite!
       /* public TitheRecord(string in_memberID = null, titheType in_type = titheType.misc, bool in_boolCash = false, bool in_boolCheck = false, string in_strCheckNumb = null, decimal in_decAmount = 0.0M)
        {
            myMemberID = in_memberID;
            myBoolCash = in_boolCash;
            myBoolCheck = in_boolCheck;
            myStrCheckNumb = in_strCheckNumb;
            myDecAmount = in_decAmount;

            titheType myType = in_type;
        }
        */

        public string _myMemberID()
        {
            
            return myMemberID;

        }
    }
}
