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
        private readonly List<string> _parts = new();
        private readonly string _carType;

        public Car (string carType) 
        {
            _carType = carType;
        }
        public void AddPart()
        { 
            _parts.Add(_carType);
        }

        public override string ToString()
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
