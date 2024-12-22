using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<string> stringList = new List<string>();
            //List<int> intList = new List<int>();

            //intList.Add(1);
            //string result = FizzBuzz("123");
            //Console.WriteLine($"123: { result }");
            //result = FizzBuzz(new PersonModel { FirstName = "Tim", LastName = "Corey" });

            GenericHelper<PersonModel> peopleHelper = new GenericHelper<PersonModel>();
            peopleHelper.CheckItemAndAdd(new PersonModel { FirstName = "Tim", HasError = true});
            

            foreach (var item in peopleHelper.RejectedItems)
            {
                Console.WriteLine($"{item.FirstName} {item.LastName} was rejected.");
            }

            Console.ReadLine();
        }

        //if divisible by 3 - Fizz, 5 - Buzz, 3 & 5 - FizzBuzz
        private static string FizzBuzz<T>(T item) //<T> says method is going to use one generic type T, T, U is a convention
        {
            int itemLength = item.ToString().Length;
            string output = "";

            if (itemLength % 3 == 0)
            {
                output += "Fizz";
            }

            if (itemLength % 5 == 0)
            {
                output += "Buzz";
            }
            return output;
        }
    }

    public class GenericHelper<T> where T : IErrorCheck
    {
        public List<T> Items { get; set; } = new List<T>();
        public List<T> RejectedItems { get; set; } = new List<T>();
        public void CheckItemAndAdd (T item)
        {
            if (item.HasError == false)
            {
                Items.Add(item);
            }
            else
            {
                RejectedItems.Add(item);
            }
            
        }
    }

    public interface IErrorCheck
    {
        bool HasError { get; set; }
    }

    public class CarModel : IErrorCheck
    {
        public string Manufacturer { get; set; }
        public int YearManufactured { get; set; }
        public bool HasError { get; set; }
    }

    public class PersonModel : IErrorCheck
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool HasError { get; set; }
    }
}


/*
What is a generic item ?
Generic item allows us to define classes, methods, and data structures that can operate with any data type while maintaining type safety. So this works with any datatype we provide.

Why do we need Generics ?
We need generics to ensure type safetey i.e. ensure compile time type checking and prevent runtime errors
It also allows us to write one method or class that works with any data type
It also increases the performance as it avoids boxing/ unboxing for value types 
 
How do we create Generics ?
We create generics by adding <T> to class and methods
class example:
    public class GenericHelper<T>
    {  
        private T item;
        
        public T GetItem()  //No need to declare <T> as it has already been declared in the class
        { 
            return item
        }
    }

method example: 
    public static void Print<T, U>(T input1, U input2)  //we can also have more than 1 generic type
    {
        Console.WriteLine(input1)
        Console.WriteLine(input2)
    }

interface example:
    public interface IImportance<T>
    {
        T MostImportant(T a, T b);
    }

    public class EvaluateImportance :  IImportance<int>, IImportance<string>    //implement in a class
    {
        public int MostImportant(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else return b;
        }

        public string MostImportant(string a, string b)
        {
            if (a.Length > b.Length)
            {
                return a;
            }
            else return b;
        }
    }
 
constrains example:
    public class SampleClass<T> whereT : class, new()   //this must have a class and an empty constructor
    {
        
    }
 */
