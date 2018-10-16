using System;
using System.Collections.Generic;
using System.Text;

namespace TestDrivenTalk.Example3
{
    public class PriceCalculator
    {
        public object GetPrice(Product product, Customer customer = null)
        {
            var result = product.SalePrice ?? product.Price;

            if (customer != null && customer.ClubMember)
            {
                // All ClubMembers get a 10% discount
                result = result - Math.Round(result / 10M);
            }

            var roundedResult = Math.Floor(result * 20) / 20;

            return roundedResult;
        }
    }
}
