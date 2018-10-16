using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestDrivenTalk.Example3
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
            var product = new Product() { Price = 11.95M };

            // Act
            var price = priceCalculator.GetPrice(product);

            // Assert
            Assert.AreEqual(11.95M, price);
        }

        [TestMethod]
        public void ClubMember10PercentDiscountTest()
        {
            // Arrange
            var priceCalculator = new PriceCalculator();
            var customer = new Customer() { ClubMember = true };
            var product = new Product() { Price = 10.00M };


            // Act
            var price = priceCalculator.GetPrice(product, customer);

            // Assert
            Assert.AreEqual(9.00M, price);
        }

        [TestMethod]
        public void ProductOnSaleTest()
        {
            // Arrange
            var priceCalculator = new PriceCalculator();
            var product = new Product() { Price = 10.00M, SalePrice = 9.00M };

            // Act
            var price = priceCalculator.GetPrice(product: product);

            // Assert
            Assert.AreEqual(9.00M, price);
        }
    }
}
