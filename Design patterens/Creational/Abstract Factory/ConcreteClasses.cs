using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_patterns.Creational.Abstract_Factory
{
    /*ConcreteProduct*/
    public class ClientClass
    {
        public class UsaDiscountService : IDiscountService
        {

            public int DiscountPercentage => 20;
        }
        /*ConcreteProduct*/
        public class FranceDiscountService : IDiscountService
        {
            public int DiscountPercentage => 5;
        }
        /*ConcreteProduct*/
        public class UsaShippingCostsService : IShippingCostsService
        {
            public decimal ShippingCosts => 20;
        }
        /*ConcreteProduct*/
        public class FranceShippingCostsService : IShippingCostsService
        {
            public decimal ShippingCosts => 30;
        }

    }
}