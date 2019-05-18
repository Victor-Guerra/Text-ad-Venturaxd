using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Text_Venture.Clases.ResourcesClases
{
    class Ammo : Resource, IResource
    {
        public Ammo( EResourceSize size) : base( size)
        {
            SetValue(MasterControl.difficulty, size);
        }

        public override void SetValue(EDifficulty diff, EResourceSize siz)
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
                    this.value = (int)siz+2;
                    break;
            }
        }

        public void onNeed(RichTextBox txtbxConsola)
        {
            throw new NotImplementedException();
        }

        public void onUse(int value, ref Player p)
        {
            throw new NotImplementedException();
        }
    }
}
