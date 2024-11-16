using DotNetRestAPIDemo.Models;

namespace DotNetRestAPIDemo.Helper
{
    public static class SeedModelDatas
    {
        private static List<Product> products = new List<Product>();

        public async static Task<List<Product>> GetProductListAsync()
        {
            // Simulate an asynchronous operation
            await Task.Delay(100); // Simulates delay, replace with actual async call if needed

            // Products Dummy Records
            products = new List<Product>
            {
                new Product()
                {
                    Id = 1,
                    Name = "T-Shirt",
                    Description = "Cotton t-shirt with a comfortable fit.",
                    Category = "Clothing",
                    Supplier = "FashionSupplies Co.",
                    Barcode = "1234567890123",
                    Material = "100% Cotton",
                    Sizes = new List<string> { "S", "M", "L", "XL" },
                    PurchasePrice = 8.50m,
                    SalesPrice = 15.99m,
                    TaxRate = 5.00m,
                    Currency="USD"
                },
                new Product()
                {
                    Id = 2,
                    Name = "Wireless Mouse",
                    Description = "Ergonomic wireless mouse with 3 DPI settings.",
                    Category = "Electronics",
                    Supplier = "Gadget World",
                    Barcode = "9876543210987",
                    Material = "Plastic",
                    Sizes = new List<string>(), // Not applicable for this product
                    PurchasePrice = 12.00m,
                    SalesPrice = 25.99m,
                    TaxRate = 18.00m,
                    Currency="USD"
                },
                new Product()
                {
                    Id = 3,
                    Name = "Water Bottle",
                    Description = "Reusable stainless steel water bottle.",
                    Category = "Accessories",
                    Supplier = "EcoSuppliers",
                    Barcode = "4567891234567",
                    Material = "Stainless Steel",
                    Sizes = new List<string>(), // Not applicable for this product
                    PurchasePrice = 5.00m,
                    SalesPrice = 10.99m,
                    TaxRate = 10.00m,
                    Currency="USD"
                },
                new Product()
                {
                    Id = 4,
                    Name = "Running Shoes",
                    Description = "Lightweight running shoes with excellent grip.",
                    Category = "Footwear",
                    Supplier = "Athletic Gear",
                    Barcode = "3216549873216",
                    Material = "Mesh, Rubber",
                    Sizes = new List<string> { "8", "9", "10", "11" },
                    PurchasePrice = 30.00m,
                    SalesPrice = 59.99m,
                    TaxRate = 12.00m,
                    Currency="USD"
                },
                new Product()
                {
                    Id = 5,
                    Name = "Notebook",
                    Description = "A5 ruled notebook with 200 pages.",
                    Category = "Stationery",
                    Supplier = "Office Supplies Inc.",
                    Barcode = "6547893216547",
                    Material = "Paper",
                    Sizes = new List<string>(), // Not applicable for this product
                    PurchasePrice = 1.50m,
                    SalesPrice = 3.99m,
                    TaxRate = 5.00m,
                    Currency="USD"
                }
            };

            return products;
        }
    }
}
