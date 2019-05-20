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
            this.buildingType = (ETypeBuilding)random.Next(1, 9);    //Escoge tipo de edificio con un random
            switch (buildingType)       //Dependiendo del tipo de edificio genera el Dictionary con loot
            {
                case ETypeBuilding.OXXO:
                    this.description = "You come across a convenience store, you see a small cup of noodles at the back, a bottle of water in the fridges, and some lose bullets on the counter, probably from whoever used to run this place.";
                    this.findables = new Dictionary<string, Object>()
                    {
                        {"bullets", new Ammo(EResourceSize.SMALL)},
                        {"noodles", new Food(EResourceSize.MEDIUM)},
                        {"bottle", new Drink(EResourceSize.MEDIUM)}
                    };
                    break;

                case ETypeBuilding.HOUSE:
                    this.description = "You encounter a house that does not seem entirely ransacked. On the pantry you see a bag of bread, on the garage, a car that was being worked on, a gas canister sits beside it, and on the kitchen table, there is an opened bottle of water.";
                    this.findables = new Dictionary<string, Object>()
                    {
                        {"gas", new Gasoline(EResourceSize.MEDIUM)},
                        {"bread", new Food(EResourceSize.LARGE)},
                        {"bottle", new Drink(EResourceSize.SMALL)}
                    };
                    break;

                    //MORE TO FIL
                case ETypeBuilding.DRUGS:
                    this.findables = new Dictionary<string, Object>()
                    {

                        {"counter", new Ammo(EResourceSize.SMALL)},
                        {"noodles", new Food(EResourceSize.MEDIUM)},
                        {"bottle", new Drink(EResourceSize.MEDIUM)}
                    };
                    break;

                case ETypeBuilding.STORE:
                    this.findables = new Dictionary<string, Object>()
                    {

                        {"counter", new Ammo(EResourceSize.SMALL)},
                        {"noodles", new Food(EResourceSize.MEDIUM)},
                        {"bottle", new Drink(EResourceSize.MEDIUM)}
                    };
                    break;

                case ETypeBuilding.MECHANIC:
                    this.findables = new Dictionary<string, Object>()
                    {

                        {"counter", new Ammo(EResourceSize.SMALL)},
                        {"noodles", new Food(EResourceSize.MEDIUM)},
                        {"bottle", new Drink(EResourceSize.MEDIUM)}
                    };
                    break;

                case ETypeBuilding.GAS_STATION:
                    this.findables = new Dictionary<string, Object>()
                    {

                        {"counter", new Ammo(EResourceSize.SMALL)},
                        {"noodles", new Food(EResourceSize.MEDIUM)},
                        {"bottle", new Drink(EResourceSize.MEDIUM)}
                    };
                    break;

                case ETypeBuilding.PLAZA:
                    this.findables = new Dictionary<string, Object>()
                    {

                        {"counter", new Ammo(EResourceSize.SMALL)},
                        {"noodles", new Food(EResourceSize.MEDIUM)},
                        {"bottle", new Drink(EResourceSize.MEDIUM)}
                    };
                    break;

                case ETypeBuilding.CAMPSITE:
                    this.findables = new Dictionary<string, Object>()
                    {

                        {"counter", new Ammo(EResourceSize.SMALL)},
                        {"noodles", new Food(EResourceSize.MEDIUM)},
                        {"bottle", new Drink(EResourceSize.MEDIUM)}
                    };
                    break;

            }
        }

        void pickFindables(ETypeBuilding type)
        {

        }

    }
}
