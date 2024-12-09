using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            InventoryItem item = new Book();  //we cannot directly instantiate InventoryItem, we have to inherit from another class before we can use it

            item.ProductName = "Huh";


            Vehicle vehicle = new Car();

            Aircraft aircraft = new Aircraft();
            aircraft.Move();

            Car car = new Car();
            car.Move();

            Console.ReadLine();
        }
    }


    public abstract class Vehicle    //could be anything
    {
        public string VIN { get; set; }    //identifies every vehichle unique
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public int YearManufactured { get; set; }

        
    }

    public interface MethodOfMovement
    {
        string Move();
    }

    public class Car : Vehicle, MethodOfMovement          //can be purchased
    {
        public int NumberOfWheels { get; set; } = 4;
        public string Move()
        {
            string output = "Car moves by rotating it's wheel on the ground";
            Console.WriteLine(output);
            return output;
        }
    }

    public class Aircraft : Vehicle, MethodOfMovement
    {
        public string Move()
        {
            string output = "Aircraft flies by pushing air through its engine to generate Lift";
            Console.WriteLine(output);
            return output;
        }
    }
}


/*
 its a class that's a base class (foundational) but its not complete on its own, its abstract
for eg. book has author, page, title, and is a real thing where as inventory item is not a thing and is abstract
we cannot directly instantiate abstract class
 don't forget to follow "is a " rule



 */
