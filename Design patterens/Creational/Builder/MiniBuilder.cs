using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_patterns.Creational.Builder
{
    public class MiniBuilder : CarBuilder
    {

        public MiniBuilder(): base("Mini")
        {
            
        }
        public override void BuildEngine()
        {
            throw new NotImplementedException();
        }

        public override void BuildFrame()
        {
            throw new NotImplementedException();
        }
    }
}
