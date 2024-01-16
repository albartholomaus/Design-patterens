using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_patterns.Creational.Abstract_Factory
{
    /*client class */
    public class ShoppingCart
    {
        private readonly IDiscountService _discountService;
        private readonly IShippingCostsService _shippingCostsService;
        private int _orderCosts;

        public ShoppingCart(IShoppingCartPurchaseFactory factory)
        {

            _discountService = factory.CreateDiscountService();
            _shippingCostsService = factory.CreateShippingCostsService();

            //in lue of a total cost implementation and totaling the cost

            _orderCosts = 200;
        }

        public void CalculateCosts()
        {
            Console.WriteLine($"Total costs= {_orderCosts - (_orderCosts / 100 * _discountService.DiscountPercentage) + _shippingCostsService.ShippingCosts}");
        }
    }

}
