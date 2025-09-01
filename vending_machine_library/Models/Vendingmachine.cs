using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;

namespace vending_machine_library.Models
{
    public class Vendingmachine
    {
        public List<Slot> Slots { get; set; } = new List<Slot>();
        public List<Transaction> Transactions { get; set; } = new List<Transaction>();
        private int _transactionCounter = 1; // Auto-increment transaction IDs

        //list of available slots
        public Vendingmachine()
        {
            for (int i = 0; i < 4; i++)
            {
                Slots.Add(new Slot());
            }
            _fillSlots();
        }

        private void _fillSlots() // Fills the slots with products and prices
        {
            for (int i = 0; i < 8; i++)
            {
                Slots[0].FillProduct(new Chips());
                Slots[1].FillProduct(new Lasagna());
                Slots[2].FillProduct(new SalamiBrick());
                Slots[3].FillProduct(new WhiteMonster());
            }
            Slots[0].Price = 20;
            Slots[1].Price = 30;
            Slots[2].Price = 5;
            Slots[3].Price = 15;
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
