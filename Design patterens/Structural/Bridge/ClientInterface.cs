using Design_patterns.Structural.Bridge.AbstractionHierarchy;
using Design_patterns.Structural.Bridge.ImplementorHierarchy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_patterns.Structural.Bridge
{
    public class ClientInterface
    {
        public void ClientCode()
        {
            var noCoupon = new NoCoupon();
            var oneDollarCoupon = new OneDollarCoupon();

            var meatBasedMenu = new MeatBasedMenu(noCoupon);
            Console.WriteLine($"Meant based menu: no coupon {meatBasedMenu.CalculatePrice()}");

            meatBasedMenu = new MeatBasedMenu(oneDollarCoupon);
            Console.WriteLine($"Meant based menu: one coupon {meatBasedMenu.CalculatePrice()}");

            var vegetarianMenu = new VegetarianMenu(noCoupon);
            Console.WriteLine($" Vegi based menu: no coupon {vegetarianMenu.CalculatePrice()}");

            vegetarianMenu = new VegetarianMenu(oneDollarCoupon);
            Console.WriteLine($"Vegi based menu: one coupon {vegetarianMenu.CalculatePrice()}");
        }
    }
}
/*Use case: 
  avoid a binding between a abstraction and its implementation aka enable switching between implementations at runtime. 
 
  when abstractions and implementations should be extensible by subclassing 

  don't what changes on implementations to have an impact on a client 

    real world: separating notifications mechanisms in a notification system 

    separating streaming protocols ie auto /video 

    separating UI components 

    Good: 
        decoupling 
        as the abstraction and implementation can evolve independently, new ones can be introduced as such
        encapsulation, hides implementation details away from the client code 
        you can focus on a high level logic in the abstraction and on th details in the implementation, single responsibility principle

    related: 
    abstract factory 
    adapter
    strategy 
    state 


 */