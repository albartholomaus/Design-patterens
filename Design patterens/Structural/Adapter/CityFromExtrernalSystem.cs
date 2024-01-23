using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_patterns.Structural.Adapter
{
    public class CityFromExternalSystem
    {
        public string Name { get; set; }
        public string NickName { get; private set; }
        public int Inhabitants { get; private set; }

        public CityFromExternalSystem(string name, string nickName, int inhabitants)
        {
            Name = name;
            NickName = nickName;
            Inhabitants = inhabitants;
        }

    }
}
