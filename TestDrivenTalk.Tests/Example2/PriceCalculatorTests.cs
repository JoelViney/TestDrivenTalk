using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestDrivenTalk.Example2
{
    [TestClass]
    public class PriceCalculatorTests
    {
        /// <summary>
        /// Test that people buying the product on line pay the same price as someone buying in store.
        /// </summary>
        [TestMethod]
        public void RoundDown5CentsTest()
        {
            // Arrange
            var priceCalculator = new PriceCalculator();

            // Act
            var price = priceCalculator.GetPrice(null, 11.95M);

            // Assert
            Assert.AreEqual(11.95M, price);
        }

        [TestMethod]
        public void ClubMember10PercentDiscountTest()
        {
            // Arrange
            var priceCalculator = new PriceCalculator();
            var customer = new Customer() { ClubMember = true };

            // Act
            var price = priceCalculator.GetPrice(customer, 10.00M);

            // Assert
            Assert.AreEqual(9.00M, price);
        }
    }
}
