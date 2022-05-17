using System;

namespace TestDrivenTalk.Example2
{
    public class PriceCalculator
    {
        public decimal GetPrice(Customer? customer, decimal amount)
        {
            var result = amount;

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
