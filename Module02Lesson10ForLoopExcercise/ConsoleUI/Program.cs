using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ask user for firstNamesCommaSeperated
            Console.Write("Please enter first names seperated by comma: ");
            string firstNamesCommaSeperated = Console.ReadLine();
            //remove all line break chars like space, tabs, linebreaks and also remove , from beginning and end, this ensures that the input is not blank
            firstNamesCommaSeperated = Regex.Replace(firstNamesCommaSeperated, @"\s", "").Trim(','); 

            while (firstNamesCommaSeperated == "")
            {
                Console.Write("User input cannot be empty. Please re-enter first names seperated by comma: ");
                firstNamesCommaSeperated = Console.ReadLine();
                firstNamesCommaSeperated = Regex.Replace(firstNamesCommaSeperated, @"\s", "").Trim(',');
            }
            

            //remove , from start and end, split into firstNamesSeperated
            string[] firstNames = firstNamesCommaSeperated.Trim(',').Split(',');

            //loop through the array and say hello
            for (int i = 0; i < firstNames.Length; i++) 
            {
                if (firstNames[i] != "")    //ignore empty array elements
                {
                    Console.WriteLine($"Hello {firstNames[i]}");
                }
            }
            Console.ReadLine();
        }
    }
}

//Ask a user for a comma seperated list of firstnames (no spaces)
//Split the string into string array
//Loop through the array and tell each person hello
