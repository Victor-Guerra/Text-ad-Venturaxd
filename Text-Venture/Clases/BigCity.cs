using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Venture.Clases
{
    public class BigCity : Location
    {
        Dictionary<string, Building> buildings = new Dictionary<string, Building>();
        BigCity[] possExits;
        bool playerIsHere;
        int dropChance;
        int dayCounter;
        public string NAME {get => this.name;}
        public string DESC { get => this.description; }

        public BigCity(string name, string description): base (name, description)
        {
           
        }

    }
}
