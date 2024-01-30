using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_patterns.Structural.Bridge.ImplementorHierarchy
{
    /*ConcreteImplementor*/
    public class OneDollarCoupon : ICoupon
    {
        public int CouponValue { get => 1; }
    }
}
