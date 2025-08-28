using System;

namespace vending_machine_library.Models
{
    public class Transaction
    {
        public int Id { get; set; }                  // Unique identifier for the transaction
        public int ProductId { get; set; }           // Which product was involved
        public int Quantity { get; set; }            // How many items were bought/refunded
        public decimal TotalAmount { get; set; }     // Total money spent (Quantity * Product.Price)
        public string Action { get; set; }           // e.g., "Purchase", "Refund", "Restock"
        public DateTime Timestamp { get; set; }      // When the transaction happened

        public Transaction() { }

        public Transaction(int id, int productId, int quantity, decimal totalAmount, string action, DateTime timestamp)
        {
            Id = id;
            ProductId = productId;
            Quantity = quantity;
            TotalAmount = totalAmount;
            Action = action;
            Timestamp = timestamp;
        }
    }
}
