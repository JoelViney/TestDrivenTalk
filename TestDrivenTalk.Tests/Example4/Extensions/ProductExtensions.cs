using System;
using System.Collections.Generic;
using System.Text;

namespace TestDrivenTalk.Example4.Extensions
{
    internal static class ProductExtensions
    {
        internal static Product HasPrice(this Product product, decimal price)
        {
            product.Price = price;
            return product;
        }

        internal static Product IsOnSale(this Product product, decimal salePrice, DateTime fromDate, DateTime toDate)
        {
            var productSale = new ProductSale()
            {
                SalePrice = salePrice,
                FromDate = fromDate,
                ToDate = toDate
            };

            product.SalePrices.Add(productSale);

            return product;
        }
    }
}
