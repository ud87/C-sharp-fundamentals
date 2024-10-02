using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userName = "";
            do
            {
                //Ask for user name
                Console.WriteLine("Type 'exit' to exit the program");
                Console.Write("Please enter your user name: ");
                userName = Console.ReadLine();

                //Check if user name is Tim
                if (userName.ToLower() == "tim")
                {
                    //if user name is Tim say Hello professor
                    Console.WriteLine("Hello Professor\n");
                }
                //else say hi username
                else
                    Console.WriteLine($"Hi {userName}\n");
            
            } while (userName != "exit");
        }
    }
}



/*

Ask for the users name. If users name is Tim, say "Hello Professor" otherwise, say hi username until they type exit


 */