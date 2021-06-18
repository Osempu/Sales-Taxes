using System.Collections.Generic;

namespace Sales_Taxes.Logic.Models
{
    public class Ticket
    {
        public IEnumerable<Item> Items { get; set; }
        public decimal SalesTaxes { get; set; }
        public decimal Total { get; set; }
    }
}
