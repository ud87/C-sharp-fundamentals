using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class Program
    {
        static string userName = "";

        static void Main(string[] args)
        {
            
            askUserName();
            welcomeUser();
            Console.ReadLine();
        }

        //method to ask for the user's name
        private static void askUserName()
        {
            Console.Write("Please enter your name: ");
            userName = Console.ReadLine();
        }    

        //method to print Hello to user
        private static void welcomeUser()
        {
            string output = $"Hello {userName}";
            Console.WriteLine(output);
        }
    }
}


/*
 Create a welcome method, a method to ask for the users name, and 
another to tell taht user "Hello _"
 */
