using Design_patterns.Structural.Decorator.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_patterns.Structural.Decorator.Decorator
{
    /* This is the Decorator (as abstract base class)
     this intercepts the sent mail operation 
     maintains a reference to a "component" object and defines an interface that conforms to a components interface 
     */
    public abstract class MailServiceDecoratorBase : IMailService
    {
        private readonly IMailService _mailService;
        public MailServiceDecoratorBase(IMailService mailService)
        {
             _mailService = mailService;
        }
        public virtual bool SendMail(string message)
        {
            return _mailService.SendMail(message);
        }
    }
}
