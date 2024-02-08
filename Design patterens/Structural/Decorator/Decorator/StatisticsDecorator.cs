using Design_patterns.Structural.Decorator.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_patterns.Structural.Decorator.Decorator
{
    /*concrete decorator */
    public class StatisticsDecorator: MailServiceDecoratorBase
    {
        public StatisticsDecorator(IMailService mailService):base(mailService) // use the base constructor we can store the instance here in the
                                                                               // readonly field in the mail service decorator abstract class 
        {}

        public override bool SendMail(string message)
        {
            //not real statistics 
            Console.WriteLine($"Collecting statistics in {nameof(StatisticsDecorator)}.");
            return base.SendMail(message);
        }

    }
}
