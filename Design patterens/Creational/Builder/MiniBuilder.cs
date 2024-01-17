using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_patterns.Creational.Builder
{
    /*Concrete builder for car one */
    public class MiniBuilder : CarBuilder
    {

        public MiniBuilder(): base("Mini") // car is the base class, base here states we want to use the carbuilder ctor
        {
            
        }
        public override void BuildEngine()
        {
            Car.AddPart("V8");
        }

        public override void BuildFrame()
        {
            Car.AddPart("9 Door");
        }
    }
    /*Concrete builder for car two */
    public class Chevelle : CarBuilder
    {

        public Chevelle() : base("Chevelle ") // car is the base class, base here states we want to use the carbuilder ctor
        {

        }
        public override void BuildEngine()
        {
            Car.AddPart("V8 turbo");
        }

        public override void BuildFrame()
        {
            Car.AddPart("2 Door");
        }
    }


}
