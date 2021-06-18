using Sales_Taxes.Logic;

namespace Sales_Taxes
{
    class Program
    {
        static void Main(string[] args)
        {

            StoreView store = new StoreView(new Store(10.0m, 5.0m));
            store.ServeCustomer();
        }
    }
}
