using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Design_patterns.Structural.Bridge.ImplementorHierarchy;

namespace Design_patterns.Structural.Bridge.AbstractionHierarchy
{
    /*Abstraction*/
    public abstract class Menu
    {
        public readonly ICoupon _coupon = null!;//must be the reference aka the bridge  
        public abstract int CalculatePrice();

        public Menu(ICoupon coupon)
        {
            _coupon = coupon;
        }
    }
}
