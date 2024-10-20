﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public static class RequestData
    {
        public static string GetAString(string message)
        {
            Console.Write(message);
            string output = Console.ReadLine();
            return output;
        }

        public static double GetADouble(string message)
        {
            Console.Write(message);
            string numberText = Console.ReadLine();
            double output;

            bool isDouble = double.TryParse(numberText, out output);

            while (!isDouble)
            {
                Console.WriteLine("That was not a valid number. Please try again.");
                Console.Write(message);
                numberText = Console.ReadLine();

                isDouble = double.TryParse(numberText, out output);
            }

            return output;
        }
    }
}
