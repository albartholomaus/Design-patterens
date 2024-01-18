using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_patterns.Creational.Builder
{
    public class BuilderInterface
    {
       public void BuilderInterfaceMethod()
        {
            /*
             Use case generating documnets 
            building a database query 
            createing a video game charter. 
             constructing a UI or form 

            goods:
            vary products interenal representation
            isolates code for constrruction 
            single responsibility 
            finer control of the construction process.

            bads: 
            can get complex 

            realted: 
            abstract factory 
            singleton
            composite

             */


            var garage = new Garage(); 
            var miniBuilder = new MiniBuilder();
            var chevelle = new Chevelle();

            garage.Construct(miniBuilder);
            Console.WriteLine(miniBuilder.Car.ToString());
            garage.Show();

            garage.Construct(chevelle);
            Console.WriteLine(chevelle.Car.ToString());
            garage.Show();

        }


    }
}
