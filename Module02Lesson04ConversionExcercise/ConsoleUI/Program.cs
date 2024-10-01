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
            //capture user age
            Console.Write("Please enter your current age: ");
            int age = 0;
            bool isValidAge = false;

            while (!isValidAge)       //isValidAge == false
            {
                string ageText = Console.ReadLine();
                isValidAge = int.TryParse(ageText, out age) && (age >=1 && age <= 100);  //sets true if age range is also between 1 and 100 

                if (isValidAge == false) 
                {
                    Console.Write("Invalid age format. Please re-enter your current age between 1 - 100: ");
                }
            };


            //capture current year
            int currentYear = DateTime.Now.Year;
            Console.WriteLine(currentYear);

            //year difference subtract current year from 2000
            int previousYear = 2000;
            int yearDifference = currentYear - previousYear;

            //subtract current age from year difference if current age is greater than or equal to year difference
            if (age > yearDifference)
            {
                int previousAge = age - yearDifference;
                Console.WriteLine($"You were {previousAge} years old in {previousYear}");
            }
            else
                Console.WriteLine("Sorry, you were not born");


            Console.ReadLine();
        }
    }
}


/*Capture a user's age from the console and then identify how old they were in 
 the year 2000. If they were not born yet, tell them that instead.
*/