using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_patterns.Creational.Builder
{
    public class Car
    {
        /*
         Product
         */

        //private readonly List<string> _parts = new List<string>();
        private readonly List<string> _parts = new();//for the demo
        private readonly string _carType;

        public Car (string carType) 
        {
            _carType = carType;
        }
        public void AddPart(string part)
        { 
            _parts.Add(part);//to construct the car 
        }

        public override string ToString()// also for testing 
        {
            var sb=new StringBuilder();
            foreach (var part in _parts)
            {
                sb.Append($"Car type {_carType} has part {part}");
            }
            return sb.ToString();
        }
    }
}
