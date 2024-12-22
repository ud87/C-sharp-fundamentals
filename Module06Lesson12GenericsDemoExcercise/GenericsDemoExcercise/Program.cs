using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDemoExcercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ToStringPrint<int>(321);
            ToStringPrint<bool>(true);
            ToStringPrint<string>("Tim");
            
            //implementing class Generic
            Generic<string> name = new Generic<String>();
            string output = name.Print("Udaya");

            Console.ReadLine();
        }

        public static void ToStringPrint<T>(T item)
        {
            Console.WriteLine(item.ToString());
        }
        
    }

    public class Generic<T>
    {
        public T Print(T value)
        {
            Console.WriteLine($"Value: {value}");
            return value;
        }
    }
}


/*
 Create a generic method that takes in an item and calls the ToString() method and prints that value to the Console
 This is a reuseable method and allows us to be flexible
 */