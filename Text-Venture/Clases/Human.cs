using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Venture.Clases
{
    public abstract class Human : Character, ICombat
    {
        protected string name;
        protected Weapon weapon;
        protected Equipment equipment;

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

        public void Attack(ref Character c, int accuracy)
        {
            throw new NotImplementedException();
        }

        public int AbscondChance(EDifficulty diff)
        {
            throw new NotImplementedException();
        }
    }
}
