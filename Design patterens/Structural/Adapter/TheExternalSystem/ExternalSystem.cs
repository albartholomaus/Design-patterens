using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Design_patterns.Structural.Adapter.TheExternalSystem
{
    /* Adaptee*/

    public class ExternalSystem
    {
        public CityFromExternalSystem GetCity()
        {
            return new CityFromExternalSystem("Sioux City", "Little Chicago", 50000);
        }
    }

}
