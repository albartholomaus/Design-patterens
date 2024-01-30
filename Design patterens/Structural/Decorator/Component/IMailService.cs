using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_patterns.Structural.Decorator.Component
{
    /*Componant (as interface)
     could be an abstract class
     */
    public interface IMailService
    {
       bool SendMail(string message);
    }
}
