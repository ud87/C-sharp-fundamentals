using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module06InheritanceDemo
{
    partial class Program
    {
        static void Main(string[] args)
        {
            List<Phone> phones = new List<Phone>();

            phones.Add(new Cellphone());
            phones.Add(new Smartphone());

            foreach (var phone in phones)
            {
                if (phone is Cellphone cell)
                {
                    cell.Carrier = "";
                }

                if (phone is Smartphone smartphone)
                {
                    smartphone.ConnectToInternet();
                }
            }



            //Excercise
            Motorcycle motorcycle = new Motorcycle();
            

            Console.ReadLine();
        }


        //Excercise 
        public class Motorcycle : Vehicle
        {
            int noOfWheels { get; set; }
        }
        public class Boat: Vehicle
        {
            string hullType = "";
        }
        public class Car: Vehicle
        {
            int noOfWheels {  get; set; }
        }
        public class Vehicle
        {
            int yearOfManufacture { get; set; }
            string fuel { get; set; }
            public void start()
            {

            }

            public void stop()
            {

            }
        }
    }
}




/*
 We can put code into a class and say there's another class 
like it for e.g. child of it and it want to use all of the 
functionality in the child class
 
you cannot directly inherit from more than one parent

we can have double inheritance if it follows is a relationship i.e. grandchild, grand parent relationship

if a property does not apply we should not inherit it

if it doesn't follow is a relationship then inheritance should not be used
if code repeats then create a class and call instances from that class
 
 */