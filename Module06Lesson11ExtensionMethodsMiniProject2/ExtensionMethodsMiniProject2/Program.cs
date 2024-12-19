using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodsMiniProject2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmployeeModel employee = new EmployeeModel();

            employee.FirstName = "Please enter your first name: ".GetString();

            employee.LastName = "Please enter your last name: ".GetString();

            employee.Age = ("Please enter your age: ".GetString()).StringToInt();
             
        }
    }

    public class EmployeeModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }

    public static class ConsoleHelper
    {
        public static string GetString(this string message)
        {
            string input = string.Empty;
            while (String.IsNullOrEmpty(input))   //While string is null or empty
            {
                Console.Write(message);
                input = Console.ReadLine();
            }
            return input;
        }

        public static int StringToInt(this string value, bool enforceRange)
        {
            if (enforceRange)
            {
                return value.StringToInt(1, 80);
            }
            else
            {
                return value.StringToInt();
            }
        }

        public static int StringToInt(this string value)
        {
            int output = 0;

            while (true)
            {
                if (int.TryParse(value, out output))
                {
                    return output;
                }
                Console.Write("Not a number ! Please re-enter data: ");
                value = Console.ReadLine();
            }
        }

        public static int StringToInt(this string value, int min, int max)
        {
            int output = 0;
            
            while (true)
            {
                if (int.TryParse(value, out output) && output >= min && output <= max)
                { 
                    return output;
                }
                Console.Write("Not a number ! Please re-enter between {min} and {max}: ");
                value = Console.ReadLine();
            }
        }
    }
}
