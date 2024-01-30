using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Design_patterns.Structural.Bridge.ImplementorHierarchy;

namespace Design_patterns.Structural.Bridge.AbstractionHierarchy
{
    public class MeatBasedMenu : Menu
    {
        /* ConcreteImplementor */
        public MeatBasedMenu(ICoupon coupon) : base(coupon)
        {

        }
        public override int CalculatePrice()
        {
            return 30 - _coupon.CouponValue;
        }
    }
}

