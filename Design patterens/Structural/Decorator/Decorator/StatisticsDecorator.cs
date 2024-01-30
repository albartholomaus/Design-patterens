using Design_patterns.Structural.Decorator.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_patterns.Structural.Decorator.Decorator
{
    public class StatisticsDecorator: MailServiceDecoratorBase
    {
        public StatisticsDecorator(IMailService mailService):base(mailService)
        {
            
        }

        public override bool SendMail(string message)
        {
            //not real statistics 
            Console.WriteLine($"Collecting statistics in {nameof(StatisticsDecorator)}.");
            return base.SendMail(message);
        }

    }
}
