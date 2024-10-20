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
            double firstNumber = CollectUserData.CollectNumber("Please enter first number: ");
            double secondNumber = CollectUserData.CollectNumber("Please enter second number: ");

            double addResult = PerformCalculation.AddNumbers(firstNumber, secondNumber);
            double subtractResult = PerformCalculation.SubtractNumbers(firstNumber, secondNumber);
            double multiplyResult = PerformCalculation.MultiplyNumbers(firstNumber, secondNumber);
            double divideResult = PerformCalculation.DivideNumbers(firstNumber, secondNumber);

            string Result = UserMessage.DisplayMessage($@"{firstNumber} and {secondNumber}
    sum is {addResult}
    difference is {subtractResult}
    multiplication is {multiplyResult}
    division is {divideResult}");
            
            Console.WriteLine(Result);

            Console.ReadLine();
        }
    }
}



/*
 Create a console application with a static class that handles calculations

Pseudocode
    class CollectUserData
        CollectNumbers
            type double
            ask for number input

    class UserMessage
        DisplayMessage
            type string

    class PerformCalculation
        methods
            add
            subtract
            divide
            multiply
 
 */