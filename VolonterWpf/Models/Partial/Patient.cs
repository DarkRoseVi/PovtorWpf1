﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VolonterWpf.Models
{
    partial class Patient
    {
        public string FullName
        {
            get
            {
                return LastName + " " + Name + " " + SurName;
            }
        }
    }
}
