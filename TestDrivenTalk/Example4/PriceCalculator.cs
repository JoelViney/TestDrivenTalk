using System;
using System.Linq;

namespace TestDrivenTalk.Example4
{
    public class PriceCalculator
    {
        private readonly ICalendar _calendar;

        public PriceCalculator(ICalendar calendar)
        {
            _calendar = calendar;
        }

        public decimal GetPrice(Product product, Customer customer = null)
        {
            var price = product.Price;

            if (product.SalePrices.Count > 0)
            {
                // Calculate the sales on full days.
                var today = this._calendar.GetDateTimeNow().Date;
                var sale = product.SalePrices.FirstOrDefault(x => today >= x.FromDate.Date && today <= x.ToDate.Date);
                if (sale != null)
                {
                    price = sale.Price;
                }
            }

            if (customer != null && customer.ClubMember)
            {
                // All ClubMembers get a 10% discount
                price = price - Math.Round(price / 10M);
            }

            var roundedResult = Math.Floor(price * 20) / 20;

            return roundedResult;
        }
    }
}
