using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Venture.Clases
{
    abstract class Human : Character
    {
        string name;
        Weapon weapon;
        Equipment equipment;

        public Human(string name, int hp, int atk, int def, string description, string file): base(hp, atk, def, description, file)
        {
            this.name = name;
        }

        protected virtual void setWeapon(Weapon w)
        {
            this.weapon = w;
        }
        protected virtual void setEquipment(Equipment e)
        {
            this.equipment = e;
        }
    }
}
