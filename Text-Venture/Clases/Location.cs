using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Adventure.Clases
{
    abstract class Location
    {
        string name;
        string description;

        public Location(string name, string description)
        {
            this.name = name;
            this.description = description;
        }
        public Location() { }
    }
}
