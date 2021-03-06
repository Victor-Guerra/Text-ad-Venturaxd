﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Venture.Clases
{
    public abstract class Human : Character, ICombat
    {
        public string name;
        protected Weapon weapon;
        protected Equipment equipment;

        public Human(string name, int hp, string description, string file): base(hp, description, file)
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
