using System;

namespace vending_machine_library.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal TotalAmount { get; set; }

        public Transaction() { } //def constructor

        public Transaction(int id, int productId, int quantity, decimal totalAmount, string action, DateTime timestamp)
        {
            Id = id;
            ProductId = productId;
            Quantity = quantity;
            TotalAmount = totalAmount;
        }
    }
}
