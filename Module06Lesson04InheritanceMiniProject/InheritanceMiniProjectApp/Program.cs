using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceMiniProjectApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<InventoryItemModel> inventory = new List<InventoryItemModel> ();
            List <IRentable> rentables = new List<IRentable> ();
            List <IPurchaseable> purchaseables = new List<IPurchaseable> ();

            var vehicle = new VehicleModel { DealerFee = 25, ProductName = "Kia Optima" };
            var book = new BookModel { ProductName = "A Tale of Two cities", NumberOfPages = 350 };
            var excavator = new ExcavatorModel { ProductName = "Bulldozer", QuantityInStock = 2 };
            
            rentables.Add(vehicle);
            rentables.Add(excavator);

            purchaseables.Add(book);
            purchaseables.Add(vehicle);

            Console.WriteLine("Do you want to rent or purchase something: (rent, purchase)");
            string rentalDecision = Console.ReadLine();

            if (rentalDecision.ToLower() == "rent")
            {
                foreach (var item in rentables)
                {
                    Console.WriteLine($"{item.ProductName}");
                    Console.Write("Do you want to rent this item (yes / no): ");
                    string wantToRent = Console.ReadLine();

                    if (wantToRent.ToLower() == "yes")
                    {
                        item.Rent();
                    }

                    Console.Write("Do you want to return this item (yes / no): ");
                    string wantToReturn = Console.ReadLine();

                    if (wantToReturn.ToLower() == "yes")
                    {
                        item.ReturnRental();
                    }
                }
            }
            else
            {
                foreach (var item in purchaseables)
                {
                    Console.WriteLine($"{item.ProductName}");
                    Console.Write("Do you want to purchase this item (yes / no): ");
                    string wantToPurchase = Console.ReadLine();

                    if ( wantToPurchase.ToLower() == "yes")
                    {
                        item.Purchase();
                    }
                }
            }

            Console.WriteLine("We are done");

            Console.ReadLine();
        }
    }
}
