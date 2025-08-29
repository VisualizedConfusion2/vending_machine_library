using System;
using System.Collections.Generic;

namespace vending_machine_library.Models
{
    public class Vendingmachine
    {
        public List<Slot> Slots { get; set; }
        public List<Transaction> Transactions { get; set; }
        private int transactionCounter = 1; // Auto-increment transaction IDs

        public Vendingmachine()
        {
            Slots = new List<Slot>();
            Transactions = new List<Transaction>();
        }

        // Buy function with transaction logging
        public string Buy(int slotIndex, decimal insertedCoins)
        {
            if (slotIndex < 0 || slotIndex >= Slots.Count)
                return "Invalid slot selected.";

            Slot slot = Slots[slotIndex];

            if (slot.Products.Count == 0)
                return "Sorry, this slot is empty.";

            if (insertedCoins < slot.Price)
                return "Not enough coins. This product costs " + slot.Price + ".";

            // Eject the product
            Product product = slot.EjectProduct();

            // Create a transaction record
            Transaction transaction = new Transaction(
                transactionCounter++,
                product.Id,
                1,
                (float)slot.Price
            );
            Transactions.Add(transaction);

            decimal change = insertedCoins - slot.Price;
            return "You bought " + product.Itemname + ". Change returned: " + change + " coins.";
        }
    }
}
