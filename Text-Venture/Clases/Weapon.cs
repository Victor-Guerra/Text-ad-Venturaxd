using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Venture.Clases
{
    abstract class Weapon: Item
    {
        protected int addedATK;
        protected int accuracy;
        protected ENoisy NoiseLvl;

        public Weapon(string name, string description, string imgFilePath,int atk, int acc): base(name, description, imgFilePath)
        {
            this.addedATK = atk;
            this.accuracy = acc;
        }
        public Weapon() { }

        public void AttractEnemy(ENoisy noise, EDifficulty diff)
        {

        }
    }
}
