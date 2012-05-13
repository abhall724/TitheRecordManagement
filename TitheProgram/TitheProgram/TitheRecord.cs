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
        private string myCheckNumb;
        private decimal myDecAmount;
        //private titheDataSetTableAdapters adapter = new titheDataSetTableAdapters.TitheRecordTableAdapter;
        //NorthwindDataSetTableAdapters.CustomersTableAdapter customersTableAdapter1;
        //customersTableAdapter1 = new NorthwindDataSetTableAdapters.CustomersTableAdapter();
        titheDataSetTableAdapters.TitheRecordTableAdapter adapter;
        //adapter = new titheDataSetTableAdapters.TitheRecordTableAdapter();

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

        public string MemberId
        {
            get
            {
                return myMemberID;
            }
            set
            {
                myMemberID = value;
            }
        }

        public bool boolCash
        {
            get
            {
                return myBoolCash;
            }
            set
            {
                myBoolCash = value;
            }
        }

        public bool boolCheck
        {
            get
            {
                return myBoolCheck;
            }
            set
            {
                myBoolCheck = value;
            }
        }

        public string CheckNumb
        {
            get
            {
                return myCheckNumb;
            }

            set
            {
                myCheckNumb = value;
            }
        }

        public decimal Amount
        {
            get
            {
                return myDecAmount;
            }
            set
            {
                myDecAmount = value;
            }
        }

        public bool InsertNewRecord(string con)
        {

            adapter.Insert();

            return true;
        }
    }
}
