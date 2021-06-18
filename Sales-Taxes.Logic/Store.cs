using Sales_Taxes.Logic.Models;
using Sales_Taxes.Logic.StoreComponents.Components;
using Sales_Taxes.Logic.StoreComponents.IComponents;
using System.Collections.Generic;

namespace Sales_Taxes.Logic
{
    public class Store
    {
        public ITaxesCalculator TaxesCalculator { get; private set; }
        public ITicketPrinter TicketPrinter { get; private set; }

        public Store(decimal salesTaxes, decimal importTaxes)
        {
            TaxesCalculator = new TaxesCalculator(salesTaxes, importTaxes);

            TicketPrinter = new TicketPrinter();
        }
    }
}
