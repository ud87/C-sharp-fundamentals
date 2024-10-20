using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    //make class public which is a access modifier
    public static class usermessages   //try to keep file name  usermessages.cs and usermessages classname the same
    {
        public static void ApplicationStartMessage(string firstName)
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Static Class Demo App");

            int hourOfDay = DateTime.Now.Hour;

            if (hourOfDay > 12)
            {
                Console.WriteLine($"Good Morning {firstName}!");
            }
            else if(hourOfDay > 19)
            {
                Console.WriteLine($"Good Afternoon {firstName}!");
            }
            else
            {
                Console.WriteLine($"Good Evening {firstName}!");
            }
        }


        public static void PrintResult(string message)
        {
            Console.WriteLine(message);
            Console.WriteLine();
            Console.WriteLine("Thank you for using our app to calculate for you.");
        }

        
    }

}
