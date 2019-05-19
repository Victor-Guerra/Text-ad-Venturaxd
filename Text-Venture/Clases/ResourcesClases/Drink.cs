using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Text_Venture.Clases.ResourcesClases
{
    class Drink: Resource, IResource
    {
        public Drink(EResourceSize size) : base(size)
        {
            SetValue(MasterControl.difficulty, size);
        }

        public void onNeed(RichTextBox txtbxConsola)
        {
            throw new NotImplementedException();
        }

        public void onUse(int value, ref Player p)
        {
            p.HydrationLvl += this.value;
        }

        public override string ToDisplay(EResourceSize siz)
        {
            string w = "Drank a ";
            string d = "";
            switch ((int)siz)
            {
                case 1:
                    w += "small";
                    d = " Not much, but useful.";
                    break;
                case 2:
                    w += "medium";
                    d = " Nice and refreshing!";
                    break;
                case 3:
                    w += "large";
                    d = " Quite sufficient for a single person!";
                    break;
            }
            w += " bottle of water.";
            w += d;
            return w;
        }
        protected override void SetValue(EDifficulty diff, EResourceSize siz)
        {
            switch ((int)diff)
            {
                case 1:
                    this.value = 3 * (int)siz;
                    break;
                case 3:
                    this.value = 2 * (int)siz;
                    break;
                case 6:
                    this.value = (int)siz;
                    break;
            }
        }
    }
}
