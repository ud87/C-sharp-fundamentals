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
            List<string> firstNames = new List<string>(); //give me new list firstName with a set of string
            firstNames.Add("Udaya");
            firstNames.Add("Sue");
            firstNames.Add("Renuka");

            Console.WriteLine($"The second element is {firstNames[1]}");
            firstNames.Remove("Sue");
            firstNames[1].ToUpper();
            Console.WriteLine($"The second element is {firstNames[1]}");

            List<string> fruits = new List<string>();
            fruits.Add("Apple");
            fruits.Add("Banana");
            fruits.Add("Pears");
            fruits.Add("Grapes");

            Console.WriteLine(fruits[0]);

            fruits.Add(fruits[0] = "None");     //replace zero indexed list with None
            Console.WriteLine(fruits[0]);

            Console.ReadLine();
        }
    }
}



/*
List <T> is a really powerful way of storing data
we do not need to know the size of the list beforehand like an array
it is dynamic and easy to work with
we can easily add and remove data
but when data is removed, it removes that element and places next element in its place
 
 */