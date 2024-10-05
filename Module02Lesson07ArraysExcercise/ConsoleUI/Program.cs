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
            //Create an array with 3 names
            string[] names = new string[] {"Udaya", "Renuka", "Tika"};

            //ask user input
            Console.Write("Select a number from 1 to 3: ");
            string choiceText = Console.ReadLine();
            bool isValidChoice = int.TryParse(choiceText, out int choice) && (choice >= 1 && choice <= 3);

            while (!isValidChoice)  //while isValidChoice = false
            {
                Console.Write("Invalid input. Please enter between 1 and 3: ");
                choiceText = Console.ReadLine();
                isValidChoice = int.TryParse(choiceText, out choice) && (choice >= 1 && choice <= 3);
            }

            //Print out array name
            Console.WriteLine($"You have selected {names[choice - 1]}");  //index starts at 0 so minus one used


            Console.ReadLine();
        }
    }
}

/*
 Create an array with 3 names. Ask the user number to select. When a user gives a number return that name
 */
