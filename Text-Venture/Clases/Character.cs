using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Venture.Clases
{
    abstract class Character
    {
        protected int HealthPoints;
        protected int baseATK;
        protected int baseDEF;
        protected string Description;
        protected string ImgFilePath;

        public Character(int hp, int atk, int def, string description, string file)
        {
            this.HealthPoints = hp;
            this.baseATK = atk;
            this.baseDEF = def;
            this.Description = description;
            this.ImgFilePath = file;
        }

       
    }
}
