using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Venture.Clases
{
    class Player : Human, ICommands
    {
        private StatusHandler status;
        private Location location;
        private int hunger, thirst, ammo, gasoline;
        private List<string> Hstorial;

        

        public Player(string name, int hp, int atk, int def, string description, string file) : base(name, hp, atk, def, description, file)
        {
        }
    }
}
