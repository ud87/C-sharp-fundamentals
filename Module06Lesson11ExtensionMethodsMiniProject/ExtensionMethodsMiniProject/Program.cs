using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodsMiniProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonModel person = new PersonModel();
            
            
            person.FirstName = "What is your first name ? ".RequestString();

            person.LastName = "What is your last name ? ".RequestString();

            person.Age = "What is your age ? ".RequestInt(0, 120);

            Console.ReadLine();
        }
    }
}


/*
 Categorize extension method by type string helper, console helper, int helper, double helper, etc and put it inside class library 
 
 */
