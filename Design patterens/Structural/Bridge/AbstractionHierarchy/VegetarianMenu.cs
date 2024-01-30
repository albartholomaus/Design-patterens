using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Design_patterns.Structural.Bridge.ImplementorHierarchy;

namespace Design_patterns.Structural.Bridge.AbstractionHierarchy
{
    public class VegetarianMenu : Menu
    {
        /*Refined abstraction */
        public VegetarianMenu(ICoupon coupon) : base(coupon)
        {

        }

        public override int CalculatePrice()
        {
            return 20 - _coupon.CouponValue;
        }
    }
}
