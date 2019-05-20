using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Venture.Clases
{
    class Building : Location
    {
        private ETypeBuilding buildingType;
        private bool playerIsHere;
        private Dictionary<string, Object> findables;

        public Building(ETypeBuilding bdType)
        {
            this.buildingType = bdType;
        }
        
    }
}
