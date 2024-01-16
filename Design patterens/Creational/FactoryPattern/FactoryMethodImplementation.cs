using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_patterns.Creational.FactoryPattern
{
    /* AKA virtual constructor

     intent: To define an interface for creating an object 
             but we are letting the SUBCLASS pick the class to instantiate 
             "defer instantiation to a subclass"

    Use Case: when the calling case would not know what object it needs to create, do not know in advance what it needs to create 
            a way to enable reusing of existing objects    

    Pros: loose coupling (open\ closed principle) 
        single responsible principle 
    Con: clients might need to create a subclass of the creator class 
     */

    /*Product*/
    public abstract class DiscountService
    {

        public abstract int DiscountPercentage { get; }
        public override string ToString() => GetType().Name;
    }
   
    /*ConcreteProduct*/
    public class CountryDiscountService : DiscountService
    {
        private readonly string _countryIdentifier;

        public CountryDiscountService(string countryIdentifier)
        {
            _countryIdentifier = countryIdentifier;
        }
        public override int DiscountPercentage
        {
            get
            {
                switch (_countryIdentifier)
                {
                    case "US":
                        return 20;
                    default:
                        return 10;
                }
            }

        }
    }

    /*ConcreteProduct*/
    public class CodeDiscountService : DiscountService
    {
        private readonly Guid _code;

        public CodeDiscountService(Guid code)
        {
            _code = code;
        }
        public override int DiscountPercentage
        {
            /* each code returns the same fixed percentage, but the code is only valid once  
                - includes a check to if it has been used before in a real world we would od that here. 
             */
            get => 15;
        }
    }
    /* Creator*/
    public abstract class DiscountFactory
    {
        public abstract DiscountService CreateDiscountService();
    }
    /*Concrete Creator*/
    public class CountryDiscountFactory : DiscountFactory
    {
        private readonly string _countryIdentifier;
        public CountryDiscountFactory(string countryIdentifier)
        {
            _countryIdentifier = countryIdentifier;
        }
        public override DiscountService CreateDiscountService()
        {
            return new CountryDiscountService(_countryIdentifier);
        }
    }
    //Concrete creator
    public class CodeDiscountFactory: DiscountFactory
    {
        private readonly Guid _code;

        public CodeDiscountFactory(Guid code)
        {
            _code = code;
        }
        public override DiscountService CreateDiscountService()
        {
            return new CodeDiscountService(_code);
        }
    }

}
