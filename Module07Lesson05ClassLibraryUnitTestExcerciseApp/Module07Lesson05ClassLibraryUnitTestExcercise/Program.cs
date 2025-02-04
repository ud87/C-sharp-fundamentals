// See https://aka.ms/new-console-template for more information

using MathLibrary;
using System.Threading.Channels;

internal class Program
{
    private static void Main(string[] args)
    {
        int x = CheckUserInputIsNumber("Please enter first number: ");
        int y = CheckUserInputIsNumber("Please enter second number: ");

        SelectMathOperation(x, y);

        static int CheckUserInputIsNumber(string msg)
        {
            bool isInputNumber;
            int number;

            do
            {
                Console.Write(msg);
                string input = Console.ReadLine();

                isInputNumber = int.TryParse(input, out number);

                if (!isInputNumber)
                {
                    Console.WriteLine("Invalid number\n");
                }

            } while (!isInputNumber);

            return number;
        }


        static void SelectMathOperation(int x, int y)
        {
            string input;
            int output;

            do
            {
                Console.WriteLine("\nPlease select add, subtract, multiply, divide: ");
                input = Console.ReadLine();

                switch (input)
                {
                    case "add":
                        output = MathOperations.Add(x, y);
                        Console.WriteLine($"Adding {x} to {y} gives {output}");
                        break;

                    case "subtract":
                        output = MathOperations.Subtract(x, y);
                        Console.WriteLine($"Subtracting {x} from {y} results in {output}");
                        break;

                    case "multiply":
                        output = MathOperations.Multiply(x, y);
                        Console.WriteLine($"{x} multiply {y} is {output}");
                        break;

                    case "divide":
                        output = MathOperations.Divide(x, y);
                        Console.WriteLine($"Dividing {x} by {y} gives {output}");
                        break;

                    default:
                        input = "Not a valid operator";
                        Console.WriteLine(input);
                        break;

                }

            } while (input == "Not a valid operator");


        }
    }
}