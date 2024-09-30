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
            //***************************string variable*************************************************************************
            string randomWord = "";   //string is a data type, firstName is the name of variable, "" is blank string assigned
            randomWord = "\"testIng 102345$@(>><";     // \" here \ is a escape character and allows us to store " without errors 
            Console.WriteLine(randomWord);         //uses the variable

            string filePath = "C:\\Temp\\Test.txt";     // \ escapes \ resulting in C:\Temp\Test.txt
            Console.WriteLine(filePath);
            Console.WriteLine("\n");                //creates a newline

            //string literals allows us to use escape and treats everything as string
            string link = @"https:\\www.google.co.uk";
            Console.WriteLine(link);

            //string interpolation allows us to use variables directly
            string firstName = "Udaya";
            string lastName = "Rai";
            string fullName = "";

            fullName = $"{firstName} {lastName}";
            Console.WriteLine(fullName);



            //***************************************Int variable****************************************************************
            //int is a whole number, can be a negative no but cannot be 
            int age = 0;

            age = 10;   //unsigned integer is positive
            age = -5;   //signed integer is negative



            //**************************************Double variable**************************************************************
            //Double holds a decimal point. Is only precise to 14-15 decimal points
            //store numbers in double unless its money
            double averageWordsPerMinute = 34.24;



            //**************************************Decimal variable**************************************************************
            //decimals are much more precise than doubles but holds requires more memory, more processing power
            //if dealing with money then use decimal
            decimal costPerContainer = 45.85M;        //all decimals should have a M in the assigned value otherwise computer thinks its double



            //**************************************Boolean ***********************************************************************
            //Only stores true or false
            bool isAlive = false;

            Console.ReadLine();
        }
    }
}


/*Notes
Job of a variable is to hold data and store information
name of the variable must be self explanatory
It's always a good practice to initialize a value even if it's blank or 0
variable names are case sensitive
what type of variable to use must be thought before declaring variable 
for e.g. using phone number as int may remove the initial zero
 
 
 */
