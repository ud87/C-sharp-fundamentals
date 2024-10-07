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
            Dictionary<int, string> importantYears = new Dictionary<int, string>();
            importantYears[1492] = "Columbus discovered the new world.";
            importantYears[1969] = "Man walks on the moon";
            importantYears[1987] = "Udaya is born";

            Console.WriteLine($"In 1978, this happened: {importantYears[1987]}");


            Dictionary<string, string> personNames = new Dictionary<string, string>();
            personNames["Harry"] = "Harry is 5 years old.";
            personNames["Udaya"] = "Udaya is 35 years old.";
            personNames["Renuka"] = "Renuka is 34 years old.";

            
            bool isValidKey = personNames.TryGetValue("Harry", out string value); //evaluates if key is valid or not if yes then assigns key value to value
            Console.WriteLine(isValidKey);


            Dictionary<string, string[]> cars = new Dictionary<string, string[]>();
            cars["Models"] = new string[] {"BMW", "Mercedez", "Ferrari"};
            cars["engine"] = new string[] { "BMW engine", "Mercedez engine", "Ferrari engine" };

            string[] models = cars["Models"];

            for (int i = 0; i < models.Length; i++)
            {
                Console.WriteLine($"{i+1}) {models[i]}");
            }





            Console.ReadLine();
        }
    }
}


/*
Dictionary is important when we need to store key value pairs
Key value pairs is important because we can store relevant information for a particular key
synatx Dictionary<keyDataType, valueDataType> dictionaryName = new Dictionary<keyDataType, valueDataType>();
Dictionary cannot have two keys the same, if this happens then the value is overridden with the latest assigned value
 */