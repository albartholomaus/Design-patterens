﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_patterns.Structural.Adapter
{
    /*helper class
     different then city from external systems  
     */
    public class City
    {
        public string Fullname { get; set; }
        public long Inhabitants { get; set; }

        public City(string fullName, long inhabitants)
        {
            Fullname = fullName;
            Inhabitants = inhabitants;
        }

    }
}
