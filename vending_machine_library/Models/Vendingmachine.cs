using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;

namespace vending_machine_library.Models
{
    public class Vendingmachine
    {
        public List<Slot> Slots { get; set; }
        public List<Transaction> Transactions { get; set; }
        private int _transactionCounter = 1; // Auto-increment transaction IDs

        public Vendingmachine()
        {
            Slots = new List<Slot>();
            Transactions = new List<Transaction>();
        }

        private void _returnChange(double change)
        {
            
        }

        public Product Buy(int slotIndex, double[] insertedCoins)
        {
            if (slotIndex < 0 || slotIndex >= Slots.Count)
            {
                throw new ArgumentOutOfRangeException("Invalid slot selected.");
            }
            double totalInserted = insertedCoins.Sum();
            if (totalInserted < Slots[slotIndex].Price)
            {
                throw new ArgumentException("Not enough money");
            }
            _returnChange(totalInserted - Slots[slotIndex].Price);

            Transactions.Add(new Transaction(_transactionCounter, Slots[slotIndex].Products[0].Name, Slots[slotIndex].Price));
            _transactionCounter++;
            return Slots[slotIndex].EjectProduct();
        }

        // Buy function with transaction logging
        
    }
}
