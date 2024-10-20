using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public static class PerformCalculation
    {
        public static double AddNumbers(double x, double y)
        {
           double output = x + y;
           return output;
        }

        public static double SubtractNumbers(double x, double y)
        {
            double output = x - y;
            return output;
        }

        public static double MultiplyNumbers(double x, double y)
        {
            double output = x * y;
            return output;
        }

        public static double DivideNumbers(double x, double y)
        {
            double output = x / y;
            return output;
        }
    }
}
