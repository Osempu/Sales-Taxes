namespace Sales_Taxes.Logic.Models
{
    public class Item
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Qty { get; set; }
        public bool IsTaxable { get; set; }
        public bool IsImported { get; set; }
        public decimal SalesTaxes { get; set; }
        public decimal ImportTaxes { get; set; }
    }
}
