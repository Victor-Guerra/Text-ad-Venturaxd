using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Venture.Clases
{
    class Scavenger : Human, ICombat
    {
        private int abscondChance;
        ETier tier;
        public Scavenger(string name, int hp, int atk, int def, string description, string file) : base(name, hp, atk, def, description, file)
        {
            tier = determineTier(MasterControl.difficulty, Location.DangerIndex);
        }

        public int AbscondChance(EDifficulty diff)
        {
            int chance;
            if (this.HealthPoints >= 75)
                chance = 1;
            else
            {
                if ((this.HealthPoints < 75) && (this.HealthPoints >= 45))
                {
                    chance = 2 * ((int)this.tier + 1) - 1;
                }
                else if((this.HealthPoints < 45)&&(this.HealthPoints > 15))
                {
                    chance = ((int)diff > 5 ? 1 : (int)diff > 2 ? 3 : 2) * ((int)this.tier==0?3:(int)this.tier==1?2:(int)this.tier==2?1:0 + 3) + 2; 
                }
                else
                {
                    chance = ((int)diff > 5 ? 1 : (int)diff > 2 ? 3 : 2 + 2) * ((int)this.tier == 0 ? 4 : (int)this.tier == 1 ? 3 : (int)this.tier == 2 ? 2 : 1 + 3) + 4;
                }
            }
            return chance;
        }

        public void Attack(ref Character c, int accuracy)
        {
            throw new NotImplementedException();
        }

        private ETier determineTier(EDifficulty diff, int dangerIndex)
        {
            int i = dangerIndex;
            switch (diff)
            {
                case EDifficulty.EASY:
                    if (i == 0) { i = 0; } else { i--; }
                    break;
                case EDifficulty.NORMAL:
                    break;
                case EDifficulty.HARD:
                    if (i == 3) { i = 3; } else { i++; }
                    break;
            }
            return (ETier)i;
        }
    }
}
