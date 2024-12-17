using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodDemoExcercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.FirstName = "John";
            person.LastName = "Doe";

            person.SetDefaultAge().PrintInfo();
        }
    }

    public class Person
    {
        public int Age { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public static class ExtensionPerson
    {
        public static Person SetDefaultAge(this Person person, int defaultAge = 18) //set default age as optional parameter
        { 
            person.Age = defaultAge;
            return person;
        }

        public static Person PrintInfo(this Person person)
        {
            Console.WriteLine($"Name: {person.FirstName} {person.LastName}, Age: {person.Age}");
            return person;
        }
        
    }
}


/*
Create the following chain using extension methods
person.SetDefaultAge().PrintInfo() 

 */
