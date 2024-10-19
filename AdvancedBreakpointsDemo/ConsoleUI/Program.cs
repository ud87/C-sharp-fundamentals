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
            LoopHundred();
            //RunsALot();
            Console.ReadLine();
        }


        private static void LoopHundred()
        {
            for (int i = 0; i <= 100; i++)
            {
                try
                {
                    Console.WriteLine(i);
                    if (i == 73)
                    {
                        throw new Exception("i is 73");
                    }
                }
                catch (Exception Ex)
                {
                    Console.WriteLine(Ex.Message);
                }
            }
        }


        private static void RunsALot()
        {
            long total = 0;
            int test = 0;

            for (int i = -1000; i <= 1000; i++)
            {
                total += i;
                try
                {
                    test = 5 / i;

                }
                catch (Exception ex)
                {
                    Console.WriteLine("There was an exception");
                    Console.WriteLine(ex.Message);
                }

            }
        }
    }


}

//Advanced breakpoints help you narrow down issue and finally find the location of the error
/*
 Excercise: Create a console app that loops from 1 to 100. Throw an exception on 73. Use a breakpoint to break before the breaking situation
 */
