using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_patterns.Structural.Decorator.Component
{
    public class CloudMailService : IMailService
    {
        /*Concrete Component 1*/
        public bool SendMail(string message)
        {
            Console.WriteLine($"Message \"{message}\" sent via {nameof(CloudMailService)}. ");
            return true;
        }
    }
}
