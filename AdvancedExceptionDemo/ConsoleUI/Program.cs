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
            try
            {
                Console.Write("What is your name: ");
                string name = Console.ReadLine();
                ComplexMethod(name);
                DifferentMethod();
                SimpleMethod();


            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine("You should not be calling these methods");
                Console.WriteLine(ex.Message);
            }
            catch (NotImplementedException)
            {
                Console.WriteLine("You forgot to implement your code");
            }
            catch (Exception ex)  //catches exception
            {
                Console.WriteLine(ex.Message);
            }
            finally { Console.WriteLine("I always run"); }
            
            Console.ReadLine();
        }

        private static void ComplexMethod(string name)
        {
            if (name.ToLower() == "tim")
            {
                throw new OutOfMemoryException("Tim is too big for this");
            }
            else
                throw new FormatException("I don't like Tim as format name");
            
        }

        private static void DifferentMethod()
        {
            throw new NotImplementedException();
        }

        private static void SimpleMethod()
        {
            throw new InvalidOperationException("You should not be calling the SimpleMethod");  //new creates new exception, more specific type
        }

        
    }
}


/*
 Exception tells us there is an error
can catch more than one exception
always run more specific exception first and then catch the general exception later
 finally always runs the code, this is important if we had to do work that always has to happen, for e.g. need to always connect to database 
 */
