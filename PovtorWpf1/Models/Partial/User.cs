using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PovtorWpf1.Models
{
  partial class User
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
