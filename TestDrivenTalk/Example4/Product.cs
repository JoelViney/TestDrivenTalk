using System.Collections.Generic;

namespace TestDrivenTalk.Example4
{
    public class Product
    {
        public Product()
        {
            this.SalePrices = new List<ProductSale>();
        }

        public decimal Price { get; set; }

        public List<ProductSale> SalePrices { get; set; }
    }
}
