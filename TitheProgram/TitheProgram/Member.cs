using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TitheProgram
{

    class Member
    {
        private string myMemberID;
        private string myLastName;
        private string myFirstName;
        private string myMidInit;
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

        public string Address
        {
            get { return myAddress; }
            set { myAddress = value; }
        }

    }
}
