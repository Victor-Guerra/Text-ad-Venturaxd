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
        BigCity[] possibleExits;
        bool playerIsHere;
        int dropChance;
        int dayCounter;

        public BigCity(string name, string description, int drop): base (name, description)
        {
           
        }
    }
}
