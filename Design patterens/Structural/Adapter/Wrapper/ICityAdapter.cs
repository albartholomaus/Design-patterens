using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_patterns.Structural.Adapter.Wrapper
{
    /* Target aka the thing we need to adapt the adaptee to
     * defines the domain specific interface tha the client uses  
     */
    public interface ICityAdapter
    {
        City GetCity();
    }
}
