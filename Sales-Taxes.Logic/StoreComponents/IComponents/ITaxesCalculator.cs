using Sales_Taxes.Logic.Models;
using System.Collections.Generic;

namespace Sales_Taxes.Logic.StoreComponents.IComponents
{
    public interface ITaxesCalculator
    {
        Ticket CalculateTotal(IEnumerable<Item> items);
    }
}