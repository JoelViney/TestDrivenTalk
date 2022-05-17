using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestDrivenTalk.Example4.Extensions;
using TestDrivenTalk.Example4.Stubs;

namespace TestDrivenTalk.Example4
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
            var priceCalculator = new PriceCalculator(new CalendarStub());
            var product = new Product() { Price = 11.99M };

            // Act
            var price = priceCalculator.GetPrice(product);

            // Assert
            Assert.AreEqual(11.95M, price);
        }

        [TestMethod]
        public void ClubMember10PercentDiscountTest()
        {
            // Arrange
            var priceCalculator = new PriceCalculator(new CalendarStub());
            var customer = new Customer() { ClubMember = true };
            var product = new Product() { Price = 10.00M };


            // Act
            var price = priceCalculator.GetPrice(product, customer);

            // Assert
            Assert.AreEqual(9.00M, price);
        }

        //[TestMethod]
        //public void ProductOnSaleTest()
        //{
        //    // Arrange
        //    var priceCalculator = new PriceCalculator();
        //    var product = new Product() { Price = 10.00M, SalePrice = 9.00M };

        //    // Act
        //    var price = priceCalculator.GetPrice(product: product);

        //    // Assert
        //    Assert.AreEqual(9.00M, price);
        //}

        [TestMethod]
        public void ProductOnSaleTest()
        {
            // Arrange
            var calendar = new CalendarStub(new DateTime(2018, 1, 2));
            var priceCalculator = new PriceCalculator(calendar);

            var product = new Product().HasPrice(10.00M).IsOnSale(9.00M, new DateTime(2018, 1, 1), new DateTime(2018, 1, 3));
                
            // Act
            var price = priceCalculator.GetPrice(product);

            // Assert
            Assert.AreEqual(9.00M, price);
        }
    }
}
