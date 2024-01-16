using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Design_patterns.Creational.Abstract_Factory.ClientClass;

namespace Design_patterns.Creational.Abstract_Factory
{
    public class UsaShoppingCartPurchaseFactory : IShoppingCartPurchaseFactory
    {
        public IDiscountService CreateDiscountService()
        {
            return new UsaDiscountService();
        }
        public IShippingCostsService CreateShippingCostsService()
        {
            return new UsaShippingCostsService();
        }
    }
    public class FranceShoppingCartPurchaseFactory : IShoppingCartPurchaseFactory
    {
        public IDiscountService CreateDiscountService()
        {
            return new FranceDiscountService();
        }
        public IShippingCostsService CreateShippingCostsService()
        {
            return new FranceShippingCostsService();
        }
    }
}
