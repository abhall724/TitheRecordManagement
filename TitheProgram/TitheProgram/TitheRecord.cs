using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TitheProgram
{

    class TitheRecord
    {
        private string myMemberID;
        private bool myBoolCash;
        private bool myBoolCheck;
        private string myCheckNumb;
        private decimal myDecAmount;
        private string myTitheType;
        private DateTime myTitheDate;

        titheDataSetTableAdapters.TitheRecordTableAdapter adapter;

        //Not actually using this...
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

        public string Type
        {
            get
            {
                return myTitheType;
            }
            set
            {
                myTitheType = value;
            }
        }

        public DateTime TitheDate
        {
            get
            {
                return myTitheDate;
            }
            set
            {
                myTitheDate = value;
            }
        }
        public bool InsertNewRecord()
        {

            titheDataSet.TitheRecordDataTable dt = new titheDataSet.TitheRecordDataTable();

            adapter = new titheDataSetTableAdapters.TitheRecordTableAdapter();
           
            adapter.Fill(dt);

            try
            {
                //adapter.Insert(myMemberID, DateTime.Now, myBoolCheck, myCheckNumb, myDecAmount, myBoolCash, myTitheType);
                //dt.Rows.Add(myMemberID, myTitheDate, myBoolCheck, myCheckNumb, myDecAmount, myBoolCash, myTitheType);
                //adapter.Update(dt.Rows.Add(myMemberID, myTitheDate, myBoolCheck, myCheckNumb, myDecAmount, myBoolCash, myTitheType));
                adapter.Insert(myMemberID, myTitheDate, myBoolCheck, myCheckNumb, myDecAmount, myBoolCash, myTitheType);
                MessageBox.Show("Record created!", "Success!");
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error!");
                return false;
            }
                
        }

    }
}
