using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_patterns.Creational.Singleton
{
    public class SingletonInterface
    {
        public void SingletonInterfaceMethod()
        {
            Console.Title = "Singleton Pattern";

            /* can't do to the protection level
            var test = new Logger();
            */

            /* so you have to do this */
            var instance1 = Logger.Instance;
            var instance2 = Logger.Instance;

            if (instance1 == instance2 && instance2 == Logger.Instance)
            {
                Console.WriteLine("Instances are the same");
            }

            instance1.Log($"Message from {nameof(instance1)}");
            instance1.Log($"Message from {nameof(instance2)}");
            Logger.Instance.Log($"Message from {nameof(Logger.Instance)}");

            Console.ReadLine();
        }





    }
}
