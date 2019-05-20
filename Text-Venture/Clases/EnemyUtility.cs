using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Venture.Clases
{
    static class EnemyUtility
    {
        public static int GetAbscondChance(EDifficulty diff, int HP, ETier tier)
        {
            int chance = 0;
            if (HP >= 75)
                chance = 0;
            else
            {
                if((HP < 75)&&(HP > 15))
                {
                    chance = 2 * (int)tier;
                }
                else
                {
                    chance = 2 * (int)tier + 2;
                }
            }
            return chance;
            

        }
        public static void AbscondResult(bool res, ref System.Windows.Forms.RichTextBox textBox)
        {
            
            if (res)
            {
                textBox.AppendText("\nThe injured enemy managed to escape! What a waste of time!");

            }
        }
    }
}
