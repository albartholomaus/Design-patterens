﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_patterns.Creational.Builder
{
    /*Builder*/
    public abstract class CarBuilder
    {
        public Car Car { get; private set; }
        

        public CarBuilder(string carType)
        {
            Car = new Car(carType);    
        }
        public abstract void BuildEngine();
        public abstract void BuildFrame();
    }
}
