using System;

namespace vending_machine_library.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }

        public Transaction() { } //def constructor

        public Transaction(int id, string productName, double price)
        {
            Id = id;
            ProductName = productName;
            Price = price;
        }
    }
}
