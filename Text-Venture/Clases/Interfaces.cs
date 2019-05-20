using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Text_Venture.Clases.ResourcesClases;

namespace Text_Venture.Clases
{
    interface IResource
    {
        void onUse(int value, ref Player p);
        //void onNeed(ref System.Windows.Forms.RichTextBox txtbxConsola);
    }

    interface IStatus
    {
        void UpdateStatus(int ammo, int gas, int hunger, int thirst, int hp, ref System.Windows.Forms.RichTextBox consola);
        void CheckAlive(ref bool isAlive);
    }

    interface ICombat
    {
        void Attack(ref Character c, int accuracy);
        int AbscondChance(EDifficulty diff);
    }

    interface ICommands
    {
        void examine<T>(T item, ref System.Windows.Forms.RichTextBox consola);
        void GoTo(string PlaceName);
        void take(Item item);
        void heal(Medkit med);
        void scavenge();
        void look_around();
    }
}
