using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Text_Venture.Clases.ResourcesClases
{
    public class Food: Resource, IResource
    {
        public Food(EResourceSize size):base(size)
        {
            SetValue(MasterControl.difficulty, size);
        }

        public void onNeed(ref RichTextBox txtbxConsola)
        {
            throw new NotImplementedException();
        }


        public override void onUse(int value, ref Player p)
        {
            throw new NotImplementedException();
        }

        public override string ToDisplay(EResourceSize siz)
        {
            string w = "Ate a ";
            string d = "";
            switch ((int)siz)
            {
                case 1:
                    w += "small";
                    d = " A small snack, barely enough to keep you going.";
                    break;
                case 2:
                    w += "medium";
                    d = " Almost a decent meal.";
                    break;
                case 3:
                    w += "large";
                    d = " Quite sufficient for a single person!";
                    break;
            }
            w += "  portion of food.";
            w += d;
            return w;
        }

        protected override void SetValue(EDifficulty diff, EResourceSize siz)
        {
            switch ((int)diff)
            {
                case 1:
                    this.value =  5 * (int)siz;
                    break;
                case 3:
                    this.value = 3 * (int)siz;
                    break;
                case 6:
                    this.value = (int)siz;
                    break;
            }
        }
    }
}
