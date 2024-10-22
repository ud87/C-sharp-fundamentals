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
            List<PersonModel> persons = new List<PersonModel>();

            string firstName;
            do
            {
                Console.Write("Please enter your first name or exit: ");
                firstName = Console.ReadLine();
                if (firstName.ToLower() == "exit")
                {
                    break;
                }

                Console.Write("Please enter your second name: ");
                string lastName = Console.ReadLine();

                Console.Write("Please enter your age: ");
                string ageText = Console.ReadLine();

                bool isAgeValid = int.TryParse(ageText, out int age);

                while (!isAgeValid)
                {
                    Console.Write("Invalid age! Please enter your age: ");
                    ageText = Console.ReadLine();
                    isAgeValid = int.TryParse(ageText, out age);
                }

                //create a new person object and set properties
                PersonModel person = new PersonModel
                {
                    FirstName = firstName,
                    LastName = lastName,
                    age = age
                };

                persons.Add(person);

            } while (firstName.ToLower() != "exit");

            foreach (PersonModel person in persons)
            {
                Console.WriteLine($"Hello {person.FirstName} {person.LastName}");
            }

            Console.ReadLine();
        }
    }
}


/*
 Create a console class application that has a person class and an address class
 
PersonModel.cs
AddressModel.cs

 */
