using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Venture.Clases
{
    public abstract class Resource
    {
        protected EResourceSize size { get; }
        protected int value;
        public int Value { get => value; }


        public Resource(EResourceSize size)
        {
            this.size = size;
        }
        protected virtual void SetValue(EDifficulty diff, EResourceSize siz)
        {
            this.value = (int)diff * (int)siz;
        }

        public virtual string ToDisplay(EResourceSize siz)
        {
            string strOut = "used a resource.";
            return strOut;
        }
    }
}
