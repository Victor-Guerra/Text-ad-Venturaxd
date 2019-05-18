using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Text_Venture.Clases
{
    class StatusHandler : IStatus
    {
        public StatusHandler(ref int ammo, ref int gasoline, ref int hunger, ref int thirst, ref int HP)
        {

        }

        public void CheckAlive(ref bool isAlive)
        {
            throw new NotImplementedException();
        }

        public void UpdateStatus(int ammo, int gas, int hunger, int thirst, int hp, ref RichTextBox consola)
        {
            throw new NotImplementedException();
        }
    }
}
