using System;

namespace TestDrivenTalk.Example1
{
    public class PriceCalculator
    {
        public decimal GetPrice(decimal amount)
        {
            var result = Math.Floor(amount * 20) / 20;
            return result;
        }
    }
}
