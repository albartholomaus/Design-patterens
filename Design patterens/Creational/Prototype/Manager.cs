
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_patterns.Creational.Prototype
{
    public class Manager : Person
    {
        public override string Name { get; set; }

        public Manager(string name)
        {
            Name = name;
        }

        public override Person Clone(bool deepClone = false)
        {
            //Deep clone 
            if (deepClone)
            {
                var settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All };
                 var objectAsJson = JsonConvert.SerializeObject(this, typeof(Employee), settings);
                //var objectAsJason = JsonSerializer.Serialize(this);
                return JsonConvert.DeserializeObject<Person>(objectAsJson,settings);
            }
            return (Person)MemberwiseClone();//creates a shallow copy , only copy primate types use this 
        }


    }
}
