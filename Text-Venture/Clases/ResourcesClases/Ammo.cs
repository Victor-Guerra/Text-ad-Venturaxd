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
                    this.value = (int)siz+2;
                    break;
            }
        }

        public override string ToDisplay(EResourceSize siz)
        {
            string w = "Used a ";
            switch ((int)siz)
            {
                case 1:
                    w += "small";
                    break;
                case 2:
                    w += "medium";
                    break;
                case 3:
                    w += "large";
                    break;     
            }
            w += " box of ammo.";
            return w;
        }

        public static void onNeed(ref RichTextBox txtbxConsola)
        {
            txtbxConsola.AppendText("\nSeems the ammo is running real low...");
        }

        public void onUse(int value, ref Player p)
        {
            throw new NotImplementedException();
        }
    }
}
