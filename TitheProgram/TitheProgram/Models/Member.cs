using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TitheProgram
{

    class Member
    {
        private string myMemberID;
        private string myLastName;
        private string myFirstName;
        private string myMidInit;
        private string mySuffix;
        private string myAddress;
        private string myCity;
        private string myZip;
        private string myState;

        public string MemberID
        {
            get { return myMemberID; }
            set { myMemberID = value; }
        }

        public string LastName
        {
            get { return myLastName; }
            set { myLastName = value; }
        }

        public string FirstName
        {
            get { return myFirstName; }
            set { myFirstName = value; }
        }

        public string MidInit
        {
            get { return myMidInit; }
            set { myMidInit = value; }
        }

        public string Suffix
        {
            get { return mySuffix; }
            set { mySuffix = value; }
        }

        public string Address
        {
            get { return myAddress; }
            set { myAddress = value; }
        }

        public string City
        {
            get { return myCity; }
            set { myCity = value; }
        }

        public string Zip
        {
            get { return myZip; }
            set { myZip = value; }
        }

        public string State
        {
            get { return myState; }
            set { myState = value; }
        }

        //public bool InsertNewMember()
        //{

        //    titheDataSet.MembersDataTable dt = new titheDataSet.MembersDataTable();

        //    adapter = new titheDataSetTableAdapters.MembersTableAdapter();
            
        //    adapter.Fill(dt);

        //    try
        //    {
        //        //adapter.Insert(myMemberID, DateTime.Now, myBoolCheck, myCheckNumb, myDecAmount, myBoolCash, myTitheType);
        //        //dt.Rows.Add(myMemberID, myTitheDate, myBoolCheck, myCheckNumb, myDecAmount, myBoolCash, myTitheType);
        //        //adapter.Update(dt.Rows.Add(myMemberID, myTitheDate, myBoolCheck, myCheckNumb, myDecAmount, myBoolCash, myTitheType));
        //        adapter.Insert(myMemberID, myLastName, myFirstName, myMidInit, mySuffix, myAddress, myCity, myState, myZip);
        //        MessageBox.Show("Record created!", "Success!");
        //        return true;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.ToString(), "Error!");
        //        return false;
        //    }

        //}

        //public string totalMembers()
        //{

        //    int totMembers = 0;

        //    titheDataSet.MembersDataTable dt = new titheDataSet.MembersDataTable();


        //    adapter = new titheDataSetTableAdapters.MembersTableAdapter();

        //    adapter.Fill(dt);

        //    try
        //    {
        //        totMembers = (int)adapter.TotalMembers();
        //        return totMembers.ToString();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }

        //    return "0.00";

        //}
    }
}
