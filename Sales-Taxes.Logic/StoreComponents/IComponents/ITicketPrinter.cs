using Sales_Taxes.Logic.Models;

namespace Sales_Taxes.Logic.StoreComponents.IComponents
{
    public interface ITicketPrinter
    {
        void PrintTicket(Ticket ticket);
    }
}
