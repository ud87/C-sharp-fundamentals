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
            string firstName = "";     // =  single equal is assign
            Console.Write("What is your first name: ");
            firstName = Console.ReadLine();

            Console.Write("What is your last name: ");
            string lastName = Console.ReadLine();   //declare and assign in the same line

            //if (firstName.ToLower() == "tim")    //double equal is a comparision
            //{
            //    Console.WriteLine("Welcome Mr. Rai");
            //}
            //else if (firstName.ToLower() == "sue")
            //{
            //    Console.WriteLine("Hello Mrs Smith");
            //}
            //else                //has to attach to an if statement
            //{
            //    Console.WriteLine("Hello other person");
            //}
            //Console.WriteLine("application done");

            //if (firstName.ToLower() == "tim" && lastName.ToLower() == "corey")
            //{
            //    Console.WriteLine("Hello professior");
            //}
            //else if (firstName.ToLower() == "tim")
            //{
            //    Console.WriteLine("Hello other Tim");
            //}

            //if (firstName.ToLower() == "tim" || firstName.ToLower() == "sue")
            //{
            //    Console.WriteLine($"Hello Professor {firstName}");
            //}
            //else
            //{
            //    Console.WriteLine("Hello students");
            //}

            //if ((firstName.ToLower() == "tim" && lastName.ToLower() == "corey") 
            //    || (firstName.ToLower()=="sue" && lastName.ToLower()=="storm"))
            //{
            //    Console.WriteLine($"Hello {firstName}");
            //}

            //if (firstName != "tim") 
            //{
            //    Console.WriteLine("You are not tim");
            //}

            int age = 39;

            switch (firstName.ToLower())
            {
                case "tim":
                    Console.WriteLine("Hello Professor");
                    break;
                case "sue":
                    Console.WriteLine("Hello Professor storm");
                    break;
                default:
                    Console.WriteLine("Hello student");
                    break;
            }
            Console.ReadLine();
        }
    }
}


/*
 It's generally not a good idea to hard code data because
    - its very difficult to update program (does not make modular)
    - we can introduce bugs and error
    - it does not make data dynamic i.e. changing according to user 
 It's best to collect data from database, user or API

 Ctrl + K + C = comment shortcut
 Ctrl + K + U = uncomment shortcut
    
 if statement evaluates an expression if true then it will process the code, if not then it will proceed to else if and evaluate the expression, and so on 

 switch cases can be used if there are multiple exact matches to be conditioned
 downsides of switch is it does not provide && or and is used for exact matches
 
 */