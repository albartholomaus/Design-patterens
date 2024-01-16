using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_patterns.Creational.FactoryPattern
{
    public class FactoryInterface
    {
        public void FactoryMethodInterface() {

            Console.Title = "Factory Method";

            var factories = new List<DiscountFactory>
            {
                new CodeDiscountFactory(Guid.NewGuid()),
                new CountryDiscountFactory("US")
            };


            foreach (var factory in factories)
            {
                var discountService = factory.CreateDiscountService();
                Console.WriteLine($"% {discountService.DiscountPercentage} coming from {discountService}");
            }
        }
    }
}
