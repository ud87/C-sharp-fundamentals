using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExcercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            Animal animal = new Animal();

            person1.Run();
            animal.Run();

            Console.ReadLine();
        }
    }

    public interface IRun
    {
        void Run();
    }

    public class Person : IRun
    {
        public void Run()
        {
            Console.WriteLine("running !!!");
        }
    }

    public class Animal : IRun
    {
        public void Run()
        {
            Console.WriteLine($"Animal is running !!!");
        }
    }
} 



/*
 Create an IRun interface and apply it to a Person class and an Animal class. Store both types in a List<IRun> object
 */