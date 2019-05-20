using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Venture.Clases
{
    public abstract class Character
    {
        public int HealthPoints;
        protected string Description;
        protected string ImgFilePath;


        public Character(int hp, string description, string file)
        {
            this.HealthPoints = hp;
            this.Description = description;
            this.ImgFilePath = file;
        }

       
    }
}
