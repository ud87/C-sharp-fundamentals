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
            string firstName = RequestData.GetAString("What is your first name ? ");

            usermessages.ApplicationStartMessage(firstName);

            double x = RequestData.GetADouble("Please enter your first number: ");
            double y = RequestData.GetADouble("Please enter your second number: ");

            double result = CalculateData.Add(x,  y);

            usermessages.PrintResult($"The sum of {x} and {y} is {result}");
            Console.ReadLine();
            
        }

        
    }

    
}


/*
 static means we get one copy for entire application for e.g. if we store data, it gets stored for the entire lifecycle of app
to create a new class right click on ConsoleUI on solution explorer and then click New item or class (same thing)
if you make your class public we can access different class programs
why do we need different class ? Because it allows us to make things more organised also it makes it more modular and easier to find things
If a new developer comes on board then it also makes it easier for them to follow the codebase and avoid creating same methods
Classes should do one thing for eg. take data, display user message, etc. Class can have more than one method but should do one logical thing
Its not a good practice to store data inside class unless its a specific type where you want to track for the entire life of the app for e.g. whos logged in etc
assume we are not going to store data in static classes by default it uses a lot of memory and increases footprint
Use class files to seperate your code so that each class and each method has its own purpose
 */