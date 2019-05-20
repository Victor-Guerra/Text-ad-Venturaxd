using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Venture.Clases
{
    public abstract class Location
    {
        protected string name;
        protected string description;
        protected int dangerIndex;
        public static int DangerIndex { get => DangerIndex; }

        public Location(string name, string description)
        {
            this.name = name;
            this.description = description;
            
        }
        public Location() { }

        
    }
}
