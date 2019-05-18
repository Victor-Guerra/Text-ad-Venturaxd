using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Venture.Clases
{
    abstract class Item
    {
        protected string name {get; }
        protected string description { get; }
        protected string imgFilePath;

        public Item(string name, string description, string imgFilePath)
        {
            this.name = name;
            this.description = description;
            this.imgFilePath = imgFilePath;

        }
        public Item() { }
    }
}
