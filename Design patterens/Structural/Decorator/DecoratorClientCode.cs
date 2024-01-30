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
            var cloudMailService = new CloudMailService();
            cloudMailService.SendMail("Hi there");

            var Onprem = new OnPremMailService();
            Onprem.SendMail("Hi there");

            //add behavior 
            var statsDecorator = new StatisticsDecorator(cloudMailService);
            statsDecorator.SendMail($"hi there via {nameof(statsDecorator)} wrapper");

            //add more behivior 
            var messageDataBase = new MessageDatabaseDecorator(Onprem);

        }

    }
}
