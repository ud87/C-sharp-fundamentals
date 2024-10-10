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
            List<string> firstNames = new List<string>();
            //ask for firstname
            Console.Write("Please enter first name: ");
            string firstName = Console.ReadLine();
            EmptyFirstName(firstName);
            firstNames.Add(firstName);
            bool addFirstName = true;

            do
            {
                Console.Write("Do you want to add more first name ? ");
                string addMoreFirstName = Console.ReadLine();

                if (addMoreFirstName.ToLower() == "y")
                {
                    addFirstName = true;
                    Console.Write("Please enter first name: ");
                    firstName = Console.ReadLine();
                    EmptyFirstName(firstName);
                    firstNames.Add(firstName);
                }
                else if (addMoreFirstName.ToLower() == "n")
                {
                    addFirstName = false;
                }
                else
                {
                    Console.Write("Invalid input ! Please enter y or n: ");
                    addFirstName = true;
                }
            } while (addFirstName);


            void EmptyFirstName (string firstNameVariable)
            {
                while (firstNameVariable == "" || int.TryParse(firstNameVariable, out _))
                {
                    Console.Write("FirstName cannot be empty or only numbers. Please re-enter first name again. ");
                    firstNameVariable = Console.ReadLine();
                }
            }

            //print out the list
            foreach (string name in firstNames)
            {
                Console.WriteLine($"Hello {name}");
            }


            //if yes then repeat if no then say hello
            Console.ReadLine();
        }
    }
}

/*
 Ask the user for their first name
Continue asking for first names unitl there are no more
then loop through each name using foreach and tell them hello
 */
