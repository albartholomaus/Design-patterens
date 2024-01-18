using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Design_patterns.Creational.Prototype
{
    public class Employee: Person
    {
        public Manager Manager { get; set; }
        public override string Name { get; set; }

        public Employee(string name, Manager manager) {
            Name = name;
            Manager = manager;
        }

        public override Person Clone(bool deepClone= false)
        {
            if (deepClone)
            {
                var settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All };
                var objectAsJson = JsonConvert.SerializeObject(this, typeof(Employee),settings);
                return JsonConvert.DeserializeObject<Person>(objectAsJson,settings);

            }
            return (Person)MemberwiseClone();
        }
        

    }
}
