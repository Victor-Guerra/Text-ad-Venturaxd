using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Text_Venture.Clases.ResourcesClases
{
    class Food: Resource, IResource
    {
        public Food(EResourceSize size):base(size)
        {
            SetValue(MasterControl.difficulty, size);
        }

        public void onNeed(ref RichTextBox txtbxConsola)
        {
            throw new NotImplementedException();
        }

        public void onUse(int value, ref Player p)
        {
            throw new NotImplementedException();
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
