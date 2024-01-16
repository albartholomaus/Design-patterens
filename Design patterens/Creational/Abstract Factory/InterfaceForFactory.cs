using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_patterns.Creational.Abstract_Factory
{

    /*AbstractFactory*/
    public interface IShoppingCartPurchaseFactory
    {
        IDiscountService CreateDiscountService ();
        IShippingCostsService CreateShippingCostsService();
    }

    /*AbstractProduct*/
    public interface IDiscountService
    {
            int DiscountPercentage { get; }
    }

    public interface IShippingCostsService
    { 
        decimal ShippingCosts { get; }
    }


}
