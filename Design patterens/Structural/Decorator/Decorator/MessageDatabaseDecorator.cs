using Design_patterns.Structural.Decorator.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_patterns.Structural.Decorator.Decorator
{
    internal class MessageDatabaseDecorator : MailServiceDecoratorBase
    {
        /// <summary>
        /// A list of sent messages - a "fake" database
        /// </summary>
        public List<string> SendMessages { get; private set; } = new List<string>();  //datastore
        public MessageDatabaseDecorator(IMailService mailService) : base(mailService)
        {

        }
        public override bool SendMail(string message)
        {
            if (base.SendMail(message))
            {
                //store sent message 
                SendMessages.Add(message);
                return true;
            };
            return false;
        }
    }
}
