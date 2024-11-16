namespace DotNetRestAPIDemo.Models
{
    public class Product
    {
        public int Id { get; set; } = 0;
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
        public string Supplier { get; set; } = string.Empty;
        public string Barcode { get; set; } = string.Empty;
        public string Material { get; set; } = string.Empty;
        public List<string> Sizes { get; set; } = new List<string>();
        public decimal PurchasePrice { get; set; } = 0_00;
        public decimal SalesPrice { get; set; } = 0_00;
        public decimal TaxRate { get; set; } = 0_00;
        public string Currency { get; set; } = string.Empty;
    }
}
