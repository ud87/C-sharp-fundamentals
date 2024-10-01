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
            Console.Write("Please enter your first name: ");
            string firstName = Console.ReadLine();

            Console.Write("Please enter your last name: ");
            string lastName = Console.ReadLine();

            if (firstName.ToLower() == "tim" &&  lastName.ToLower() =="corey")
            {
                Console.WriteLine("Welcome professor");
            }
            else
            {
                Console.WriteLine("Welcome students");
            }

            Console.ReadLine();
        }
    }
}


/*
 Create a console application that asks the user for their name. Welcome me(Tim) as professor or anyone else as a student
 */
