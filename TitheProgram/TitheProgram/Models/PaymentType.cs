﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TitheProgram.Models
{
    public class PaymentType
    {
        public int id
        {
            get;
            set;
        }

        public string name
        {
            get;
            set;
        }

        public override string ToString()
        {
            return this.name;
        }
    }
}
