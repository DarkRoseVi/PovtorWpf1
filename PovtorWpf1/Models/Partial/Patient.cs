using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PovtorWpf1.Models
{ 
  partial  class Patient
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
