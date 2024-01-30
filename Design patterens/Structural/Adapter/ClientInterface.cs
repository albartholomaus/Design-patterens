using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Design_patterns.Structural.Adapter.Wrapper;

namespace Design_patterns.Structural.Adapter
{
    public class ClientInterface
    {
        /*Adaptee define and existing interface that needs to be adapted aka the thing that needs to be adapted 
          
         adapter==wrapper
         */

        public void  ClientInterfaceMethod()
        {
            Console.Title = "Adapter";
            ICityAdapter adapter = new CityAdapter();
            var city =adapter.GetCity();

            Console.WriteLine($"{city.Fullname},{city.Inhabitants}");
            Console.ReadKey();

            /* in summery we are "adapting " the external system by changing the int to a long and merging 2 strings into one. */

        }
        

        /*
         when to use: when use have interface that are not compatible 
         integrating with third party library 
         integrating with a web service 
         mocking objects during testing 
         integrating with logging frameworks 
         
        goods: 
        can work with many adaptees 
        it is separated out from the rest of the code // single responsibility principle 
        can be introduced with out breaking client  // open closed principle

        bads: 
        harder to over ride adaptee 
        complexity

        related: 
        bridge separates interface from implementation, adapter changes the interface of an existing object 
        decorator= changes an object with out changing its interface 

        facade== define a new interface for an entire subsystem 

        proxy defines a surrogate for another object 
         */
    }
}
