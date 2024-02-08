using Design_patterns.Structural.Decorator.Component;
using Design_patterns.Structural.Decorator.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_patterns.Structural.Decorator
{
    public class DecoratorClientCode
    {
        public void DecoratorClient()
        {
            /* Intent 
                attach additional responsibilities to a object dynamically 
                provides a flexible alternative to subclassing for extending functionality 

                We don't what to add responsibility to a class but add it to an "instance" of a class at runtime:  aka object 
                 Also know a as a wrapper
             */
            var cloudMailService = new CloudMailService();
            cloudMailService.SendMail("Hi there");

            var Onprem = new OnPremMailService();
            Onprem.SendMail("Hi there");

            //add behavior 
            var statsDecorator = new StatisticsDecorator(cloudMailService);
            statsDecorator.SendMail($"hi there via {nameof(statsDecorator)} wrapper");

            //add more behavior 
            var messageDataBaseDecorator = new MessageDatabaseDecorator(Onprem);
            messageDataBaseDecorator.SendMail($"hi there via {nameof(messageDataBaseDecorator)} wrapper 1.");
            messageDataBaseDecorator.SendMail($"hi there via {nameof(messageDataBaseDecorator)} wrapper 2.");

            foreach (var message in messageDataBaseDecorator.SendMessages)
            {
                Console.WriteLine($"Stored message: \"{message}\"");
            }
        }

    }
}
