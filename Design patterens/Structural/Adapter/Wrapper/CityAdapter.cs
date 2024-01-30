using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Design_patterns.Structural.Adapter.TheExternalSystem;

namespace Design_patterns.Structural.Adapter.Wrapper
{
/* 
 * composition
 * https://www.c-sharpcorner.com/UploadFile/ff2f08/inheritance-vs-composition/
 */
    //this is the part that needs to be done 

    /*Adapter*/
    public class CityAdapter : ICityAdapter//<--- remove to use the class implementation 
    //public class CityAdapter :ExternalSystem, ICityAdapter//<---  class implementation 
    {
        public ExternalSystem ExternalSystem { get; private set; } = new();//<--- remove to use the class implementation 

        public City GetCity()
        {
            //call into the external system 
            var cityFromExternalSystem = ExternalSystem.GetCity();
            //var cityFromExternalSystem = base.GetCity();/<--- class implementation 

            //adapt the CityFromExternalCity to a City
            return new City($"{cityFromExternalSystem.Name} - {cityFromExternalSystem.NickName}", cityFromExternalSystem.Inhabitants);

        }
    }
}
