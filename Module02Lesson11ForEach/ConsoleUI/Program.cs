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
            //List<string> firstNames = new List<string>();

            //firstNames.Add("Tim");
            //firstNames.Add("Sue");
            //firstNames.Add("Bob");
            //firstNames.Add("Dan");

            //foreach (string name in firstNames)
            //{
            //    Console.WriteLine($"Hello {name}");
            //}

            Dictionary<int, string> importantYears = new Dictionary<int, string>();

            importantYears.Add(1942, "Columbus arrives in Central America");
            importantYears.Add(1969, "Man walks on the moon");
            importantYears.Add(1987, "Udaya is born");

            foreach (var year in importantYears) 
            {
                Console.WriteLine($"{year.Key} : {year.Value}");
            }
            Console.ReadLine();
        }
    }
}


/*
 Whenever you can please use foreach for list 
 if you really need to use counter you can 
 
 */