using System;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                BadCall();
            }
            catch (Exception ex)
            {

                Console.WriteLine("There was an exception thrown in our app");
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }

        private static void BadCall()
        {
            int[] ages = new int[] { 1, 3, 5 };

            for (int i = 0; i <= ages.Length; i++)
            {
                Console.WriteLine(ages[i]);
            }
        }
    }

    
}


/*
 Index is out of bounds - means index is outside of lower and upper limit
 * 
 */