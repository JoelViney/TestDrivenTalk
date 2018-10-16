using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestDrivenTalk.Example1
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
            var price = priceCalculator.GetPrice(11.95M);

            // Assert
            Assert.AreEqual(11.95M, price);
        }
    }
}
