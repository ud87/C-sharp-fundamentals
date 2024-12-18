 using System;

namespace ExtensionMethodsMiniProject
{
    public static class ConsoleHelper   //extension method, put them into 
    {
        public static string RequestString(this string message)
        {
            string output = "";
            
            while (string.IsNullOrEmpty(output))
            {
                Console.Write(message);
                output = Console.ReadLine();
            }
            return output;
        }

        public static int RequestInt(this string message, int minValue, int maxValue)
        {
            return message.RequestInt(true, minValue, maxValue);
        }

        public static int RequestInt(this string message)
        {
            return message.RequestInt(false);
        }

        private static int RequestInt(this string message, bool useMinMax, int minValue = 0, int maxValue = 0)  //min and max values are optional params
        {
            int output = 0;
            bool isValidInt = false;
            bool isInValidRange = true;

            while (isValidInt == false || isInValidRange == false)   //run while loop until output is number
            {
                Console.Write(message);
                isValidInt = int.TryParse(Console.ReadLine(), out output);

                if (useMinMax == true)
                {
                    isInValidRange = (output >= minValue && output <= maxValue);

                    /*
                    if (output >= minValue && output <= maxValue)
                    {
                        isInValidRange = true;
                    }
                    else
                    {
                        isInValidRange = false;
                    }
                    */
                }
            }
            return output;
        }

    }
}


/*
 Categorize extension method by type string helper, console helper, int helper, double helper, etc and put it inside class library 
 
 */
