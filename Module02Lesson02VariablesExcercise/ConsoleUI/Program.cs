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
            /*Create a console app that has variables to hold a persons name,
             age, if they are alive, and their phone number*/

            string firstName = "";
            Console.Write("Please enter your first name: ");
            firstName = Console.ReadLine().Trim();  //removes the spaces from the beginning and the back

            string lastName = "";
            Console.Write("Please enter your last name: ");
            lastName = Console.ReadLine().Trim();
            string fullName = $"{firstName} {lastName}";

            int age = 0;
            Console.Write("Please enter your age: ");
            bool ageCorrectFormat = false;
            //loop until correct age format is entered
            while (ageCorrectFormat == false)
            {
                ageCorrectFormat = int.TryParse(Console.ReadLine(), out age);    //takes input from user, converts to int if successful assigns int value else sets valueof ageCorrectFormat to false
                if (ageCorrectFormat == false)
                {
                    Console.Write("Age must be number. Please re-enter: ");
                }
            }

            Console.Clear();     //clears console
            Console.WriteLine($"Your full name is {fullName}");
            Console.WriteLine($"You are {age} years old");

            Console.WriteLine("Press any key to exit");
            Console.ReadLine();      //to pause the program
        }
    }
}
