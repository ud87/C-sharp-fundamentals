using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI   //namespace is project name by default
{
    internal class Program
    {
        static void Main(string[] args)   //static void main is a method which is a code that runs everything inside the { }, compiler knows where to start the app
        {
            Console.Beep();      //Beeps and makes sound 
            Console.Write("Computer says: ");
            Console.WriteLine("Hello World!");   //console is a class which holds a bunch of methods, .writeLine is a method which outputs the string
            //all methods have ( ) and all C# code line ends in ;
            Console.ReadLine();             //waits until user inputs something, way to collect a user input


            //whenever we need Intellisence we can press Ctrl + j
            

        }
    }
}
