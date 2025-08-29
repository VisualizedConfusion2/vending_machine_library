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

        //list of available slots
        public Vendingmachine()
        {
            Slots = new List<Slot>();
            Transactions = new List<Transaction>();
        }
        //Transaction logging, change return and buy function
        private void _returnChange(double change)
        {
            Debug.WriteLine(change+ "her er dine penge");
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
        
    }
}
