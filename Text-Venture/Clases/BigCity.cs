using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Venture.Clases
{
    public class BigCity : Location
    {
        Dictionary<string, Building> buildings;
        string[] possExits;
        public bool playerIsHere;
        int dropChance;
        int dayCounter;
        public string NAME {get => this.name;}
        public string DESC { get => this.description; }
        public string onLookAround;
        public BigCity(string name, string description): base (name, description)
        {
            buildings = new Dictionary<string, Building>()
            {
                {"1", new Building()},
                {"2", new Building()},
                {"3", new Building()}
            };

            onLookAround = "";
            //hacer que diga los buildings que hay y sus salidas
        }

    }
}
