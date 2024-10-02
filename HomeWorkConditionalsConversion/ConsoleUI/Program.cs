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
            Console.Write("Please enter your firstName: ");
            string firstName = Console.ReadLine();

            Console.Write("Please enter your lastName: ");
            string lastName = Console.ReadLine();

            Console.Write("Please enter your age: ");
            string ageText = Console.ReadLine();

            int ageLimit = 21;

            bool isAgeValid = int.TryParse(ageText, out int age);
            
            if (firstName.ToLower() == "bob" || firstName.ToLower() == "sue")
            {
                Console.Write($"Hello professor {firstName}. ");
            }

            if (age < ageLimit)
            {
                Console.Write($"You should wait {ageLimit - age} years to start this class.");
            }
            else
                Console.WriteLine($"Welcome to class {firstName}.");

            Console.ReadLine();
        }
    }
}


/*
 Homework: Plan and build a console app that asks a user for their name and their age.
If name is Bob or Sue, address them as professor. If the person is under 21 recommend they wait X years to start this class

Pseudocode
Ask user for firstname
Ask user for lastname
Ask user for age
ageLimit = 21

If firstname is bob or sue
	ConsoleWrite Hello professor name

if age < ageLimit
	ConsoleWrite "you should wait ageLimit - age" to start this class
else 
	ConsoleWrite "Welcome to class"
 */