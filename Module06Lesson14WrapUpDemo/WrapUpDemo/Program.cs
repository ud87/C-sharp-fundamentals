using System;
using System.Collections.Generic;
using System.IO;
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

            DataAccess<PersonModel> peopleData = new DataAccess<PersonModel>();
            peopleData.BadEntryFound += PeopleData_BadEntryFound;

            DataAccess<CarModel> carData = new DataAccess<CarModel>();
            carData.BadEntryFound += CarData_BadEntryFound;

            peopleData.SaveToCSV(people, @"C:\Temp\SavedFiles\people.csv");  //@ tells us there are no escape characters
            carData.SaveToCSV(cars, @"C:\Temp\SavedFiles\cars.csv");

            Console.ReadLine();
        }

        private static void CarData_BadEntryFound(object sender, CarModel e)
        {
            Console.WriteLine($"Bad Entry found for {e.Manufacturer} {e.Model}");
        }

        private static void PeopleData_BadEntryFound(object sender, PersonModel e)
        {
            Console.WriteLine($"Bad Entry found for {e.FirstName} {e.LastName}");
        }
    }

    public class DataAccess<T> where T : new()
    {
        public event EventHandler<T> BadEntryFound;
        public void SaveToCSV(List<T> items, string filePath)   //generic extension method
        {
            List<string> rows = new List<string>();
            T entry = new T();
            var cols = entry.GetType().GetProperties();  //gets the properties

            string row = "";
            foreach (var col in cols)
            {
                row += $",{col.Name}";
            }
            row = row.Substring(1);  //will start from 1st index
            rows.Add(row);

            bool badWordDetected = false;

            foreach (var item in items)
            {
                row = "";
                foreach (var col in cols)
                {
                    string val = col.GetValue(item, null).ToString();

                    badWordDetected = BadWordDetector(val);
                    if (badWordDetected == true)
                    { 
                        BadEntryFound?.Invoke(this, item);
                        break;      //break us out of for loop
                    }
                    row += $",{val}";
                }

                if (badWordDetected == false)
                {
                    row = row.Substring(1);  //will start from 1st index
                    rows.Add(row);
                }
            }

            File.WriteAllLines(filePath, rows);

            

        }

        private bool BadWordDetector(string stringToTest)  //will test if a bad workd is in string
        {
            bool output = false;
            string lowerCaseTest = stringToTest.ToLower();

            if (lowerCaseTest.Contains("darn") || lowerCaseTest.Contains("heck"))
            {
                output = true;
            }

            return output;
        }
    }
}
