using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Venture.Clases
{
    public class BigCity : Location
    {
        public Dictionary<string, Building> buildings;
        public List<string> possExits;
        public bool playerIsHere;
        int dropChance;
        int dayCounter;
       

        public BigCity(string name, string description) : base(name, description)
        {
            Random random = new Random();
            
            buildings = new Dictionary<string, Building>()
            {
                {"1", new Building((ETypeBuilding)random.Next(1, 9))},
                {"2", new Building((ETypeBuilding)random.Next(1, 9))},
                {"3", new Building((ETypeBuilding)random.Next(1, 9))}
            };

            //hacer que diga los buildings que hay y sus salidas
        }
        public override string onLook() 
        {
            string outt = "vailable exit highways to ";
            foreach (string s in possExits)
            {
                outt += s.ToUpper() + ", ";
            }
            outt += "but there´s a ";

            foreach (Building b in buildings.Values) {
                outt += b.Name.ToUpper() + (Equals(b, buildings.Values.Last<Building>())? ", and":", a ");
            }
            outt += " a couple of hostiles, too.\n\n";
            return outt; 
            

        }
    }
}
