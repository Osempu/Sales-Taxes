using Sales_Taxes.Logic.Models;
using System.Collections.Generic;

namespace Sales_Taxes.MockData
{
    public static class StoreCatalog
    {

        //Hardcoded store catalog
        public static List<Item> GetStoreCatalog()
        {
            return new List<Item>
            {
                new Item {Name = "Book", Price = 12.49m, IsTaxable = false, IsImported = false},
                new Item {Name = "Music CD", Price = 14.99m, IsTaxable = true, IsImported = false},
                new Item {Name = "Chocolate Bar", Price = 0.85m, IsTaxable = false, IsImported = false},
                new Item {Name = "Bottle of perfume", Price = 12.49m, IsTaxable = true, IsImported = false},
                new Item {Name = "Bag of chips", Price = 3.99m, IsTaxable = false, IsImported = false},
                new Item {Name = "Cellphone charger", Price = 10.00m, IsTaxable = true, IsImported = false},
                new Item {Name = "Bag of donuts", Price = 7.99m, IsTaxable = false, IsImported = false},
                new Item {Name = "Packet of headache Pills", Price = 9.75m, IsTaxable = false, IsImported = false},
                new Item {Name = "Packet of painkillers", Price = 11.39m, IsTaxable = false, IsImported = false},

                //Imported products
                new Item {Name = "Book", Price = 12.49m, IsTaxable = false, IsImported = true},
                new Item {Name = "Music CD", Price = 14.99m, IsTaxable = true, IsImported = true},
                new Item {Name = "Chocolate Bar", Price = 0.85m, IsTaxable = false, IsImported = true},
                new Item {Name = "Bottle of perfume", Price = 12.49m, IsTaxable = true, IsImported = true},
                new Item {Name = "Bag of chips", Price = 3.99m, IsTaxable = false, IsImported = true},
                new Item {Name = "Cellphone charger", Price = 10.00m, IsTaxable = true, IsImported = true},
                new Item {Name = "Bag of donuts", Price = 7.99m, IsTaxable = false, IsImported = true},
                new Item {Name = "Packet of headache Pills", Price = 9.75m, IsTaxable = false, IsImported = true},
                new Item {Name = "Packet of painkillers", Price = 11.39m, IsTaxable = false, IsImported = true},
            };
        } 
    }
}
