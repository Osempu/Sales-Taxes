
using Sales_Taxes.Logic.Models;
using Sales_Taxes.Logic.StoreComponents.IComponents;
using System;
using System.Collections.Generic;

namespace Sales_Taxes.Logic.StoreComponents.Components
{
    public class TaxesCalculator : ITaxesCalculator
    {
        private decimal SalesTaxes { get; set; }
        private decimal ImportTaxes { get; set; }

        public TaxesCalculator(decimal salesTaxes, decimal importTaxes)
        {
            this.SalesTaxes = salesTaxes / 100;
            this.ImportTaxes = importTaxes / 100;
        }

        /// <summary>
        /// Takes the list of items added to the basket by the customer and performs
        /// the correspondig calculations to return a ticket item ready to be printed.
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        public Ticket CalculateTotal(IEnumerable<Item> items)
        {
            decimal totalTaxes = 0.0m;
            decimal bigTotal = 0.0m;

            foreach (var item in items)
            {
                if (item.IsTaxable && item.IsImported)
                {
                    item.SalesTaxes = RoundToNearest5(item.Price * SalesTaxes);
                    item.ImportTaxes = RoundToNearest5(item.Price * ImportTaxes);
                    item.Price += SalesTaxes + ImportTaxes;

                    totalTaxes += item.SalesTaxes + item.ImportTaxes;
                    bigTotal += item.Price;

                    continue;
                }

                if (item.IsTaxable)
                {
                    item.SalesTaxes = RoundToNearest5(item.Price * SalesTaxes);
                    item.Price += item.SalesTaxes;

                    totalTaxes += item.SalesTaxes;
                    bigTotal += item.Price;
                }
                else if (item.IsImported)
                {
                    item.ImportTaxes = RoundToNearest5(item.Price * ImportTaxes);
                    item.Price += ImportTaxes;

                    totalTaxes += item.ImportTaxes;
                    bigTotal += item.Price;
                }
                else
                {
                    bigTotal += item.Price;
                }
            }


            return new Ticket
            {
                Items = items,
                SalesTaxes = totalTaxes,
                Total = bigTotal
            };
        }


        /// <summary>
        /// Function to round a decimal value up tp the nearest 5 cents
        /// </summary>
        /// <param name="value"></param>
        /// <returns>The rounded value</returns>
        private static decimal RoundToNearest5(decimal value)
        {
            var ceiling = Math.Ceiling(value * 20);
            if (ceiling == 0)
            {
                return 0;
            }
            return ceiling / 20;
        }
    }
}
