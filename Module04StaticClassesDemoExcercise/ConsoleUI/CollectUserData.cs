using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public static class CollectUserData
    {
        //CollectNumbers
        public static double CollectNumber(string message)
        {
            Console.Write(message); //    ask for number input
            string numberText = Console.ReadLine();
            double number;

            bool isNumberValid = double.TryParse(numberText, out number);

            while (!isNumberValid)    //isNumberValid == false
            {
                Console.Write("Entered value is not a number. Please enter number: "); //    re-ask for number input
                numberText = Console.ReadLine();        //re-store number entered by user

                isNumberValid = double.TryParse(numberText, out number);    //re-evaluate if entered value is a number
            }
            return number;
        }

    }
}
