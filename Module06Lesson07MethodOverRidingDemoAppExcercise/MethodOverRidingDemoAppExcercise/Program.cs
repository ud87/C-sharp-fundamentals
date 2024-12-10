using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverRidingDemoAppExcercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person
            {
                FirstName = "Udaya",
                LastName = "Rai",
                Email = "udayarai@aol.com"
            };

            Console.WriteLine(person);


            Employee employee = new Employee();
            Console.WriteLine(employee.Introduce());

            Console.ReadLine();
        }
    }

    public abstract class Greeting
    {
        public abstract string Introduce();
    }

    public class Employee : Greeting
    {
        public override string Introduce()
        {
            return $"Hi I am a permanent employee";
        }
    }

    public class Contractor : Greeting 
    {
        public override string Introduce()
        {
            return $"Hi I am a contractor";  
        }
    }
}


/*
Create a person class and override the ToString method in it. 
Make it return the user's first and last name
add a abstract method to the person class then override the method in an employee class which inherits from a person
 */
