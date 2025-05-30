using System;

namespace MilkbarPOS.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }

        public Product() { }

        public Product(int productId, string productName, decimal price, int stockQuantity)
        {
            ProductID = productId;
            ProductName = productName;
            Price = price;
            StockQuantity = stockQuantity;
        }
    }
}
