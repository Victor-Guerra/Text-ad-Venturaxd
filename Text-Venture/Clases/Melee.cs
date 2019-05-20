using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Venture.Clases
{
    public class Melee : Weapon
    {
        private int hitbackChance;

        public Melee(string name, string description, string imgFilePath, int atk, int acc, int hitback, ENoisy noise): base(name,description,imgFilePath,atk,acc)
        {
            this.hitbackChance = hitback;
            this.NoiseLvl = ENoisy.SILENT;
        }

        public void RecoilVal(int hitbackChance)
        {

        }
    }
}
