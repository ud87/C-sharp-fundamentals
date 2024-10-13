using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)  //entry point to our application i.e. starting point
        {
            SayAuthor();

            //WelcomeUser("udaya");


            string firstName = GetUsersName("What is your first name: ");
            string lastName = GetUsersName("What is your last name: ");
            WelcomeUser(firstName, lastName);


            Console.ReadLine();    //reads the information off the line
        }

        private static void  SayAuthor() //private only available to other methods inside class program, void means does not return any data
        {
            Console.WriteLine("********************************");
            Console.WriteLine("Written by: Udaya Rai");
            Console.WriteLine("********************************");
        }
        
        private static void WelcomeUser(string firstName, string lastName)
        {
            Console.WriteLine($"Hello {firstName} {lastName}");
        }

        private static string GetUsersName(string message)
        {
            Console.Write(message);
            string output = Console.ReadLine();

            return output;
        }
    
    }
}


/*
 Inside class
Method name is Pascal case i.e. starts with capital letter
Benefit of method is debugging, if error then can change at one place and no need to change other places
Method is focuses on doing one core thing then name it what it does
 */