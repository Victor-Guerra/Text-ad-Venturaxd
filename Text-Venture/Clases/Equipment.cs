using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Venture.Clases
{
    public class Equipment: Item
    {
        private int addedDEF { get; }

        public Equipment(string name, string description, string imgFilePath, int def): base(name,description,imgFilePath)
        {
            this.addedDEF = def;
        }
    }
}
