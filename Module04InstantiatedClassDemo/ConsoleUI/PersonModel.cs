using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    // Blueprint
    public class PersonModel        //since it is not static it cannot be directly accessed in Program.cs
    {
        //public string firstName;
        //public string lastName;
        //public string emailAddress;
        public string FirstName { get; set; }
        public string LastName { get; set; } 
        public string EmailAddress { get; set; }
        public bool HasBeenGreeted { get; set; }
    }
}
