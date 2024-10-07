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
            //create a dictionary
            Dictionary<int, string> employeeRecord = new Dictionary<int, string>();

            //assign ID to dictionary
            employeeRecord[1] = "Udaya";
            employeeRecord[2] = "Renuka";
            employeeRecord[3] = "Sarita";
            employeeRecord[4] = "Manoj";
            employeeRecord[5] = "Anita";

            

            //ask user for the ID
            Console.Write($"Please enter employee id between 1 and {employeeRecord.Count}: ");
            string idText = Console.ReadLine();

            int id = 0;

            //convert idText to number and assign it to id
            bool isIdValid = int.TryParse(idText, out id) && id >= 1 && id <= employeeRecord.Count;   

            //loop until correct number is entered for employee Id input
            while (!isIdValid)  //while false
            {
                Console.Write($"Invalid employee id. Please enter value between 1 and {employeeRecord.Count}: ");
                idText = Console.ReadLine();
                isIdValid = int.TryParse(idText, out id) && id >= 1 && id <= employeeRecord.Count;
            }

            Console.WriteLine($"Student name is {employeeRecord[id]}");

            Console.ReadLine(); //to stop the program from exiting
        }
    }
}


/*
 Create a dictionary list of IDs and the name that goes with the ID. Fill it with few records.
Then ask the user for their ID and return their name
 */
