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
            //for (int i = 1; i < 10; i++)
            //{
            //    Console.WriteLine(i);
            //}


            //string[] firstNames = new string[] { "udaya", "Renuka", "Manoj", "Harry" };

            //for (int i = 0; i < firstNames.Length; i++)
            //{
            //    Console.WriteLine(firstNames[i]);
            //}


            List<string> firstNames = new List<string>();
            firstNames.Add("Mahesh");
            firstNames.Add("Harry");
            firstNames.Add("Ronda");
            firstNames.Add("Rilesh");
            firstNames.Add("Nilesh");

            for (int i = 0; i < firstNames.Count; i++)
            {
                Console.WriteLine(firstNames[i]);
            }

            Console.ReadLine();
        }
    }
}
