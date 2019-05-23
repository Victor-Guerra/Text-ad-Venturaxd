using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Venture.Clases
{
    [AttributeUsage(AttributeTargets.Method)]
    public class Commandos : Attribute
    {
        private string methodName;
        public string MethodName { get => methodName; }
        public Commandos(string name)
        {
            this.methodName = name;
        }

    }
}
