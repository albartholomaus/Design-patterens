//using Newtonsoft.Json;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text.Json;
using System.Threading.Tasks;

namespace Design_patterns.Creational.Prototype
{
    public class Employee : Person
    {
        public Manager Manager { get; set; }
        public override string Name { get; set; }

        public Employee(string name, Manager manager)
        {
            Name = name;
            Manager = manager;
        }

        public override Person Clone(bool deepClone = false)
        {
            if (deepClone)//removing this here and just returning the the memberwise with work for shallow copy 
            {
            //    var settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All };
            //    var objectAsJson = JsonConvert.SerializeObject(this, typeof(Employee), settings);
            //    return JsonConvert.DeserializeObject<Person>(objectAsJson, settings);

                var objectAsJsond = System.Text.Json.JsonSerializer.Serialize(this);
                return System.Text.Json.JsonSerializer.Deserialize<Employee>(objectAsJsond);

            }
            return (Person)MemberwiseClone();
        }


    }
}
