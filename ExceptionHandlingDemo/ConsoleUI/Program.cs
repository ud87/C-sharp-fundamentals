using System;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //try
            //{
            //    BadCall();
            //}
            //catch (Exception ex)
            //{

            //    Console.WriteLine("There was an exception thrown in our app");
            //    Console.WriteLine(ex.Message);
            //}


            int[] numbers = new int[] { 1, 2, 3, 4, 5 };

            for (int i = 0; i <= numbers.Length; i++)
            {
                try
                {
                    Console.WriteLine(numbers[i]);
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
            }

            Console.ReadLine();
        }

        /*
        private static void BadCall()
        {
            int[] ages = new int[] { 1, 3, 5 };

            for (int i = 0; i <= ages.Length; i++)
            {
                Console.WriteLine(ages[i]);
            }
        }*/
    }

    
}


/*
 Index is out of bounds - means index is outside of lower and upper limit
Only catch exception where you think there may be an error
Try to use at the top level


Excercise create a console app with a for loop that throws an exception after five iterations. Catch the exception
 * 
 */