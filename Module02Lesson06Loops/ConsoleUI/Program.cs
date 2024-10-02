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
            //string continueResult = "";     //continue is a reserved keyword

            //do        //do something
            //{
            //    Console.Write("What is your first name: ");
            //    string firstName = Console.ReadLine();

            //    Console.WriteLine($"Hello {firstName}");

            //    Console.Write("Do you want to continue (y/n): ");
            //    continueResult = Console.ReadLine();
            //    Console.Clear();


            //} while (continueResult.ToLower() == "y");      //keep doing something this expression is true, have to ensure end condition is always hit

            Console.WriteLine("What is your age: ");
            string ageText = Console.ReadLine();

            bool isValidAge = int.TryParse(ageText, out int age);

            while (isValidAge == false)     //runs 0 or more times
            {
                Console.WriteLine("That was an invalid age. Please try again.");
                Console.WriteLine("What is your age: ");
                ageText = Console.ReadLine();

                isValidAge = int.TryParse(ageText, out age);
            }

            Console.WriteLine($"Your age in 10 years will be {age + 10}.");

            Console.Write("Press any key to exit: ");
            Console.ReadLine();
        }
    }
}


/*
do loop always run at least once 
while loop may not happen at all
 */
