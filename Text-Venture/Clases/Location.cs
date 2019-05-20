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
        public bool playerIsHere;
        protected string filePath;
        public string NAME { get => this.name; }
        public string DESC { get => this.description; }
        public static int DangerIndex { get => DangerIndex; }

        public Location(string name, string filePath)
        {
            this.filePath = filePath;
            this.name = name;

        }
        public Location(string name, string description, string filePath)
        {
            this.filePath = filePath;
            this.name = name;
            this.description = description;
            
        }
        public Location() { }

        public virtual string onLook() {
            return "";
        }
    }
}
