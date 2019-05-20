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
        private Dictionary<string, Resource> findables;
        public string Desc { get => description; }
        public string Name { get => name; }
        protected string filePath;

        public Building(ETypeBuilding bType)
        {
            switch (bType)       //Dependiendo del tipo de edificio genera el Dictionary con loot
            {
                case ETypeBuilding.OXXO:
                    name = "oxxo";
                    description = "You look around and see a bunch of opened packets of chips and other snacks. You spot a small cup of noodles at the back, a bottle of water in the fridges, and some lose bullets on the counter, probably from whoever used to run this place.";
                    findables = new Dictionary<string, Resource>()
                    {
                        {"bullets", new Ammo(EResourceSize.SMALL)},
                        {"noodles", new Food(EResourceSize.MEDIUM)},
                        {"bottle", new Drink(EResourceSize.MEDIUM)}
                    };
                    break;

                case ETypeBuilding.HOUSE:
                    name = "house";
                    description = "You look around the abandoned house. On the pantry you see a bag of bread, on the garage, a car that was being worked on, a small gas canister beside it, and on the kitchen table, there is an opened bottle of water.";
                    findables = new Dictionary<string, Resource>()
                    {
                        {"gas", new Gasoline(EResourceSize.SMALL)},
                        {"bread", new Food(EResourceSize.LARGE)},
                        {"bottle", new Drink(EResourceSize.SMALL)}
                    };
                    break;

                case ETypeBuilding.DRUGS:
                    name = "pharmacy";
                    description = "You find a drugstore. Empty boxes are all over the place. At the end of the hygiene aisle you see a medkit that looks unopened. On the counter you see a candy bar";
                    findables = new Dictionary<string, Resource>()
                    {
                        {"candy bar", new Food(EResourceSize.SMALL)},
                        {"medkit", new Medkit(EResourceSize.MEDIUM)}
                    };
                    break;

                case ETypeBuilding.STORE:
                    name = "supermarket";
                    description = "Most of the food has obviously been raided, but for some reason they've left a perfectly good watermelon the size of a toddler on the center of the produce section. You also see a jug of water hidden behind some boxes of raisin bran, which is an excelent hiding spot, since no one likes raisin bran.";
                    findables = new Dictionary<string, Resource>()
                    {
                        {"watermelon", new Food(EResourceSize.LARGE)},
                        {"noodles", new Drink(EResourceSize.LARGE)},
                    };
                    break;

                case ETypeBuilding.MECHANIC:
                    name = "mechanic shop";
                    description = "You look around the mechanic shop. There are many tools that would be useful were they not rusted to hell. Besides one of the tools, you see a bottle of diesel fuel. Your car runs on gas, but eh, beggars can't be choosers. Near the garage door you also spot an empty rifle case, but it has some ammo inside it.";
                    findables = new Dictionary<string, Resource>()
                    {

                        {"ammo", new Ammo(EResourceSize.MEDIUM)},
                        {"gas", new Food(EResourceSize.MEDIUM)}
                    };
                    break;

                case ETypeBuilding.GAS_STATION:
                    name = "gas station";
                    description = "You find gas. At a gas station. Surprisingly. Also there's about half a bag of chips next to a broken pump.";
                    findables = new Dictionary<string, Resource>()
                    {
                        {"gas", new Gasoline(EResourceSize.LARGE)},
                        {"chips", new Food(EResourceSize.SMALL)}
                    };
                    break;

                case ETypeBuilding.PLAZA:
                    name = "plaza";
                    description = "You look around the plaza. Most stores have been boarded up, but oddly enough, one is still clean and looks as if nothing had happened, at the center of the store is a medkit.";
                    findables = new Dictionary<string, Resource>()
                    {

                        {"medkit", new Medkit(EResourceSize.MEDIUM)}
                    };
                    break;

                case ETypeBuilding.CAMPSITE:
                    name = "campsite";
                    description = "You look around the campsite. It would appear an animal has been here recently seeing as how everything seems to be all over the place. That said, stuck to a tree branch you see a bag of marshmellows, and just outside the campsite a canteen. Inside one of the tents you find ammo. Let's hope it was for a camping trip.";
                    findables = new Dictionary<string, Resource>()
                    {

                        {"ammo", new Ammo(EResourceSize.SMALL)},
                        {"marshmallows", new Food(EResourceSize.MEDIUM)},
                        {"canteen", new Drink(EResourceSize.MEDIUM)}
                    };
                    break;

            }
        }
        public override string onLook()
        {
            return DESC;
        }
    }
}
