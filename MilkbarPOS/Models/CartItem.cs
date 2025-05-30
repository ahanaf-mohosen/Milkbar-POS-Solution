using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkbarPOS.Models
{
    public class CartItem
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        // Computed property for the total price of this cart item
        public decimal Total => Quantity * Price;

        public CartItem() { }

        public CartItem(int productId, string productName, int quantity, decimal price)
        {
            ProductID = productId;
            ProductName = productName;
            Quantity = quantity;
            Price = price;
        }
    }
}
