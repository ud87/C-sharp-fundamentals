using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverRidingDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //instantiate PersonModel class
            PersonModel person = new PersonModel
            {
                FirstName = "Udaya",
                LastName = "Rai",
                Email = "udayarai@udayarai.co.uk"
            };
            Console.WriteLine(person); 

            Console.ReadLine();
        }
    }

    public abstract class Car
    {
        public virtual void StartCar()
        {
            Console.WriteLine("Turn Key and Start!");
        }

        public abstract void SetClock();
    }

    public class Corolla : Car
    {
        public override void SetClock()
        {
            Console.WriteLine("Fiddle with the Corolla clock");
        }
    }

    public class Tesla : Car
    {
        public override void StartCar()
        {
            Console.WriteLine("Think about your destination");
        }
        public override void SetClock()
        {
            Console.WriteLine("It sets itself");
        }

        
    }
}
