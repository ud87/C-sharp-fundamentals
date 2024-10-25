using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class AddressModel
    {
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }


        //full property
        private string _address;

        public string FullAddress
        {
            get 
            { 
                return $"{StreetAddress}\n{City}\n{State}\n{PostalCode}";
            }
        }

    }
}
