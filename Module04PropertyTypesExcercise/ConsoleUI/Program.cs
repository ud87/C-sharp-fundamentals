using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AddressModel address = new AddressModel
            {
                StreetAddress = "Culver Road",
                City = "Basingstoke",
                State = "Hampshire",
                PostalCode = "RG21 3NJ"
            };


            Console.WriteLine(address.FullAddress);

            Console.ReadLine();
        }
    }
}

/* 
 Create a class that has properties for street address, city, state,
and zip code. Then add a FullAddress property that is read-only
 
 
 */
