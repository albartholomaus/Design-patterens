using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_patterns.Creational.Abstract_Factory
{
    /*
     Use case: 
     when a system should not be dependent of how its products are created
     when you want to reveal their interfaces but not the implementations 
     a system should have several families of products, families being USA and France 
     when families need to tus e the same product and you need to make sure that it is enforced 

    real life: 
    multi languages
    converting to diff formats 
    abstracting away you databases access layer


    Pros: Isolates concrete classes, because it encapsulates the responsibility and the process of creating products
    can introduce new products: open/closed principle 
    code to create products in one place: single responsibility  
    making exchanges easy
    consistency among products

    Cons:
    new kinds of kinds of products is not easy, would need to change the interfaces 

    method vs abstract 
    method:
    method has one product 
    creates objects through inheritance
    exposes an interface with a method on it to create an object of a certain type 

    abstract: 
    family of objects 
    exposes an interface wto created related objects
    products a family of products 

    related: 
    prototype:
    singleton to make sure on instance is created  

     */

    public class InterfaceForAbstractFactoryPattern
    {
        public void InterfaceForAbstractFactoryPatternMethod()
        {
            Console.Title = "Abstract Factory";

            var USAFactory= new UsaShoppingCartPurchaseFactory();
            var ShoppingCartForUSA = new ShoppingCart(USAFactory);
            ShoppingCartForUSA.CalculateCosts();

            var FranceFactory = new FranceShoppingCartPurchaseFactory();
            var ShoppingCartForFrance = new ShoppingCart(FranceFactory);
            ShoppingCartForFrance.CalculateCosts();
        }

    }
}
