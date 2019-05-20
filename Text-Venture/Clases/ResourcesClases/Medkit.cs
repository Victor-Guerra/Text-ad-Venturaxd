﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Text_Venture.Clases.ResourcesClases
{
    class Medkit : Resource, IResource
    {
        public Medkit(EResourceSize size) : base(size)
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
                    this.value = 5 * (int)siz + 1;
                    break;
                case 3:
                    this.value = 3 * (int)siz + 2;
                    break;
                case 6:
                    this.value = 2 * (int)siz + 5;
                    break;
            }
        }
    }
}