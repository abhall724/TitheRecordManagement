using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TitheProgram.Models
{

    public class Member
    {
        
        public int id
        {
            get;
            set;
        }

        public string lastname
        {
            get;
            set;
        }

        public string firstname
        {
            get;
            set;
        }

        public string middleInitial
        {
            get;
            set;
        }

        public string suffix
        {
            get;
            set;
        }

        public string address
        {
            get;
            set;
        }

        public string city
        {
            get;
            set;
        }

        public string state
        {
            get;
            set;
        }

        public string zip
        {
            get;
            set;
        }
    }
}
