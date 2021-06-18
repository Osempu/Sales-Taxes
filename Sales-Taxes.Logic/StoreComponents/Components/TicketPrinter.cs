using Sales_Taxes.Logic.Models;
using Sales_Taxes.Logic.StoreComponents.IComponents;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sales_Taxes.Logic.StoreComponents.Components
{
    public class TicketPrinter : ITicketPrinter
    {

        /// <summary>
        /// Taskes a ticket as in parameter and prints it in the specified format.
        /// </summary>
        /// <param name="ticket"></param>
        public void PrintTicket(Ticket ticket)
        {
            StringBuilder sb = new StringBuilder();

            ticket.Items = GroupItems(ticket.Items);

            foreach (var item in ticket.Items)
            {
                string itemName = item.IsImported ? $"Imported {item.Name}" : item.Name;

                if (item.Qty > 1)
                {
                    sb.AppendLine($"{itemName}: {item.Price * item.Qty} ({item.Qty} @ {item.Price + item.SalesTaxes})");
                }else
                {
                    sb.AppendLine($"{itemName}: {item.Price + item.SalesTaxes}");
                }
            }

            sb.AppendLine($"Sales Taxes: {ticket.SalesTaxes}");
            sb.AppendLine($"Total: {ticket.Total}");

            string printedTicket = sb.ToString();
            System.Console.WriteLine(printedTicket);
        }

        /// <summary>
        /// This function groups the items in the list with the same attributes.
        /// </summary>
        /// <param name="items"></param>
        /// <returns>An item list with the repeated items grouped into 1 and with the count
        /// attribute of that elemnt sames as the number of repeated items</returns>
        private IEnumerable<Item> GroupItems(IEnumerable<Item> items)
        {
            var result = items.GroupBy(x => new { x.Name, x.Price, x.IsImported })
                            .Select(x => new Item
                            {
                                Name = x.Key.Name,
                                Qty = x.Count(),
                                Price = x.Key.Price,
                                IsImported = x.Key.IsImported,
                            }).ToList();

            return result;
        }
    }
}
