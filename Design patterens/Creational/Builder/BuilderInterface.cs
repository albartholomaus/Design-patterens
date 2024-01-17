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
