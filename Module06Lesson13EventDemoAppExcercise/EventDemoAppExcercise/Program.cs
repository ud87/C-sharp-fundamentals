using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDemoAppExcercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StockModel myStocksISA = new StockModel("My Stock ISA");

            myStocksISA.AccountTaxFreeLimit += MyStocksISA_AccountTaxFreeLimit;   //subscription

            myStocksISA.AddStock("Google", 20, 150).PrintToConsole();
            myStocksISA.AddStock("PLTR", 150, 80).PrintToConsole();
            myStocksISA.AddStock("Coinbase", 20, 300).PrintToConsole();
            myStocksISA.AddStock("Rocket Labs", 1000, 40).PrintToConsole();

            myStocksISA.DisplayStock();

            Console.ReadLine();
        }

        private static void MyStocksISA_AccountTaxFreeLimit(object sender, string e)
        {
            Console.WriteLine(e);
        }
    }

    public static class ConsoleHelpers
    {
        public static void PrintToConsole(this string message)
        {
            Console.WriteLine(message);
        }
    }

    public class StockModel
    {
        public event EventHandler<string> AccountTaxFreeLimit;  //event declaration
        public string AccountName { get; set; }
        public int TotalValue { get; set; }
        public Dictionary<string, int> StocksQty = new Dictionary<string, int>();   

        public StockModel(string accountType)
        {
            AccountName = accountType;
            //Stocks.Add(stock);      //add stock to Stocks List
        }

        public string AddStock(string stock, int qty, int price)
        {
            string output = "";
            int value = qty * price;
            StocksQty.Add(stock, value);
            TotalValue += value;

            if (TotalValue > 20000)
            {
                AccountTaxFreeLimit?.Invoke(this, $"{stock} was not added as it exceeds 20000");    //implementation
                StocksQty.Remove(stock);      //remove stock
                return output;
            }

            output = $"{stock} was added to {AccountName}";
            return output;
        }

        public void DisplayStock()
        {
            Console.WriteLine($"\n{AccountName} portfolio: ");
            foreach (var stock in StocksQty)
            {
                Console.WriteLine(stock.Key);
            }
        }
    }
}


/*
Create an event in a class and then consume that class. Attach a listener to the event and have it wire to the console  
*/