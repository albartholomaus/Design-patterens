using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_patterns.Structural.Composite
{
    public class CompositeClientCode
    {

        /*
         Intent: compose object into tree structures to represent part or whole hierarchies 
         
         */
       public void CompositeClientCodeMethod()
        {
            var root = new Composite.Directory1("root",0);
            var toplevelFile = new Composite.File("TopLevel.TXT",100);
            var TopLevelDirectory1 = new Composite.Directory1("topleveldirectory1", 4);
            var TopLevelDirectory2 = new Composite.Directory1("topleveldirectory2", 4);

            root.Add(toplevelFile);
            root.Add(TopLevelDirectory1);
            root.Add(TopLevelDirectory2);

            var subLevelFile1 = new Composite.File("sublevel1.txt",200);
            var subLevelFile2 = new Composite.File("sublevel1.txt", 150);

            
            TopLevelDirectory2.Add(subLevelFile1);
            TopLevelDirectory2.Add(subLevelFile2);

            Console.WriteLine($"Size of topleveldirectory1:{TopLevelDirectory1.GetSize()}");
            Console.WriteLine($"Size of topleveldirectory2:{TopLevelDirectory2.GetSize()}");
            Console.WriteLine($"Size of root:{root.GetSize()}");

            Console.ReadKey();
        }
    }
}
