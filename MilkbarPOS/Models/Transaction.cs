using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkbarPOS.Models
{
    public class Transaction
    {
        public int TransactionID { get; set; }
        public int UserID { get; set; }
        public DateTime Date { get; set; }
        public decimal TotalAmount { get; set; }
        public List<CartItem> Items { get; set; }

        public Transaction()
        {
            Items = new List<CartItem>();
        }

        public Transaction(int transactionId, int userId, DateTime date, decimal totalAmount, List<CartItem> items)
        {
            TransactionID = transactionId;
            UserID = userId;
            Date = date;
            TotalAmount = totalAmount;
            Items = items ?? new List<CartItem>();
        }
    }
}
