using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Venture.Clases
{
    class Melee : Weapon
    {
        private int hitbackChance;

        public Melee(int atk, int acc, ENoisy noise, int hitback): base(atk,acc,noise)
        {
            this.hitbackChance = hitback;
        }

        public void RecoilVal(int hitbackChance)
        {

        }
    }
}
