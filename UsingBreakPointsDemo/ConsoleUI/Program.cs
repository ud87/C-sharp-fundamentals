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
            //for (int i = 0; i < 20; i++) 
            //{
            //    Console.WriteLine($"The value of i is {i}");
            //    for (int j = 0; j < 10; j++) 
            //    {
            //        Console.WriteLine($"The value of j is {j}");
            //    }
            //}

            int total = 0;
            for (int i = 1; i < 10; i=i*5)
            {
                total += i;
                Console.WriteLine($"Total is {total}");
            }


            Console.ReadLine();
        }
    }
}



/*
 Click on the far left grey line to add in breakpoint

Continue - continue until you hit the next break point
Step into (F11) - Go into the next step
Debug > Toggle BreakPoint (turns off breakpoint) or just click the breakpoint


Excercise:
Create a console app with a for loop that multiplies a number by 5 and adds it to the total each time. Step through the code
 */