using Sales_Taxes.Enums;
using Sales_Taxes.Logic;
using Sales_Taxes.Logic.Models;
using Sales_Taxes.MockData;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Sales_Taxes
{
    public class StoreView
    {
        private readonly Store store;

        public StoreView(Store store)
        {
            this.store = store;
        }

        /// <summary>
        /// Prints the store menu and takes user input to perform corresponding action
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Item> ServeCustomer()
        {
            IEnumerable<Item> order = new List<Item>();

            while (true)
            {
                Console.WriteLine("=================================================");
                Console.WriteLine("Welcome dear customer, what would you like to do?");
                Console.WriteLine("1 => Add Item to Basket");
                Console.WriteLine("2 => Print Order");
                Console.WriteLine("3 => Exit Store");

                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        ConsoleUtil.ClearConsole();
                        order = TakeOrder();
                        break;
                    case 2:
                        if (!order.Any())
                        {
                            ConsoleUtil.ClearConsole();
                            ConsoleUtil.PrintAlert($"There are no items in your basket", AlertEnum.Info);
                            break;
                        }
                        else
                        {
                            var ticket = store.TaxesCalculator.CalculateTotal(order);
                            store.TicketPrinter.PrintTicket(ticket);
                        }
                        return order;
                    case 3:
                        return null;
                    default:
                        return null;
                }
            }
        }

        /// <summary>
        /// Reads the in-memory store catalog and returns a descriptive name based on if the product is
        /// imported or not and also appends the product price at the end.
        /// </summary>
        /// <param name="storeCatalog"></param>
        private void DisplayStoreCatalog(IEnumerable<Item> storeCatalog)
        {
            var catalogArr = storeCatalog.ToArray();
            for (int i = 0; i < storeCatalog.Count(); i++)
            {

                string itemName = catalogArr[i].IsImported ? $"Imported {catalogArr[i].Name}" : catalogArr[i].Name;
                Console.WriteLine($"[{i + 1}] {itemName} at {catalogArr[i].Price}");
            }
        }

        /// <summary>
        /// Takes the input from the user to select the item from the catalog.
        /// </summary>
        /// <returns></returns>
        private IEnumerable<Item> TakeOrder()
        {
            Item selectedItem = null;
            var storeCatalog = StoreCatalog.GetStoreCatalog();
            List<Item> basket = new List<Item>();

            while (true)
            {
                ConsoleUtil.ClearConsole();

                if (selectedItem != null)
                {
                    ConsoleUtil.PrintAlert($"{selectedItem.Name} added to your basket", AlertEnum.Notification);
                }

                Console.WriteLine("Plaease select the item you want to add to your basket");
                DisplayStoreCatalog(storeCatalog);
                Console.WriteLine("[b] To go Back to Store Menu");

                string userInput = Console.ReadLine();

                if (userInput == "b")
                {
                    ConsoleUtil.ClearConsole();
                    return basket;
                }

                if (!Int32.TryParse(userInput, out int inputAsInt))
                {
                    ConsoleUtil.PrintAlert("Invalid item, please insert a valid item number", AlertEnum.Warning);
                }

                if (inputAsInt > storeCatalog.Count())
                {
                    ConsoleUtil.PrintAlert("The item you selected does not exists", AlertEnum.Warning);
                }
                else
                {
                    selectedItem = storeCatalog.ElementAt(inputAsInt - 1);
                    basket.Add(selectedItem);
                }
            }
        }


    }
}
