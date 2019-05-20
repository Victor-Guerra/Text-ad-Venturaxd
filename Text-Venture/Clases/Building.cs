using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Text_Venture.Clases.ResourcesClases;

namespace Text_Venture.Clases
{
    public class Building : Location
    {
        private ETypeBuilding buildingType;
        private bool playerIsHere;
        private Dictionary<string, Object> findables;

        public Building()
        {
            Random random = new Random();
            this.buildingType = (ETypeBuilding)random.Next(1,9);    //Escoge tipo de edificio con un random
            //switch (type)
            //{
            //    case ETypeBuilding.OXXO:
            //        this.findables = new Dictionary<string, Resource>()
            //        {
            //            {"chips", new Food()}
            //        }
            //        break;
            //}
        }
        
        void pickFindables(ETypeBuilding type)
        {
            
        }

    }
}
