using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WrapUpDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<PersonModel> people = new List<PersonModel>
            {
                new PersonModel{ FirstName = "Tim", LastName = "Corey", Email = "timcorey@hotmail.com"},
                new PersonModel{ FirstName = "Sue", LastName = "Storm", Email = "sue@hsormy.net"},
                new PersonModel{ FirstName = "John", LastName = "Smith", Email = "john@aol.com"}
            };

            List<CarModel> cars = new List<CarModel>
            {
                new CarModel {Manufacturer = "Toyota", Model = "Corolla"},
                new CarModel {Manufacturer = "Toyota", Model = "Highlander"},
                new CarModel {Manufacturer = "Ford", Model = "Mustang"}
            };

            Console.ReadLine();
        }
    }

    public static class DataAccess
    {
        public static void SaveToCSV<T>(List<T> items) where T:new()   //generic extension method
        {
            List<string> rows = new List<string>();
            T entry = new T();
            var cols = entry.GetType().GetProperties();  //gets the properties

            string row = "";
            foreach (var col in cols)
            {
                row += $"{col.Name}, ";
            }

            13:49

        }
    }
}
