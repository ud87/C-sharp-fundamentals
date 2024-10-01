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
            Console.Write("What is your age: ");
            string ageText = Console.ReadLine();

            //int age = int.Parse(ageText);   //if trust user to put in correct data format
            bool isValidAge = int.TryParse(ageText, out int age);  //if correct output into age integer variable

            if (isValidAge)   //equivalent to isValidAge = true
            {
                //age = age + 10;
                age += 10;

                Console.WriteLine($"You are going to be {age} in 10 years."); 
            }
            else
            {
                Console.WriteLine("That was not a valid age.");
            }
            Console.ReadLine();
        }
    }
}


/*
Conversion is converting one data type to another 
it is important to validate user data to ensure correct user is entering data in correct format for e.g. 13 instead of thirteen
string to int conversion is required because when we use Console.ReadLine() to obtain input from user it is in a string format and we cannot perform any calulations and other ops 
we can convert string to int using int.Parse() or int.TryParse(input, out variable);
its safer to use TryParse when converting string to integer because we are validating user data
We can also use TryParse for double, decimal, bool
Do not convert from one data type to another unless really required. Avoid if possible.
 */
