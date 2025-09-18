using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using vending_machine_library.Models;

namespace VendingmachineTests
{
    [TestClass()]
    public class VendingmachineTests
    {

        private Vendingmachine _vendingMachine;
        [TestInitialize]
        public void Setup()
        {
            _vendingMachine = new Vendingmachine();
        }

        [TestMethod]
        public void Buy_Slot0WithEnoughCoins_ReturnsChips()
        {
            // Arrange
            double[] coins = { 10, 10, 5 }; // total 25

            // Act
            Product result = _vendingMachine.Buy(0, coins);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Chips", result.Name);
        }


    }
}