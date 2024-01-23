using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_patterns.Creational.Prototype
{
    public class PrototypeInterface
    {
        /* used to copy existing object with out the client code dependent on the concrete classes 
         declares and interface for cloning its self 

        our object here is to do a Deep copy 

        with a Deep copy even if we change the name, the "Copy should still be Cindy as it was created before"

        with a shallow copy  values are shared 

        with a deep copy, we can make changes with out affecting the cloned object 

        Uscase: 
        clone document's in word process 
        preserving a copy of that document  
        managing configuration instances 
        creating reusable UI components
        Creating charters in games

        pros: 
        hides the concrete product class 
        reduce subclassing 

        cons: each base class has to implement its own clone method 

        related:
        factory pattern 
        Singleton 
        Decorator
        Composite 
         */

        public void PrototypeInterfaceMethod() {

            var manager = new Manager("Cindy");
            var managerClone = (Manager)manager.Clone();//we need to cast to a Manager as the clone method will return a person object  
            Console.WriteLine($"Manager was cloned: {managerClone.Name}");//to test 

            var employee = new Employee("Kevin", managerClone);
            var employeeClone = (Employee)employee.Clone(true);
            Console.WriteLine($"Employee was cloned: {employeeClone.Name}, with manager {employeeClone.Manager.Name}");

            // change the manager name
            manager.Name = "Karen";
            Console.WriteLine($"Employee was cloned: {employeeClone.Name}, with manager {employeeClone.Manager.Name}");

        }
    }
}
